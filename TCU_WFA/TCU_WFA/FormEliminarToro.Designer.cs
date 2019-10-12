namespace TCU_WFA
{
    partial class FormEliminarToro : DefaultForm
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
            this.textBoxCausaDeBaja = new System.Windows.Forms.TextBox();
            this.comboBoxNumeroTrazableToro = new System.Windows.Forms.ComboBox();
            this.labelCausaDeBaja = new System.Windows.Forms.Label();
            this.labelNumeroTrazableToro = new System.Windows.Forms.Label();
            this.botonDarDeBaja = new System.Windows.Forms.Button();
            this.groupBoxDestete.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(713, 415);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 3;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // groupBoxDestete
            // 
            this.groupBoxDestete.Controls.Add(this.textBoxCausaDeBaja);
            this.groupBoxDestete.Controls.Add(this.comboBoxNumeroTrazableToro);
            this.groupBoxDestete.Controls.Add(this.labelCausaDeBaja);
            this.groupBoxDestete.Controls.Add(this.labelNumeroTrazableToro);
            this.groupBoxDestete.Location = new System.Drawing.Point(228, 12);
            this.groupBoxDestete.Name = "groupBoxDestete";
            this.groupBoxDestete.Size = new System.Drawing.Size(345, 143);
            this.groupBoxDestete.TabIndex = 4;
            this.groupBoxDestete.TabStop = false;
            // 
            // textBoxCausaDeBaja
            // 
            this.textBoxCausaDeBaja.Location = new System.Drawing.Point(100, 53);
            this.textBoxCausaDeBaja.MinimumSize = new System.Drawing.Size(236, 50);
            this.textBoxCausaDeBaja.Multiline = true;
            this.textBoxCausaDeBaja.Name = "textBoxCausaDeBaja";
            this.textBoxCausaDeBaja.Size = new System.Drawing.Size(236, 81);
            this.textBoxCausaDeBaja.TabIndex = 16;
            // 
            // comboBoxNumeroTrazableToro
            // 
            this.comboBoxNumeroTrazableToro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumeroTrazableToro.FormattingEnabled = true;
            this.comboBoxNumeroTrazableToro.Location = new System.Drawing.Point(136, 13);
            this.comboBoxNumeroTrazableToro.Name = "comboBoxNumeroTrazableToro";
            this.comboBoxNumeroTrazableToro.Size = new System.Drawing.Size(200, 21);
            this.comboBoxNumeroTrazableToro.TabIndex = 3;
            // 
            // labelCausaDeBaja
            // 
            this.labelCausaDeBaja.AutoSize = true;
            this.labelCausaDeBaja.Location = new System.Drawing.Point(6, 56);
            this.labelCausaDeBaja.Name = "labelCausaDeBaja";
            this.labelCausaDeBaja.Size = new System.Drawing.Size(79, 13);
            this.labelCausaDeBaja.TabIndex = 8;
            this.labelCausaDeBaja.Text = "Causa de baja*";
            // 
            // labelNumeroTrazableToro
            // 
            this.labelNumeroTrazableToro.AutoSize = true;
            this.labelNumeroTrazableToro.Location = new System.Drawing.Point(6, 16);
            this.labelNumeroTrazableToro.Name = "labelNumeroTrazableToro";
            this.labelNumeroTrazableToro.Size = new System.Drawing.Size(84, 13);
            this.labelNumeroTrazableToro.TabIndex = 2;
            this.labelNumeroTrazableToro.Text = "Número trazable";
            // 
            // botonDarDeBaja
            // 
            this.botonDarDeBaja.Location = new System.Drawing.Point(632, 415);
            this.botonDarDeBaja.Name = "botonDarDeBaja";
            this.botonDarDeBaja.Size = new System.Drawing.Size(75, 23);
            this.botonDarDeBaja.TabIndex = 5;
            this.botonDarDeBaja.Text = "Dar de baja";
            this.botonDarDeBaja.UseVisualStyleBackColor = true;
            this.botonDarDeBaja.Click += new System.EventHandler(this.botonDarDeBaja_Click);
            // 
            // FormEliminarToro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonDarDeBaja);
            this.Controls.Add(this.groupBoxDestete);
            this.Controls.Add(this.botonVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEliminarToro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEliminarToro";
            this.Load += new System.EventHandler(this.FormEliminarToro_Load);
            this.groupBoxDestete.ResumeLayout(false);
            this.groupBoxDestete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.GroupBox groupBoxDestete;
        private System.Windows.Forms.TextBox textBoxCausaDeBaja;
        private System.Windows.Forms.ComboBox comboBoxNumeroTrazableToro;
        private System.Windows.Forms.Label labelCausaDeBaja;
        private System.Windows.Forms.Label labelNumeroTrazableToro;
        private System.Windows.Forms.Button botonDarDeBaja;
    }
}