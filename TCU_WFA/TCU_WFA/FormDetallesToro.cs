// Hecho por Luis Porras.
using System;
using System.Windows.Forms;
using TCU_WFA.Models;

namespace TCU_WFA
{
    public partial class FormDetallesToro : DefaultForm
    {
        //Constantes
        private const string QUERY_SELECT_DATA_GRID_VIEW_EXAMENES = "SELECT e.PK_FECHA AS 'Fecha examen antropologico' FROM [dbo].[EXAMEN_ANTROPOLOGICO] e WHERE e.PK_FK_NUMERO_TRAZABLE_TORO = ";
        private const int FECHA = 0;

        //Mensajes
        public const string MENSAJE_ERROR_SELECCION_EXAMEN_TORO = "Por favor seleccionar primero el examen del que desea ver los detalles.";

        //Titulos
        public const string TITULO_AVISO_EXAMEN_TORO = "Aviso detalles examen antropologico";

        //Campos
        private ToroModel informacionToroSeleccionado;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="informacionToroSeleccionado">ToroModel con la información del vaca a mostrar</param>
        public FormDetallesToro(ToroModel informacionToroSeleccionado = null)
        {
            InitializeComponent();
            this.informacionToroSeleccionado = informacionToroSeleccionado;
        }

        /// <summary>
        /// Método que se llama cada vez que se carga el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormDetallesToro_Load(object sender, EventArgs e)
        {
            LlenarInformcionToro();
            LlenarDataGridViews();
        }

        /// <summary>
        /// Llena todos los DataGridViews del form.
        /// </summary>
        private void LlenarDataGridViews()
        {
            Utilities.LlenarDataGridView(QUERY_SELECT_DATA_GRID_VIEW_EXAMENES + informacionToroSeleccionado.pkNumeroTrazable + ";", dataGridViewExamenesToro);
        }

        /// <summary>
        /// Asigna a los componentes del form la información de la vaca seleccionada.  
        /// </summary>
        private void LlenarInformcionToro()
        {
            textBoxNumeroTrazableToro.Text = this.informacionToroSeleccionado.pkNumeroTrazable.ToString();
            textBoxNombre.Text = this.informacionToroSeleccionado.nombre;
            textBoxCaracteristicas.Text = this.informacionToroSeleccionado.caracteriscas;
            textBoxRaza.Text = this.informacionToroSeleccionado.razaStr;
        }

        /// <summary>
        /// Redirige al form FormDetallesExamenAntropologico.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonDetalles_Click(object sender, EventArgs e)
        {
            if (dataGridViewExamenesToro.SelectedRows.Count != 0)
            {
                DataGridViewRow filaSelecionada = dataGridViewExamenesToro.SelectedRows[0];
                if (filaSelecionada.Cells[0].Value != null)
                {
                    FormDetallesExamenAndrologico form = new FormDetallesExamenAndrologico((DateTime)filaSelecionada.Cells[FECHA].Value, this.informacionToroSeleccionado.pkNumeroTrazable);
                    form.Tag = this;
                    form.Show(this);
                    Hide();
                }
                else
                {
                    Utilities.MostrarMessageBox(MENSAJE_ERROR_SELECCION_EXAMEN_TORO, TITULO_AVISO_EXAMEN_TORO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Utilities.MostrarMessageBox(MENSAJE_ERROR_SELECCION_EXAMEN_TORO, TITULO_AVISO_EXAMEN_TORO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
