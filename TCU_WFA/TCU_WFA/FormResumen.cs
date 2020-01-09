//Hecho por Ariel Arias
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TCU_WFA.Models;
using TCU_WFA.Repository;

namespace TCU_WFA
{
    public partial class FormResumen : DefaultForm
    {
        //Constantes
        private const string MENSAJE_ERROR = "Error";
        private const int INDICE_DTR_NUMERO_TRAZABLE = 0;
        private const int INDICE_DTR_NOMBRE = 1;
        private const int INDICE_DTR_EDAD_PRIMER_PARTO = 2;
        private const int INDICE_DTR_PARTOS = 3;
        private const int INDICE_DTR_EDAD_ULTIMA_CRIA = 4;
        private const int INDICE_DTR_FECHA_DESTETE_ULTIMA_CRIA = 5;
        private const int INDICE_DTR_IEP_PROMEDIO = 6;
        private const int INDICE_DTR_ULTIMO_IEP = 7;
        private const int INDICE_DTR_FECHA_ULTIMA_MONTA = 8;
        private const int INDICE_DTR_GESTACION_DIAS = 9;
        private const int INDICE_DTR_FECHA_PARTO = 10;

        //Consultas
        private const string CONSULTA_HEMBRAS_CONSIDERADAS = "SELECT COUNT(*) FROM [dbo].[VACA]";       
        private const string CONSULTA_HEMBRAS_PARIDO = "SELECT COUNT (DISTINCT V.PK_NUMERO_TRAZABLE) FROM [dbo].[VACA] V INNER JOIN [dbo].[PARTO] P ON V.PK_NUMERO_TRAZABLE = P.PK_FK_NUMERO_TRAZABLE_VACA";
        private const string CONSULTA_PARTOS = "SELECT COUNT (*) FROM [dbo].[PARTO]";

        //Valores del resumen
        DatosGeneralesResumen datosResumen = new DatosGeneralesResumen();

        //Lista de vacas
        List<VacaModel> listaVacas;
        

        public FormResumen()
        {
            InitializeComponent();
        }

        private void FormResumen_Load(object sender, EventArgs e)
        {
            CargarDatosResumen();
            ActualizarDatosForm();
        }

        /// <summary>
        /// Método para obtener de la BD todos los datos a utilzar en el resumen y actualizar los valores del form
        /// </summary>
        private void CargarDatosResumen()
        {
            //Se obtiene la configuración actual de la aplicación
            ProgramConfiguration config = new ProgramConfiguration();
            string unidadDeTiempo = config.ObtenerConfig(ProgramConfiguration.LLAVE_UNIDAD_DE_TIEMPO);

            //Se obtienen los datos a cargar
            datosResumen.fechaActual = DateTime.Now.ToShortDateString();
            try
            {
                datosResumen.hembrasConsideradas = Utilities.EjecutarConsultaCount(CONSULTA_HEMBRAS_CONSIDERADAS);
            }
            catch
            {
                datosResumen.hembrasConsideradas = Utilities.RESULTADO_ERROR;
            }
            try
            {
                datosResumen.hembrasParido = Utilities.EjecutarConsultaCount(CONSULTA_HEMBRAS_PARIDO);                
            }
            catch
            {
                datosResumen.hembrasParido = Utilities.RESULTADO_ERROR;
            }
            try
            {
                double  IEPHistorico = ProcedimientosAlmacenados.ProcObtenerIEPHistorico();
                switch (unidadDeTiempo)
                {
                    case "Meses":
                        labelIEPPromHistoricoMeses.Text = "IEP Prom.Histórico (meses)";
                        datosResumen.iepPromHistoricoMeses = IEPHistorico / 30;
                        break;
                    case "Semanas":
                        labelIEPPromHistoricoMeses.Text = "IEP Prom.Histórico (semanas)";
                        datosResumen.iepPromHistoricoMeses = IEPHistorico / 7;
                        break;
                    default:
                        labelIEPPromHistoricoMeses.Text = "IEP Prom.Histórico (días)";
                        datosResumen.iepPromHistoricoMeses = IEPHistorico;
                        break;
                }
            }
            catch
            {
                datosResumen.iepPromHistoricoMeses = Utilities.RESULTADO_ERROR;
            }
            try
            {
                int resultadoPartos = Utilities.EjecutarConsultaCount(CONSULTA_PARTOS);
                if (resultadoPartos != Utilities.RESULTADO_ERROR && datosResumen.hembrasConsideradas != Utilities.RESULTADO_ERROR && datosResumen.hembrasConsideradas != 0)
                {
                    datosResumen.promPartosHato = (double)resultadoPartos / (double)datosResumen.hembrasConsideradas;
                }
                else
                {
                    datosResumen.promPartosHato = Utilities.RESULTADO_ERROR;
                }
            }
            catch
            {
                datosResumen.promPartosHato = Utilities.RESULTADO_ERROR;
            }
            try
            { 
                double ultimoIEPHistorico = ProcedimientosAlmacenados.ProcObtenerUltimoIEPHistorico();
                switch (unidadDeTiempo)
                {
                    case "Meses":
                        labelUltimoIEPVacaMeses.Text = "Último IEP cada vaca (meses)";
                        datosResumen.ultimoIEPVacaMeses = ultimoIEPHistorico / 30;
                        break;
                    case "Semanas":
                        labelUltimoIEPVacaMeses.Text = "Último IEP cada vaca (semanas)";
                        datosResumen.ultimoIEPVacaMeses = ultimoIEPHistorico / 7;
                        break;
                    default:
                        labelUltimoIEPVacaMeses.Text = "Último IEP cada vaca (días)";
                        datosResumen.ultimoIEPVacaMeses = ultimoIEPHistorico;
                        break;
                }
            }
            catch
            {
                datosResumen.ultimoIEPVacaMeses = Utilities.RESULTADO_ERROR;
            }
            if(datosResumen.hembrasParido != Utilities.RESULTADO_ERROR && datosResumen.hembrasConsideradas != Utilities.RESULTADO_ERROR && datosResumen.hembrasConsideradas != 0)
            {
                datosResumen.porcParicionHistorico = ((double)datosResumen.hembrasParido / (double)datosResumen.hembrasConsideradas) * 100;
            }
            //ToDo obtener el último % de parición
        }

        /// <summary>
        /// Metodo para actualizar los datos del form
        /// </summary>
        private void ActualizarDatosForm()
        {
            //Se actualizan los datos del form
            textBoxHembrasConsideradasValue.Text = datosResumen.hembrasConsideradas != Utilities.RESULTADO_ERROR ? datosResumen.hembrasConsideradas.ToString() : MENSAJE_ERROR;
            textBoxHembrasParidoValue.Text = datosResumen.hembrasParido != Utilities.RESULTADO_ERROR ? datosResumen.hembrasParido.ToString() : MENSAJE_ERROR;
            textBoxPromHistoricoMesesValue.Text = datosResumen.iepPromHistoricoMeses != (double)Utilities.RESULTADO_ERROR ? datosResumen.iepPromHistoricoMeses.ToString("0.##") : MENSAJE_ERROR;
            textBoxPorcParicionHistoricoValue.Text = datosResumen.porcParicionHistorico != (double)Utilities.RESULTADO_ERROR ? datosResumen.porcParicionHistorico.ToString() : MENSAJE_ERROR;
            textBoxUltimoIEPVacaMesesValue.Text = datosResumen.ultimoIEPVacaMeses != (double)Utilities.RESULTADO_ERROR ? datosResumen.ultimoIEPVacaMeses.ToString("0.##") : MENSAJE_ERROR;
            textBoxUltimoPorcParicionValue.Text = datosResumen.ultimoPorcParicion != (double)Utilities.RESULTADO_ERROR ? datosResumen.ultimoPorcParicion.ToString() : MENSAJE_ERROR;
            textBoxPromPartosHatoValue.Text = datosResumen.promPartosHato != (double)Utilities.RESULTADO_ERROR ? datosResumen.promPartosHato.ToString() : MENSAJE_ERROR;
        }

        /// <summary>
        /// Método utilizado para generar el excel al presionar el botón
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonGenerarInformeExcel_Click(object sender, EventArgs e)
        {
            //Se obtienen los datos a utilizar en el resumen
            CargarDatosResumen();
            CargarDatosVacas();
            CargarDatosVacasGrafico();

            //Se genera el documento excel
            ExcelGenerator.CrearDocumentoResumenExcel(datosResumen, listaVacas, promedioIEPHato, listaDatosVacas);
           // ExcelGenerator.CrearDocumentoGraficosExcel(promedioIEPHato, listaDatosVacas);
        }

        /// <summary>
        /// Metodo para obtener todos los datos de las vacas registradas para el documento excel
        /// </summary>
        private void CargarDatosVacas()
        {
            if (datosResumen.hembrasConsideradas > 0)
            {
                //Se obtienen los datos de las vacas y se guardan en la lista 
                listaVacas = new List<VacaModel>();
                DataTable dt = new DataTable();
                dt = ProcedimientosAlmacenados.ProcObtenerResumenVacas();
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int iteradorVacas = 0; iteradorVacas < dt.Rows.Count; ++iteradorVacas)
                    {
                        listaVacas.Add(new VacaModel());
                        listaVacas[iteradorVacas].pkNumeroTrazable = (int)dt.Rows[iteradorVacas][INDICE_DTR_NUMERO_TRAZABLE];
                        listaVacas[iteradorVacas].nombre = dt.Rows[iteradorVacas][INDICE_DTR_NOMBRE] != DBNull.Value ? dt.Rows[iteradorVacas][INDICE_DTR_NOMBRE].ToString() : null;
                        if (dt.Rows[iteradorVacas][INDICE_DTR_EDAD_PRIMER_PARTO] != DBNull.Value)
                        {
                            listaVacas[iteradorVacas].edadAPrimerPartoMeses = (int)dt.Rows[iteradorVacas][INDICE_DTR_EDAD_PRIMER_PARTO];
                        }
                        if (dt.Rows[iteradorVacas][INDICE_DTR_PARTOS] != DBNull.Value)
                        {
                            listaVacas[iteradorVacas].numeroDePartos = (int)dt.Rows[iteradorVacas][INDICE_DTR_PARTOS];
                        }
                        if (dt.Rows[iteradorVacas][INDICE_DTR_EDAD_ULTIMA_CRIA] != DBNull.Value)
                        {
                            listaVacas[iteradorVacas].edadUltimaCria = (int)dt.Rows[iteradorVacas][INDICE_DTR_EDAD_ULTIMA_CRIA];
                        }
                        if (dt.Rows[iteradorVacas][INDICE_DTR_FECHA_DESTETE_ULTIMA_CRIA] != DBNull.Value)
                        {
                            listaVacas[iteradorVacas].fechaDesteteUltimaCria = ((DateTime)dt.Rows[iteradorVacas][INDICE_DTR_FECHA_DESTETE_ULTIMA_CRIA]).ToShortDateString();
                        }
                        if (dt.Rows[iteradorVacas][INDICE_DTR_IEP_PROMEDIO] != DBNull.Value)
                        {
                            listaVacas[iteradorVacas].iepPromedioMeses = Convert.ToDouble(dt.Rows[iteradorVacas][INDICE_DTR_IEP_PROMEDIO]);
                        }
                        if (dt.Rows[iteradorVacas][INDICE_DTR_ULTIMO_IEP] != DBNull.Value)
                        {
                            listaVacas[iteradorVacas].ultimoIEPMeses = Convert.ToDouble(dt.Rows[iteradorVacas][INDICE_DTR_ULTIMO_IEP]);
                        }
                        if (dt.Rows[iteradorVacas][INDICE_DTR_FECHA_ULTIMA_MONTA] != DBNull.Value)
                        {
                            listaVacas[iteradorVacas].fechaUltimaMonta = ((DateTime)dt.Rows[iteradorVacas][INDICE_DTR_FECHA_ULTIMA_MONTA]).ToShortDateString();
                        }
                        if (dt.Rows[iteradorVacas][INDICE_DTR_GESTACION_DIAS] != DBNull.Value)
                        {
                            listaVacas[iteradorVacas].gestacionDias = (int)dt.Rows[iteradorVacas][INDICE_DTR_GESTACION_DIAS];
                        }
                        if (dt.Rows[iteradorVacas][INDICE_DTR_FECHA_PARTO] != DBNull.Value)
                        {
                            listaVacas[iteradorVacas].fechaParto = ((DateTime)dt.Rows[iteradorVacas][INDICE_DTR_FECHA_PARTO]).ToShortDateString();
                        }
                    }
                }
            }
        }


        //--------------------------------------------------------

        //Consulta cantidad vacas
        private const string CONSULTA_VACAS_CONSIDERADAS = "SELECT COUNT(*) FROM [dbo].[VACA]";
        //Indices dataReader
        private const int INDICE_DTR_NUMERO_TRAZABLE_GRAFICO = 0;
        private const int INDICE_DTR_CANTIDAD_PARTOS = 1;
        private const int INDICE_DTR_IEP_VACA = 2;
        private const int INDICE_DTR_ULTIMO_IEP_VACA = 3;

        //IEP Promedio del hato
        private double promedioIEPHato = 0;

        //Cantidad de vacas
        private int cantidadVacas = 0;

        //Lista de datos de las vacas
        List<DatosVacaGraficos> listaDatosVacas = new List<DatosVacaGraficos>();


        /// <summary>
        /// Método para obtener los datos a utilizar en el worksheet gráfico
        /// </summary>
        private void CargarDatosVacasGrafico()
        {
            //Se obtiene la cantidad de vacas
            try
            {
                cantidadVacas = Utilities.EjecutarConsultaCount(CONSULTA_VACAS_CONSIDERADAS);
            }
            catch
            {
                cantidadVacas = Utilities.RESULTADO_ERROR;
            }

            if (cantidadVacas > 0 && cantidadVacas != Utilities.RESULTADO_ERROR)
            {
                //Se obtiene el IEP promedio del hato
                promedioIEPHato = ProcedimientosAlmacenados.ProcObtenerIEPHistorico();

                //Se obtienen todos los demás datos
                DataTable dt = new DataTable();
                dt = ProcedimientosAlmacenados.ProcObtenerDatosGraficosVacas();

                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int iteradorVacas = 0; iteradorVacas < dt.Rows.Count; ++iteradorVacas)
                    {
                        listaDatosVacas.Add(new DatosVacaGraficos());
                        listaDatosVacas[iteradorVacas].pkNumeroTrazableVaca = (int)dt.Rows[iteradorVacas][INDICE_DTR_NUMERO_TRAZABLE_GRAFICO];

                        if (dt.Rows[iteradorVacas][INDICE_DTR_CANTIDAD_PARTOS] != DBNull.Value)
                        {
                            listaDatosVacas[iteradorVacas].partosVaca = (int)dt.Rows[iteradorVacas][INDICE_DTR_CANTIDAD_PARTOS];
                        }

                        if (dt.Rows[iteradorVacas][INDICE_DTR_IEP_VACA] != DBNull.Value)
                        {
                            listaDatosVacas[iteradorVacas].iepPromedioVacaMeses = Convert.ToDouble(dt.Rows[iteradorVacas][INDICE_DTR_IEP_VACA]);
                        }

                        if (dt.Rows[iteradorVacas][INDICE_DTR_ULTIMO_IEP_VACA] != DBNull.Value)
                        {
                            listaDatosVacas[iteradorVacas].ultimoIEPVacaMeses = Convert.ToDouble(dt.Rows[iteradorVacas][INDICE_DTR_ULTIMO_IEP_VACA]);
                        }
                    }
                }
            }
        }
    }
}
