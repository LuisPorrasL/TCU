// Hecho por Luis Porras.
using System;
using System.Windows.Forms;
using TCU_WFA.Models;
using TCU_WFA.Repository;

namespace TCU_WFA
{
    public partial class FormParto : DefaultForm
    {
        //Constantes
        private const string QUERY_LLENAR_COMBO_BOX_ID_MADRE = "SELECT v.PK_NUMERO_TRAZABLE, v.PK_NUMERO_TRAZABLE FROM [dbo].[VACA] v, [dbo].[DESARROLLO] d WHERE v.ACTIVA = 1 AND d.ESTADO != 'Ternera' AND v.FK_ID_DESARROLLO = d.PK_ID_DESARROLLO;";
        private const string QUERY_LLENAR_COMBO_BOX_ID_PADRE = "SELECT t.PK_NUMERO_TRAZABLE, t.PK_NUMERO_TRAZABLE FROM [dbo].[TORO] t WHERE t.ACTIVA = 1;";
        private const string QUERY_LLENAR_COMBO_BOX_RAZA = "SELECT * FROM [dbo].[RAZA];";
        private const string QUERY_OBTENER_ID_MODO_PRENNES = "SELECT mp.PK_ID_MODO_PRENNES FROM [dbo].[MODO_PRENNES] mP WHERE mP.MODO_PRENNES = @ModoPrennes";
        private const string MODO_PRENNES_PARAM = "@ModoPrennes";
        private const string QUERY_OBTENER_ID_RAZA = "SELECT r.PK_ID_RAZA FROM [dbo].[RAZA] r WHERE r.RAZA = @raza";
        private const string RAZA_PARAM = "@raza";
        private const string QUERY_OBTENER_ID_DESARROLLO = "SELECT d.PK_ID_DESARROLLO FROM [dbo].[DESARROLLO] d WHERE d.ESTADO = @estadoDesarrollo";
        private const string DESARROLLO_PARAM = "@estadoDesarrollo";
        private const string MODO_PRENNES_TERNERO = "No preñada";
        private const string DESARROLLO_TERNERO = "Ternera";

        //Campos
        private DateTime fechaParto;
        private char sexoCria;
        private int idMadre;
        private int? idPadre;
        private bool muertePrematura;
        private string causaAborto;
        private VacaModel informacionTernero;

        /// <summary>
        /// Constructor.
        /// </summary>
        public FormParto()
        {
            InitializeComponent();
            InicializarCampos();
        }

        /// <summary>
        /// Asigna un valor inicial a los atributos privados de la clase.
        /// </summary>
        private void InicializarCampos()
        {
            this.fechaParto = new DateTime();
            this.sexoCria = ' ';
            this.idMadre = 0;
            this.idPadre = 0;
            this.muertePrematura = false;
            this.causaAborto = "";
            this.informacionTernero = new VacaModel();
        }

        /// <summary>
        /// Método que se llama cada vez que se carga el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormParto_Load(object sender, EventArgs e)
        {
            OcultarComponentes();
            LlenarComboBoxList();
        }

        /// <summary>
        /// Oculta componentes del form.
        /// </summary>
        private void OcultarComponentes()
        {
            labelCausaAborto.Visible = textBoxCausaAborto.Visible = labelRegistrarTernero.Visible = radioButtonSiRegistroTernero.Visible = radioButtonNoRegistroTernero.Visible = groupBoxRegistroTernero.Visible = false;
        }

        /// <summary>
        /// Llena todos los ComboBoxList del form.
        /// </summary>
        private void LlenarComboBoxList()
        {
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_ID_MADRE, comboBoxIdMadre);
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_ID_PADRE, comboBoxIdPadre);
            comboBoxIdPadre.Text = "";
            llenarComboBoxListSexo();
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_RAZA, comboBoxRaza);
        }

        /// <summary>
        /// Pobla el ComboBoxListSexo del form con datos válidos.
        /// </summary>
        private void llenarComboBoxListSexo()
        {
            comboBoxSexo.Items.Clear();
            comboBoxSexo.DisplayMember = "sexo";
            comboBoxSexo.ValueMember = "id";
            comboBoxSexo.Items.Add(new { sexo = 'H', id = 0 });
            comboBoxSexo.Items.Add(new { sexo = 'M', id = 1 });
            comboBoxSexo.SelectedIndex = 0;
        }

        /// <summary>
        /// Implementa la función principal del form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Limpia la entrada realizada por el usuario.
        /// </summary>
        private void LimpiarEntradaUsuario()
        {
            InicializarCampos();
            OcultarComponentes();
            LlenarComboBoxList();
            radioButtonSi.Checked = radioButtonNo.Checked = false;
            dateTimePickerFechaParto.Value = DateTime.Now;
            textBoxCausaAborto.Text = "";
            radioButtonSiRegistroTernero.Checked = radioButtonNoRegistroTernero.Checked = false;
            textBoxNumeroTrazableTernero.Text = textBoxNombre.Text = textBoxPeso.Text = textBoxCaracteristicasTernero.Text = ""; 
        }

        /// <summary>
        /// Intenta insertar un nuevo parto en la base de datos.
        /// </summary>
        /// <returns>Un booleano. True sí la operación fue correcta, false en caso contrario.</returns>
        private bool RegistrarParto()
        {
            try
            {
                int resultado = ProcedimientosAlmacenados.ProcRegistrarParto(this.fechaParto, this.sexoCria, this.idMadre, this.idPadre, this.muertePrematura, this.causaAborto);
                if (resultado == Utilities.RESULTADO_ERROR) return false;
                if(radioButtonNo.Checked && radioButtonSiRegistroTernero.Checked)
                {
                    if (this.sexoCria == 'H') resultado = ProcedimientosAlmacenados.ProcInsertarVaca(this.informacionTernero);
                    //else resultado = ProcedimientosAlmacenados.ProcInsertarToro(this.informacionTernero);
                    if (resultado == Utilities.RESULTADO_ERROR) return false;
                }
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
        private void ObtenerDatosEntradaUsuario()
        {
            this.fechaParto = dateTimePickerFechaParto.Value;
            this.sexoCria = comboBoxSexo.Text[0];
            this.idMadre = Int32.Parse(comboBoxIdMadre.Text);
            if (comboBoxIdPadre.Text != "") this.idPadre = Int32.Parse(comboBoxIdPadre.Text);
            else this.idPadre = null;
            if (radioButtonSi.Checked)
            {
                this.muertePrematura = true;
                this.causaAborto = textBoxCausaAborto.Text;
            }
            else
            {
                this.muertePrematura = false;
                if (radioButtonSiRegistroTernero.Checked)
                {
                    this.informacionTernero.fecha = this.fechaParto;
                    this.informacionTernero.fkNumeroTrazableMadre = this.idMadre;
                    this.informacionTernero.fkNumeroTrazablePadre = this.idPadre;
                    this.informacionTernero.pkNumeroTrazable = Int32.Parse(textBoxNumeroTrazableTernero.Text);
                    this.informacionTernero.nombre = textBoxNombre.Text;
                    this.informacionTernero.raza = (Int32)Utilities.ObtenerAtributoTabla(QUERY_OBTENER_ID_RAZA, RAZA_PARAM, comboBoxRaza.Text);
                    if (textBoxPeso.Text != "") this.informacionTernero.peso = double.Parse(textBoxPeso.Text.Replace('.', ','));
                    else this.informacionTernero.peso = null;
                    this.informacionTernero.caracteriscas = textBoxCaracteristicasTernero.Text;
                    this.informacionTernero.fkModoPrennes = (Int32)Utilities.ObtenerAtributoTabla(QUERY_OBTENER_ID_MODO_PRENNES, MODO_PRENNES_PARAM, MODO_PRENNES_TERNERO);
                    this.informacionTernero.fkDesarrollo = (Int32)Utilities.ObtenerAtributoTabla(QUERY_OBTENER_ID_DESARROLLO, DESARROLLO_PARAM, DESARROLLO_TERNERO);
                }
            }
            this.causaAborto = textBoxCausaAborto.Text;
        }

        /// <summary>
        /// Revisa que los datos insertados o seleccionados por el usuario sean válidos.
        /// </summary>
        /// <returns>Un booleano. True sí los datos insertados por el usuario son válidos, false en caso contrario.</returns>
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
                if (radioButtonNo.Checked)
                {
                    if (!radioButtonSiRegistroTernero.Checked && !radioButtonNoRegistroTernero.Checked) return false;
                    if (radioButtonSiRegistroTernero.Checked)
                    {
                        if (textBoxNumeroTrazableTernero.Text == "" || Int32.Parse(textBoxNumeroTrazableTernero.Text) <= 0) return false;
                        if (textBoxPeso.Text != "")
                        {
                            double peso = double.Parse(textBoxPeso.Text.Replace('.', ','));
                            if (peso < 0 || peso > 999.99) return false;
                        }
                        if (textBoxCaracteristicasTernero.Text == "") return false;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void radioButtonSi_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSi.Checked)
            {
                labelCausaAborto.Visible = textBoxCausaAborto.Visible = true;
                labelRegistrarTernero.Visible = radioButtonSiRegistroTernero.Visible = radioButtonNoRegistroTernero.Visible = groupBoxRegistroTernero.Visible = false;
            }
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNo.Checked)
            {
                labelCausaAborto.Visible = textBoxCausaAborto.Visible = false;
                labelRegistrarTernero.Visible = radioButtonSiRegistroTernero.Visible = radioButtonNoRegistroTernero.Visible = true;
            }
        }

        private void radioButtonSiRegistroTernero_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSiRegistroTernero.Checked)
            {
                groupBoxRegistroTernero.Visible = true;
            }
        }

        private void radioButtonNoRegistroTernero_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNoRegistroTernero.Checked)
            {
                groupBoxRegistroTernero.Visible = false;
            }
        }

        private void comboBoxIdPadre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
