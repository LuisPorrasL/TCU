using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCU_WFA
{
    public partial class FormInformacion : DefaultForm
    {
        //Descripción general TCU
        private const string INFO_TCU = "Esta aplicación fue desarrollada como un proyecto del Trabajo Comunal Universitario de la Universidad de Costa Rica.";

        //Nombre del TCU
        private const string NOMBRE_TCU = "TC-228 Asesoría agroeconómica a organizaciones de productores agrícolas y agroindustriales";

        //Nombre del profesor
        private const string NOMBRE_PROFESOR = "Alberth Campos Arguello";

        //Nombres
        private string[] ESTUDIANTES = new string[4]{ "Ariel Stiven Arias Rojas", "José Alberto Soto Li", "Luis Andrés Porras Ledezma", "Leonel Rodolfo Sánchez Loaiza" };

        public FormInformacion()
        {
            InitializeComponent();
        }

        private void FormInformacion_Load(object sender, EventArgs e)
        {
            labelInfo.Text = INFO_TCU;
            labelNombreTCU.Text = NOMBRE_TCU;
            labelNombreProfesor.Text = NOMBRE_PROFESOR;
            labelEstudiante1.Text = ESTUDIANTES[0];
            labelEstudiante2.Text = ESTUDIANTES[1];
            labelEstudiante3.Text = ESTUDIANTES[2];
            labelEstudiante4.Text = ESTUDIANTES[3];
        }
    }
}
