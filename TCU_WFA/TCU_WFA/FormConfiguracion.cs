//Hecho por Luis Porras.

using System;
using System.Windows.Forms;

namespace TCU_WFA
{
    public partial class FormConfiguracion : DefaultForm
    {
        //Cosntantes
        private const string ERROR_ARCHIVO_CONFIG = "Error: Archivo de configuración no es válido. La configuración por defecto de la aplicación será cargada.";

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
    }
}
