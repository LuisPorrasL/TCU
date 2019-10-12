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
    public partial class FormDetallesExamenAntropologico : DefaultForm
    {

        //Campos
        private int numeroTrazableToro;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="fechaExamen"></param>
        /// <param name="idToro"></param>
        public FormDetallesExamenAntropologico(DateTime fechaExamen, int idToro)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que se llama cada vez que se carga el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormDetallesExamenAntropologico_Load(object sender, EventArgs e)
        {

        }
    }
}
