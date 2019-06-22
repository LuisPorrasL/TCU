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
    public partial class FormRegistroVacas : DefaultForm
    {
        public FormRegistroVacas()
        {
            InitializeComponent();
        }

        private void FormRegistroVacas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tCU_DBDataSet.VACA' table. You can move, or remove it, as needed.
            this.vACATableAdapter.Fill(this.tCU_DBDataSet.VACA);
        }

        private void botonAgregarVaca_Click(object sender, EventArgs e)
        {
            FormAgregarVaca form = new FormAgregarVaca();
            form.Tag = this;
            form.Show(this);
            Hide();
        }
    }
}
