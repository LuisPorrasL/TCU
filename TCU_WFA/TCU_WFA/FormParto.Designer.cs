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
            this.groupBoxAgregarVaca.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAgregarVaca.Name = "groupBoxAgregarVaca";
            this.groupBoxAgregarVaca.Size = new System.Drawing.Size(345, 292);
            this.groupBoxAgregarVaca.TabIndex = 3;
            this.groupBoxAgregarVaca.TabStop = false;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(175, 191);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNo.TabIndex = 18;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            this.radioButtonNo.CheckedChanged += new System.EventHandler(this.radioButtonNo_CheckedChanged);
            // 
            // radioButtonSi
            // 
            this.radioButtonSi.AutoSize = true;
            this.radioButtonSi.Location = new System.Drawing.Point(133, 191);
            this.radioButtonSi.Name = "radioButtonSi";
            this.radioButtonSi.Size = new System.Drawing.Size(36, 17);
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
            this.comboBoxSexo.Location = new System.Drawing.Point(136, 62);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(200, 21);
            this.comboBoxSexo.TabIndex = 16;
            // 
            // textBoxCausaAborto
            // 
            this.textBoxCausaAborto.Location = new System.Drawing.Point(100, 231);
            this.textBoxCausaAborto.MinimumSize = new System.Drawing.Size(236, 50);
            this.textBoxCausaAborto.Multiline = true;
            this.textBoxCausaAborto.Name = "textBoxCausaAborto";
            this.textBoxCausaAborto.Size = new System.Drawing.Size(236, 50);
            this.textBoxCausaAborto.TabIndex = 15;
            // 
            // labelCausaAborto
            // 
            this.labelCausaAborto.AutoSize = true;
            this.labelCausaAborto.Location = new System.Drawing.Point(6, 234);
            this.labelCausaAborto.Name = "labelCausaAborto";
            this.labelCausaAborto.Size = new System.Drawing.Size(70, 13);
            this.labelCausaAborto.TabIndex = 14;
            this.labelCausaAborto.Text = "Causa aborto";
            // 
            // labelMuertePrematura
            // 
            this.labelMuertePrematura.AutoSize = true;
            this.labelMuertePrematura.Location = new System.Drawing.Point(3, 193);
            this.labelMuertePrematura.Name = "labelMuertePrematura";
            this.labelMuertePrematura.Size = new System.Drawing.Size(91, 13);
            this.labelMuertePrematura.TabIndex = 12;
            this.labelMuertePrematura.Text = "Muete prematura*";
            // 
            // comboBoxIdPadre
            // 
            this.comboBoxIdPadre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdPadre.FormattingEnabled = true;
            this.comboBoxIdPadre.Location = new System.Drawing.Point(136, 142);
            this.comboBoxIdPadre.Name = "comboBoxIdPadre";
            this.comboBoxIdPadre.Size = new System.Drawing.Size(200, 21);
            this.comboBoxIdPadre.TabIndex = 11;
            this.comboBoxIdPadre.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdPadre_SelectedIndexChanged);
            // 
            // labelIdPadre
            // 
            this.labelIdPadre.AutoSize = true;
            this.labelIdPadre.Location = new System.Drawing.Point(6, 145);
            this.labelIdPadre.Name = "labelIdPadre";
            this.labelIdPadre.Size = new System.Drawing.Size(46, 13);
            this.labelIdPadre.TabIndex = 10;
            this.labelIdPadre.Text = "Id padre";
            // 
            // comboBoxIdMadre
            // 
            this.comboBoxIdMadre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdMadre.FormattingEnabled = true;
            this.comboBoxIdMadre.Location = new System.Drawing.Point(136, 99);
            this.comboBoxIdMadre.Name = "comboBoxIdMadre";
            this.comboBoxIdMadre.Size = new System.Drawing.Size(200, 21);
            this.comboBoxIdMadre.TabIndex = 9;
            // 
            // labelIdMadre
            // 
            this.labelIdMadre.AutoSize = true;
            this.labelIdMadre.Location = new System.Drawing.Point(6, 102);
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
            this.labelSexoCria.Location = new System.Drawing.Point(6, 65);
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
            this.groupBoxRegistroTernero.Location = new System.Drawing.Point(443, 57);
            this.groupBoxRegistroTernero.Name = "groupBoxRegistroTernero";
            this.groupBoxRegistroTernero.Size = new System.Drawing.Size(345, 247);
            this.groupBoxRegistroTernero.TabIndex = 19;
            this.groupBoxRegistroTernero.TabStop = false;
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(139, 125);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(200, 20);
            this.textBoxPeso.TabIndex = 26;
            // 
            // textBoxNumeroTrazableTernero
            // 
            this.textBoxNumeroTrazableTernero.Location = new System.Drawing.Point(139, 18);
            this.textBoxNumeroTrazableTernero.Name = "textBoxNumeroTrazableTernero";
            this.textBoxNumeroTrazableTernero.Size = new System.Drawing.Size(200, 20);
            this.textBoxNumeroTrazableTernero.TabIndex = 21;
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(9, 128);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(31, 13);
            this.labelPeso.TabIndex = 25;
            this.labelPeso.Text = "Peso";
            // 
            // labelNumeroTrazableTernero
            // 
            this.labelNumeroTrazableTernero.AutoSize = true;
            this.labelNumeroTrazableTernero.Location = new System.Drawing.Point(9, 21);
            this.labelNumeroTrazableTernero.Name = "labelNumeroTrazableTernero";
            this.labelNumeroTrazableTernero.Size = new System.Drawing.Size(88, 13);
            this.labelNumeroTrazableTernero.TabIndex = 20;
            this.labelNumeroTrazableTernero.Text = "Número trazable*";
            // 
            // comboBoxRaza
            // 
            this.comboBoxRaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRaza.FormattingEnabled = true;
            this.comboBoxRaza.Location = new System.Drawing.Point(139, 88);
            this.comboBoxRaza.Name = "comboBoxRaza";
            this.comboBoxRaza.Size = new System.Drawing.Size(200, 21);
            this.comboBoxRaza.TabIndex = 24;
            // 
            // labelRaza
            // 
            this.labelRaza.AutoSize = true;
            this.labelRaza.Location = new System.Drawing.Point(9, 91);
            this.labelRaza.Name = "labelRaza";
            this.labelRaza.Size = new System.Drawing.Size(32, 13);
            this.labelRaza.TabIndex = 23;
            this.labelRaza.Text = "Raza";
            // 
            // textBoxCaracteristicasTernero
            // 
            this.textBoxCaracteristicasTernero.Location = new System.Drawing.Point(103, 191);
            this.textBoxCaracteristicasTernero.MinimumSize = new System.Drawing.Size(236, 50);
            this.textBoxCaracteristicasTernero.Multiline = true;
            this.textBoxCaracteristicasTernero.Name = "textBoxCaracteristicasTernero";
            this.textBoxCaracteristicasTernero.Size = new System.Drawing.Size(236, 50);
            this.textBoxCaracteristicasTernero.TabIndex = 15;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(139, 55);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombre.TabIndex = 22;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(9, 58);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 21;
            this.labelNombre.Text = "Nombre";
            // 
            // labelCaracteristicasTernero
            // 
            this.labelCaracteristicasTernero.AutoSize = true;
            this.labelCaracteristicasTernero.Location = new System.Drawing.Point(9, 194);
            this.labelCaracteristicasTernero.Name = "labelCaracteristicasTernero";
            this.labelCaracteristicasTernero.Size = new System.Drawing.Size(80, 13);
            this.labelCaracteristicasTernero.TabIndex = 14;
            this.labelCaracteristicasTernero.Text = "Caracteristicas*";
            // 
            // labelRegistrarTernero
            // 
            this.labelRegistrarTernero.AutoSize = true;
            this.labelRegistrarTernero.Location = new System.Drawing.Point(449, 37);
            this.labelRegistrarTernero.Name = "labelRegistrarTernero";
            this.labelRegistrarTernero.Size = new System.Drawing.Size(97, 13);
            this.labelRegistrarTernero.TabIndex = 19;
            this.labelRegistrarTernero.Text = "¿Registrar ternero?";
            // 
            // radioButtonSiRegistroTernero
            // 
            this.radioButtonSiRegistroTernero.AutoSize = true;
            this.radioButtonSiRegistroTernero.Location = new System.Drawing.Point(590, 35);
            this.radioButtonSiRegistroTernero.Name = "radioButtonSiRegistroTernero";
            this.radioButtonSiRegistroTernero.Size = new System.Drawing.Size(36, 17);
            this.radioButtonSiRegistroTernero.TabIndex = 20;
            this.radioButtonSiRegistroTernero.TabStop = true;
            this.radioButtonSiRegistroTernero.Text = "Sí";
            this.radioButtonSiRegistroTernero.UseVisualStyleBackColor = true;
            this.radioButtonSiRegistroTernero.CheckedChanged += new System.EventHandler(this.radioButtonSiRegistroTernero_CheckedChanged);
            // 
            // radioButtonNoRegistroTernero
            // 
            this.radioButtonNoRegistroTernero.AutoSize = true;
            this.radioButtonNoRegistroTernero.Location = new System.Drawing.Point(632, 35);
            this.radioButtonNoRegistroTernero.Name = "radioButtonNoRegistroTernero";
            this.radioButtonNoRegistroTernero.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNoRegistroTernero.TabIndex = 21;
            this.radioButtonNoRegistroTernero.TabStop = true;
            this.radioButtonNoRegistroTernero.Text = "No";
            this.radioButtonNoRegistroTernero.UseVisualStyleBackColor = true;
            this.radioButtonNoRegistroTernero.CheckedChanged += new System.EventHandler(this.radioButtonNoRegistroTernero_CheckedChanged);
            // 
            // FormParto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxRegistroTernero);
            this.Controls.Add(this.botonsRegistrar);
            this.Controls.Add(this.groupBoxAgregarVaca);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.labelRegistrarTernero);
            this.Controls.Add(this.radioButtonNoRegistroTernero);
            this.Controls.Add(this.radioButtonSiRegistroTernero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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