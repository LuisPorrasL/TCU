// Hecho por Luis Porras.
using System;
using System.Windows.Forms;
using TCU_WFA.Repository;

namespace TCU_WFA
{
    public partial class FormEliminarVaca : DefaultForm
    {
        // Constantes
        private const string QUERY_LLENAR_COMBO_BOX_NUMERO_TRAZABLE_VACA = "SELECT v.PK_NUMERO_TRAZABLE, v.PK_NUMERO_TRAZABLE FROM [dbo].[VACA] v WHERE v.ACTIVA = 1;";

        //Campos
        private int numeroTrazableVaca;
        private string causaDeBaja;

        //Titulos
        public const string TITULO_AVISO_ELIMINAR_VACA = "Aviso eliminar vaca";

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="numeroTrazableVaca"></param>
        public FormEliminarVaca(int numeroTrazableVaca)
        {
            InitializeComponent();
            this.numeroTrazableVaca = numeroTrazableVaca;
        }

        /// <summary>
        /// Método que se llama cada vez que se carga el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEliminarVaca_Load(object sender, EventArgs e)
        {
            LlenarComboBoxList();
            LlenarInformcionVaca();
        }

        /// <summary>
        /// Llena todos los ComboBoxList del form.
        /// </summary>
        private void LlenarComboBoxList()
        {
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_NUMERO_TRAZABLE_VACA, comboBoxNumeroTrazableVaca);
        }

        /// <summary>
        /// Asigna a los componentes del form la información de la vaca seleccionada.
        /// </summary>
        private void LlenarInformcionVaca()
        {
            comboBoxNumeroTrazableVaca.SelectedIndex = comboBoxNumeroTrazableVaca.FindString(this.numeroTrazableVaca.ToString());
            textBoxCausaDeBaja.Text = "";
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
                bool resultado = EliminarVaca();
                if (resultado)
                {
                    Utilities.MostrarMessageBox(Utilities.MENSAJE_EXITO, Utilities.TITULO_EXITO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormRegistroVacas formRegistroVacas = (FormRegistroVacas)Tag;
                    formRegistroVacas.LlenarDataGridViewVacas();
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
            this.numeroTrazableVaca = -1;
            textBoxCausaDeBaja.Text = "";
            LlenarComboBoxList();
        }

        /// <summary>
        /// Intenta eliminar la vaca seleccionada de la base de datos.
        /// </summary>
        /// <returns>Un booleano. True sí la operación fue correcta, false en caso contrario.</returns>
        private bool EliminarVaca()
        {
            DialogResult resultadoDialogo = Utilities.MostrarMessageBox("¿Seguro que desea eliminar la vaca " + this.numeroTrazableVaca + "?. Esta operación no se puede revertir.", TITULO_AVISO_ELIMINAR_VACA, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultadoDialogo == DialogResult.Yes)
            {
                try
                {
                    int resultado = ProcedimientosAlmacenados.ProcEliminarVaca(this.numeroTrazableVaca, this.causaDeBaja);
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
            this.numeroTrazableVaca = Int32.Parse(comboBoxNumeroTrazableVaca.Text);
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
                if (comboBoxNumeroTrazableVaca.Text == "" || Int32.Parse(comboBoxNumeroTrazableVaca.Text) <= 0) return false;
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
