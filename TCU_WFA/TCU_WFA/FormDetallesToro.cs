using System;
using System.Windows.Forms;
using TCU_WFA.Models;

namespace TCU_WFA
{
    public partial class FormDetallesToro : DefaultForm
    {

        //Campos
        private ToroModel informacionToroSeleccionado;

        public FormDetallesToro(ToroModel informacionToroSeleccionado = null)
        {
            InitializeComponent();
            this.informacionToroSeleccionado = informacionToroSeleccionado;
        }

        private void FormDetallesToro_Load(object sender, EventArgs e)
        {

        }
    }
}
