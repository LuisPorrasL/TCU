using System;
using System.Windows.Forms;
using TCU_WFA.Models;
using TCU_WFA.Repository;

namespace TCU_WFA
{
    public partial class FormAgregarVaca : DefaultForm
    {

        // Constantes
        private const string QUERY_LLENAR_COMBO_BOX_RAZA = "SELECT * FROM [dbo].[RAZA];";
        private const string QUERY_LLENAR_COMBO_BOX_MODO_PRENNES = "SELECT * FROM [dbo].[MODO_PRENNES];";
        private const string QUERY_LLENAR_COMBO_BOX_DESARROLLO = "SELECT * FROM [dbo].[DESARROLLO];";
        private const string QUERY_LLENAR_COMBO_BOX_ID_MADRE = "SELECT v.PK_NUMERO_TRAZABLE, v.PK_NUMERO_TRAZABLE FROM [dbo].[VACA] v WHERE v.ACTIVA = 1;";
        private const string QUERY_LLENAR_COMBO_BOX_ID_PADRE = "SELECT t.PK_NUMERO_TRAZABLE, t.PK_NUMERO_TRAZABLE FROM [dbo].[TORO] t WHERE t.ACTIVA = 1;";
        private const string QUERY_OBTENER_ID_MODO_PRENNES = "SELECT mp.PK_ID_MODO_PRENNES FROM [dbo].[MODO_PRENNES] mP WHERE mP.MODO_PRENNES = @ModoPrennes";
        private const string MODO_PRENNES_PARAM = "@ModoPrennes";
        private const string QUERY_OBTENER_ID_RAZA = "SELECT r.PK_ID_RAZA FROM [dbo].[RAZA] r WHERE r.RAZA = @raza";
        private const string RAZA_PARAM = "@raza";
        private const string QUERY_OBTENER_ID_DESARROLLO = "SELECT d.PK_ID_DESARROLLO FROM [dbo].[DESARROLLO] d WHERE d.ESTADO = @estadoDesarrollo";
        private const string DESARROLLO_PARAM = "@estadoDesarrollo";

        public FormAgregarVaca()
        {
            InitializeComponent();
        }

        private void FormAgregarVaca_Load(object sender, EventArgs e)
        {
            LlenarComboBoxList();
        }

        private void LlenarComboBoxList()
        {
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_RAZA, comboBoxRaza);
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_MODO_PRENNES, comboBoxModoPrennes);
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_DESARROLLO, comboBoxDesarrollo);
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_ID_MADRE, comboBoxIdMadre);
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_ID_PADRE, comboBoxIdPadre);
            comboBoxIdMadre.Text = "";
            comboBoxIdPadre.Text = "";
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

        private VacaModel ObtenerDatosEntradaUsuario()
        {
            VacaModel resultado = new VacaModel();
            resultado.pkNumeroTrazable = Int32.Parse(textBoxNumeroTrazableVaca.Text);
            resultado.nombre = textBoxNombre.Text;
            resultado.caracteriscas = textBoxCaracteristicas.Text;
            if (textBoxPeso.Text != "") resultado.peso = double.Parse(textBoxPeso.Text.Replace('.', ','));
            else resultado.peso = null;
            if (comboBoxIdMadre.Text != "") resultado.fkNumeroTrazableMadre = Int32.Parse(comboBoxIdMadre.Text);
            else resultado.fkNumeroTrazableMadre = null;
            if (comboBoxIdPadre.Text != "") resultado.fkNumeroTrazablePadre = Int32.Parse(comboBoxIdPadre.Text);
            else resultado.fkNumeroTrazablePadre = null;
            resultado.raza = Utilities.ObtenerIdTabla(QUERY_OBTENER_ID_RAZA, RAZA_PARAM, comboBoxRaza.Text);
            resultado.fkModoPrennes = Utilities.ObtenerIdTabla(QUERY_OBTENER_ID_MODO_PRENNES, MODO_PRENNES_PARAM, comboBoxModoPrennes.Text);
            resultado.fkDesarrollo = Utilities.ObtenerIdTabla(QUERY_OBTENER_ID_DESARROLLO, DESARROLLO_PARAM, comboBoxDesarrollo.Text);
            resultado.fecha = dateTimePickerFechaNacimiento.Value;
            return resultado;
        }

        private bool RevisarEntradaUsuario()
        {
            try
            {
                if (textBoxNumeroTrazableVaca.Text == "" || Int32.Parse(textBoxNumeroTrazableVaca.Text) <= 0) return false;
                if (textBoxPeso.Text != "")
                {
                    double peso = double.Parse(textBoxPeso.Text.Replace('.', ','));
                    if (peso < 0 || peso > 999.99) return false;
                }
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
                if (dateTimePickerFechaNacimiento.Value > DateTime.Now) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void LimpiarEntradaUsuario()
        {
            textBoxNumeroTrazableVaca.Clear();
            textBoxNombre.Clear();
            textBoxCaracteristicas.Clear();
            textBoxPeso.Clear();
            dateTimePickerFechaNacimiento.Value = DateTime.Now;
            LlenarComboBoxList();
        }
    }
}
