using System;
using System.Windows.Forms;
using TCU_WFA.Models;
using TCU_WFA.Repository;

namespace TCU_WFA
{
    public partial class FormEditarToro : DefaultForm
    {
        // Constantes
        private const string QUERY_LLENAR_COMBO_BOX_RAZA = "SELECT * FROM [dbo].[RAZA];";
        private const string QUERY_OBTENER_ID_RAZA = "SELECT r.PK_ID_RAZA FROM [dbo].[RAZA] r WHERE r.RAZA = @raza";
        private const string RAZA_PARAM = "@raza";

        // Campos
        private ToroModel informacionToroSeleccionado;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="informacionToroSeleccionado">ToroModel con la información del toro a mostrar</param>
        public FormEditarToro(ToroModel informacionToroSeleccionado = null)
        {
            InitializeComponent();
            this.informacionToroSeleccionado = informacionToroSeleccionado;
        }

        /// <summary>
        /// Método que se llama cada vez que se carga el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEditarToro_Load(object sender, EventArgs e)
        {
            LlenarComboBoxList();
            LlenarInformcionVaca();
        }

        /// <summary>
        /// Asigna a los componentes del form la información del toro seleccionado.
        /// </summary>
        private void LlenarInformcionVaca()
        {
            textBoxNumeroTrazableToro.Text = this.informacionToroSeleccionado.pkNumeroTrazable.ToString();
            textBoxNombre.Text = this.informacionToroSeleccionado.nombre;
            textBoxCaracteristicas.Text = this.informacionToroSeleccionado.caracteriscas;
            comboBoxRaza.SelectedIndex = comboBoxRaza.FindString(this.informacionToroSeleccionado.razaStr);
        }

        /// <summary>
        /// Llena todos los ComboBoxList del form.
        /// </summary>
        private void LlenarComboBoxList()
        {
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_RAZA, comboBoxRaza);
        }

        /// <summary>
        /// Implementa la función principal del form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonEditar_Click(object sender, EventArgs e)
        {
            bool entradaUsuarioCorrecta = RevisarEntradaUsuario();
            if (entradaUsuarioCorrecta)
            {
                ToroModel datosNuevoToro = ObtenerDatosEntradaUsuario();
                bool resultado = EditarToro(datosNuevoToro);
                if (resultado)
                {
                    Utilities.MostrarMessageBox(Utilities.MENSAJE_EXITO, Utilities.TITULO_EXITO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormRegistroToros formRegistroToros = (FormRegistroToros)Tag;
                    formRegistroToros.LlenarDataGridViewToros();
                    this.informacionToroSeleccionado = datosNuevoToro;
                }
                else Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR_ENTRADA_USUARIO, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Intenta editar la información del toro en la base de datos.
        /// </summary>
        /// <param name="datosNuevoToro"></param>
        /// <returns>Un booleano. True sí la operación fue correcta, false en caso contrario.</returns>
        private bool EditarToro(ToroModel datosNuevoToro)
        {
            try
            {
                int resultado = ProcedimientosAlmacenados.ProcEditarToro(datosNuevoToro);
                if (resultado == Utilities.RESULTADO_ERROR) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Obtiene los datos digitados o seleccionados por el usuario.
        /// </summary>
        /// <returns>Un ToroModel con la información ingresada por el usuario.</returns>
        private ToroModel ObtenerDatosEntradaUsuario()
        {
            ToroModel resultado = new ToroModel();
            resultado.pkNumeroTrazable = Int32.Parse(textBoxNumeroTrazableToro.Text);
            resultado.nombre = textBoxNombre.Text;
            resultado.caracteriscas = textBoxCaracteristicas.Text;
            resultado.raza = Utilities.ObtenerIdTabla(QUERY_OBTENER_ID_RAZA, RAZA_PARAM, comboBoxRaza.Text);
            return resultado;
        }

        /// <summary>
        /// Revisa que los datos insertados o seleccionados por el usuario sean válidos.
        /// </summary>
        /// <returns>Un booleano. True sí los datos insertados por el usuario son válidos, false en caso contrario.</returns>
        private bool RevisarEntradaUsuario()
        {
            try
            {
                if (textBoxNumeroTrazableToro.Text == "" || Int32.Parse(textBoxNumeroTrazableToro.Text) <= 0) return false;
                if (textBoxCaracteristicas.Text == "") return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
