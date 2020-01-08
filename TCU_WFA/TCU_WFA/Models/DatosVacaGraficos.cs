//Hecho por Ariel Arias
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCU_WFA.Models
{
    /// <summary>
    /// Modelo utilizado para almacenar los datos necesarios por cada vaca para el excel de gráficos
    /// </summary>
    public class DatosVacaGraficos
    {
        public int partosVaca { get; set; }

        public int pkNumeroTrazableVaca { get; set; }

        public double? iepPromedioVacaMeses { get; set; }

        public double ultimoIEPVacaMeses { get; set; }
    }
}
