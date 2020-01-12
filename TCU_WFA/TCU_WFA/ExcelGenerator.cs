//Hecho por Ariel Arias y Alberto Soto
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TCU_WFA.Models;

namespace TCU_WFA
{
    /// <summary>
    /// Clase encargada de la generación de los documentos excel
    /// </summary>
    public static class ExcelGenerator
    {
        //Constantes Resumen
        private const string TITULO_RESUMEN = "Resumen";

        //Mensajes de creación del documento
        private const string TITULO_MENSAJE = "Documento generado";
        private const string MENSAJE_CORRECTO = "El documento se guardó en: ";
        private const string MENSAJE_INCORRECTO = "Ocurrió un error al guardar el documento";
        /// <summary>
        /// Método para generar el documento excel del resumen
        /// </summary>
        /// <param name="datosResumen">Los datos a utilizar para el resumen general</param>
        public static void CrearDocumentoResumenExcel(DatosGeneralesResumen datosResumen, List<VacaModel> listaVacas, double promedioIEPHato, List<DatosVacaGraficos> listaDatosVacas)
        {
            //Se crea una instancia del paquete de excel del documento a utilizar
            ExcelPackage documentoExcel = new ExcelPackage();

            //Se crea la hoja que se va a generar
            ExcelWorksheet hojaResumen = documentoExcel.Workbook.Worksheets.Add(TITULO_RESUMEN);

            //Se establece el primer rango de celdas a utilizar para la información general, con sus colores
            ExcelRange celdasInformacionGeneral = hojaResumen.Cells[1,1,8,4];
            celdasInformacionGeneral.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
            celdasInformacionGeneral.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(204, 255, 204));
            celdasInformacionGeneral[1, 4, 8, 4].Style.Font.Color.SetColor(Color.Red);

            //Se completan las celdas con sus valores respectivos

            //Se obtiene la configuración actual de la aplicación
            ProgramConfiguration config = new ProgramConfiguration();
            string unidadDeTiempo = config.ObtenerConfig(ProgramConfiguration.LLAVE_UNIDAD_DE_TIEMPO);

            switch (unidadDeTiempo)
            {
                case "Meses":
                    celdasInformacionGeneral[6, 1].Value = "Último IEP cada vaca (meses)";
                    celdasInformacionGeneral[4, 1].Value = "IEP Prom. Histórico (meses)";
                    break;
                case "Semanas":
                    celdasInformacionGeneral[6, 1].Value = "Último IEP cada vaca (semanas)";
                    celdasInformacionGeneral[4, 1].Value = "IEP Prom. Histórico (semanas)";
                    break;
                default:
                    celdasInformacionGeneral[6, 1].Value = "Último IEP cada vaca (días)";
                    celdasInformacionGeneral[4, 1].Value = "IEP Prom. Histórico (días)";
                    break;
            }

            celdasInformacionGeneral[1, 1].Value = "Fecha referencia";
            celdasInformacionGeneral[1, 4].Value = datosResumen.fechaActual;
            celdasInformacionGeneral[2, 1].Value = "Número hembras consideradas";
            celdasInformacionGeneral[2, 4].Value = datosResumen.hembrasConsideradas;
            celdasInformacionGeneral[3, 1].Value = "Hembras que han parido";
            celdasInformacionGeneral[3, 4].Value = datosResumen.hembrasParido;
            celdasInformacionGeneral[4, 4].Value = datosResumen.iepPromHistoricoMeses;
            celdasInformacionGeneral[5, 1].Value = "% parición histórico";
            celdasInformacionGeneral[5, 4].Value = datosResumen.porcParicionHistorico;
            celdasInformacionGeneral[6, 4].Value = datosResumen.ultimoIEPVacaMeses;
            celdasInformacionGeneral[7, 1].Value = "Último % parición ";
            celdasInformacionGeneral[7, 4].Value = datosResumen.ultimoPorcParicion;
            celdasInformacionGeneral[8, 1].Value = "Promedio partos hato";
            celdasInformacionGeneral[8, 4].Value = datosResumen.promPartosHato;

            //Generación de la lista de las vacas con su respectiva información

            //Se establece el segundo rango de celdas a utilizar para la lista de vacas
            ExcelRange celdasListaVacas = hojaResumen.Cells[9, 1, 9 + listaVacas.Count, 12];

            //Estilos
            celdasListaVacas.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
            celdasListaVacas[9, 1, 9, 12].Style.WrapText = true;
            celdasListaVacas.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
            celdasListaVacas.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
            celdasListaVacas[9, 1, 9, 12].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(182, 221, 232));
            celdasListaVacas[9, 1, 9, 12].Style.Font.Bold = true;
            celdasListaVacas[9, 1, 9, 12].Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
            celdasListaVacas[9, 1, 9, 12].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
            celdasListaVacas[9, 1, 9, 12].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
            celdasListaVacas[9, 1, 9, 12].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

            //Titulos
            switch (unidadDeTiempo)
            {
                case "Meses":
                    celdasListaVacas[9, 8].Value = "IEP promedio /cada/vaca (meses)";
                    celdasListaVacas[9, 9].Value = "Último IEP cada vaca (meses)";
                    break;
                case "Semanas":
                    celdasListaVacas[9, 8].Value = "IEP promedio /cada/vaca (semanas)";
                    celdasListaVacas[9, 9].Value = "Último IEP cada vaca (semanas)";
                    break;
                default:
                    celdasListaVacas[9, 8].Value = "IEP promedio /cada/vaca (días)";
                    celdasListaVacas[9, 9].Value = "Último IEP cada vaca (días)";
                    break;
            }

            celdasListaVacas[9, 1].Value = "Número de orden";
            celdasListaVacas[9, 2].Value = "Número de la vaca";
            celdasListaVacas[9, 3].Value = "Número trazable de la vaca";
            celdasListaVacas[9, 4].Value = "Edad a 1er parto, meses";
            celdasListaVacas[9, 5].Value = "Nº partos";
            celdasListaVacas[9, 6].Value = "Edad de la última cría, meses";
            celdasListaVacas[9, 7].Value = "Fecha destete a 7 meses, última cría";
            celdasListaVacas[9, 10].Value = "Fecha de última monta o IA";
            celdasListaVacas[9, 11].Value = "Gestación días";
            celdasListaVacas[9, 12].Value = "Fecha parto";

            //Se agregan las filas con la información de las vacas
            if (listaVacas.Count > 0)
            {
                celdasListaVacas[10, 1, 9 + listaVacas.Count, 12].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(216, 216, 216));
                celdasListaVacas[10, 1, 9 + listaVacas.Count, 12].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                celdasListaVacas[10, 1, 9 + listaVacas.Count, 12].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                for (int iterador = 0; iterador < listaVacas.Count; iterador++)
                {
                    celdasListaVacas[10 + iterador, 1].Value = iterador + 1;
                    celdasListaVacas[10 + iterador, 2].Value = listaVacas[iterador].nombre;
                    celdasListaVacas[10 + iterador, 3].Value = listaVacas[iterador].pkNumeroTrazable;
                    celdasListaVacas[10 + iterador, 4].Value = listaVacas[iterador].edadAPrimerPartoMeses;
                    celdasListaVacas[10 + iterador, 5].Value = listaVacas[iterador].numeroDePartos;
                    celdasListaVacas[10 + iterador, 6].Value = listaVacas[iterador].edadUltimaCria;
                    celdasListaVacas[10 + iterador, 7].Value = listaVacas[iterador].fechaDesteteUltimaCria;
                    switch (unidadDeTiempo)
                    {
                        case "Meses":
                            celdasListaVacas[10 + iterador, 8].Value = Math.Round(listaVacas[iterador].iepPromedioDias / Utilities.DIAS_MES, 2);
                            celdasListaVacas[10 + iterador, 9].Value = Math.Round(listaVacas[iterador].ultimoIEPDias / Utilities.DIAS_MES, 2);
                            break;
                        case "Semanas":
                            celdasListaVacas[10 + iterador, 8].Value = Math.Round(listaVacas[iterador].iepPromedioDias / Utilities.DIAS_SEMANA, 2);
                            celdasListaVacas[10 + iterador, 9].Value = Math.Round(listaVacas[iterador].ultimoIEPDias / Utilities.DIAS_SEMANA, 2);
                            break;
                        default:
                            celdasListaVacas[10 + iterador, 8].Value = Math.Round(listaVacas[iterador].iepPromedioDias, 2);
                            celdasListaVacas[10 + iterador, 9].Value = Math.Round(listaVacas[iterador].ultimoIEPDias, 2);
                            break;
                    }
                    celdasListaVacas[10 + iterador, 10].Value = listaVacas[iterador].fechaUltimaMonta;
                    celdasListaVacas[10 + iterador, 11].Value = listaVacas[iterador].gestacionDias;
                    celdasListaVacas[10 + iterador, 12].Value = listaVacas[iterador].fechaParto;
                }
            }

            //-------------------------------Worksheet Gráfico-----------------------------

            //Aqui se crea el worksheet
            ExcelWorksheet grafico = documentoExcel.Workbook.Worksheets.Add("Gráficos");
            
            if (listaDatosVacas.Count > 0)
            {
                ExcelRange celdasListaVacasGraficos = grafico.Cells[1, 1, 1 + listaDatosVacas.Count, 6];

                //Se definen estilos
                celdasListaVacasGraficos.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                celdasListaVacasGraficos.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(255, 255, 255));
                celdasListaVacasGraficos[1, 1, 1, 6].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(211, 211, 211));
                celdasListaVacasGraficos[1, 1, 1, 6].Style.WrapText = true;
                celdasListaVacasGraficos[1, 1, 1, 6].Style.Font.Bold = true;
                celdasListaVacasGraficos[1, 1, 1, 6].Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                celdasListaVacasGraficos[1, 1, 1, 6].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                celdasListaVacasGraficos[1, 1, 1, 6].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                celdasListaVacasGraficos[1, 1, 1, 6].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;


                //Se le da un valor a los encabezados
                celdasListaVacasGraficos[1, 1].Value = "Orden";
                celdasListaVacasGraficos[1, 2].Value = "Núm vaca";
                celdasListaVacasGraficos[1, 4].Value = "Partos/vaca";
                
                switch (unidadDeTiempo)
                {
                    case "Meses":
                        celdasListaVacasGraficos[1, 3].Value = "Prom hato (meses)";
                        celdasListaVacasGraficos[1, 5].Value = "Prom/vaca (meses)";
                        celdasListaVacasGraficos[1, 6].Value = "Últ/vaca (meses)";
                        break;
                    case "Semanas":
                        celdasListaVacasGraficos[1, 3].Value = "Prom hato (semanas)";
                        celdasListaVacasGraficos[1, 5].Value = "Prom/vaca (semanas)";
                        celdasListaVacasGraficos[1, 6].Value = "Últ/vaca (semanas)";
                        break;
                    default:
                        celdasListaVacasGraficos[1, 3].Value = "Prom hato (días)";
                        celdasListaVacasGraficos[1, 5].Value = "Prom/vaca (días)";
                        celdasListaVacasGraficos[1, 6].Value = "Últ/vaca (días)";
                        break;
                }

                //Mas estilos
                celdasListaVacasGraficos.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                celdasListaVacasGraficos[2, 1, 1 + listaDatosVacas.Count, 1].Style.WrapText = true;
                celdasListaVacasGraficos.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                celdasListaVacasGraficos.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                celdasListaVacasGraficos[2, 1, 1 + listaDatosVacas.Count, 1].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(182, 221, 232));
                celdasListaVacasGraficos[2, 1, 1 + listaDatosVacas.Count, 1].Style.Font.Bold = true;
                celdasListaVacasGraficos[2, 1, 1 + listaDatosVacas.Count, 1].Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                celdasListaVacasGraficos[2, 1, 1 + listaDatosVacas.Count, 1].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                celdasListaVacasGraficos[2, 1, 1 + listaDatosVacas.Count, 1].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                celdasListaVacasGraficos[2, 1, 1 + listaDatosVacas.Count, 1].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

                //Se recorre la lista de vacas y se carga el worksheet
                for (int iterador = 0; iterador < listaDatosVacas.Count; iterador++)
                {
                    celdasListaVacasGraficos[2 + iterador, 1].Value = iterador + 1;
                    celdasListaVacasGraficos[2 + iterador, 2].Value = listaDatosVacas[iterador].pkNumeroTrazableVaca.ToString();
                    celdasListaVacasGraficos[2 + iterador, 4].Value = listaDatosVacas[iterador].partosVaca;
                    celdasListaVacasGraficos[2 + iterador, 5].Value = listaDatosVacas[iterador].iepPromedioVacaDias;
                    switch (unidadDeTiempo)
                    {
                        case "Meses":
                            celdasListaVacasGraficos[2 + iterador, 3].Value = Math.Round(promedioIEPHato / Utilities.DIAS_MES, 2);
                            celdasListaVacasGraficos[2 + iterador, 5].Value = Math.Round(listaDatosVacas[iterador].iepPromedioVacaDias / Utilities.DIAS_MES, 2);
                            celdasListaVacasGraficos[2 + iterador, 6].Value = Math.Round(listaDatosVacas[iterador].ultimoIEPVacaDias / Utilities.DIAS_MES, 2);
                            break;
                        case "Semanas":
                            celdasListaVacasGraficos[2 + iterador, 3].Value = Math.Round(promedioIEPHato / Utilities.DIAS_SEMANA, 2);
                            celdasListaVacasGraficos[2 + iterador, 5].Value = Math.Round(listaDatosVacas[iterador].iepPromedioVacaDias / Utilities.DIAS_SEMANA, 2);
                            celdasListaVacasGraficos[2 + iterador, 6].Value = Math.Round(listaDatosVacas[iterador].ultimoIEPVacaDias / Utilities.DIAS_SEMANA, 2);
                            break;
                        default:
                            celdasListaVacasGraficos[2 + iterador, 3].Value = Math.Round(promedioIEPHato, 2);
                            celdasListaVacasGraficos[2 + iterador, 5].Value = Math.Round(listaDatosVacas[iterador].iepPromedioVacaDias, 2);
                            celdasListaVacasGraficos[2 + iterador, 6].Value = Math.Round(listaDatosVacas[iterador].ultimoIEPVacaDias, 2);
                            break;
                    }
                }
            }


            //Se crea el gráfico
            var chartVacas = grafico.Drawings.AddChart("chart", OfficeOpenXml.Drawing.Chart.eChartType.ColumnClustered3D);

            //Valores maximos y minimos para los ejes "x" y "y"
            chartVacas.YAxis.MinValue = 0;
            chartVacas.XAxis.MaxValue = listaDatosVacas.Count;

            //Se declaran las series que se utilizarán para poblar el gráfico
            var serieHato = chartVacas.Series.Add("C2: C" + listaDatosVacas.Count + 1, "B2: B" + listaDatosVacas.Count + 1);
            serieHato.Header = "Promedio Hato";

            var ult = chartVacas.Series.Add("D2: D" + listaDatosVacas.Count + 1, "B2: B" + listaDatosVacas.Count + 1);
            ult.Header =  "Partos/vaca";

            var prom = chartVacas.Series.Add("E2: E" + listaDatosVacas.Count + 1, "B2: B" + listaDatosVacas.Count + 1);
            prom.Header = "Prom c/vaca";

            var partos = chartVacas.Series.Add("F2: F" + listaDatosVacas.Count + 1, "B2: B" + listaDatosVacas.Count + 1);
            partos.Header = "Últ c/vaca";

            chartVacas.Border.Fill.Color = System.Drawing.Color.Green;
            chartVacas.Title.Text = "Todo el hato: comparación IEP del hato, último c/vaca y prom c/vaca";

            //Tamaño del gráfico
            chartVacas.SetSize(500, 300);

            // Posicionamos el gráfico
            chartVacas.SetPosition(1, 1, 13, 1);


            //--------------------------------Worksheet Gráfico-----------------------------

            //Se guarda el documento
            string ubicacionDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nombreDocumentoResumen = ubicacionDocumentos + @"\" + "Resumen_" + DateTime.Now.ToString().Replace("/", ".").Replace(":", ".").Replace(" ", "_").Replace("\\", ".") + ".xlsx";
            try
            {
                documentoExcel.SaveAs(new FileInfo(nombreDocumentoResumen));

                //Se muestra el mensaje que indica al usuario en donde quedó el documento
                Utilities.MostrarMessageBox(MENSAJE_CORRECTO + nombreDocumentoResumen, TITULO_MENSAJE, MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch
            {
                //Se muestra el mensaje que indica al usuario en donde quedó el documento
                Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Se cierra el documento
            documentoExcel.Dispose();
        }

    }
}
