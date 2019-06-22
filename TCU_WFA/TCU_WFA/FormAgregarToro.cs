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
    public partial class FormAgregarToro : DefaultForm
    {

        public FormAgregarToro()
        {
            InitializeComponent();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            FormRegistroToros form = (FormRegistroToros)Tag;
            form.Show();
            Close();
        }

        private void FormAgregarToro_Load(object sender, EventArgs e)
        {

        }
    }
}
