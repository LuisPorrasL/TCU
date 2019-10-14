// Hecho por Luis Porras. 
using System;

namespace TCU_WFA.Models
{
    /// <summary>
    /// Modelo basado en la tabla Vaca de la base de datos.
    /// </summary>
    public class ToroModel
    {
        public int pkNumeroTrazable { get; set; }
        public string nombre { get; set; }
        public string caracteriscas { get; set; }
        public int raza { get; set; }
        public string razaStr { get; set; }
        public bool activa { get; set; }
        public string causaDeBaja { get; set; }
    }
}
