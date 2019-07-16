namespace TCU_WFA
{
    partial class FormParto : DefaultForm
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
            this.groupBoxAgregarVaca = new System.Windows.Forms.GroupBox();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonSi = new System.Windows.Forms.RadioButton();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.textBoxCausaAborto = new System.Windows.Forms.TextBox();
            this.labelCausaAborto = new System.Windows.Forms.Label();
            this.labelMuertePrematura = new System.Windows.Forms.Label();
            this.comboBoxIdPadre = new System.Windows.Forms.ComboBox();
            this.labelIdPadre = new System.Windows.Forms.Label();
            this.comboBoxIdMadre = new System.Windows.Forms.ComboBox();
            this.labelIdMadre = new System.Windows.Forms.Label();
            this.dateTimePickerFechaParto = new System.Windows.Forms.DateTimePicker();
            this.labelFechaParto = new System.Windows.Forms.Label();
            this.labelSexoCria = new System.Windows.Forms.Label();
            this.botonsRegistrar = new System.Windows.Forms.Button();
            this.groupBoxAgregarVaca.SuspendLayout();
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
            // groupBoxAgregarVaca
            // 
            this.groupBoxAgregarVaca.Controls.Add(this.radioButtonNo);
            this.groupBoxAgregarVaca.Controls.Add(this.radioButtonSi);
            this.groupBoxAgregarVaca.Controls.Add(this.comboBoxSexo);
            this.groupBoxAgregarVaca.Controls.Add(this.textBoxCausaAborto);
            this.groupBoxAgregarVaca.Controls.Add(this.labelCausaAborto);
            this.groupBoxAgregarVaca.Controls.Add(this.labelMuertePrematura);
            this.groupBoxAgregarVaca.Controls.Add(this.comboBoxIdPadre);
            this.groupBoxAgregarVaca.Controls.Add(this.labelIdPadre);
            this.groupBoxAgregarVaca.Controls.Add(this.comboBoxIdMadre);
            this.groupBoxAgregarVaca.Controls.Add(this.labelIdMadre);
            this.groupBoxAgregarVaca.Controls.Add(this.dateTimePickerFechaParto);
            this.groupBoxAgregarVaca.Controls.Add(this.labelFechaParto);
            this.groupBoxAgregarVaca.Controls.Add(this.labelSexoCria);
            this.groupBoxAgregarVaca.Location = new System.Drawing.Point(224, 12);
            this.groupBoxAgregarVaca.Name = "groupBoxAgregarVaca";
            this.groupBoxAgregarVaca.Size = new System.Drawing.Size(345, 313);
            this.groupBoxAgregarVaca.TabIndex = 3;
            this.groupBoxAgregarVaca.TabStop = false;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(178, 198);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNo.TabIndex = 18;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonSi
            // 
            this.radioButtonSi.AutoSize = true;
            this.radioButtonSi.Location = new System.Drawing.Point(136, 198);
            this.radioButtonSi.Name = "radioButtonSi";
            this.radioButtonSi.Size = new System.Drawing.Size(36, 17);
            this.radioButtonSi.TabIndex = 17;
            this.radioButtonSi.TabStop = true;
            this.radioButtonSi.Text = "Sí";
            this.radioButtonSi.UseVisualStyleBackColor = true;
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Location = new System.Drawing.Point(136, 67);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(200, 21);
            this.comboBoxSexo.TabIndex = 16;
            // 
            // textBoxCausaAborto
            // 
            this.textBoxCausaAborto.Location = new System.Drawing.Point(100, 247);
            this.textBoxCausaAborto.MinimumSize = new System.Drawing.Size(236, 50);
            this.textBoxCausaAborto.Multiline = true;
            this.textBoxCausaAborto.Name = "textBoxCausaAborto";
            this.textBoxCausaAborto.Size = new System.Drawing.Size(236, 50);
            this.textBoxCausaAborto.TabIndex = 15;
            // 
            // labelCausaAborto
            // 
            this.labelCausaAborto.AutoSize = true;
            this.labelCausaAborto.Location = new System.Drawing.Point(6, 250);
            this.labelCausaAborto.Name = "labelCausaAborto";
            this.labelCausaAborto.Size = new System.Drawing.Size(70, 13);
            this.labelCausaAborto.TabIndex = 14;
            this.labelCausaAborto.Text = "Causa aborto";
            // 
            // labelMuertePrematura
            // 
            this.labelMuertePrematura.AutoSize = true;
            this.labelMuertePrematura.Location = new System.Drawing.Point(6, 200);
            this.labelMuertePrematura.Name = "labelMuertePrematura";
            this.labelMuertePrematura.Size = new System.Drawing.Size(91, 13);
            this.labelMuertePrematura.TabIndex = 12;
            this.labelMuertePrematura.Text = "Muete prematura*";
            // 
            // comboBoxIdPadre
            // 
            this.comboBoxIdPadre.FormattingEnabled = true;
            this.comboBoxIdPadre.Location = new System.Drawing.Point(136, 156);
            this.comboBoxIdPadre.Name = "comboBoxIdPadre";
            this.comboBoxIdPadre.Size = new System.Drawing.Size(200, 21);
            this.comboBoxIdPadre.TabIndex = 11;
            // 
            // labelIdPadre
            // 
            this.labelIdPadre.AutoSize = true;
            this.labelIdPadre.Location = new System.Drawing.Point(6, 159);
            this.labelIdPadre.Name = "labelIdPadre";
            this.labelIdPadre.Size = new System.Drawing.Size(46, 13);
            this.labelIdPadre.TabIndex = 10;
            this.labelIdPadre.Text = "Id padre";
            // 
            // comboBoxIdMadre
            // 
            this.comboBoxIdMadre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdMadre.FormattingEnabled = true;
            this.comboBoxIdMadre.Location = new System.Drawing.Point(136, 113);
            this.comboBoxIdMadre.Name = "comboBoxIdMadre";
            this.comboBoxIdMadre.Size = new System.Drawing.Size(200, 21);
            this.comboBoxIdMadre.TabIndex = 9;
            // 
            // labelIdMadre
            // 
            this.labelIdMadre.AutoSize = true;
            this.labelIdMadre.Location = new System.Drawing.Point(6, 116);
            this.labelIdMadre.Name = "labelIdMadre";
            this.labelIdMadre.Size = new System.Drawing.Size(52, 13);
            this.labelIdMadre.TabIndex = 8;
            this.labelIdMadre.Text = "Id madre*";
            // 
            // dateTimePickerFechaParto
            // 
            this.dateTimePickerFechaParto.Location = new System.Drawing.Point(136, 19);
            this.dateTimePickerFechaParto.Name = "dateTimePickerFechaParto";
            this.dateTimePickerFechaParto.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaParto.TabIndex = 7;
            // 
            // labelFechaParto
            // 
            this.labelFechaParto.AutoSize = true;
            this.labelFechaParto.Location = new System.Drawing.Point(6, 25);
            this.labelFechaParto.Name = "labelFechaParto";
            this.labelFechaParto.Size = new System.Drawing.Size(68, 13);
            this.labelFechaParto.TabIndex = 6;
            this.labelFechaParto.Text = "Fecha parto*";
            // 
            // labelSexoCria
            // 
            this.labelSexoCria.AutoSize = true;
            this.labelSexoCria.Location = new System.Drawing.Point(6, 70);
            this.labelSexoCria.Name = "labelSexoCria";
            this.labelSexoCria.Size = new System.Drawing.Size(57, 13);
            this.labelSexoCria.TabIndex = 4;
            this.labelSexoCria.Text = "Sexo cría*";
            // 
            // botonsRegistrar
            // 
            this.botonsRegistrar.Location = new System.Drawing.Point(632, 415);
            this.botonsRegistrar.Name = "botonsRegistrar";
            this.botonsRegistrar.Size = new System.Drawing.Size(75, 23);
            this.botonsRegistrar.TabIndex = 4;
            this.botonsRegistrar.Text = "Registrar";
            this.botonsRegistrar.UseVisualStyleBackColor = true;
            this.botonsRegistrar.Click += new System.EventHandler(this.botonsRegistrar_Click);
            // 
            // FormParto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonsRegistrar);
            this.Controls.Add(this.groupBoxAgregarVaca);
            this.Controls.Add(this.botonVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormParto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parto";
            this.Load += new System.EventHandler(this.FormParto_Load);
            this.groupBoxAgregarVaca.ResumeLayout(false);
            this.groupBoxAgregarVaca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.GroupBox groupBoxAgregarVaca;
        private System.Windows.Forms.TextBox textBoxCausaAborto;
        private System.Windows.Forms.Label labelCausaAborto;
        private System.Windows.Forms.Label labelMuertePrematura;
        private System.Windows.Forms.ComboBox comboBoxIdPadre;
        private System.Windows.Forms.Label labelIdPadre;
        private System.Windows.Forms.ComboBox comboBoxIdMadre;
        private System.Windows.Forms.Label labelIdMadre;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaParto;
        private System.Windows.Forms.Label labelFechaParto;
        private System.Windows.Forms.Label labelSexoCria;
        protected internal System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonSi;
        private System.Windows.Forms.Button botonsRegistrar;
    }
}