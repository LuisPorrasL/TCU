namespace TCU_WFA
{
    partial class FormSaltos : DefaultForm
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
            this.labelFechaSalto = new System.Windows.Forms.Label();
            this.labelNumeroTrazableVaca = new System.Windows.Forms.Label();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.groupBoxDestete.SuspendLayout();
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
            // groupBoxDestete
            // 
            this.groupBoxDestete.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.groupBoxDestete.Controls.Add(this.comboBoxNumeroTrazableVaca);
            this.groupBoxDestete.Controls.Add(this.labelFechaSalto);
            this.groupBoxDestete.Controls.Add(this.labelNumeroTrazableVaca);
            this.groupBoxDestete.Location = new System.Drawing.Point(228, 12);
            this.groupBoxDestete.Name = "groupBoxDestete";
            this.groupBoxDestete.Size = new System.Drawing.Size(345, 80);
            this.groupBoxDestete.TabIndex = 2;
            this.groupBoxDestete.TabStop = false;
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(136, 50);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaNacimiento.TabIndex = 9;
            // 
            // comboBoxNumeroTrazableVaca
            // 
            this.comboBoxNumeroTrazableVaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumeroTrazableVaca.FormattingEnabled = true;
            this.comboBoxNumeroTrazableVaca.Location = new System.Drawing.Point(136, 13);
            this.comboBoxNumeroTrazableVaca.Name = "comboBoxNumeroTrazableVaca";
            this.comboBoxNumeroTrazableVaca.Size = new System.Drawing.Size(200, 21);
            this.comboBoxNumeroTrazableVaca.TabIndex = 3;
            // 
            // labelFechaSalto
            // 
            this.labelFechaSalto.AutoSize = true;
            this.labelFechaSalto.Location = new System.Drawing.Point(6, 56);
            this.labelFechaSalto.Name = "labelFechaSalto";
            this.labelFechaSalto.Size = new System.Drawing.Size(79, 13);
            this.labelFechaSalto.TabIndex = 8;
            this.labelFechaSalto.Text = "Fecha del salto";
            // 
            // labelNumeroTrazableVaca
            // 
            this.labelNumeroTrazableVaca.AutoSize = true;
            this.labelNumeroTrazableVaca.Location = new System.Drawing.Point(6, 16);
            this.labelNumeroTrazableVaca.Name = "labelNumeroTrazableVaca";
            this.labelNumeroTrazableVaca.Size = new System.Drawing.Size(84, 13);
            this.labelNumeroTrazableVaca.TabIndex = 2;
            this.labelNumeroTrazableVaca.Text = "Número trazable";
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.Location = new System.Drawing.Point(632, 415);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(75, 23);
            this.botonRegistrar.TabIndex = 10;
            this.botonRegistrar.Text = "Registrar";
            this.botonRegistrar.UseVisualStyleBackColor = true;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click);
            // 
            // FormSaltos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonRegistrar);
            this.Controls.Add(this.groupBoxDestete);
            this.Controls.Add(this.botonVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSaltos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saltos";
            this.Load += new System.EventHandler(this.FormSaltos_Load);
            this.groupBoxDestete.ResumeLayout(false);
            this.groupBoxDestete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.GroupBox groupBoxDestete;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
        private System.Windows.Forms.ComboBox comboBoxNumeroTrazableVaca;
        private System.Windows.Forms.Label labelFechaSalto;
        private System.Windows.Forms.Label labelNumeroTrazableVaca;
        private System.Windows.Forms.Button botonRegistrar;
    }
}