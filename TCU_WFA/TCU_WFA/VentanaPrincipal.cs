// Hecho por Luis Porras.
using System;
using System.Windows.Forms;

namespace TCU_WFA
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void botonRegistroVacas_Click(object sender, EventArgs e)
        {
            FormRegistroVacas form = new FormRegistroVacas();
            form.Tag = this;
            form.Show(this);
            Hide();
        }

        private void botonParto_Click(object sender, EventArgs e)
        {
            FormParto form = new FormParto();
            form.Tag = this;
            form.Show(this);
            Hide();
        }

        private void botonPalpacion_Click(object sender, EventArgs e)
        {
            FormPalpacion form = new FormPalpacion();
            form.Tag = this;
            form.Show(this);
            Hide();
        }

        private void botonSalto_Click(object sender, EventArgs e)
        {
            FormSaltos form = new FormSaltos();
            form.Tag = this;
            form.Show(this);
            Hide();
        }

        private void botonDestete_Click(object sender, EventArgs e)
        {
            FormDestete form = new FormDestete();
            form.Tag = this;
            form.Show(this);
            Hide();
        }

        private void botonRegistroToros_Click(object sender, EventArgs e)
        {
            FormRegistroToros form = new FormRegistroToros();
            form.Tag = this;
            form.Show(this);
            Hide();
        }

        private void botonExamenAndrologico_Click(object sender, EventArgs e)
        {
            FormExamenAndrologico form = new FormExamenAndrologico();
            form.Tag = this;
            form.Show(this);
            Hide();
        }

        private void botonSincronizacion_Click(object sender, EventArgs e)
        {
            FormSincronizacion form = new FormSincronizacion();
            form.Tag = this;
            form.Show(this);
            Hide();
        }

        private void botonResumen_Click(object sender, EventArgs e)
        {
            FormResumen form = new FormResumen();
            form.Tag = this;
            form.Show(this);
            Hide();
        }

        private void botonGraficos_Click(object sender, EventArgs e)
        {
            FormGraficos form = new FormGraficos();
            form.Tag = this;
            form.Show(this);
            Hide();
        }

        private void botonConfiguracion_Click(object sender, EventArgs e)
        {
            FormConfiguracion form = new FormConfiguracion();
            form.Tag = this;
            form.Show(this);
            Hide();
        }
    }
}
