using System;
using TCU_WFA.Models;

namespace TCU_WFA
{
    public partial class FormDetallesVaca : DefaultForm
    {
        // Constantes
        private const string QUERY_LLENAR_COMBO_BOX_FECHAS_SALTOS = "SELECT * FROM [dbo].[FECHAS_SALTOS] f WHERE f.PK_FK_NUMERO_TRAZABLE_VACA = ";
        private const string QUERY_LLENAR_COMBO_BOX_FECHAS_DESTETES = "SELECT * FROM [dbo].[FECHAS_DESTETES] f WHERE f.PK_FK_NUMERO_TRAZABLE_VACA = ";
        private const string QUERY_SELECT_DATA_GRID_VIEW_PALPACIONES = "SELECT p.PK_FK_NUMERO_TRAZABLE_VACA AS 'Id', p.PK_FECHA AS 'Fecha', p.CONDICION_CORPORAL AS 'Condición corporal', p.RESULTADO AS 'Resultado', p.CONFIRMACION AS 'Confirmación' FROM [dbo].[PALPACION] p WHERE p.PK_FK_NUMERO_TRAZABLE_VACA = ";
        private const string QUERY_SELECT_DATA_GRID_VIEW_PARTOS = "SELECT p.PK_FK_NUMERO_TRAZABLE_VACA AS 'Id madre', p.PK_FK_NUMERO_TRAZABLE_TORO AS 'Id padre', p.PK_FECHA AS 'Fecha', p.SEXO AS 'Sexo cría', p.MUERTE_PREMATURA AS 'Muerte prematura', p.CAUSA_ABORTO AS 'Causa aborto' FROM [dbo].[PARTO] p WHERE p.PK_FK_NUMERO_TRAZABLE_VACA = ";

        private VacaModel informacionVacaSeleccionada;
        public FormDetallesVaca(VacaModel informacionVacaSeleccionada = null)
        {
            InitializeComponent();
            this.informacionVacaSeleccionada = informacionVacaSeleccionada;
        }

        private void FormDetallesVaca_Load(object sender, EventArgs e)
        {
            LlenarComboBoxList();
            LlenarInformcionVaca();
            LlenarDataGridViews();
        }

        public void LlenarDataGridViews()
        {
            Utilities.LlenarDataGridView(QUERY_SELECT_DATA_GRID_VIEW_PALPACIONES + informacionVacaSeleccionada.pkNumeroTrazable + ";", dataGridViewPalpacionesVaca);
            Utilities.LlenarDataGridView(QUERY_SELECT_DATA_GRID_VIEW_PARTOS + informacionVacaSeleccionada.pkNumeroTrazable + ";", dataGridViewPartosVacas);
        }

        private void LlenarComboBoxList()
        {
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_FECHAS_SALTOS + informacionVacaSeleccionada.pkNumeroTrazable + ";", comboBoxFechasSaltos);
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_FECHAS_DESTETES + informacionVacaSeleccionada.pkNumeroTrazable + ";", comboBoxFechasDestetes);
        }

        private void LlenarInformcionVaca()
        {
            textBoxNumeroTrazableVaca.Text = this.informacionVacaSeleccionada.pkNumeroTrazable.ToString();
            textBoxNombre.Text = this.informacionVacaSeleccionada.nombre;
            textBoxRaza.Text = this.informacionVacaSeleccionada.raza;
            textBoxCaracteristicas.Text = this.informacionVacaSeleccionada.caracteriscas;
            textBoxFechaNacimiento.Text = this.informacionVacaSeleccionada.fecha.ToString();
            textBoxModoPrennes.Text = this.informacionVacaSeleccionada.modoPrennes;
            textBoxIdMadre.Text = this.informacionVacaSeleccionada.fkNumeroTrazableMadre.ToString();
            textBoxIdPadre.Text = this.informacionVacaSeleccionada.fkNumeroTrazablePadre.ToString();
            int edad = DateTime.Today.Year - this.informacionVacaSeleccionada.fecha.Year;
            if (this.informacionVacaSeleccionada.fecha.Date > DateTime.Today.AddYears(-edad)) edad--;
            textBoxEdad.Text = edad.ToString();
        }
    }
}
