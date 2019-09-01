using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCU_WFA.Repository;

namespace TCU_WFA
{
    public partial class FormPalpacion : DefaultForm
    {

        //Constantes
        private const string QUERY_LLENAR_COMBO_BOX_ID_MADRE = "SELECT v.PK_NUMERO_TRAZABLE, v.PK_NUMERO_TRAZABLE FROM [dbo].[VACA] v WHERE v.ACTIVA = 1;";
        private const string QUERY_LLENAR_COMBO_BOX_MODO_PRENNES = "SELECT * FROM [dbo].[MODO_PRENNES];";
        private const string QUERY_OBTENER_ID_MODO_PRENNES = "SELECT mp.PK_ID_MODO_PRENNES FROM [dbo].[MODO_PRENNES] mP WHERE mP.MODO_PRENNES = @ModoPrennes";
        private const string MODO_PRENNES_PARAM = "@ModoPrennes";
        //Campos
        private DateTime fechaPalpacion;
        private int numeroTrazable;
        private float condicionCorporal;
        private bool confirmacion;
        private string resultadoPalpacion;
        private int fkNuevoModoPrennes;

        public FormPalpacion()
        {
            InitializeComponent();
            InicializarCampos();
        }

        private void InicializarCampos()
        {
            this.fechaPalpacion = new DateTime();
            this.numeroTrazable = 0;
            this.condicionCorporal = 0.0f;
            this.confirmacion = false;
            this.resultadoPalpacion = "";
            this.fkNuevoModoPrennes = 0;
        }

        private void FormPalpacion_Load(object sender, EventArgs e)
        {
            OcultarComponentes();
            LlenarComboBoxList();
        }

        private void OcultarComponentes()
        {
            labelActualizarInformacionVaca.Visible = radioButtonSi.Visible = radioButtonNo.Visible = groupBoxNuevoModoPrennes.Visible = false;
        }

        private void LlenarComboBoxList()
        {
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_ID_MADRE, comboBoxNumeroTrazable);
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_MODO_PRENNES, comboBoxNuevoModoPrennes);
            llenarComboBoxListCondicionCorporal();
        }

        private void llenarComboBoxListCondicionCorporal()
        {
            comboBoxCondicionCorporal.DisplayMember = "condicionCorporal";
            comboBoxCondicionCorporal.ValueMember = "id";
            comboBoxCondicionCorporal.Items.Add(new { condicionCorporal = 1f, id = 0 });
            comboBoxCondicionCorporal.Items.Add(new { condicionCorporal = 1.5f, id = 1 });
            comboBoxCondicionCorporal.Items.Add(new { condicionCorporal = 2f, id = 2 });
            comboBoxCondicionCorporal.Items.Add(new { condicionCorporal = 2.5f, id = 3 });
            comboBoxCondicionCorporal.Items.Add(new { condicionCorporal = 3f, id = 4 });
            comboBoxCondicionCorporal.Items.Add(new { condicionCorporal = 3.5f, id = 5 });
            comboBoxCondicionCorporal.Items.Add(new { condicionCorporal = 4f, id = 6 });
            comboBoxCondicionCorporal.Items.Add(new { condicionCorporal = 4.5f, id = 7 });
            comboBoxCondicionCorporal.Items.Add(new { condicionCorporal = 5f, id = 8 });
            comboBoxCondicionCorporal.SelectedIndex = 0;
        }

        private void botonsRegistrar_Click(object sender, EventArgs e)
        {
            bool entradaUsuarioCorrecta = RevisarEntradaUsuario();
            if (entradaUsuarioCorrecta)
            {
                ObtenerDatosEntradaUsuario();
                bool resultado = RegistrarPalpacion();
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
            dateTimePickerFechaPalpacion.Value = DateTime.Now;
            radioButtonPositiva.Checked = false;
            radioButtonVacia.Checked = false;
            textBoxResultado.Text = "";
        }

        private bool RegistrarPalpacion()
        {
            try
            {
                int resultado = ProcedimientosAlmacenados.ProcRegistrarPalpacion(this.numeroTrazable, this.fechaPalpacion, this.condicionCorporal, this.confirmacion, this.resultadoPalpacion);
                if (resultado == Utilities.RESULTADO_ERROR) return false;
                if (radioButtonPositiva.Checked && radioButtonSi.Checked)
                {
                    resultado = ProcedimientosAlmacenados.ProcActualizarModoPrennesVaca(this.numeroTrazable, this.fkNuevoModoPrennes);
                    if (resultado == Utilities.RESULTADO_ERROR) return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void ObtenerDatosEntradaUsuario()
        {
            this.fechaPalpacion = dateTimePickerFechaPalpacion.Value;
            this.numeroTrazable = Int32.Parse(comboBoxNumeroTrazable.Text);
            this.condicionCorporal = float.Parse(comboBoxCondicionCorporal.Text.Replace(',', '.'), CultureInfo.InvariantCulture.NumberFormat);
            if (radioButtonPositiva.Checked) this.confirmacion = true;
            else this.confirmacion = false;
            this.resultadoPalpacion = textBoxResultado.Text;
            if (radioButtonPositiva.Checked && radioButtonSi.Checked)
            {
                this.fkNuevoModoPrennes = Utilities.ObtenerIdTabla(QUERY_OBTENER_ID_MODO_PRENNES, MODO_PRENNES_PARAM, comboBoxNuevoModoPrennes.Text);
            }
        }

        private bool RevisarEntradaUsuario()
        {
            try
            {
                if (dateTimePickerFechaPalpacion.Value > DateTime.Now) return false;
                if (Int32.Parse(comboBoxNumeroTrazable.Text) <= 0) return false;
                float cC = float.Parse(comboBoxCondicionCorporal.Text.Replace(',', '.'), CultureInfo.InvariantCulture.NumberFormat);
                if (cC < 1f || cC > 5f) return false;
                if (!radioButtonPositiva.Checked && !radioButtonVacia.Checked) return false;
                if (radioButtonPositiva.Checked)
                {
                    if (!radioButtonSi.Checked && !radioButtonNo.Checked) return false;
                    if (radioButtonSi.Checked)
                    {
                        if (comboBoxNuevoModoPrennes.Text == "") return false;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void radioButtonPositiva_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPositiva.Checked)
            {
                labelActualizarInformacionVaca.Visible = radioButtonSi.Visible = radioButtonNo.Visible = true;
            }
        }

        private void radioButtonVacia_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVacia.Checked)
            {
                labelActualizarInformacionVaca.Visible = radioButtonSi.Visible = radioButtonNo.Visible = groupBoxNuevoModoPrennes.Visible = false;
            }
        }

        private void radioButtonSi_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSi.Checked)
            {
                groupBoxNuevoModoPrennes.Visible = true;
            }
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNo.Checked)
            {
                groupBoxNuevoModoPrennes.Visible = false;
            }
        }
    }
}
