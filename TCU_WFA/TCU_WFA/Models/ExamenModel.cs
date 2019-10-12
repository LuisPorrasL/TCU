using System;

namespace TCU_WFA.Models
{
    public class ExamenModel  {


        public int pkNumeroTrazable { get; set; } //1
        public DateTime pkFecha { get; set; } //2
        public String condicionCorporal { get; set; } //3
        public bool libido { get; set; }//4
        public bool capacidadMonta { get; set; }//5
        public int descansoSexual { get; set; }//6
        public bool prepucio { get; set; }//7
        public bool pene { get; set; }//8
        public bool testiculos { get; set; }//9
        public bool epididimos { get; set; }//10
        public bool glandulasB { get; set; }//11
        public bool prostata { get; set; }//12
        public bool vesiculasSeminales { get; set; }//13
        public bool ampulas { get; set; }//14
        public float circunferenciaEscrotal { get; set; }//15
        public float volumenEyaculado { get; set; }//16
        public float concentracion { get; set; }//17
        public int motilidadMasal { get; set; }//18
        public int motidilidadProgresiva { get; set; }//19
        public int morfologiaNormal { get; set; }//20
        public String anormalidadesPrimarias { get; set; }//21
        public String dannosAcrosomales { get; set; }//22
        public String anormalidadesSecundarias { get; set; }//23
        public int totalAnormalidades { get; set; }//24
        public String anomaliaFrecuente { get; set; }//25
        public int leucocitos { get; set; }//26
        public int celulasEpit { get; set; }//27
        public String observaciones { get; set; }//28
        public bool satisfactorio { get; set; }//29
        public String veterinario { get; set; }//30
        public bool palpacion { get; set; }
        public bool ecografia { get; set; }
        public bool vaginaArt { get; set; }
        public bool electroEya { get; set; }
        public bool protusion { get; set; }

}
}
