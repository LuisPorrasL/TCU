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
    public partial class FormConfiguracion : DefaultForm
    { 

        public FormConfiguracion()
        {
            InitializeComponent();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            VentanaPrincipal form = (VentanaPrincipal)Tag;
            form.Show();
            Close();
        }

        private void FormConfiguracion_Load(object sender, EventArgs e)
        {

        }
    }
}
