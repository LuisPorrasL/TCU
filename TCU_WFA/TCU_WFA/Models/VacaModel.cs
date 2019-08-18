using System;

namespace TCU_WFA.Models
{
    public class VacaModel
    {
        public int pkNumeroTrazable { get; set; }
        public string nombre { get; set; }
        public string caracteriscas { get; set; }
        public int raza { get; set; }
        public string razaStr { get; set; }
        public int fkModoPrennes { get; set; }
        public string modoPrennes { get; set; }
        public DateTime fecha { get; set; }
        public int? fkNumeroTrazableMadre { get; set; }
        public int? fkNumeroTrazablePadre { get; set; }
        public double? peso { get; set; }
        public int fkDesarrollo { get; set; }
        public string desarrollo { get; set; }
    }
}
