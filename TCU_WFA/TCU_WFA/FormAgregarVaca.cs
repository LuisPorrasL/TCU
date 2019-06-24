using System;
using System.Windows.Forms;
using TCU_WFA.Models;
using TCU_WFA.Repository;

namespace TCU_WFA
{
    public partial class FormAgregarVaca : DefaultForm
    {

        // Constantes
        private const int NO_MADRE_PADRE_ID = -1;
        private const string QUERY_LLENAR_COMBO_BOX_MODO_PRENNES = "SELECT * FROM [dbo].[MODO_PRENNES];";
        private const string QUERY_LLENAR_COMBO_BOX_ID_MADRE = "SELECT v.PK_NUMERO_TRAZABLE, v.PK_NUMERO_TRAZABLE FROM [dbo].[VACA] v;";
        private const string QUERY_LLENAR_COMBO_BOX_ID_PADRE = "SELECT t.PK_NUMERO_TRAZABLE, t.PK_NUMERO_TRAZABLE FROM [dbo].[TORO] t;";

        public FormAgregarVaca()
        {
            InitializeComponent();
        }

        private void FormAgregarVaca_Load(object sender, EventArgs e)
        {
            LlenarComboBoxListAgregarVaca();
        }

        private void LlenarComboBoxListAgregarVaca()
        {
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_MODO_PRENNES, comboBoxModoPrennes);
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_ID_MADRE, comboBoxIdMadre);
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_ID_PADRE, comboBoxIdPadre);
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            bool entradaUsuarioCorrecta = RevisarEntradaUsuario();
            if (entradaUsuarioCorrecta)
            {
                VacaModel datosNuevaVaca = ObtenerDatosEntradaUsuario();
                bool resultado = AgregarNuevaVaca(datosNuevaVaca);
                if (resultado)
                {
                    Utilities.MostrarMessageBox(Utilities.MENSAJE_EXITO, Utilities.TITULO_EXITO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarEntradaUsuario();
                    FormRegistroVacas formRegistroVacas = (FormRegistroVacas)Tag;
                    formRegistroVacas.LlenarDataGridViewVacas();
                }
                else Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR_ENTRADA_USUARIO, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AgregarNuevaVaca(VacaModel datosNuevaVaca)
        {
            try
            {
                int resultado = ProcedimientosAlmacenados.ProcInsertarVaca(datosNuevaVaca);
                if(resultado == Utilities.RESULTADO_ERROR) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool RevisarEntradaUsuario()
        {
            try
            {
                if (textBoxNumeroTrazableVaca.Text == "" || Int32.Parse(textBoxNumeroTrazableVaca.Text) <= 0) return false;
                if (textBoxCaracteristicas.Text == "") return false;
                if (comboBoxModoPrennes.Text == "") return false;
                if (comboBoxIdMadre.Text != "")
                {
                   if( Int32.Parse(comboBoxIdMadre.Text) <= 0) return false;
                }
                if (comboBoxIdPadre.Text != "")
                {
                    if (Int32.Parse(comboBoxIdPadre.Text) <= 0) return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private VacaModel ObtenerDatosEntradaUsuario()
        {
            VacaModel resultado = new VacaModel();
            resultado.pkNumeroTrazable = Int32.Parse(textBoxNumeroTrazableVaca.Text);
            resultado.nombre = textBoxNombre.Text;
            resultado.caracteriscas = textBoxCaracteristicas.Text;
            resultado.raza = textBoxRaza.Text;
            if (comboBoxIdMadre.Text != "") resultado.fkNumeroTrazableMadre = Int32.Parse(comboBoxIdMadre.Text);
            else resultado.fkNumeroTrazableMadre = null;
            if (comboBoxIdPadre.Text != "") resultado.fkNumeroTrazablePadre = Int32.Parse(comboBoxIdPadre.Text);
            else resultado.fkNumeroTrazablePadre = null;
            resultado.fkModoPrennes = Utilities.ObtenerIdModoPrennes(comboBoxModoPrennes.Text);
            resultado.fecha = dateTimePickerFechaNacimiento.Value;
            return resultado;
        }

        private void LimpiarEntradaUsuario()
        {
            textBoxNumeroTrazableVaca.Clear();
            textBoxNombre.Clear();
            textBoxRaza.Clear();
            textBoxCaracteristicas.Clear();
            dateTimePickerFechaNacimiento.Value = DateTime.Now;
            LlenarComboBoxListAgregarVaca();
        }

    }
}
