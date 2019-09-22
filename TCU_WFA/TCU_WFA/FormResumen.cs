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

namespace TCU_WFA
{
    public partial class FormResumen : DefaultForm
    {

        public FormResumen()
        {
            InitializeComponent();
        }

        private void FormResumen_Load(object sender, EventArgs e)
        {

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
            //ToDo

            //Se genera el documento excel
            CrearDocumentoExcel();
        }

        private void CrearDocumentoExcel()
        {
            //Se crea una instancia del paquete de excel del documento a utilizar
            ExcelPackage documentoExcel = new ExcelPackage();

            //Se crea la hoja que se va a generar
            ExcelWorksheet hojaResumen = documentoExcel.Workbook.Worksheets.Add("Resumen");

            //Se establece el primer rango de celdas a utilizar para la información general
            ExcelRange celdasInformacionGeneral = hojaResumen.Cells[1, 1, 8, 3];

            //Se completan las celdas con sus valores respectivos
            celdasInformacionGeneral[1, 1].Value = "Fecha referencia";
            celdasInformacionGeneral[1, 3].Value = DateTime.Now.ToString();

            //Se guarda el documento
            string ubicacionDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nombreDocumentoResumen = ubicacionDocumentos + @"\" + "Resumen_" + DateTime.Now.ToString().Replace("/",".").Replace(":", ".").Replace(" ","_").Replace("\\", ".") + ".xlsx";

            try
            {
                documentoExcel.SaveAs(new FileInfo(nombreDocumentoResumen));

                //Se muestra el mensaje que indica al usuario en donde quedó el documento
                MessageBox.Show("El documento se guardó con exito en: " + nombreDocumentoResumen);
            }
            catch
            {
                //Se muestra el mensaje que indica al usuario en donde quedó el documento
                MessageBox.Show("Ocurrió un error al guardar el documento","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

            


            //Se cierra el documento
            documentoExcel.Dispose();
        }
    }
}
