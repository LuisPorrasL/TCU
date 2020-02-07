//Hecho por Luis Porras.

using System;
using System.Windows.Forms;
using TCU_WFA.Repository;

namespace TCU_WFA
{
    public partial class FormConfiguracion : DefaultForm
    {
        //Cosntantes
        private const string ERROR_ARCHIVO_CONFIG = "Error: Archivo de configuración no es válido. La configuración por defecto de la aplicación será cargada.";
        private const string QUERY_SELECT_RAZAS_DATA_GRID_VIEW = "SELECT r.RAZA as 'Raza' FROM dbo.[RAZA] r";
        private const string QUERY_SELECT_MODOS_PRENNES_DATA_GRID_VIEW = "SELECT mP.MODO_PRENNES as 'Modo preñez' FROM dbo.[MODO_PRENNES] mP";

        //Mensajes
        public const string MENSAJE_ERROR_SELECCION_ELIMINAR_RAZA = "Por favor seleccionar primero la raza que se desea eliminar.";
        public const string MENSAJE_ERROR_SELECCION_ELIMINAR_MODO_PRENNES = "Por favor seleccionar primero el modo preñez que se desea eliminar.";

        //Titulos
        public const string TITULO_AVISO_ELIMINAR_RAZA = "Aviso eliminar raza";
        public const string TITULO_AVISO_ELIMINAR_MODO_PRENNES = "Aviso eliminar modo preñez";

        //Campos
        ProgramConfiguration config;

        /// <summary>
        /// Constructor
        /// </summary>
        public FormConfiguracion()
        {
            InitializeComponent();
            config = new ProgramConfiguration();
        }

        /// <summary>
        /// Método llamado cada vez que se carga el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormConfiguracion_Load(object sender, EventArgs e)
        {
            LlenarComboBoxUnidadDeTiempo();
            CargarConfiguracionActual();
            LlenarDataGridViewsCRUDS();
        }

        /// <summary>
        /// Llena los DataGridViews para los CRUDS
        /// </summary>
        private void LlenarDataGridViewsCRUDS()
        {
            Utilities.LlenarDataGridView(QUERY_SELECT_RAZAS_DATA_GRID_VIEW, dataGridViewRazas);
            Utilities.LlenarDataGridView(QUERY_SELECT_MODOS_PRENNES_DATA_GRID_VIEW, dataGridViewModoPrennes);
        }

        /// <summary>
        /// Llena el combo box con los diferentes valores para la unidad de tiempo.
        /// </summary>
        private void LlenarComboBoxUnidadDeTiempo()
        {
            comboBoxUnidadDeTiempo.DisplayMember = "unidadDeTiempo";
            comboBoxUnidadDeTiempo.ValueMember = "id";
            comboBoxUnidadDeTiempo.Items.Add(new { unidadDeTiempo = "Días", id = "Días" });
            comboBoxUnidadDeTiempo.Items.Add(new { unidadDeTiempo = "Semanas", id = "Semanas" });
            comboBoxUnidadDeTiempo.Items.Add(new { unidadDeTiempo = "Meses", id = "Meses" });
            comboBoxUnidadDeTiempo.SelectedIndex = 0;
        }

        /// <summary>
        /// Llena los componentes del form con la configuración actual cargada.
        /// </summary>
        private void CargarConfiguracionActual()
        {
            int indiceUnidadDeTiempo = comboBoxUnidadDeTiempo.FindString(config.ObtenerConfig(ProgramConfiguration.LLAVE_UNIDAD_DE_TIEMPO));
            comboBoxUnidadDeTiempo.SelectedIndex = indiceUnidadDeTiempo;
            numericUpDownAlertaIEP.Value = Int32.Parse(config.ObtenerConfig(ProgramConfiguration.LLAVE_ALERTA_IEP));
            numericUpDownAlertaPalpacion.Value = Int32.Parse(config.ObtenerConfig(ProgramConfiguration.LLAVE_ALERTA_PALPACION));
            numericUpDownParto.Value = Int32.Parse(config.ObtenerConfig(ProgramConfiguration.LLAVE_ALERTA_PARTO));
        }

        /// <summary>
        /// Guarga la nueva configuración seleccionada por el usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                config.CambiarConfig(ProgramConfiguration.LLAVE_UNIDAD_DE_TIEMPO, comboBoxUnidadDeTiempo.Text);
                config.CambiarConfig(ProgramConfiguration.LLAVE_ALERTA_IEP, numericUpDownAlertaIEP.Value.ToString());
                config.CambiarConfig(ProgramConfiguration.LLAVE_ALERTA_PALPACION, numericUpDownAlertaPalpacion.Value.ToString());
                config.CambiarConfig(ProgramConfiguration.LLAVE_ALERTA_PARTO, numericUpDownParto.Value.ToString());
                Utilities.MostrarMessageBox(Utilities.MENSAJE_EXITO, Utilities.TITULO_EXITO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Muestra el boton "botonGuardar" cuando de entra al tab "tabPageGeneral"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPageGeneral_Enter(object sender, EventArgs e)
        {
            botonGuardar.Show();
        }

        /// <summary>
        /// Esconde el boton "botonGuardar" cuando de entra al tab "tabPageCRUD"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPageCRUD_Enter(object sender, EventArgs e)
        {
            botonGuardar.Hide();
        }

        /// <summary>
        /// Elimina la raza seleccionada por el usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonEliminarRaza_Click(object sender, EventArgs e)
        {
            if (dataGridViewRazas.SelectedRows.Count != 0)
            {
                DataGridViewRow filaSelecionada = dataGridViewRazas.SelectedRows[0];
                if (filaSelecionada.Cells[0].Value != null)
                {
                    bool resultado = EliminarRaza((string)filaSelecionada.Cells[0].Value);
                    if (resultado)
                    {
                        Utilities.MostrarMessageBox(Utilities.MENSAJE_EXITO, Utilities.TITULO_EXITO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarDataGridViewsCRUDS();
                    }
                    else Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Utilities.MostrarMessageBox(MENSAJE_ERROR_SELECCION_ELIMINAR_RAZA, TITULO_AVISO_ELIMINAR_RAZA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Utilities.MostrarMessageBox(MENSAJE_ERROR_SELECCION_ELIMINAR_RAZA, TITULO_AVISO_ELIMINAR_RAZA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método ausiliar de "botonEliminarRaza_Click", elimina la raza seleccionada por el usuario de la base de datos.
        /// </summary>
        /// <param name="raza"></param>
        private bool EliminarRaza(string raza)
        {
            DialogResult resultadoDialogo = Utilities.MostrarMessageBox("¿Seguro que desea eliminar la raza seleccionada?. Esta operación no se puede revertir.", TITULO_AVISO_ELIMINAR_RAZA, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultadoDialogo == DialogResult.Yes)
            {
                try
                {
                    int resultado = ProcedimientosAlmacenados.ProcEliminarRaza(raza);
                    if (resultado == Utilities.RESULTADO_ERROR) return false;
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else return false;
        }

        /// <summary>
        /// Agrega la raza digitada por el usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonAgregarRaza_Click(object sender, EventArgs e)
        {
            if (textBoxRaza.Text != "")
            {
                bool resultado = AgregarNuevaRaza(textBoxRaza.Text);
                if (resultado)
                {
                    Utilities.MostrarMessageBox(Utilities.MENSAJE_EXITO, Utilities.TITULO_EXITO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxRaza.Text = "";
                    LlenarDataGridViewsCRUDS();
                }
                else Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR_ENTRADA_USUARIO, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método ausiliar de "botonAgregarRaza_Click", inserta la raza digitada por el usuario de la base de datos.
        /// </summary>
        /// <param name="raza"></param>
        /// <returns></returns>
        private bool AgregarNuevaRaza(string raza)
        {
            try
            {
                int resultado = ProcedimientosAlmacenados.ProcInsertarRaza(raza);
                if (resultado == Utilities.RESULTADO_ERROR) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Elimina el modo preñes seleccionado por el usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonEliminarModoPrennes_Click(object sender, EventArgs e)
        {
            if (dataGridViewModoPrennes.SelectedRows.Count != 0)
            {
                DataGridViewRow filaSelecionada = dataGridViewModoPrennes.SelectedRows[0];
                if (filaSelecionada.Cells[0].Value != null)
                {
                    bool resultado = EliminarModoPrennes((string)filaSelecionada.Cells[0].Value);
                    if (resultado)
                    {
                        Utilities.MostrarMessageBox(Utilities.MENSAJE_EXITO, Utilities.TITULO_EXITO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarDataGridViewsCRUDS();
                    }
                    else Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Utilities.MostrarMessageBox(MENSAJE_ERROR_SELECCION_ELIMINAR_MODO_PRENNES, TITULO_AVISO_ELIMINAR_MODO_PRENNES, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Utilities.MostrarMessageBox(MENSAJE_ERROR_SELECCION_ELIMINAR_MODO_PRENNES, TITULO_AVISO_ELIMINAR_MODO_PRENNES, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método ausiliar de "botonEliminarModoPrennes_Click", elimina el modo preñes seleccionado por el usuario de la base de datos.
        /// </summary>
        /// <param name="modoPrennes"></param>
        /// <returns></returns>
        private bool EliminarModoPrennes(string modoPrennes)
        {
            DialogResult resultadoDialogo = Utilities.MostrarMessageBox("¿Seguro que desea eliminar el modo preñez seleccionado?. Esta operación no se puede revertir.", TITULO_AVISO_ELIMINAR_RAZA, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultadoDialogo == DialogResult.Yes)
            {
                try
                {
                    int resultado = ProcedimientosAlmacenados.ProcEliminarModoPrennes(modoPrennes);
                    if (resultado == Utilities.RESULTADO_ERROR) return false;
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else return false;
        }

        /// <summary>
        /// Agrega el modo preñes digitado por el usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonAgregarModoPrennes_Click(object sender, EventArgs e)
        {
            if (textBoxModoPrennes.Text != "")
            {
                bool resultado = AgregarNuevoModoPrennes(textBoxModoPrennes.Text);
                if (resultado)
                {
                    Utilities.MostrarMessageBox(Utilities.MENSAJE_EXITO, Utilities.TITULO_EXITO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxModoPrennes.Text = "";
                    LlenarDataGridViewsCRUDS();
                }
                else Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR_ENTRADA_USUARIO, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método ausiliar de "botonAgregarModoPrennes_Click", inserta el modo preñes digitada por el usuario de la base de datos.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private bool AgregarNuevoModoPrennes(string modoPrennes)
        {
            try
            {
                int resultado = ProcedimientosAlmacenados.ProcInsertarModoPrennes(modoPrennes);
                if (resultado == Utilities.RESULTADO_ERROR) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
