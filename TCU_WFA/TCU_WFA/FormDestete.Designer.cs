namespace TCU_WFA
{
    partial class FormDestete : DefaultForm
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
            this.groupBoxDestete = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.comboBoxNumeroTrazableVaca = new System.Windows.Forms.ComboBox();
            this.labelFechaDestete = new System.Windows.Forms.Label();
            this.labelNumeroTrazableVaca = new System.Windows.Forms.Label();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.groupBoxDestete.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(951, 511);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(100, 28);
            this.botonVolver.TabIndex = 0;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // groupBoxDestete
            // 
            this.groupBoxDestete.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.groupBoxDestete.Controls.Add(this.comboBoxNumeroTrazableVaca);
            this.groupBoxDestete.Controls.Add(this.labelFechaDestete);
            this.groupBoxDestete.Controls.Add(this.labelNumeroTrazableVaca);
            this.groupBoxDestete.Location = new System.Drawing.Point(304, 15);
            this.groupBoxDestete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDestete.Name = "groupBoxDestete";
            this.groupBoxDestete.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDestete.Size = new System.Drawing.Size(460, 98);
            this.groupBoxDestete.TabIndex = 1;
            this.groupBoxDestete.TabStop = false;
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(181, 62);
            this.dateTimePickerFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerFechaNacimiento.TabIndex = 9;
            // 
            // comboBoxNumeroTrazableVaca
            // 
            this.comboBoxNumeroTrazableVaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumeroTrazableVaca.FormattingEnabled = true;
            this.comboBoxNumeroTrazableVaca.Location = new System.Drawing.Point(181, 16);
            this.comboBoxNumeroTrazableVaca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxNumeroTrazableVaca.Name = "comboBoxNumeroTrazableVaca";
            this.comboBoxNumeroTrazableVaca.Size = new System.Drawing.Size(265, 24);
            this.comboBoxNumeroTrazableVaca.TabIndex = 3;
            // 
            // labelFechaDestete
            // 
            this.labelFechaDestete.AutoSize = true;
            this.labelFechaDestete.Location = new System.Drawing.Point(8, 69);
            this.labelFechaDestete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaDestete.Name = "labelFechaDestete";
            this.labelFechaDestete.Size = new System.Drawing.Size(118, 17);
            this.labelFechaDestete.TabIndex = 8;
            this.labelFechaDestete.Text = "Fecha de destete";
            // 
            // labelNumeroTrazableVaca
            // 
            this.labelNumeroTrazableVaca.AutoSize = true;
            this.labelNumeroTrazableVaca.Location = new System.Drawing.Point(8, 20);
            this.labelNumeroTrazableVaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumeroTrazableVaca.Name = "labelNumeroTrazableVaca";
            this.labelNumeroTrazableVaca.Size = new System.Drawing.Size(113, 17);
            this.labelNumeroTrazableVaca.TabIndex = 2;
            this.labelNumeroTrazableVaca.Text = "Número trazable";
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.Location = new System.Drawing.Point(843, 511);
            this.botonRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(100, 28);
            this.botonRegistrar.TabIndex = 2;
            this.botonRegistrar.Text = "Registrar";
            this.botonRegistrar.UseVisualStyleBackColor = true;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click);
            // 
            // FormDestete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.botonRegistrar);
            this.Controls.Add(this.groupBoxDestete);
            this.Controls.Add(this.botonVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormDestete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Destete";
            this.Load += new System.EventHandler(this.FormDestete_Load);
            this.groupBoxDestete.ResumeLayout(false);
            this.groupBoxDestete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.GroupBox groupBoxDestete;
        private System.Windows.Forms.Label labelNumeroTrazableVaca;
        private System.Windows.Forms.ComboBox comboBoxNumeroTrazableVaca;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
        private System.Windows.Forms.Label labelFechaDestete;
        private System.Windows.Forms.Button botonRegistrar;
    }
}