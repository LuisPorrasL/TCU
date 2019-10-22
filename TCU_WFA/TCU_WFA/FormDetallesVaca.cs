//Hecho por Luis Porras.
using System;
using TCU_WFA.Models;
using TCU_WFA.Repository;

namespace TCU_WFA
{
    public partial class FormDetallesVaca : DefaultForm
    {
        // Constantes
        private const string QUERY_LLENAR_COMBO_BOX_FECHAS_SALTOS = "SELECT * FROM [dbo].[FECHAS_CELOS] f WHERE f.PK_FK_NUMERO_TRAZABLE_VACA = ";
        private const string QUERY_LLENAR_COMBO_BOX_FECHAS_DESTETES = "SELECT * FROM [dbo].[FECHAS_DESTETES] f WHERE f.PK_FK_NUMERO_TRAZABLE_VACA = ";
        private const string QUERY_SELECT_DATA_GRID_VIEW_PALPACIONES = "SELECT p.PK_FK_NUMERO_TRAZABLE_VACA AS 'Id', p.PK_FECHA AS 'Fecha', p.CONDICION_CORPORAL AS 'Condición corporal', p.RESULTADO AS 'Resultado', p.CONFIRMACION AS 'Confirmación' FROM [dbo].[PALPACION] p WHERE p.PK_FK_NUMERO_TRAZABLE_VACA = ";
        private const string QUERY_SELECT_DATA_GRID_VIEW_PARTOS = "SELECT p.PK_FK_NUMERO_TRAZABLE_VACA AS 'Id madre', p.FK_NUMERO_TRAZABLE_TORO AS 'Id padre', p.PK_FECHA AS 'Fecha', p.SEXO AS 'Sexo cría', p.MUERTE_PREMATURA AS 'Muerte prematura', p.CAUSA_ABORTO AS 'Causa aborto' FROM [dbo].[PARTO] p WHERE p.PK_FK_NUMERO_TRAZABLE_VACA = ";
        private const string QUERY_SELECT_FECHA_ULTIMO_CELO_VACA = "SELECT MAX(c.PK_FECHA) FROM [dbo].[FECHAS_CELOS] c WHERE c.PK_FK_NUMERO_TRAZABLE_VACA = @idVaca";
        private const string VACA_PARAM = "@idVaca";

        //Campos
        private VacaModel informacionVacaSeleccionada;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="informacionVacaSeleccionada">VacaModel con la información de la vaca a mostrar</param>
        public FormDetallesVaca(VacaModel informacionVacaSeleccionada = null)
        {
            InitializeComponent();
            this.informacionVacaSeleccionada = informacionVacaSeleccionada;
        }

        /// <summary>
        /// Método que se llama cada vez que se carga el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormDetallesVaca_Load(object sender, EventArgs e)
        {
            LlenarComboBoxList();
            LlenarInformcionVaca();
            LlenarDataGridViews();
        }

        /// <summary>
        /// Llena todos los DataGridViews del form.
        /// </summary>
        public void LlenarDataGridViews()
        {
            Utilities.LlenarDataGridView(QUERY_SELECT_DATA_GRID_VIEW_PALPACIONES + informacionVacaSeleccionada.pkNumeroTrazable + ";", dataGridViewPalpacionesVaca);
            Utilities.LlenarDataGridView(QUERY_SELECT_DATA_GRID_VIEW_PARTOS + informacionVacaSeleccionada.pkNumeroTrazable + ";", dataGridViewPartosVacas);
        }

        /// <summary>
        /// Llena todos los ComboBoxList del form.
        /// </summary>
        private void LlenarComboBoxList()
        {
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_FECHAS_SALTOS + informacionVacaSeleccionada.pkNumeroTrazable + " ORDER BY f.PK_FECHA DESC;", comboBoxFechasSaltos);
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_FECHAS_DESTETES + informacionVacaSeleccionada.pkNumeroTrazable + " ORDER BY f.PK_FECHA DESC;", comboBoxFechasDestetes);
        }

        /// <summary>
        /// Asigna a los componentes del form la información de la vaca seleccionada.  
        /// </summary>
        private void LlenarInformcionVaca()
        {
            textBoxNumeroTrazableVaca.Text = this.informacionVacaSeleccionada.pkNumeroTrazable.ToString();
            textBoxNombre.Text = this.informacionVacaSeleccionada.nombre;
            textBoxCaracteristicas.Text = this.informacionVacaSeleccionada.caracteriscas;
            textBoxFechaNacimiento.Text = this.informacionVacaSeleccionada.fecha.ToString();
            textBoxModoPrennes.Text = this.informacionVacaSeleccionada.modoPrennes;
            textBoxIdMadre.Text = this.informacionVacaSeleccionada.fkNumeroTrazableMadre.ToString();
            textBoxIdPadre.Text = this.informacionVacaSeleccionada.fkNumeroTrazablePadre.ToString();
            textBoxRaza.Text = this.informacionVacaSeleccionada.razaStr;
            int edad = -1;
            if (this.informacionVacaSeleccionada.fecha != null)
            {
                edad = DateTime.Today.Year - ((DateTime)this.informacionVacaSeleccionada.fecha).Year;
                if (((DateTime)this.informacionVacaSeleccionada.fecha).Date > DateTime.Today.AddYears(-edad)) edad--;
            }
            textBoxEdad.Text = edad.ToString();
            textBoxPeso.Text = this.informacionVacaSeleccionada.peso.ToString();
            textBoxDesarrollo.Text = this.informacionVacaSeleccionada.desarrollo;
            if (this.informacionVacaSeleccionada.activa)
            {
                checkBoxActiva.Checked = true;
                textBoxCausaDeBaja.Visible = false;
                labelCausaDeBaja.Visible = false;
            }
            else
            {
                checkBoxActiva.Checked = false;
                textBoxCausaDeBaja.Visible = true;
                textBoxCausaDeBaja.Text = this.informacionVacaSeleccionada.causaDeBaja;
            }
            // Se calculan los parametros reproductivos de la vaca.
            try
            {
                double resultado = ProcedimientosAlmacenados.ProcObtenerUltimoIEP(this.informacionVacaSeleccionada.pkNumeroTrazable);
                if ((int)resultado == Utilities.RESULTADO_ERROR) textBoxUltimoIEP.Text = "Error";
                else textBoxUltimoIEP.Text = resultado.ToString();
            }
            catch
            {
                textBoxUltimoIEP.Text = "Error";
            }
            try
            {
                double resultado = ProcedimientosAlmacenados.ProcObtenerIEP(this.informacionVacaSeleccionada.pkNumeroTrazable);
                if ((int)resultado == Utilities.RESULTADO_ERROR) textBoxIEPPromedio.Text = "Error";
                else textBoxIEPPromedio.Text = resultado.ToString();
            }
            catch
            {
                textBoxIEPPromedio.Text = "Error";
            }
            // Se calcula una fecha de parto tentativa.
            Object resultadoQuery = Utilities.ObtenerAtributoTabla(QUERY_SELECT_FECHA_ULTIMO_CELO_VACA, VACA_PARAM, this.informacionVacaSeleccionada.pkNumeroTrazable);
            if (resultadoQuery != null)
            {
                if (resultadoQuery.GetType().ToString() == "System.Int32") textBoxFechaTentativaParto.Text = "Error";
                else
                {
                    try
                    {
                        DateTime fechaUltimoCeloVaca = (DateTime)resultadoQuery;
                        DateTime fechaActual = DateTime.Now;
                        int diferenciaMesesFechas = (fechaActual.Year - fechaUltimoCeloVaca.Year) * 12 + fechaActual.Month - fechaUltimoCeloVaca.Month;
                        if (diferenciaMesesFechas < Utilities.TIEMPO_GESTACION_VACA_MESES)
                        {
                            DateTime fechaTentativaParto = fechaUltimoCeloVaca.AddMonths(Utilities.TIEMPO_GESTACION_VACA_MESES);
                            textBoxFechaTentativaParto.Text = fechaTentativaParto.ToShortDateString();
                        }
                        else textBoxFechaTentativaParto.Text = "";
                    }
                    catch
                    {
                        textBoxFechaTentativaParto.Text = "";
                    }
                }
            }
            else textBoxFechaTentativaParto.Text = "";
        }
    }
}
