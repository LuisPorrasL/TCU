using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCU_WFA
{
    public partial class FormRegistroVacas : DefaultForm
    {

        //Constantes
        private const string QUERY_SELECT_VACAS_DATA_GRID_VIEW = "SELECT v.PK_NUMERO_TRAZABLE as 'Id', v.NOMBRE AS 'Nombre', v.FECHA_NACIMIENTO AS 'Fecha nacimiento', v.RAZA AS 'Raza', v.CARACTERISTICAS AS 'Caracteristicas', mP.MODO_PRENNES AS 'Modo preñes', v.FK_NUMERO_TRAZABLE_VACA AS 'Id madre', v.FK_NUMERO_TRAZABLE_TORO AS 'Id padre'  FROM [dbo].[VACA] v, [dbo].MODO_PRENNES mP WHERE v.FK_ID_MODO_PRENNES = mP.PK_ID_MODO_PRENNES";
        //Mensajes
        public const string MENSAJE_ERROR_SELECCION_ELIMINAR_VACA = "Por favor seleccionar primero la vaca que se desea eliminar.";
        public const string MENSAJE_ERROR_SELECCION_EDITAR_VACA = "Por favor seleccionar primero la vaca que se desea editar.";
        public const string MENSAJE_ERROR_SELECCION_DETALLES_VACA = "Por favor seleccionar primero la vaca de la que desea ver los detalles.";
        //Titulos
        public const string TITULO_AVISO_ELIMINAR_VACA = "Aviso eliminar vaca";
        public const string TITULO_AVISO_EDITAR_VACA = "Aviso editar vaca";
        public const string TITULO_AVISO_DETALLES_VACA = "Aviso detalles vaca";

        public FormRegistroVacas()
        {
            InitializeComponent();
        }

        private void FormRegistroVacas_Load(object sender, EventArgs e)
        {
            LlenarDataGridViewVacas();
        }

        public void LlenarDataGridViewVacas()
        {
            Utilities.LlenarDataGridView(QUERY_SELECT_VACAS_DATA_GRID_VIEW, dataGridViewVacas);
        }

        private void botonAgregarVaca_Click(object sender, EventArgs e)
        {
            FormAgregarVaca form = new FormAgregarVaca();
            form.Tag = this;
            form.Show(this);
            Hide();
        }

        private void botonBuscarVaca_Click(object sender, EventArgs e)
        {

        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewVacas.SelectedRows.Count != 0)
            {
                DataGridViewRow filaSelecionada = dataGridViewVacas.SelectedRows[0];
                FormEditarVaca form = new FormEditarVaca(filaSelecionada);
                form.Tag = this;
                form.Show(this);
                Hide();
            }
            else
            {
                Utilities.MostrarMessageBox(MENSAJE_ERROR_SELECCION_EDITAR_VACA, TITULO_AVISO_EDITAR_VACA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if(dataGridViewVacas.SelectedRows.Count != 0)
            {
                DataGridViewRow filaSelecionada = dataGridViewVacas.SelectedRows[0];
                DialogResult resultado = Utilities.MostrarMessageBox("¿Seguro que desea eliminar la vaca " + filaSelecionada.Cells["Id"].Value + "?. Esta operación no se puede revertir.", TITULO_AVISO_ELIMINAR_VACA, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(resultado == DialogResult.Yes)
                {
                    //TODO: llamar al proc almacenado para eliminar la vaca seleccionada
                    //TODO: dar retroalimentación al usuario sobre el resultado del proc almacenado
                    //TODO: en caso de exito refrescar dataGridViewVacas
                }
            }
            else
            {
                Utilities.MostrarMessageBox(MENSAJE_ERROR_SELECCION_ELIMINAR_VACA, TITULO_AVISO_ELIMINAR_VACA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonDetalles_Click(object sender, EventArgs e)
        {
            if (dataGridViewVacas.SelectedRows.Count != 0)
            {
                DataGridViewRow filaSelecionada = dataGridViewVacas.SelectedRows[0];
                FormDetallesVaca form = new FormDetallesVaca(filaSelecionada);
                form.Tag = this;
                form.Show(this);
                Hide();
            }
            else
            {
                Utilities.MostrarMessageBox(MENSAJE_ERROR_SELECCION_DETALLES_VACA, TITULO_AVISO_DETALLES_VACA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
