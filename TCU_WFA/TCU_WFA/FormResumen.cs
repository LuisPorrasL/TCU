//Hecho por Ariel Arias
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
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
        private const int LLAVE_TIPO_RESUMEN_GENERAL = 0;
        private const int LLAVE_TIPO_RESUMEN_POR_FECHAS = 1;

        //Consultas generales
        private const string CONSULTA_HEMBRAS_CONSIDERADAS = "SELECT COUNT(*) FROM [dbo].[VACA]";       
        private const string CONSULTA_HEMBRAS_PARIDO = "SELECT COUNT (DISTINCT V.PK_NUMERO_TRAZABLE) FROM [dbo].[VACA] V INNER JOIN [dbo].[PARTO] P ON V.PK_NUMERO_TRAZABLE = P.PK_FK_NUMERO_TRAZABLE_VACA";
        private const string CONSULTA_PARTOS = "SELECT COUNT (*) FROM [dbo].[PARTO]";
        

        //Valores del resumen
        DatosGeneralesResumen datosResumen = new DatosGeneralesResumen();

        //Lista de vacas
        List<VacaModel> listaVacas;

        //Fechas a utilizar por defecto
        //Primer día del año y el día actual
        private DateTime fechaPrimerDiaInicio = new DateTime(DateTime.Now.Year, 1, 1);
        private DateTime fechaDiaActual = DateTime.Now;


        public FormResumen()
        {
            InitializeComponent();
        }

        private void FormResumen_Load(object sender, EventArgs e)
        {
            LlenarOpcionesComboBoxTipoResumen();
            dateTimePickerInicio.Value = fechaPrimerDiaInicio;
            dateTimePickerFinal.Value = fechaDiaActual;
            CargarDatosResumen();
            ActualizarDatosForm();
        }

        /// <summary>
        /// Método para llenar las opciones del comboBox para seleccionar el tipo de resumen
        /// </summary>
        private void LlenarOpcionesComboBoxTipoResumen()
        {
            Dictionary<int, string> opcionesComboBox = new Dictionary<int, string>();
            opcionesComboBox.Add(LLAVE_TIPO_RESUMEN_GENERAL, "General");
            opcionesComboBox.Add(LLAVE_TIPO_RESUMEN_POR_FECHAS, "Por fechas");
            comboBoxTipoResumen.DataSource = new BindingSource(opcionesComboBox, null);
            comboBoxTipoResumen.DisplayMember = "Value";
            comboBoxTipoResumen.ValueMember = "Key";
            comboBoxTipoResumen.SelectedIndex = LLAVE_TIPO_RESUMEN_GENERAL;
            datosResumen.tipoResumen = LLAVE_TIPO_RESUMEN_GENERAL;
        }

        /// <summary>
        /// Método para obtener de la BD todos los datos a utilzar en el resumen y actualizar los valores del form
        /// </summary>
        private void CargarDatosResumen()
        {
            //Se obtienen los datos a cargar
            datosResumen.fechaActual = DateTime.Now.ToShortDateString();

            //Si el resumen es por fechas se obtienen las fechas seleccionadas
            if (datosResumen.tipoResumen == LLAVE_TIPO_RESUMEN_POR_FECHAS)
            {
                datosResumen.fechaInicioResumen = dateTimePickerInicio.Value;
                datosResumen.fechaFinalResumen = dateTimePickerFinal.Value;
            }

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
                datosResumen.iepPromHistoricoMeses = ProcedimientosAlmacenados.ProcObtenerIEPHistorico();                
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
                datosResumen.ultimoIEPVacaMeses = ProcedimientosAlmacenados.ProcObtenerUltimoIEPHistorico();
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
            textBoxPromHistoricoMesesValue.Text = datosResumen.iepPromHistoricoMeses != (double)Utilities.RESULTADO_ERROR ? datosResumen.iepPromHistoricoMeses.ToString() : MENSAJE_ERROR;
            textBoxPorcParicionHistoricoValue.Text = datosResumen.porcParicionHistorico != (double)Utilities.RESULTADO_ERROR ? datosResumen.porcParicionHistorico.ToString() : MENSAJE_ERROR;
            textBoxUltimoIEPVacaMesesValue.Text = datosResumen.ultimoIEPVacaMeses != (double)Utilities.RESULTADO_ERROR ? datosResumen.ultimoIEPVacaMeses.ToString() : MENSAJE_ERROR;
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

        /// <summary>
        /// Método que actualiza los datos a mostrar cuando se actualiza la fecha inicial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {
            CargarDatosResumen();
            ActualizarDatosForm();
        }

        /// <summary>
        /// Método que actualiza los datos a mostrar cuando se actualiza la fecha final
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePickerFinal_ValueChanged(object sender, EventArgs e)
        {
            CargarDatosResumen();
            ActualizarDatosForm();
        }

        /// <summary>
        /// Método que actualiza los datos del resumen al cambiar el tipo seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxTipoResumen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(((KeyValuePair<int, string>)comboBoxTipoResumen.SelectedItem).Key == LLAVE_TIPO_RESUMEN_POR_FECHAS)
            {
                datosResumen.tipoResumen = LLAVE_TIPO_RESUMEN_POR_FECHAS;
                labelFechaInicio.Visible = true;
                dateTimePickerInicio.Visible = true;
                labelFechaFinal.Visible = true;
                dateTimePickerFinal.Visible = true;
            }
            else
            {
                datosResumen.tipoResumen = LLAVE_TIPO_RESUMEN_GENERAL;
                labelFechaInicio.Visible = false;
                dateTimePickerInicio.Visible = false;
                labelFechaFinal.Visible = false;
                dateTimePickerFinal.Visible = false;
            }

            CargarDatosResumen();
            ActualizarDatosForm();
        }
    }
}
