using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCU_WFA.Repository;

namespace TCU_WFA
{
    public partial class FormParto : DefaultForm
    {
        //Constantes
        private const string QUERY_LLENAR_COMBO_BOX_ID_MADRE = "SELECT v.PK_NUMERO_TRAZABLE, v.PK_NUMERO_TRAZABLE FROM [dbo].[VACA] v;";
        private const string QUERY_LLENAR_COMBO_BOX_ID_PADRE = "SELECT t.PK_NUMERO_TRAZABLE, t.PK_NUMERO_TRAZABLE FROM [dbo].[TORO] t;";
        //Campos
        private DateTime fechaParto;
        private char sexoCria;
        private int idMadre;
        private int? idPadre;
        private bool muertePrematura;
        private string causaAborto;

        public FormParto()
        {
            InitializeComponent();
            InicializarCampos();
        }

        private void InicializarCampos()
        {
            this.fechaParto = new DateTime();
            this.sexoCria = ' ';
            this.idMadre = 0;
            this.idPadre = 0;
            this.muertePrematura = false;
            this.causaAborto = "";
        }

        private void FormParto_Load(object sender, EventArgs e)
        {
            LlenarComboBoxList();
        }

        private void LlenarComboBoxList()
        {
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_ID_MADRE, comboBoxIdMadre);
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_ID_PADRE, comboBoxIdPadre);
            comboBoxIdPadre.Text = "";
            llenarComboBoxListSexo();
        }

        private void llenarComboBoxListSexo()
        {
            comboBoxSexo.DisplayMember = "sexo";
            comboBoxSexo.ValueMember = "id";
            comboBoxSexo.Items.Add(new { sexo = 'H', id = 0 });
            comboBoxSexo.Items.Add(new { sexo = 'M', id = 1 });
            comboBoxSexo.SelectedIndex = 0;
        }

        private void botonsRegistrar_Click(object sender, EventArgs e)
        {
            bool entradaUsuarioCorrecta = RevisarEntradaUsuario();
            if (entradaUsuarioCorrecta)
            {
                ObtenerDatosEntradaUsuario();
                bool resultado = RegistrarParto();
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
            dateTimePickerFechaParto.Value = DateTime.Now;
            textBoxCausaAborto.Text = "";
            radioButtonSi.Checked = false;
            radioButtonNo.Checked = false;
        }

        private bool RegistrarParto()
        {
            try
            {
                int resultado = ProcedimientosAlmacenados.ProcRegistrarParto(this.fechaParto, this.sexoCria, this.idMadre, this.idPadre, this.muertePrematura, this.causaAborto);
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
            this.fechaParto = dateTimePickerFechaParto.Value;
            this.sexoCria = comboBoxSexo.Text[0];
            this.idMadre = Int32.Parse(comboBoxIdMadre.Text);
            if (comboBoxIdPadre.Text != "") this.idPadre = Int32.Parse(comboBoxIdPadre.Text);
            else this.idPadre = null;
            if (radioButtonSi.Checked) this.muertePrematura = true;
            else this.muertePrematura = false;
            this.causaAborto = textBoxCausaAborto.Text;
        }

        private bool RevisarEntradaUsuario()
        {
            try
            {
                if (dateTimePickerFechaParto.Value > DateTime.Now) return false;
                if (comboBoxSexo.Text != "H" && comboBoxSexo.Text != "M") return false;
                if (Int32.Parse(comboBoxIdMadre.Text) <= 0) return false;
                if (comboBoxIdPadre.Text != "")
                {
                    if (Int32.Parse(comboBoxIdPadre.Text) <= 0) return false;
                }
                if (!radioButtonSi.Checked && !radioButtonNo.Checked) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
