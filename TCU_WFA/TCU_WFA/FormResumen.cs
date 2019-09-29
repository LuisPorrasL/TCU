//Hecho por Ariel Arias
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using System.Diagnostics;
using TCU_WFA.Repository;

namespace TCU_WFA
{
    public partial class FormResumen : DefaultForm
    {
        //Constantes
        private const string MENSAJE_ERROR = "Error";
        private const string TITULO_MENSAJE = "Documento generado";
        private const string MENSAJE_CORRECTO = "El documento se guardó en: ";
        private const string MENSAJE_INCORRECTO = "Ocurrió un error al guardar el documento";
        private const string TITULO_HOJA_EXCEL = "Resumen";
        

        //Consultas
        private const string CONSULTA_HEMBRAS_CONSIDERADAS = "SELECT COUNT(*) FROM [dbo].[VACA]";
        private const string CONSULTA_HEMBRAS_PARIDO = "SELECT COUNT (DISTINCT V.PK_NUMERO_TRAZABLE) FROM [dbo].[VACA] V INNER JOIN [dbo].[PARTO] P ON V.PK_NUMERO_TRAZABLE = P.PK_FK_NUMERO_TRAZABLE_VACA";

        //Valores del resumen
        private string fechaActual;
        private string hembrasConsideradas;
        private string hembrasParido;
        private string iepPromHistoricoMeses;
        private string porcParicionHistorico;
        private string ultimoIEPVacaMeses;
        private string ultimoPorcParicion;
        private string promPartosHato;
        

        public FormResumen()
        {
            InitializeComponent();
        }

        private void FormResumen_Load(object sender, EventArgs e)
        {
            CargarDatosResumen();
        }

        /// <summary>
        /// Método para obtener de la BD todos los datos a utilzar en el resumen y actualizar los valores del form
        /// </summary>
        private void CargarDatosResumen()
        {
            //Se obtienen los datos a cargar
            fechaActual = DateTime.Now.ToShortDateString();
            try
            {
                int resultadoHembrasConsideradas = Utilities.EjecutarConsultaCount(CONSULTA_HEMBRAS_CONSIDERADAS);
                hembrasConsideradas = resultadoHembrasConsideradas == Utilities.RESULTADO_ERROR ? MENSAJE_ERROR : resultadoHembrasConsideradas.ToString();
            }
            catch
            {
                hembrasConsideradas = MENSAJE_ERROR;
            }
            try
            {
                int resultadoHembrasParido = Utilities.EjecutarConsultaCount(CONSULTA_HEMBRAS_PARIDO);
                hembrasParido = resultadoHembrasParido == Utilities.RESULTADO_ERROR ? MENSAJE_ERROR : resultadoHembrasParido.ToString();
            }
            catch
            {
                hembrasParido = MENSAJE_ERROR;
            }
            try
            {
                double resultadoIEPHistorico = ProcedimientosAlmacenados.ProcObtenerIEPHistorico();
                iepPromHistoricoMeses = resultadoIEPHistorico == (double)Utilities.RESULTADO_ERROR ? MENSAJE_ERROR : resultadoIEPHistorico.ToString();
            }
            catch
            {
                iepPromHistoricoMeses = MENSAJE_ERROR;
            }
            //Se actualizan los datos del form
            textBoxHembrasConsideradasValue.Text = hembrasConsideradas;
            textBoxHembrasParidoValue.Text = hembrasParido;
            textBoxPromHistoricoMesesValue.Text = iepPromHistoricoMeses;
            textBoxPorcParicionHistoricoValue.Text = porcParicionHistorico;
            textBoxUltimoIEPVacaMesesValue.Text = ultimoIEPVacaMeses;
            textBoxUltimoPorcParicionValue.Text = ultimoPorcParicion;
            textBoxPromPartosHatoValue.Text = promPartosHato;
        }

        /// <summary>
        /// Método utilizado para generar el excel al presionar el botón
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonGenerarInformeExcel_Click(object sender, EventArgs e)
        {
            //Se genera el excel con toda la información correspondiente del resumen
            GenerarExcelResumen();
        }

        /// <summary>
        /// Método para generar el documento de Excel con el resumen y los datos correspondientes.
        /// </summary>
        private void GenerarExcelResumen()
        {
            //Se obtienen los datos a utilizar en el resumen

                //Se genera el documento excel
                CrearDocumentoResumenExcel();
        }

        private void CrearDocumentoResumenExcel()
        {
            //Se crea una instancia del paquete de excel del documento a utilizar
            ExcelPackage documentoExcel = new ExcelPackage();

            //Se crea la hoja que se va a generar
            ExcelWorksheet hojaResumen = documentoExcel.Workbook.Worksheets.Add(TITULO_HOJA_EXCEL);

            //Se establece el primer rango de celdas a utilizar para la información general
            ExcelRange celdasInformacionGeneral = hojaResumen.Cells[1, 1, 8, 3];

            //Se completan las celdas con sus valores respectivos
            celdasInformacionGeneral[1, 1].Value = "Fecha referencia";
            celdasInformacionGeneral[1, 3].Value = fechaActual;

            //Se guarda el documento
            string ubicacionDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nombreDocumentoResumen = ubicacionDocumentos + @"\" + "Resumen_" + DateTime.Now.ToString().Replace("/",".").Replace(":", ".").Replace(" ","_").Replace("\\", ".") + ".xlsx";
            try
            {
                documentoExcel.SaveAs(new FileInfo(nombreDocumentoResumen));

                //Se muestra el mensaje que indica al usuario en donde quedó el documento
                Utilities.MostrarMessageBox(MENSAJE_CORRECTO + nombreDocumentoResumen, TITULO_MENSAJE, MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch
            {
                //Se muestra el mensaje que indica al usuario en donde quedó el documento
                Utilities.MostrarMessageBox(MENSAJE_INCORRECTO, MENSAJE_ERROR, MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            //Se cierra el documento
            documentoExcel.Dispose();
        }
    }
}
