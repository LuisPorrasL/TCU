// Hecho por Luis Porras.
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

        //Constantes
        private const string QUERY_SELECT_TOROS_DATA_GRID_VIEW = "SELECT t.PK_NUMERO_TRAZABLE as 'Id', t.NOMBRE AS 'Nombre', r.RAZA AS 'Raza', t.CARACTERISTICAS AS 'Caracteristicas', t.ACTIVA AS '¿Activo?' FROM dbo.[TORO] t, dbo.[RAZA] r WHERE t.ACTIVA = 1 AND t.FK_ID_RAZA = r.PK_ID_RAZA;";
        private const string QUERY_BUSCAR_TORO_DATA_GRID_VIEW = "SELECT t.PK_NUMERO_TRAZABLE as 'Id', t.NOMBRE AS 'Nombre', r.RAZA AS 'Raza', t.CARACTERISTICAS AS 'Caracteristicas', t.ACTIVA AS '¿Activo?' FROM dbo.[TORO] t, dbo.[RAZA] r WHERE t.ACTIVA = 1 AND t.FK_ID_RAZA = r.PK_ID_RAZA AND t.PK_NUMERO_TRAZABLE = ";

        /// <summary>
        /// Constructor.
        /// </summary>
        public FormRegistroToros()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que se llama cada vez que se carga el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormRegistroToros_Load(object sender, EventArgs e)
        {
            LlenarDataGridViewToros();
        }

        /// <summary>
        /// Pobla el DataGridView del form.
        /// </summary>
        public void LlenarDataGridViewToros()
        {
            string query = QUERY_SELECT_TOROS_DATA_GRID_VIEW;
            Utilities.LlenarDataGridView(query, dataGridViewToros);
        }

        /// <summary>
        /// Actualiza el DataGridView del form según lo que desea buscar el usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonBuscarToro_Click(object sender, EventArgs e)
        {
            string textoBuscar = textBoxBuscarToro.Text;
            if (textoBuscar != "")
            {
                try
                {
                    int idVacaABuscar = Int32.Parse(textoBuscar);
                    string query = QUERY_BUSCAR_TORO_DATA_GRID_VIEW;
                    Utilities.LlenarDataGridView(query + idVacaABuscar + ";", dataGridViewToros);
                }
                catch
                {
                    Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                LlenarDataGridViewToros();
            }
        }

        /// <summary>
        /// Redirige al form FormAgregarToro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonAgregarToro_Click(object sender, EventArgs e)
        {
            FormAgregarToro form = new FormAgregarToro();
            form.Tag = this;
            form.Show(this);
            Hide();
        }
    }
}
