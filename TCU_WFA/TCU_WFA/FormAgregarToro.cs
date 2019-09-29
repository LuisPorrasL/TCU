using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCU_WFA.Models;
using TCU_WFA.Repository;

namespace TCU_WFA
{
    public partial class FormAgregarToro : DefaultForm
    {

        // Constantes
        private const string QUERY_LLENAR_COMBO_BOX_RAZA = "SELECT * FROM [dbo].[RAZA];";
        private const string QUERY_OBTENER_ID_RAZA = "SELECT r.PK_ID_RAZA FROM [dbo].[RAZA] r WHERE r.RAZA = @raza";
        private const string RAZA_PARAM = "@raza";

        /// <summary>
        /// Constructor.
        /// </summary>
        public FormAgregarToro()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que se llama cada vez que se carga el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAgregarToro_Load(object sender, EventArgs e)
        {
            LlenarComboBoxList();
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
        private void botonAgregar_Click(object sender, EventArgs e)
        {
            bool entradaUsuarioCorrecta = RevisarEntradaUsuario();
            if (entradaUsuarioCorrecta)
            {
                ToroModel datosNuevoToro = ObtenerDatosEntradaUsuario();
                bool resultado = AgregarNuevoToro(datosNuevoToro);
                if (resultado)
                {
                    Utilities.MostrarMessageBox(Utilities.MENSAJE_EXITO, Utilities.TITULO_EXITO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarEntradaUsuario();
                    FormRegistroToros formRegistroToros = (FormRegistroToros)Tag;
                    formRegistroToros.LlenarDataGridViewToros();
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
            textBoxNumeroTrazableToro.Clear();
            textBoxNombre.Clear();
            textBoxCaracteristicas.Clear();
            LlenarComboBoxList();
        }

        private bool AgregarNuevoToro(ToroModel datosNuevoToro)
        {
            try
            {
                int resultado = ProcedimientosAlmacenados.ProcInsertarToro(datosNuevoToro);
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
