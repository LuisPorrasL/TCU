using System;
using System.Windows.Forms;
using TCU_WFA.Models;
using TCU_WFA.Repository;

namespace TCU_WFA
{
    public partial class FormRegistroVacas : DefaultForm
    {

        //Constantes
        private const string QUERY_SELECT_VACAS_DATA_GRID_VIEW = "SELECT v.PK_NUMERO_TRAZABLE as 'Id', v.NOMBRE AS 'Nombre', v.FECHA_NACIMIENTO AS 'Fecha nacimiento', r.RAZA AS 'Raza', v.PESO AS 'Peso', d.ESTADO AS 'Estado desarrollo', v.CARACTERISTICAS AS 'Caracteristicas', mP.MODO_PRENNES AS 'Modo preñes', v.FK_NUMERO_TRAZABLE_VACA AS 'Id madre', v.FK_NUMERO_TRAZABLE_TORO AS 'Id padre', v.ACTIVA AS '¿Activa?' FROM dbo.[VACA] v, dbo.[MODO_PRENNES] mP, dbo.[RAZA] r, dbo.DESARROLLO d WHERE v.ACTIVA = 1 AND v.FK_ID_MODO_PRENNES = mP.PK_ID_MODO_PRENNES AND v.FK_ID_RAZA = r.PK_ID_RAZA AND v.FK_ID_DESARROLLO = d.PK_ID_DESARROLLO;";
        private const string QUERY_SELECT_BAJAS_VACAS_DATA_GRID_VIEW = "SELECT v.PK_NUMERO_TRAZABLE as 'Id', v.NOMBRE AS 'Nombre', v.FECHA_NACIMIENTO AS 'Fecha nacimiento', r.RAZA AS 'Raza', v.PESO AS 'Peso', d.ESTADO AS 'Estado desarrollo', v.CARACTERISTICAS AS 'Caracteristicas', mP.MODO_PRENNES AS 'Modo preñes', v.FK_NUMERO_TRAZABLE_VACA AS 'Id madre', v.FK_NUMERO_TRAZABLE_TORO AS 'Id padre', v.ACTIVA AS '¿Activa?', v.CAUSA_DE_BAJA AS 'Causa de baja' FROM dbo.[VACA] v, dbo.[MODO_PRENNES] mP, dbo.[RAZA] r, dbo.DESARROLLO d WHERE v.ACTIVA = 0 AND v.FK_ID_MODO_PRENNES = mP.PK_ID_MODO_PRENNES AND v.FK_ID_RAZA = r.PK_ID_RAZA AND v.FK_ID_DESARROLLO = d.PK_ID_DESARROLLO;";
        private const string QUERY_BUSCAR_VACA_DATA_GRID_VIEW = "SELECT v.PK_NUMERO_TRAZABLE as 'Id', v.NOMBRE AS 'Nombre', v.FECHA_NACIMIENTO AS 'Fecha nacimiento', r.RAZA AS 'Raza', v.PESO AS 'Peso', d.ESTADO AS 'Estado desarrollo', v.CARACTERISTICAS AS 'Caracteristicas', mP.MODO_PRENNES AS 'Modo preñes', v.FK_NUMERO_TRAZABLE_VACA AS 'Id madre', v.FK_NUMERO_TRAZABLE_TORO AS 'Id padre', v.ACTIVA AS '¿Activa?' FROM dbo.[VACA] v, dbo.[MODO_PRENNES] mP, dbo.[RAZA] r, dbo.DESARROLLO d WHERE v.ACTIVA = 1 AND v.FK_ID_MODO_PRENNES = mP.PK_ID_MODO_PRENNES AND v.FK_ID_RAZA = r.PK_ID_RAZA AND v.FK_ID_DESARROLLO = d.PK_ID_DESARROLLO AND v.PK_NUMERO_TRAZABLE = ";
        private const string QUERY_BUSCAR_BAJAS_VACA_DATA_GRID_VIEW = "SELECT v.PK_NUMERO_TRAZABLE as 'Id', v.NOMBRE AS 'Nombre', v.FECHA_NACIMIENTO AS 'Fecha nacimiento', r.RAZA AS 'Raza', v.PESO AS 'Peso', d.ESTADO AS 'Estado desarrollo', v.CARACTERISTICAS AS 'Caracteristicas', mP.MODO_PRENNES AS 'Modo preñes', v.FK_NUMERO_TRAZABLE_VACA AS 'Id madre', v.FK_NUMERO_TRAZABLE_TORO AS 'Id padre', v.ACTIVA AS '¿Activa?', v.CAUSA_DE_BAJA AS 'Causa de baja' FROM dbo.[VACA] v, dbo.[MODO_PRENNES] mP, dbo.[RAZA] r, dbo.DESARROLLO d WHERE v.ACTIVA = 0 AND v.FK_ID_MODO_PRENNES = mP.PK_ID_MODO_PRENNES AND v.FK_ID_RAZA = r.PK_ID_RAZA AND v.FK_ID_DESARROLLO = d.PK_ID_DESARROLLO AND v.PK_NUMERO_TRAZABLE = ";
        private const int NUMERO_TRAZABLE = 0;
        private const int NOMBRE = 1;
        private const int FECHA = 2;
        private const int RAZA = 3;
        private const int PESO = 4;
        private const int ESTADO = 5;
        private const int CARACTERISTICAS = 6;
        private const int MODO_PRENNES = 7;
        private const int MADRE_ID = 8;
        private const int PADRE_ID = 9;
        private const int ACTIVA = 10;
        private const int CAUSA_DE_BAJA = 11;
        //Mensajes
        public const string MENSAJE_ERROR_SELECCION_ELIMINAR_VACA = "Por favor seleccionar primero la vaca que se desea eliminar.";
        public const string MENSAJE_ERROR_SELECCION_EDITAR_VACA = "Por favor seleccionar primero la vaca que se desea editar.";
        public const string MENSAJE_ERROR_SELECCION_DETALLES_VACA = "Por favor seleccionar primero la vaca de la que desea ver los detalles.";
        //Titulos
        public const string TITULO_AVISO_EDITAR_VACA = "Aviso editar vaca";
        public const string TITULO_AVISO_DETALLES_VACA = "Aviso detalles vaca";
        public const string TITULO_AVISO_ELIMINAR_VACA = "Aviso eliminar vaca";

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
            string query = QUERY_SELECT_VACAS_DATA_GRID_VIEW;
            if (checkBoxVerBajas.Checked) query = QUERY_SELECT_BAJAS_VACAS_DATA_GRID_VIEW;
            Utilities.LlenarDataGridView(query, dataGridViewVacas);
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
                    string query = QUERY_BUSCAR_VACA_DATA_GRID_VIEW;
                    if (checkBoxVerBajas.Checked) query = QUERY_BUSCAR_BAJAS_VACA_DATA_GRID_VIEW;
                    Utilities.LlenarDataGridView(query + idVacaABuscar + ";", dataGridViewVacas);
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

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if(dataGridViewVacas.SelectedRows.Count != 0)
            {
                DataGridViewRow filaSelecionada = dataGridViewVacas.SelectedRows[0];
                if (filaSelecionada.Cells[0].Value != null)
                {
                    FormEliminarVaca form = new FormEliminarVaca((int)filaSelecionada.Cells[NUMERO_TRAZABLE].Value);
                    form.Tag = this;
                    form.Show(this);
                    Hide();
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

        private VacaModel obtenerInformacionVacaSelecionada(DataGridViewRow filaSelecionada)
        {
            VacaModel informacionVacaSeleccionada = new VacaModel();
            informacionVacaSeleccionada.pkNumeroTrazable = (int)filaSelecionada.Cells[NUMERO_TRAZABLE].Value;
            try
            {
                informacionVacaSeleccionada.nombre = (string)filaSelecionada.Cells[NOMBRE].Value;
            }
            catch
            {
                informacionVacaSeleccionada.nombre = null;
            }
            try
            {
                informacionVacaSeleccionada.fecha = (DateTime)filaSelecionada.Cells[FECHA].Value;
            }
            catch
            {
                informacionVacaSeleccionada.fecha = null;
            }
            informacionVacaSeleccionada.desarrollo = (string)filaSelecionada.Cells[ESTADO].Value;
            informacionVacaSeleccionada.razaStr = (string)filaSelecionada.Cells[RAZA].Value;
            informacionVacaSeleccionada.caracteriscas = (string)filaSelecionada.Cells[CARACTERISTICAS].Value;
            informacionVacaSeleccionada.modoPrennes = (string)filaSelecionada.Cells[MODO_PRENNES].Value;
            informacionVacaSeleccionada.activa = (bool)filaSelecionada.Cells[ACTIVA].Value;
            if (checkBoxVerBajas.Checked) informacionVacaSeleccionada.causaDeBaja = (string)filaSelecionada.Cells[CAUSA_DE_BAJA].Value;

            try
            {
                informacionVacaSeleccionada.peso = double.Parse(filaSelecionada.Cells[PESO].Value.ToString().Replace('.', ','));
            }
            catch
            {
                informacionVacaSeleccionada.peso = null;
            }
            try
            {
                informacionVacaSeleccionada.fkNumeroTrazableMadre = (int)filaSelecionada.Cells[MADRE_ID].Value;
            }
            catch
            {
                informacionVacaSeleccionada.fkNumeroTrazableMadre = null;
            }
            try
            {
                informacionVacaSeleccionada.fkNumeroTrazablePadre = (int)filaSelecionada.Cells[PADRE_ID].Value;
            }
            catch
            {
                informacionVacaSeleccionada.fkNumeroTrazablePadre = null;
            }

            return informacionVacaSeleccionada;
        }

        private void checkBoxVerBajas_CheckedChanged(object sender, EventArgs e)
        {
            LlenarDataGridViewVacas();
            botonEditar.Enabled = !checkBoxVerBajas.Checked;
            botonEliminar.Enabled = !checkBoxVerBajas.Checked;
        }
    }
}
