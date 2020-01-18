// Hecho por Luis Porras.
using System;
using System.Windows.Forms;
using TCU_WFA.Models;

namespace TCU_WFA
{
    public partial class FormRegistroToros : DefaultForm
    {

        //Constantes
        private const string QUERY_SELECT_TOROS_DATA_GRID_VIEW = "SELECT t.PK_NUMERO_TRAZABLE as 'Id', t.NOMBRE AS 'Nombre', r.RAZA AS 'Raza', t.CARACTERISTICAS AS 'Caracteristicas' FROM dbo.[TORO] t, dbo.[RAZA] r WHERE t.ACTIVA = 1 AND t.FK_ID_RAZA = r.PK_ID_RAZA;";
        private const string QUERY_BUSCAR_TORO_DATA_GRID_VIEW = "SELECT t.PK_NUMERO_TRAZABLE as 'Id', t.NOMBRE AS 'Nombre', r.RAZA AS 'Raza', t.CARACTERISTICAS AS 'Caracteristicas' FROM dbo.[TORO] t, dbo.[RAZA] r WHERE t.ACTIVA = 1 AND t.FK_ID_RAZA = r.PK_ID_RAZA AND t.PK_NUMERO_TRAZABLE = ";
        private const int NUMERO_TRAZABLE = 0;
        private const int NOMBRE = 1;
        private const int RAZA = 2;
        private const int CARACTERISTICAS = 3;

        //Mensajes
        public const string MENSAJE_ERROR_SELECCION_ELIMINAR_TORO = "Por favor seleccionar primero el toro que se desea eliminar.";
        public const string MENSAJE_ERROR_SELECCION_EDITAR_TORO = "Por favor seleccionar primero el toro que se desea editar.";
        public const string MENSAJE_ERROR_SELECCION_DETALLES_TORO = "Por favor seleccionar primero el toro de la que desea ver los detalles.";

        //Titulos
        public const string TITULO_AVISO_EDITAR_TORO = "Aviso editar vaca";
        public const string TITULO_AVISO_DETALLES_TORO = "Aviso detalles vaca";
        public const string TITULO_AVISO_ELIMINAR_TORO = "Aviso eliminar vaca";



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

        /// <summary>
        /// Redirige al form FormEditarToro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewToros.SelectedRows.Count != 0)
            {
                DataGridViewRow filaSelecionada = dataGridViewToros.SelectedRows[0];
                if (filaSelecionada.Cells[0].Value != null)
                {
                    ToroModel informacionToroSeleccionado = obtenerInformacionToroSelecionado(filaSelecionada);
                    FormEditarToro form = new FormEditarToro(informacionToroSeleccionado);
                    form.Tag = this;
                    form.Show(this);
                    Hide();
                }
                else
                {
                    Utilities.MostrarMessageBox(MENSAJE_ERROR_SELECCION_EDITAR_TORO, TITULO_AVISO_EDITAR_TORO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Utilities.MostrarMessageBox(MENSAJE_ERROR_SELECCION_EDITAR_TORO, TITULO_AVISO_EDITAR_TORO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Redirige al form FormEliminarToro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewToros.SelectedRows.Count != 0)
            {
                DataGridViewRow filaSelecionada = dataGridViewToros.SelectedRows[0];
                if (filaSelecionada.Cells[0].Value != null)
                {
                    FormEliminarToro form = new FormEliminarToro((int)filaSelecionada.Cells[NUMERO_TRAZABLE].Value);
                    form.Tag = this;
                    form.Show(this);
                    Hide();
                }
                else
                {
                    Utilities.MostrarMessageBox(MENSAJE_ERROR_SELECCION_ELIMINAR_TORO, TITULO_AVISO_ELIMINAR_TORO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Utilities.MostrarMessageBox(MENSAJE_ERROR_SELECCION_ELIMINAR_TORO, TITULO_AVISO_ELIMINAR_TORO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Redirige al form FormDetallesToro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonDetalles_Click(object sender, EventArgs e)
        {
            if (dataGridViewToros.SelectedRows.Count != 0)
            {
                DataGridViewRow filaSelecionada = dataGridViewToros.SelectedRows[0];
                if (filaSelecionada.Cells[0].Value != null)
                {
                    ToroModel informacionToroSeleccionado = obtenerInformacionToroSelecionado(filaSelecionada);
                    FormDetallesToro form = new FormDetallesToro(informacionToroSeleccionado);
                
                    form.Tag = this;
                    form.Show(this);
                    Hide();
                }
                else
                {
                    Utilities.MostrarMessageBox(MENSAJE_ERROR_SELECCION_DETALLES_TORO, TITULO_AVISO_DETALLES_TORO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Utilities.MostrarMessageBox(MENSAJE_ERROR_SELECCION_DETALLES_TORO, TITULO_AVISO_DETALLES_TORO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Extrae la información sobre la vaca seleccioada por el usuario en el DataGridView del form.
        /// </summary>
        /// <param name="filaSelecionada"></param>
        /// <returns>Un VacaModel con la información de la vaca seleccionada.</returns>
        private ToroModel obtenerInformacionToroSelecionado(DataGridViewRow filaSelecionada)
        {
            ToroModel informaciontoroSeleccionado = new ToroModel();
            informaciontoroSeleccionado.pkNumeroTrazable = (int)filaSelecionada.Cells[NUMERO_TRAZABLE].Value;
            try
            {
                informaciontoroSeleccionado.nombre = (string)filaSelecionada.Cells[NOMBRE].Value;
            }
            catch
            {
                informaciontoroSeleccionado.nombre = null;
            }
            informaciontoroSeleccionado.razaStr = (string)filaSelecionada.Cells[RAZA].Value;
            informaciontoroSeleccionado.caracteriscas = (string)filaSelecionada.Cells[CARACTERISTICAS].Value;

            return informaciontoroSeleccionado;
        }
    }
}
