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
    public partial class FormRegistroToros : DefaultForm
    {

        public FormRegistroToros()
        {
            InitializeComponent();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            VentanaPrincipal form = (VentanaPrincipal)Tag;
            form.Show();
            Close();
        }

        private void FormRegistroToros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tCU_DBDataSet.TORO' table. You can move, or remove it, as needed.
            this.tOROTableAdapter.Fill(this.tCU_DBDataSet.TORO);

        }

        private void botonAgregarToro_Click(object sender, EventArgs e)
        {
            FormAgregarToro form = new FormAgregarToro();
            form.Tag = this;
            form.Show(this);
            Hide();
        }
    }
}
