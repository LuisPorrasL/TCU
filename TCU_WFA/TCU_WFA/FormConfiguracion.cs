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
        //Cosntantes
        private const string ERROR_ARCHIVO_CONFIG = "Error: Archivo de configuración no es válido. La configuración por defecto de la aplicación será cargada.";

        //Campos
        ProgramConfiguration config;

        public FormConfiguracion()
        {
            InitializeComponent();
            config = new ProgramConfiguration();
        }

        private void FormConfiguracion_Load(object sender, EventArgs e)
        {
            LlenarComboBoxUnidadDeTiempo();
            CargarConfiguracionActual();
        }

        private void LlenarComboBoxUnidadDeTiempo()
        {
            comboBoxUnidadDeTiempo.DisplayMember = "unidadDeTiempo";
            comboBoxUnidadDeTiempo.ValueMember = "id";
            comboBoxUnidadDeTiempo.Items.Add(new { unidadDeTiempo = "Días", id = "Días" });
            comboBoxUnidadDeTiempo.Items.Add(new { unidadDeTiempo = "Semanas", id = "Semanas" });
            comboBoxUnidadDeTiempo.Items.Add(new { unidadDeTiempo = "Meses", id = "Meses" });
            comboBoxUnidadDeTiempo.SelectedIndex = 0;
        }

        private void CargarConfiguracionActual()
        {
            int indiceUnidadDeTiempo = comboBoxUnidadDeTiempo.FindString(config.ObtenerConfig(ProgramConfiguration.LLAVE_UNIDAD_DE_TIEMPO));
            comboBoxUnidadDeTiempo.SelectedIndex = indiceUnidadDeTiempo;
            numericUpDownAlertaIEP.Value = Int32.Parse(config.ObtenerConfig(ProgramConfiguration.LLAVE_ALERTA_IEP));
            numericUpDownAlertaPalpacion.Value = Int32.Parse(config.ObtenerConfig(ProgramConfiguration.LLAVE_ALERTA_PALPACION));
            numericUpDownParto.Value = Int32.Parse(config.ObtenerConfig(ProgramConfiguration.LLAVE_ALERTA_PARTO));
        }

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
