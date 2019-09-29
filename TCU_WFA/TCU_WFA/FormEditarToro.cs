using System;
using System.Windows.Forms;
using TCU_WFA.Models;

namespace TCU_WFA
{
    public partial class FormEditarToro : DefaultForm
    {

        // Campos
        private ToroModel informacionToroSeleccionado;

        public FormEditarToro(ToroModel informacionToroSeleccionado = null)
        {
            InitializeComponent();
            this.informacionToroSeleccionado = informacionToroSeleccionado;
        }

        private void FormEditarToro_Load(object sender, EventArgs e)
        {

        }
    }
}
