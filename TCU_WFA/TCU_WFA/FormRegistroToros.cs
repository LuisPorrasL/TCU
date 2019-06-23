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

        private void FormRegistroToros_Load(object sender, EventArgs e)
        {
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
