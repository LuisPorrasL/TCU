namespace TCU_WFA
{
    partial class FormConfiguracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonVolver = new System.Windows.Forms.Button();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.numericUpDownParto = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAlertaPalpacion = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAlertaIEP = new System.Windows.Forms.NumericUpDown();
            this.comboBoxUnidadDeTiempo = new System.Windows.Forms.ComboBox();
            this.labelAlertaParto = new System.Windows.Forms.Label();
            this.labelAlertaPalpacion = new System.Windows.Forms.Label();
            this.labelAlertaIEP = new System.Windows.Forms.Label();
            this.labelUnidadDeTiempo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.tabPageGeneral.SuspendLayout();
            this.groupBoxGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlertaPalpacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlertaIEP)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(713, 415);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 0;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.groupBoxGeneral);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(792, 383);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Controls.Add(this.numericUpDownParto);
            this.groupBoxGeneral.Controls.Add(this.numericUpDownAlertaPalpacion);
            this.groupBoxGeneral.Controls.Add(this.numericUpDownAlertaIEP);
            this.groupBoxGeneral.Controls.Add(this.comboBoxUnidadDeTiempo);
            this.groupBoxGeneral.Controls.Add(this.labelAlertaParto);
            this.groupBoxGeneral.Controls.Add(this.labelAlertaPalpacion);
            this.groupBoxGeneral.Controls.Add(this.labelAlertaIEP);
            this.groupBoxGeneral.Controls.Add(this.labelUnidadDeTiempo);
            this.groupBoxGeneral.Location = new System.Drawing.Point(9, 6);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(776, 371);
            this.groupBoxGeneral.TabIndex = 0;
            this.groupBoxGeneral.TabStop = false;
            // 
            // numericUpDownParto
            // 
            this.numericUpDownParto.Location = new System.Drawing.Point(341, 130);
            this.numericUpDownParto.Name = "numericUpDownParto";
            this.numericUpDownParto.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownParto.TabIndex = 9;
            // 
            // numericUpDownAlertaPalpacion
            // 
            this.numericUpDownAlertaPalpacion.Location = new System.Drawing.Point(341, 93);
            this.numericUpDownAlertaPalpacion.Name = "numericUpDownAlertaPalpacion";
            this.numericUpDownAlertaPalpacion.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAlertaPalpacion.TabIndex = 8;
            // 
            // numericUpDownAlertaIEP
            // 
            this.numericUpDownAlertaIEP.Location = new System.Drawing.Point(340, 50);
            this.numericUpDownAlertaIEP.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownAlertaIEP.Name = "numericUpDownAlertaIEP";
            this.numericUpDownAlertaIEP.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAlertaIEP.TabIndex = 6;
            // 
            // comboBoxUnidadDeTiempo
            // 
            this.comboBoxUnidadDeTiempo.FormattingEnabled = true;
            this.comboBoxUnidadDeTiempo.Location = new System.Drawing.Point(340, 13);
            this.comboBoxUnidadDeTiempo.Name = "comboBoxUnidadDeTiempo";
            this.comboBoxUnidadDeTiempo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUnidadDeTiempo.TabIndex = 5;
            // 
            // labelAlertaParto
            // 
            this.labelAlertaParto.AutoSize = true;
            this.labelAlertaParto.Location = new System.Drawing.Point(7, 132);
            this.labelAlertaParto.Name = "labelAlertaParto";
            this.labelAlertaParto.Size = new System.Drawing.Size(267, 13);
            this.labelAlertaParto.TabIndex = 4;
            this.labelAlertaParto.Text = "Cantidad de días antes de un parto para mostrar alerta:";
            // 
            // labelAlertaPalpacion
            // 
            this.labelAlertaPalpacion.AutoSize = true;
            this.labelAlertaPalpacion.Location = new System.Drawing.Point(7, 95);
            this.labelAlertaPalpacion.Name = "labelAlertaPalpacion";
            this.labelAlertaPalpacion.Size = new System.Drawing.Size(285, 13);
            this.labelAlertaPalpacion.TabIndex = 3;
            this.labelAlertaPalpacion.Text = "Cantidad de días antes de la palpación para mostrar alerta:";
            // 
            // labelAlertaIEP
            // 
            this.labelAlertaIEP.AutoSize = true;
            this.labelAlertaIEP.Location = new System.Drawing.Point(6, 52);
            this.labelAlertaIEP.Name = "labelAlertaIEP";
            this.labelAlertaIEP.Size = new System.Drawing.Size(279, 13);
            this.labelAlertaIEP.TabIndex = 1;
            this.labelAlertaIEP.Text = "Valor máximo aceptable del IEP (días) para mostrar alerta:";
            // 
            // labelUnidadDeTiempo
            // 
            this.labelUnidadDeTiempo.AutoSize = true;
            this.labelUnidadDeTiempo.Location = new System.Drawing.Point(6, 16);
            this.labelUnidadDeTiempo.Name = "labelUnidadDeTiempo";
            this.labelUnidadDeTiempo.Size = new System.Drawing.Size(255, 13);
            this.labelUnidadDeTiempo.TabIndex = 0;
            this.labelUnidadDeTiempo.Text = "Unidad de tiempo para los parámetros reproductivos:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGeneral);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 409);
            this.tabControl1.TabIndex = 1;
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(632, 415);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 2;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // FormConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.botonVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.FormConfiguracion_Load);
            this.tabPageGeneral.ResumeLayout(false);
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlertaPalpacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlertaIEP)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Label labelUnidadDeTiempo;
        private System.Windows.Forms.Label labelAlertaParto;
        private System.Windows.Forms.Label labelAlertaPalpacion;
        private System.Windows.Forms.Label labelAlertaIEP;
        private System.Windows.Forms.NumericUpDown numericUpDownParto;
        private System.Windows.Forms.NumericUpDown numericUpDownAlertaPalpacion;
        private System.Windows.Forms.NumericUpDown numericUpDownAlertaIEP;
        private System.Windows.Forms.ComboBox comboBoxUnidadDeTiempo;
    }
}