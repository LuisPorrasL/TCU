//Hecho por Ariel Arias

using System;

namespace TCU_WFA.Models
{
    public class DatosGeneralesResumen
    {
        public string fechaActual { get; set; }
        public int hembrasConsideradas { get; set; }
        public int hembrasParido { get; set; }
        public double iepPromHistoricoMeses { get; set; }
        public double porcParicionHistorico { get; set; }
        public double ultimoIEPVacaMeses { get; set; }
        public double ultimoPorcParicion { get; set; }
        public double promPartosHato { get; set; }
        public int tipoResumen { get; set; }
        public DateTime fechaInicioResumen { get; set; }
        public DateTime fechaFinalResumen { get; set; }

        public DatosGeneralesResumen()
        {
            hembrasConsideradas = 0;
            hembrasParido = 0;
            iepPromHistoricoMeses = 0;
            porcParicionHistorico = 0;
            ultimoIEPVacaMeses = 0;
            ultimoPorcParicion = 0;
            promPartosHato = 0;
        }
    }
}
