using System;
using System.Windows.Forms;

namespace TCU_WFA
{
    public partial class FormEliminarToro : DefaultForm
    {

        //Campos
        private int numeroTrazableToro;
        private string causaDeBaja;

        public FormEliminarToro(int numeroTrazableToro)
        {
            InitializeComponent();
            this.numeroTrazableToro = numeroTrazableToro;
        }

        private void FormEliminarToro_Load(object sender, EventArgs e)
        {

        }
    }
}
