using System;
using System.Windows.Forms;
using TCU_WFA.Models;
using TCU_WFA.Repository;

namespace TCU_WFA
{
    public partial class FormEditarVaca : DefaultForm
    {

        // Constantes
        private const string QUERY_LLENAR_COMBO_BOX_MODO_PRENNES = "SELECT * FROM [dbo].[MODO_PRENNES];";
        private const string QUERY_LLENAR_COMBO_BOX_ID_MADRE = "SELECT v.PK_NUMERO_TRAZABLE, v.PK_NUMERO_TRAZABLE FROM [dbo].[VACA] v WHERE v.PK_NUMERO_TRAZABLE != ";
        private const string QUERY_LLENAR_COMBO_BOX_ID_PADRE = "SELECT t.PK_NUMERO_TRAZABLE, t.PK_NUMERO_TRAZABLE FROM [dbo].[TORO] t WHERE v.PK_NUMERO_TRAZABLE != ;";

        private VacaModel informacionVacaSeleccionada;
        public FormEditarVaca(VacaModel informacionVacaSeleccionada = null)
        {
            InitializeComponent();
            this.informacionVacaSeleccionada = informacionVacaSeleccionada;
        }

        private void FormEditarVaca_Load(object sender, EventArgs e)
        {
            LlenarComboBoxList();
            LlenarInformcionVaca();
        }

        private void LlenarInformcionVaca()
        {
            textBoxNumeroTrazableVaca.Text = this.informacionVacaSeleccionada.pkNumeroTrazable.ToString();
            textBoxNombre.Text = this.informacionVacaSeleccionada.nombre;
            textBoxRaza.Text = this.informacionVacaSeleccionada.raza;
            textBoxCaracteristicas.Text = this.informacionVacaSeleccionada.caracteriscas;
            dateTimePickerFechaNacimiento.Value = this.informacionVacaSeleccionada.fecha;
            int indiceModoPrennes = comboBoxModoPrennes.FindString(this.informacionVacaSeleccionada.modoPrennes);
            comboBoxModoPrennes.SelectedIndex = indiceModoPrennes;
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

        private void LlenarComboBoxList()
        {
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_MODO_PRENNES, comboBoxModoPrennes);
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_ID_MADRE + this.informacionVacaSeleccionada.pkNumeroTrazable + ";", comboBoxIdMadre);
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_ID_PADRE + this.informacionVacaSeleccionada.pkNumeroTrazable + ";", comboBoxIdPadre);
        }

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

        private bool RevisarEntradaUsuario()
        {
            try
            {
                if (textBoxNumeroTrazableVaca.Text == "" || Int32.Parse(textBoxNumeroTrazableVaca.Text) <= 0) return false;
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
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
