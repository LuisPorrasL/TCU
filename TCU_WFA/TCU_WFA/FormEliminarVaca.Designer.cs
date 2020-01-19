namespace TCU_WFA
{
    partial class FormEliminarVaca : DefaultForm
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
            this.dateTimePickerFechaDeBaja = new System.Windows.Forms.DateTimePicker();
            this.labelFechaBaja = new System.Windows.Forms.Label();
            this.textBoxCausaDeBaja = new System.Windows.Forms.TextBox();
            this.comboBoxNumeroTrazableVaca = new System.Windows.Forms.ComboBox();
            this.labelCausaDeBaja = new System.Windows.Forms.Label();
            this.labelNumeroTrazableVaca = new System.Windows.Forms.Label();
            this.botonDarDeBaja = new System.Windows.Forms.Button();
            this.groupBoxDestete.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(713, 415);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 1;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // groupBoxDestete
            // 
            this.groupBoxDestete.Controls.Add(this.dateTimePickerFechaDeBaja);
            this.groupBoxDestete.Controls.Add(this.labelFechaBaja);
            this.groupBoxDestete.Controls.Add(this.textBoxCausaDeBaja);
            this.groupBoxDestete.Controls.Add(this.comboBoxNumeroTrazableVaca);
            this.groupBoxDestete.Controls.Add(this.labelCausaDeBaja);
            this.groupBoxDestete.Controls.Add(this.labelNumeroTrazableVaca);
            this.groupBoxDestete.Location = new System.Drawing.Point(228, 12);
            this.groupBoxDestete.Name = "groupBoxDestete";
            this.groupBoxDestete.Size = new System.Drawing.Size(345, 203);
            this.groupBoxDestete.TabIndex = 3;
            this.groupBoxDestete.TabStop = false;
            // 
            // dateTimePickerFechaDeBaja
            // 
            this.dateTimePickerFechaDeBaja.Location = new System.Drawing.Point(136, 55);
            this.dateTimePickerFechaDeBaja.Name = "dateTimePickerFechaDeBaja";
            this.dateTimePickerFechaDeBaja.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaDeBaja.TabIndex = 18;
            // 
            // labelFechaBaja
            // 
            this.labelFechaBaja.AutoSize = true;
            this.labelFechaBaja.Location = new System.Drawing.Point(9, 57);
            this.labelFechaBaja.Name = "labelFechaBaja";
            this.labelFechaBaja.Size = new System.Drawing.Size(79, 13);
            this.labelFechaBaja.TabIndex = 17;
            this.labelFechaBaja.Text = "Fecha de baja*";
            // 
            // textBoxCausaDeBaja
            // 
            this.textBoxCausaDeBaja.Location = new System.Drawing.Point(100, 101);
            this.textBoxCausaDeBaja.MinimumSize = new System.Drawing.Size(236, 50);
            this.textBoxCausaDeBaja.Multiline = true;
            this.textBoxCausaDeBaja.Name = "textBoxCausaDeBaja";
            this.textBoxCausaDeBaja.Size = new System.Drawing.Size(236, 81);
            this.textBoxCausaDeBaja.TabIndex = 16;
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
            // labelCausaDeBaja
            // 
            this.labelCausaDeBaja.AutoSize = true;
            this.labelCausaDeBaja.Location = new System.Drawing.Point(6, 104);
            this.labelCausaDeBaja.Name = "labelCausaDeBaja";
            this.labelCausaDeBaja.Size = new System.Drawing.Size(79, 13);
            this.labelCausaDeBaja.TabIndex = 8;
            this.labelCausaDeBaja.Text = "Causa de baja*";
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
            // botonDarDeBaja
            // 
            this.botonDarDeBaja.Location = new System.Drawing.Point(632, 415);
            this.botonDarDeBaja.Name = "botonDarDeBaja";
            this.botonDarDeBaja.Size = new System.Drawing.Size(75, 23);
            this.botonDarDeBaja.TabIndex = 4;
            this.botonDarDeBaja.Text = "Dar de baja";
            this.botonDarDeBaja.UseVisualStyleBackColor = true;
            this.botonDarDeBaja.Click += new System.EventHandler(this.botonDarDeBaja_Click);
            // 
            // FormEliminarVaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonDarDeBaja);
            this.Controls.Add(this.groupBoxDestete);
            this.Controls.Add(this.botonVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEliminarVaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEliminarVaca";
            this.Load += new System.EventHandler(this.FormEliminarVaca_Load);
            this.groupBoxDestete.ResumeLayout(false);
            this.groupBoxDestete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.GroupBox groupBoxDestete;
        private System.Windows.Forms.Label labelCausaDeBaja;
        private System.Windows.Forms.Label labelNumeroTrazableVaca;
        private System.Windows.Forms.ComboBox comboBoxNumeroTrazableVaca;
        private System.Windows.Forms.TextBox textBoxCausaDeBaja;
        private System.Windows.Forms.Button botonDarDeBaja;
        private System.Windows.Forms.Label labelFechaBaja;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDeBaja;
    }
}