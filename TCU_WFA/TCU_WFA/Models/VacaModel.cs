// Hecho por Luis Porras. 
// Modificado por Ariel Arias (9/29/2019). 
using System;

namespace TCU_WFA.Models
{
    /// <summary>
    /// Modelo basado en la tabla Vaca de la base de datos.
    /// </summary>
    public class VacaModel
    {
        public int pkNumeroTrazable { get; set; }
        public string nombre { get; set; }
        public string caracteriscas { get; set; }
        public int raza { get; set; }
        public string razaStr { get; set; }
        public int fkModoPrennes { get; set; }
        public string modoPrennes { get; set; }
        public DateTime? fecha { get; set; }
        public int? fkNumeroTrazableMadre { get; set; }
        public int? fkNumeroTrazablePadre { get; set; }
        public double? peso { get; set; }
        public int fkDesarrollo { get; set; }
        public string desarrollo { get; set; }
        public bool activa { get; set; }
        public string causaDeBaja { get; set; }
        public int? edadAPrimerPartoMeses { get; set; }
        public int? numeroDePartos { get; set; }
        public int? edadUltimaCria { get; set; }
        public string fechaDesteteUltimaCria { get; set; }
        public double iepPromedioDias { get; set; }
        public double ultimoIEPDias { get; set; }
        public string fechaUltimaMonta { get; set; }
        public int gestacionDias { get; set; }
        public string fechaParto { get; set; }
    }
}
