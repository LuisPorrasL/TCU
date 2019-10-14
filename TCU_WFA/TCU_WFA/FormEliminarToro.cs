// Hecho por Luis Porras.
using System;
using System.Windows.Forms;
using TCU_WFA.Repository;

namespace TCU_WFA
{
    public partial class FormEliminarToro : DefaultForm
    {
        // Constantes
        private const string QUERY_LLENAR_COMBO_BOX_NUMERO_TRAZABLE_TORO = "SELECT t.PK_NUMERO_TRAZABLE, t.PK_NUMERO_TRAZABLE FROM [dbo].[TORO] t WHERE t.ACTIVA = 1;";

        //Titulos
        public const string TITULO_AVISO_ELIMINAR_TORO = "Aviso eliminar toro";

        //Campos
        private int numeroTrazableToro;
        private string causaDeBaja;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="numeroTrazableToro"></param>
        public FormEliminarToro(int numeroTrazableToro)
        {
            InitializeComponent();
            this.numeroTrazableToro = numeroTrazableToro;
        }

        /// <summary>
        /// Método que se llama cada vez que se carga el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEliminarToro_Load(object sender, EventArgs e)
        {
            LlenarComboBoxList();
            LlenarInformcionVaca();
        }

        /// <summary>
        /// Asigna a los componentes del form la información del toro seleccionado.
        /// </summary>
        private void LlenarInformcionVaca()
        {
            comboBoxNumeroTrazableToro.SelectedIndex = comboBoxNumeroTrazableToro.FindString(this.numeroTrazableToro.ToString());
            textBoxCausaDeBaja.Text = "";
        }

        /// <summary>
        /// Llena todos los ComboBoxList del form.
        /// </summary>
        private void LlenarComboBoxList()
        {
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_NUMERO_TRAZABLE_TORO, comboBoxNumeroTrazableToro);
        }

        /// <summary>
        /// Implementa la función principal del form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonDarDeBaja_Click(object sender, EventArgs e)
        {
            bool entradaUsuarioCorrecta = RevisarEntradaUsuario();
            if (entradaUsuarioCorrecta)
            {
                ObtenerDatosEntradaUsuario();
                bool resultado = EliminarToro();
                if (resultado)
                {
                    Utilities.MostrarMessageBox(Utilities.MENSAJE_EXITO, Utilities.TITULO_EXITO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormRegistroToros formRegistroToros = (FormRegistroToros)Tag;
                    formRegistroToros.LlenarDataGridViewToros();
                    LimpiarEntradaUsuario();
                }
                else Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR_ENTRADA_USUARIO, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Limpia la entrada realizada por el usuario.
        /// </summary>
        private void LimpiarEntradaUsuario()
        {
            this.numeroTrazableToro = -1;
            textBoxCausaDeBaja.Text = "";
            LlenarComboBoxList();
        }

        /// <summary>
        /// Intenta eliminar el toro seleccionado de la base de datos.
        /// </summary>
        /// <returns>Un booleano. True sí la operación fue correcta, false en caso contrario.</returns>
        private bool EliminarToro()
        {
            DialogResult resultadoDialogo = Utilities.MostrarMessageBox("¿Seguro que desea eliminar el toro " + this.numeroTrazableToro + "?. Esta operación no se puede revertir.", TITULO_AVISO_ELIMINAR_TORO, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultadoDialogo == DialogResult.Yes)
            {
                try
                {
                    int resultado = ProcedimientosAlmacenados.ProcEliminarToro(this.numeroTrazableToro, this.causaDeBaja);
                    if (resultado == Utilities.RESULTADO_ERROR) return false;
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else return false;
        }

        /// <summary>
        /// Obtiene los datos digitados o seleccionados por el usuario.
        /// </summary>
        private void ObtenerDatosEntradaUsuario()
        {
            this.numeroTrazableToro = Int32.Parse(comboBoxNumeroTrazableToro.Text);
            this.causaDeBaja = textBoxCausaDeBaja.Text;
        }

        /// <summary>
        /// Revisa que los datos insertados o seleccionados por el usuario sean válidos.
        /// </summary>
        /// <returns>Un booleano. True sí los datos insertados por el usuario son válidos, false en caso contrario.</returns>
        private bool RevisarEntradaUsuario()
        {
            try
            {
                if (comboBoxNumeroTrazableToro.Text == "" || Int32.Parse(comboBoxNumeroTrazableToro.Text) <= 0) return false;
                if (textBoxCausaDeBaja.Text == "") return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
