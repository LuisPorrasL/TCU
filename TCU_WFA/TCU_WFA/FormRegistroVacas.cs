using System;
using System.Windows.Forms;
using TCU_WFA.Models;
using TCU_WFA.Repository;

namespace TCU_WFA
{
    public partial class FormRegistroVacas : DefaultForm
    {

        //Constantes
        private const string QUERY_SELECT_VACAS_DATA_GRID_VIEW = "SELECT v.PK_NUMERO_TRAZABLE as 'Id', v.NOMBRE AS 'Nombre', v.FECHA_NACIMIENTO AS 'Fecha nacimiento', v.RAZA AS 'Raza', v.CARACTERISTICAS AS 'Caracteristicas', mP.MODO_PRENNES AS 'Modo preñes', v.FK_NUMERO_TRAZABLE_VACA AS 'Id madre', v.FK_NUMERO_TRAZABLE_TORO AS 'Id padre'  FROM [dbo].[VACA] v, [dbo].MODO_PRENNES mP WHERE v.FK_ID_MODO_PRENNES = mP.PK_ID_MODO_PRENNES";
        private const string QUERY_BUSCAR_VACA_DATA_GRID_VIEW = "SELECT v.PK_NUMERO_TRAZABLE as 'Id', v.NOMBRE AS 'Nombre', v.FECHA_NACIMIENTO AS 'Fecha nacimiento', v.RAZA AS 'Raza', v.CARACTERISTICAS AS 'Caracteristicas', mP.MODO_PRENNES AS 'Modo preñes', v.FK_NUMERO_TRAZABLE_VACA AS 'Id madre', v.FK_NUMERO_TRAZABLE_TORO AS 'Id padre'  FROM [dbo].[VACA] v, [dbo].MODO_PRENNES mP WHERE v.FK_ID_MODO_PRENNES = mP.PK_ID_MODO_PRENNES AND v.PK_NUMERO_TRAZABLE = ";
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
            string textoBuscar = textBoxBuscarVaca.Text;
            if(textoBuscar != "")
            {
                try
                {
                    int idVacaABuscar = Int32.Parse(textoBuscar);
                    Utilities.LlenarDataGridView(QUERY_BUSCAR_VACA_DATA_GRID_VIEW + idVacaABuscar + ";", dataGridViewVacas);
                }
                catch
                {
                    Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                LlenarDataGridViewVacas();
            }
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewVacas.SelectedRows.Count != 0)
            {
                DataGridViewRow filaSelecionada = dataGridViewVacas.SelectedRows[0];
                if (filaSelecionada.Cells[0].Value != null)
                {
                    VacaModel informacionVacaSeleccionada = obtenerInformacionVacaSelecionada(filaSelecionada);
                    FormEditarVaca form = new FormEditarVaca(informacionVacaSeleccionada);
                    form.Tag = this;
                    form.Show(this);
                    Hide();
                }
                else
                {
                    Utilities.MostrarMessageBox(MENSAJE_ERROR_SELECCION_EDITAR_VACA, TITULO_AVISO_EDITAR_VACA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Utilities.MostrarMessageBox(MENSAJE_ERROR_SELECCION_EDITAR_VACA, TITULO_AVISO_EDITAR_VACA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private VacaModel obtenerInformacionVacaSelecionada(DataGridViewRow filaSelecionada)
        {
            VacaModel informacionVacaSeleccionada = new VacaModel();
            informacionVacaSeleccionada.pkNumeroTrazable = (int)filaSelecionada.Cells[0].Value;
            informacionVacaSeleccionada.nombre = (string)filaSelecionada.Cells[1].Value;
            informacionVacaSeleccionada.fecha = (DateTime)filaSelecionada.Cells[2].Value;
            informacionVacaSeleccionada.raza = (string)filaSelecionada.Cells[3].Value;
            informacionVacaSeleccionada.caracteriscas = (string)filaSelecionada.Cells[4].Value;
            informacionVacaSeleccionada.modoPrennes = (string)filaSelecionada.Cells[5].Value;
            try
            {
                informacionVacaSeleccionada.fkNumeroTrazableMadre = (int)filaSelecionada.Cells[6].Value;
            }
            catch
            {
                informacionVacaSeleccionada.fkNumeroTrazableMadre = null;
            }
            try
            {
                informacionVacaSeleccionada.fkNumeroTrazablePadre = (int)filaSelecionada.Cells[7].Value;
            }
            catch
            {
                informacionVacaSeleccionada.fkNumeroTrazablePadre = null;
            }

            return informacionVacaSeleccionada;
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if(dataGridViewVacas.SelectedRows.Count != 0)
            {
                DataGridViewRow filaSelecionada = dataGridViewVacas.SelectedRows[0];
                if (filaSelecionada.Cells[0].Value != null)
                {
                    DialogResult resultado = Utilities.MostrarMessageBox("¿Seguro que desea eliminar la vaca " + filaSelecionada.Cells["Id"].Value + "?. Esta operación no se puede revertir.", TITULO_AVISO_ELIMINAR_VACA, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        bool resultadoProc = EliminarVaca((int)filaSelecionada.Cells["Id"].Value);
                        if (resultadoProc)
                        {
                            Utilities.MostrarMessageBox(Utilities.MENSAJE_EXITO, Utilities.TITULO_EXITO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LlenarDataGridViewVacas();
                        }
                        else Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Utilities.MostrarMessageBox(MENSAJE_ERROR_SELECCION_ELIMINAR_VACA, TITULO_AVISO_ELIMINAR_VACA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Utilities.MostrarMessageBox(MENSAJE_ERROR_SELECCION_ELIMINAR_VACA, TITULO_AVISO_ELIMINAR_VACA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EliminarVaca(int vacaId)
        {
            try
            {
                int resultado = ProcedimientosAlmacenados.ProcEliminarVaca(vacaId);
                if (resultado == Utilities.RESULTADO_ERROR) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void botonDetalles_Click(object sender, EventArgs e)
        {
            if (dataGridViewVacas.SelectedRows.Count != 0)
            {
                DataGridViewRow filaSelecionada = dataGridViewVacas.SelectedRows[0];
                if (filaSelecionada.Cells[0].Value != null)
                {
                    VacaModel informacionVacaSeleccionada = obtenerInformacionVacaSelecionada(filaSelecionada);
                    FormDetallesVaca form = new FormDetallesVaca(informacionVacaSeleccionada);
                    form.Tag = this;
                    form.Show(this);
                    Hide();
                }
                else
                {
                    Utilities.MostrarMessageBox(MENSAJE_ERROR_SELECCION_DETALLES_VACA, TITULO_AVISO_DETALLES_VACA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Utilities.MostrarMessageBox(MENSAJE_ERROR_SELECCION_DETALLES_VACA, TITULO_AVISO_DETALLES_VACA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
