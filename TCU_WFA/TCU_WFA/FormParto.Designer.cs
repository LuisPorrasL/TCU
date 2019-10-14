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
            this.groupBoxRegistroTernero = new System.Windows.Forms.GroupBox();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.textBoxNumeroTrazableTernero = new System.Windows.Forms.TextBox();
            this.labelPeso = new System.Windows.Forms.Label();
            this.labelNumeroTrazableTernero = new System.Windows.Forms.Label();
            this.comboBoxRaza = new System.Windows.Forms.ComboBox();
            this.labelRaza = new System.Windows.Forms.Label();
            this.textBoxCaracteristicasTernero = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCaracteristicasTernero = new System.Windows.Forms.Label();
            this.labelRegistrarTernero = new System.Windows.Forms.Label();
            this.radioButtonSiRegistroTernero = new System.Windows.Forms.RadioButton();
            this.radioButtonNoRegistroTernero = new System.Windows.Forms.RadioButton();
            this.groupBoxAgregarVaca.SuspendLayout();
            this.groupBoxRegistroTernero.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(951, 511);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(4);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(100, 28);
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
            this.groupBoxAgregarVaca.Location = new System.Drawing.Point(16, 15);
            this.groupBoxAgregarVaca.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAgregarVaca.Name = "groupBoxAgregarVaca";
            this.groupBoxAgregarVaca.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAgregarVaca.Size = new System.Drawing.Size(460, 359);
            this.groupBoxAgregarVaca.TabIndex = 3;
            this.groupBoxAgregarVaca.TabStop = false;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(233, 235);
            this.radioButtonNo.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(47, 21);
            this.radioButtonNo.TabIndex = 18;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            this.radioButtonNo.CheckedChanged += new System.EventHandler(this.radioButtonNo_CheckedChanged);
            // 
            // radioButtonSi
            // 
            this.radioButtonSi.AutoSize = true;
            this.radioButtonSi.Location = new System.Drawing.Point(177, 235);
            this.radioButtonSi.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonSi.Name = "radioButtonSi";
            this.radioButtonSi.Size = new System.Drawing.Size(41, 21);
            this.radioButtonSi.TabIndex = 17;
            this.radioButtonSi.TabStop = true;
            this.radioButtonSi.Text = "Sí";
            this.radioButtonSi.UseVisualStyleBackColor = true;
            this.radioButtonSi.CheckedChanged += new System.EventHandler(this.radioButtonSi_CheckedChanged);
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Location = new System.Drawing.Point(181, 76);
            this.comboBoxSexo.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(265, 24);
            this.comboBoxSexo.TabIndex = 16;
            // 
            // textBoxCausaAborto
            // 
            this.textBoxCausaAborto.Location = new System.Drawing.Point(133, 284);
            this.textBoxCausaAborto.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCausaAborto.MinimumSize = new System.Drawing.Size(313, 61);
            this.textBoxCausaAborto.Multiline = true;
            this.textBoxCausaAborto.Name = "textBoxCausaAborto";
            this.textBoxCausaAborto.Size = new System.Drawing.Size(313, 61);
            this.textBoxCausaAborto.TabIndex = 15;
            // 
            // labelCausaAborto
            // 
            this.labelCausaAborto.AutoSize = true;
            this.labelCausaAborto.Location = new System.Drawing.Point(8, 288);
            this.labelCausaAborto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCausaAborto.Name = "labelCausaAborto";
            this.labelCausaAborto.Size = new System.Drawing.Size(93, 17);
            this.labelCausaAborto.TabIndex = 14;
            this.labelCausaAborto.Text = "Causa aborto";
            // 
            // labelMuertePrematura
            // 
            this.labelMuertePrematura.AutoSize = true;
            this.labelMuertePrematura.Location = new System.Drawing.Point(4, 238);
            this.labelMuertePrematura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMuertePrematura.Name = "labelMuertePrematura";
            this.labelMuertePrematura.Size = new System.Drawing.Size(121, 17);
            this.labelMuertePrematura.TabIndex = 12;
            this.labelMuertePrematura.Text = "Muete prematura*";
            // 
            // comboBoxIdPadre
            // 
            this.comboBoxIdPadre.FormattingEnabled = true;
            this.comboBoxIdPadre.Location = new System.Drawing.Point(181, 175);
            this.comboBoxIdPadre.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxIdPadre.Name = "comboBoxIdPadre";
            this.comboBoxIdPadre.Size = new System.Drawing.Size(265, 24);
            this.comboBoxIdPadre.TabIndex = 11;
            this.comboBoxIdPadre.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdPadre_SelectedIndexChanged);
            // 
            // labelIdPadre
            // 
            this.labelIdPadre.AutoSize = true;
            this.labelIdPadre.Location = new System.Drawing.Point(8, 178);
            this.labelIdPadre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIdPadre.Name = "labelIdPadre";
            this.labelIdPadre.Size = new System.Drawing.Size(60, 17);
            this.labelIdPadre.TabIndex = 10;
            this.labelIdPadre.Text = "Id padre";
            // 
            // comboBoxIdMadre
            // 
            this.comboBoxIdMadre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdMadre.FormattingEnabled = true;
            this.comboBoxIdMadre.Location = new System.Drawing.Point(181, 122);
            this.comboBoxIdMadre.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxIdMadre.Name = "comboBoxIdMadre";
            this.comboBoxIdMadre.Size = new System.Drawing.Size(265, 24);
            this.comboBoxIdMadre.TabIndex = 9;
            // 
            // labelIdMadre
            // 
            this.labelIdMadre.AutoSize = true;
            this.labelIdMadre.Location = new System.Drawing.Point(8, 126);
            this.labelIdMadre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIdMadre.Name = "labelIdMadre";
            this.labelIdMadre.Size = new System.Drawing.Size(68, 17);
            this.labelIdMadre.TabIndex = 8;
            this.labelIdMadre.Text = "Id madre*";
            // 
            // dateTimePickerFechaParto
            // 
            this.dateTimePickerFechaParto.Location = new System.Drawing.Point(181, 23);
            this.dateTimePickerFechaParto.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFechaParto.Name = "dateTimePickerFechaParto";
            this.dateTimePickerFechaParto.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerFechaParto.TabIndex = 7;
            // 
            // labelFechaParto
            // 
            this.labelFechaParto.AutoSize = true;
            this.labelFechaParto.Location = new System.Drawing.Point(8, 31);
            this.labelFechaParto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaParto.Name = "labelFechaParto";
            this.labelFechaParto.Size = new System.Drawing.Size(89, 17);
            this.labelFechaParto.TabIndex = 6;
            this.labelFechaParto.Text = "Fecha parto*";
            // 
            // labelSexoCria
            // 
            this.labelSexoCria.AutoSize = true;
            this.labelSexoCria.Location = new System.Drawing.Point(8, 80);
            this.labelSexoCria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSexoCria.Name = "labelSexoCria";
            this.labelSexoCria.Size = new System.Drawing.Size(71, 17);
            this.labelSexoCria.TabIndex = 4;
            this.labelSexoCria.Text = "Sexo cría*";
            // 
            // botonsRegistrar
            // 
            this.botonsRegistrar.Location = new System.Drawing.Point(843, 511);
            this.botonsRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.botonsRegistrar.Name = "botonsRegistrar";
            this.botonsRegistrar.Size = new System.Drawing.Size(100, 28);
            this.botonsRegistrar.TabIndex = 4;
            this.botonsRegistrar.Text = "Registrar";
            this.botonsRegistrar.UseVisualStyleBackColor = true;
            this.botonsRegistrar.Click += new System.EventHandler(this.botonsRegistrar_Click);
            // 
            // groupBoxRegistroTernero
            // 
            this.groupBoxRegistroTernero.Controls.Add(this.textBoxPeso);
            this.groupBoxRegistroTernero.Controls.Add(this.textBoxNumeroTrazableTernero);
            this.groupBoxRegistroTernero.Controls.Add(this.labelPeso);
            this.groupBoxRegistroTernero.Controls.Add(this.labelNumeroTrazableTernero);
            this.groupBoxRegistroTernero.Controls.Add(this.comboBoxRaza);
            this.groupBoxRegistroTernero.Controls.Add(this.labelRaza);
            this.groupBoxRegistroTernero.Controls.Add(this.textBoxCaracteristicasTernero);
            this.groupBoxRegistroTernero.Controls.Add(this.textBoxNombre);
            this.groupBoxRegistroTernero.Controls.Add(this.labelNombre);
            this.groupBoxRegistroTernero.Controls.Add(this.labelCaracteristicasTernero);
            this.groupBoxRegistroTernero.Location = new System.Drawing.Point(591, 70);
            this.groupBoxRegistroTernero.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxRegistroTernero.Name = "groupBoxRegistroTernero";
            this.groupBoxRegistroTernero.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxRegistroTernero.Size = new System.Drawing.Size(460, 304);
            this.groupBoxRegistroTernero.TabIndex = 19;
            this.groupBoxRegistroTernero.TabStop = false;
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(185, 154);
            this.textBoxPeso.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(265, 22);
            this.textBoxPeso.TabIndex = 26;
            // 
            // textBoxNumeroTrazableTernero
            // 
            this.textBoxNumeroTrazableTernero.Location = new System.Drawing.Point(185, 22);
            this.textBoxNumeroTrazableTernero.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumeroTrazableTernero.Name = "textBoxNumeroTrazableTernero";
            this.textBoxNumeroTrazableTernero.Size = new System.Drawing.Size(265, 22);
            this.textBoxNumeroTrazableTernero.TabIndex = 21;
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(12, 158);
            this.labelPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(40, 17);
            this.labelPeso.TabIndex = 25;
            this.labelPeso.Text = "Peso";
            // 
            // labelNumeroTrazableTernero
            // 
            this.labelNumeroTrazableTernero.AutoSize = true;
            this.labelNumeroTrazableTernero.Location = new System.Drawing.Point(12, 26);
            this.labelNumeroTrazableTernero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumeroTrazableTernero.Name = "labelNumeroTrazableTernero";
            this.labelNumeroTrazableTernero.Size = new System.Drawing.Size(118, 17);
            this.labelNumeroTrazableTernero.TabIndex = 20;
            this.labelNumeroTrazableTernero.Text = "Número trazable*";
            // 
            // comboBoxRaza
            // 
            this.comboBoxRaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRaza.FormattingEnabled = true;
            this.comboBoxRaza.Location = new System.Drawing.Point(185, 108);
            this.comboBoxRaza.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRaza.Name = "comboBoxRaza";
            this.comboBoxRaza.Size = new System.Drawing.Size(265, 24);
            this.comboBoxRaza.TabIndex = 24;
            // 
            // labelRaza
            // 
            this.labelRaza.AutoSize = true;
            this.labelRaza.Location = new System.Drawing.Point(12, 112);
            this.labelRaza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRaza.Name = "labelRaza";
            this.labelRaza.Size = new System.Drawing.Size(41, 17);
            this.labelRaza.TabIndex = 23;
            this.labelRaza.Text = "Raza";
            // 
            // textBoxCaracteristicasTernero
            // 
            this.textBoxCaracteristicasTernero.Location = new System.Drawing.Point(137, 235);
            this.textBoxCaracteristicasTernero.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCaracteristicasTernero.MinimumSize = new System.Drawing.Size(313, 61);
            this.textBoxCaracteristicasTernero.Multiline = true;
            this.textBoxCaracteristicasTernero.Name = "textBoxCaracteristicasTernero";
            this.textBoxCaracteristicasTernero.Size = new System.Drawing.Size(313, 61);
            this.textBoxCaracteristicasTernero.TabIndex = 15;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(185, 68);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(265, 22);
            this.textBoxNombre.TabIndex = 22;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 71);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 17);
            this.labelNombre.TabIndex = 21;
            this.labelNombre.Text = "Nombre";
            // 
            // labelCaracteristicasTernero
            // 
            this.labelCaracteristicasTernero.AutoSize = true;
            this.labelCaracteristicasTernero.Location = new System.Drawing.Point(12, 239);
            this.labelCaracteristicasTernero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCaracteristicasTernero.Name = "labelCaracteristicasTernero";
            this.labelCaracteristicasTernero.Size = new System.Drawing.Size(106, 17);
            this.labelCaracteristicasTernero.TabIndex = 14;
            this.labelCaracteristicasTernero.Text = "Caracteristicas*";
            // 
            // labelRegistrarTernero
            // 
            this.labelRegistrarTernero.AutoSize = true;
            this.labelRegistrarTernero.Location = new System.Drawing.Point(599, 46);
            this.labelRegistrarTernero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegistrarTernero.Name = "labelRegistrarTernero";
            this.labelRegistrarTernero.Size = new System.Drawing.Size(132, 17);
            this.labelRegistrarTernero.TabIndex = 19;
            this.labelRegistrarTernero.Text = "¿Registrar ternero?";
            // 
            // radioButtonSiRegistroTernero
            // 
            this.radioButtonSiRegistroTernero.AutoSize = true;
            this.radioButtonSiRegistroTernero.Location = new System.Drawing.Point(787, 43);
            this.radioButtonSiRegistroTernero.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonSiRegistroTernero.Name = "radioButtonSiRegistroTernero";
            this.radioButtonSiRegistroTernero.Size = new System.Drawing.Size(41, 21);
            this.radioButtonSiRegistroTernero.TabIndex = 20;
            this.radioButtonSiRegistroTernero.TabStop = true;
            this.radioButtonSiRegistroTernero.Text = "Sí";
            this.radioButtonSiRegistroTernero.UseVisualStyleBackColor = true;
            this.radioButtonSiRegistroTernero.CheckedChanged += new System.EventHandler(this.radioButtonSiRegistroTernero_CheckedChanged);
            // 
            // radioButtonNoRegistroTernero
            // 
            this.radioButtonNoRegistroTernero.AutoSize = true;
            this.radioButtonNoRegistroTernero.Location = new System.Drawing.Point(843, 43);
            this.radioButtonNoRegistroTernero.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonNoRegistroTernero.Name = "radioButtonNoRegistroTernero";
            this.radioButtonNoRegistroTernero.Size = new System.Drawing.Size(47, 21);
            this.radioButtonNoRegistroTernero.TabIndex = 21;
            this.radioButtonNoRegistroTernero.TabStop = true;
            this.radioButtonNoRegistroTernero.Text = "No";
            this.radioButtonNoRegistroTernero.UseVisualStyleBackColor = true;
            this.radioButtonNoRegistroTernero.CheckedChanged += new System.EventHandler(this.radioButtonNoRegistroTernero_CheckedChanged);
            // 
            // FormParto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBoxRegistroTernero);
            this.Controls.Add(this.botonsRegistrar);
            this.Controls.Add(this.groupBoxAgregarVaca);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.labelRegistrarTernero);
            this.Controls.Add(this.radioButtonNoRegistroTernero);
            this.Controls.Add(this.radioButtonSiRegistroTernero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormParto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parto";
            this.Load += new System.EventHandler(this.FormParto_Load);
            this.groupBoxAgregarVaca.ResumeLayout(false);
            this.groupBoxAgregarVaca.PerformLayout();
            this.groupBoxRegistroTernero.ResumeLayout(false);
            this.groupBoxRegistroTernero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox groupBoxRegistroTernero;
        private System.Windows.Forms.TextBox textBoxCaracteristicasTernero;
        private System.Windows.Forms.Label labelCaracteristicasTernero;
        private System.Windows.Forms.TextBox textBoxNumeroTrazableTernero;
        private System.Windows.Forms.Label labelNumeroTrazableTernero;
        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.ComboBox comboBoxRaza;
        private System.Windows.Forms.Label labelRaza;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelRegistrarTernero;
        private System.Windows.Forms.RadioButton radioButtonSiRegistroTernero;
        private System.Windows.Forms.RadioButton radioButtonNoRegistroTernero;
    }
}