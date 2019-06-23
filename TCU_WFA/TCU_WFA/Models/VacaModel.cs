using System;

namespace TCU_WFA.Models
{
    public class VacaModel
    {
        public int pkNumeroTrazable { get; set; }
        public string nombre { get; set; }
        public string caracteriscas { get; set; }
        public string raza { get; set; }
        public int fkModoPrennes { get; set; }
        public DateTime fecha { get; set; }
        public int fkNumeroTrazableMadre { get; set; }
        public int fkNumeroTrazablePadre { get; set; }
    }
}
