using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCU_WFA.Models;
using TCU_WFA.Repository;

namespace TCU_WFA
{
    public partial class FormGraficos : DefaultForm
    {
        //Consulta cantidad vacas
        private const string CONSULTA_VACAS_CONSIDERADAS = "SELECT COUNT(*) FROM [dbo].[VACA]";
        //Indices dataReader
        private const int INDICE_DTR_NUMERO_TRAZABLE = 0;
        private const int INDICE_DTR_CANTIDAD_PARTOS = 1;
        private const int INDICE_DTR_IEP_VACA = 2;
        private const int INDICE_DTR_ULTIMO_IEP_VACA = 3;

        //IEP Promedio del hato
        private double promedioIEPHato = 0;

        //Cantidad de vacas
        private int cantidadVacas = 0;

        //Lista de datos de las vacas
        List<DatosVacaGraficos> listaDatosVacas = new List<DatosVacaGraficos>();

        public FormGraficos()
        {
            InitializeComponent();
        }

        private void FormGraficos_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Método de click en el botón de generar excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGenerarExcelGraficos_Click(object sender, EventArgs e)
        {
            //Se obtienen los datos y se genera el excel
            CargarDatosVacas();
            GenerarExcelGraficos();
        }

        private void CargarDatosVacas()
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

            if(cantidadVacas > 0 && cantidadVacas != Utilities.RESULTADO_ERROR)
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
                        listaDatosVacas[iteradorVacas].pkNumeroTrazableVaca = (int)dt.Rows[iteradorVacas][INDICE_DTR_NUMERO_TRAZABLE];

                        if (dt.Rows[iteradorVacas][INDICE_DTR_CANTIDAD_PARTOS] != DBNull.Value)
                        {
                            listaDatosVacas[iteradorVacas].partosVaca = (int)dt.Rows[iteradorVacas][INDICE_DTR_CANTIDAD_PARTOS];
                        }

                        if(dt.Rows[iteradorVacas][INDICE_DTR_IEP_VACA] != DBNull.Value)
                        {
                            listaDatosVacas[iteradorVacas].iepPromedioVacaMeses = Convert.ToDouble(dt.Rows[iteradorVacas][INDICE_DTR_IEP_VACA]);
                        }

                        if(dt.Rows[iteradorVacas][INDICE_DTR_ULTIMO_IEP_VACA] != DBNull.Value)
                        {
                            listaDatosVacas[iteradorVacas].ultimoIEPVacaMeses = Convert.ToDouble(dt.Rows[iteradorVacas][INDICE_DTR_ULTIMO_IEP_VACA]);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Método para generar el excel 
        /// </summary>
        private void GenerarExcelGraficos()
        {
            //Se llama al método para generar el excel con los datos obtenidos
          //  ExcelGenerator.CrearDocumentoGraficosExcel(promedioIEPHato, listaDatosVacas);
        }

    }
}
