//Hecho por Luis Porras.
using System;
using System.Windows.Forms;
using TCU_WFA.Models;
using TCU_WFA.Repository;

namespace TCU_WFA
{
    public partial class FormEditarVaca : DefaultForm
    {
        // Constantes
        private const string QUERY_LLENAR_COMBO_BOX_RAZA = "SELECT * FROM [dbo].[RAZA];";
        private const string QUERY_LLENAR_COMBO_BOX_MODO_PRENNES = "SELECT * FROM [dbo].[MODO_PRENNES];";
        private const string QUERY_LLENAR_COMBO_BOX_DESARROLLO = "SELECT * FROM [dbo].[DESARROLLO];";
        private const string QUERY_LLENAR_COMBO_BOX_ID_MADRE = "SELECT v.PK_NUMERO_TRAZABLE, v.PK_NUMERO_TRAZABLE FROM [dbo].[VACA] v WHERE v.ACTIVA = 1 AND v.PK_NUMERO_TRAZABLE != ";
        private const string QUERY_LLENAR_COMBO_BOX_ID_PADRE = "SELECT t.PK_NUMERO_TRAZABLE, t.PK_NUMERO_TRAZABLE FROM [dbo].[TORO] t WHERE t.ACTIVA = 1;";
        private const string QUERY_OBTENER_ID_MODO_PRENNES = "SELECT mp.PK_ID_MODO_PRENNES FROM [dbo].[MODO_PRENNES] mP WHERE mP.MODO_PRENNES = @ModoPrennes";
        private const string MODO_PRENNES_PARAM = "@ModoPrennes";
        private const string QUERY_OBTENER_ID_RAZA = "SELECT r.PK_ID_RAZA FROM [dbo].[RAZA] r WHERE r.RAZA = @raza";
        private const string RAZA_PARAM = "@raza";
        private const string QUERY_OBTENER_ID_DESARROLLO = "SELECT d.PK_ID_DESARROLLO FROM [dbo].[DESARROLLO] d WHERE d.ESTADO = @estadoDesarrollo";
        private const string DESARROLLO_PARAM = "@estadoDesarrollo";

        // Campos
        private VacaModel informacionVacaSeleccionada;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="informacionVacaSeleccionada">VacaModel con la información de la vaca a mostrar</param>
        public FormEditarVaca(VacaModel informacionVacaSeleccionada = null)
        {
            InitializeComponent();
            this.informacionVacaSeleccionada = informacionVacaSeleccionada;
        }

        /// <summary>
        /// Método que se llama cada vez que se carga el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEditarVaca_Load(object sender, EventArgs e)
        {
            LlenarComboBoxList();
            LlenarInformcionVaca();
        }

        /// <summary>
        /// Llena todos los ComboBoxList del form.
        /// </summary>
        private void LlenarComboBoxList()
        {
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_RAZA, comboBoxRaza);
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_MODO_PRENNES, comboBoxModoPrennes);
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_DESARROLLO, comboBoxDesarrollo);
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_ID_MADRE + this.informacionVacaSeleccionada.pkNumeroTrazable + ";", comboBoxIdMadre);
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_ID_PADRE, comboBoxIdPadre);
        }

        /// <summary>
        /// Asigna a los componentes del form la información de la vaca seleccionada.
        /// </summary>
        private void LlenarInformcionVaca()
        {
            textBoxNumeroTrazableVaca.Text = this.informacionVacaSeleccionada.pkNumeroTrazable.ToString();
            textBoxNombre.Text = this.informacionVacaSeleccionada.nombre;
            textBoxCaracteristicas.Text = this.informacionVacaSeleccionada.caracteriscas;
            textBoxPeso.Text = this.informacionVacaSeleccionada.peso.ToString();
            dateTimePickerFechaNacimiento.Value = (DateTime)this.informacionVacaSeleccionada.fecha;
            comboBoxRaza.SelectedIndex = comboBoxRaza.FindString(this.informacionVacaSeleccionada.razaStr);
            comboBoxModoPrennes.SelectedIndex = comboBoxModoPrennes.FindString(this.informacionVacaSeleccionada.modoPrennes);
            comboBoxDesarrollo.SelectedIndex = comboBoxDesarrollo.FindString(this.informacionVacaSeleccionada.desarrollo);
            if (this.informacionVacaSeleccionada.fkNumeroTrazableMadre != null)
            {
                int indiceIdMadre = comboBoxIdMadre.FindString(this.informacionVacaSeleccionada.fkNumeroTrazableMadre.ToString());
                comboBoxIdMadre.SelectedIndex = indiceIdMadre;
            }
            else comboBoxIdMadre.Text = "";
            if (this.informacionVacaSeleccionada.fkNumeroTrazablePadre != null)
            {
                int indiceIdPadre = comboBoxIdPadre.FindString(this.informacionVacaSeleccionada.fkNumeroTrazablePadre.ToString());
                comboBoxIdPadre.SelectedIndex = indiceIdPadre;
            }
            else comboBoxIdPadre.Text = "";
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
                VacaModel datosNuevaVaca = ObtenerDatosEntradaUsuario();
                bool resultado = EditarVaca(datosNuevaVaca);
                if (resultado)
                {
                    Utilities.MostrarMessageBox(Utilities.MENSAJE_EXITO, Utilities.TITULO_EXITO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormRegistroVacas formRegistroVacas = (FormRegistroVacas)Tag;
                    formRegistroVacas.LlenarDataGridViewVacas();
                    this.informacionVacaSeleccionada = datosNuevaVaca;
                }
                else Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR_ENTRADA_USUARIO, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Intenta editar la información de la vaca en la base de datos.
        /// </summary>
        /// <param name="datosNuevaVaca"></param>
        /// <returns>Un booleano. True sí la operación fue correcta, false en caso contrario.</returns>
        private bool EditarVaca(VacaModel datosNuevaVaca)
        {
            try
            {
                int resultado = ProcedimientosAlmacenados.ProcEditarVaca(datosNuevaVaca);
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
        /// <returns>Un VacaModel con la información ingresada por el usuario.</returns>
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

        /// <summary>
        /// Revisa que los datos insertados o seleccionados por el usuario sean válidos.
        /// </summary>
        /// <returns>Un booleano. True sí los datos insertados por el usuario son válidos, false en caso contrario.</returns>
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
                    if (Int32.Parse(comboBoxIdMadre.Text) <= 0) return false;
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
    }
}
