using System;
using System.Windows.Forms;
using TCU_WFA.Repository;

namespace TCU_WFA
{
    public partial class FormSaltos : DefaultForm
    {

        // Constantes
        private const string QUERY_LLENAR_COMBO_BOX_NUMERO_TRAZABLE_VACA = "SELECT v.PK_NUMERO_TRAZABLE, v.PK_NUMERO_TRAZABLE FROM [dbo].[VACA] v;";

        //Campos
        private int vacaId;
        private DateTime fechaSalto;

        public FormSaltos()
        {
            InitializeComponent();
            InicializarCampos();
        }

        private void InicializarCampos()
        {
            this.vacaId = 0;
            this.fechaSalto = new DateTime();
        }

        private void FormSaltos_Load(object sender, EventArgs e)
        {
            LlenarComboBoxList();
        }

        private void LlenarComboBoxList()
        {
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_NUMERO_TRAZABLE_VACA, comboBoxNumeroTrazableVaca);
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            bool entradaUsuarioCorrecta = RevisarEntradaUsuario();
            if (entradaUsuarioCorrecta)
            {
                ObtenerDatosEntradaUsuario();
                bool resultado = InsertarDestete();
                if (resultado)
                {
                    Utilities.MostrarMessageBox(Utilities.MENSAJE_EXITO, Utilities.TITULO_EXITO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarEntradaUsuario();
                }
                else Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR_ENTRADA_USUARIO, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarEntradaUsuario()
        {
            InicializarCampos();
            LlenarComboBoxList();
            dateTimePickerFechaNacimiento.Value = DateTime.Now;
        }

        private bool InsertarDestete()
        {
            try
            {
                int resultado = ProcedimientosAlmacenados.ProcInsertarSalto(this.vacaId, this.fechaSalto);
                if (resultado == Utilities.RESULTADO_ERROR) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void ObtenerDatosEntradaUsuario()
        {
            this.vacaId = Int32.Parse(comboBoxNumeroTrazableVaca.Text);
            this.fechaSalto = dateTimePickerFechaNacimiento.Value;
        }

        private bool RevisarEntradaUsuario()
        {
            try
            {
                if (Int32.Parse(comboBoxNumeroTrazableVaca.Text) <= 0) return false;
                if (dateTimePickerFechaNacimiento.Value > DateTime.Now) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
