namespace TCU_WFA
{
    partial class FormEditarVaca
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
            this.botonEditar = new System.Windows.Forms.Button();
            this.groupBoxAgregarVaca = new System.Windows.Forms.GroupBox();
            this.textBoxRaza = new System.Windows.Forms.TextBox();
            this.textBoxCaracteristicas = new System.Windows.Forms.TextBox();
            this.labelCaracteristicas = new System.Windows.Forms.Label();
            this.comboBoxModoPrennes = new System.Windows.Forms.ComboBox();
            this.labelModoPrennes = new System.Windows.Forms.Label();
            this.comboBoxIdPadre = new System.Windows.Forms.ComboBox();
            this.labelIdPadre = new System.Windows.Forms.Label();
            this.comboBoxIdMadre = new System.Windows.Forms.ComboBox();
            this.labelIdMadre = new System.Windows.Forms.Label();
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.labelRaza = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNumeroTrazableVaca = new System.Windows.Forms.TextBox();
            this.labelNumeroTrazableVaca = new System.Windows.Forms.Label();
            this.groupBoxAgregarVaca.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(713, 415);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 2;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(632, 415);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(75, 23);
            this.botonEditar.TabIndex = 4;
            this.botonEditar.Text = "Editar";
            this.botonEditar.UseVisualStyleBackColor = true;
            // 
            // groupBoxAgregarVaca
            // 
            this.groupBoxAgregarVaca.Controls.Add(this.textBoxRaza);
            this.groupBoxAgregarVaca.Controls.Add(this.textBoxCaracteristicas);
            this.groupBoxAgregarVaca.Controls.Add(this.labelCaracteristicas);
            this.groupBoxAgregarVaca.Controls.Add(this.comboBoxModoPrennes);
            this.groupBoxAgregarVaca.Controls.Add(this.labelModoPrennes);
            this.groupBoxAgregarVaca.Controls.Add(this.comboBoxIdPadre);
            this.groupBoxAgregarVaca.Controls.Add(this.labelIdPadre);
            this.groupBoxAgregarVaca.Controls.Add(this.comboBoxIdMadre);
            this.groupBoxAgregarVaca.Controls.Add(this.labelIdMadre);
            this.groupBoxAgregarVaca.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.groupBoxAgregarVaca.Controls.Add(this.labelFechaNacimiento);
            this.groupBoxAgregarVaca.Controls.Add(this.labelRaza);
            this.groupBoxAgregarVaca.Controls.Add(this.textBoxNombre);
            this.groupBoxAgregarVaca.Controls.Add(this.labelNombre);
            this.groupBoxAgregarVaca.Controls.Add(this.textBoxNumeroTrazableVaca);
            this.groupBoxAgregarVaca.Controls.Add(this.labelNumeroTrazableVaca);
            this.groupBoxAgregarVaca.Location = new System.Drawing.Point(224, 12);
            this.groupBoxAgregarVaca.Name = "groupBoxAgregarVaca";
            this.groupBoxAgregarVaca.Size = new System.Drawing.Size(345, 426);
            this.groupBoxAgregarVaca.TabIndex = 5;
            this.groupBoxAgregarVaca.TabStop = false;
            // 
            // textBoxRaza
            // 
            this.textBoxRaza.Location = new System.Drawing.Point(136, 155);
            this.textBoxRaza.Name = "textBoxRaza";
            this.textBoxRaza.Size = new System.Drawing.Size(200, 20);
            this.textBoxRaza.TabIndex = 16;
            // 
            // textBoxCaracteristicas
            // 
            this.textBoxCaracteristicas.Location = new System.Drawing.Point(100, 351);
            this.textBoxCaracteristicas.MinimumSize = new System.Drawing.Size(236, 50);
            this.textBoxCaracteristicas.Multiline = true;
            this.textBoxCaracteristicas.Name = "textBoxCaracteristicas";
            this.textBoxCaracteristicas.Size = new System.Drawing.Size(236, 50);
            this.textBoxCaracteristicas.TabIndex = 15;
            // 
            // labelCaracteristicas
            // 
            this.labelCaracteristicas.AutoSize = true;
            this.labelCaracteristicas.Location = new System.Drawing.Point(6, 354);
            this.labelCaracteristicas.Name = "labelCaracteristicas";
            this.labelCaracteristicas.Size = new System.Drawing.Size(82, 13);
            this.labelCaracteristicas.TabIndex = 14;
            this.labelCaracteristicas.Text = "Características*";
            // 
            // comboBoxModoPrennes
            // 
            this.comboBoxModoPrennes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModoPrennes.FormattingEnabled = true;
            this.comboBoxModoPrennes.Location = new System.Drawing.Point(136, 197);
            this.comboBoxModoPrennes.Name = "comboBoxModoPrennes";
            this.comboBoxModoPrennes.Size = new System.Drawing.Size(200, 21);
            this.comboBoxModoPrennes.TabIndex = 13;
            // 
            // labelModoPrennes
            // 
            this.labelModoPrennes.AutoSize = true;
            this.labelModoPrennes.Location = new System.Drawing.Point(6, 200);
            this.labelModoPrennes.Name = "labelModoPrennes";
            this.labelModoPrennes.Size = new System.Drawing.Size(73, 13);
            this.labelModoPrennes.TabIndex = 12;
            this.labelModoPrennes.Text = "Modo preñes*";
            // 
            // comboBoxIdPadre
            // 
            this.comboBoxIdPadre.FormattingEnabled = true;
            this.comboBoxIdPadre.Location = new System.Drawing.Point(136, 284);
            this.comboBoxIdPadre.Name = "comboBoxIdPadre";
            this.comboBoxIdPadre.Size = new System.Drawing.Size(200, 21);
            this.comboBoxIdPadre.TabIndex = 11;
            // 
            // labelIdPadre
            // 
            this.labelIdPadre.AutoSize = true;
            this.labelIdPadre.Location = new System.Drawing.Point(6, 287);
            this.labelIdPadre.Name = "labelIdPadre";
            this.labelIdPadre.Size = new System.Drawing.Size(46, 13);
            this.labelIdPadre.TabIndex = 10;
            this.labelIdPadre.Text = "Id padre";
            // 
            // comboBoxIdMadre
            // 
            this.comboBoxIdMadre.FormattingEnabled = true;
            this.comboBoxIdMadre.Location = new System.Drawing.Point(136, 241);
            this.comboBoxIdMadre.Name = "comboBoxIdMadre";
            this.comboBoxIdMadre.Size = new System.Drawing.Size(200, 21);
            this.comboBoxIdMadre.TabIndex = 9;
            // 
            // labelIdMadre
            // 
            this.labelIdMadre.AutoSize = true;
            this.labelIdMadre.Location = new System.Drawing.Point(6, 244);
            this.labelIdMadre.Name = "labelIdMadre";
            this.labelIdMadre.Size = new System.Drawing.Size(48, 13);
            this.labelIdMadre.TabIndex = 8;
            this.labelIdMadre.Text = "Id madre";
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(136, 102);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaNacimiento.TabIndex = 7;
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Location = new System.Drawing.Point(6, 108);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(106, 13);
            this.labelFechaNacimiento.TabIndex = 6;
            this.labelFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // labelRaza
            // 
            this.labelRaza.AutoSize = true;
            this.labelRaza.Location = new System.Drawing.Point(6, 158);
            this.labelRaza.Name = "labelRaza";
            this.labelRaza.Size = new System.Drawing.Size(32, 13);
            this.labelRaza.TabIndex = 4;
            this.labelRaza.Text = "Raza";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(136, 58);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombre.TabIndex = 3;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(6, 61);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNumeroTrazableVaca
            // 
            this.textBoxNumeroTrazableVaca.Location = new System.Drawing.Point(136, 13);
            this.textBoxNumeroTrazableVaca.Name = "textBoxNumeroTrazableVaca";
            this.textBoxNumeroTrazableVaca.Size = new System.Drawing.Size(200, 20);
            this.textBoxNumeroTrazableVaca.TabIndex = 1;
            // 
            // labelNumeroTrazableVaca
            // 
            this.labelNumeroTrazableVaca.AutoSize = true;
            this.labelNumeroTrazableVaca.Location = new System.Drawing.Point(6, 16);
            this.labelNumeroTrazableVaca.Name = "labelNumeroTrazableVaca";
            this.labelNumeroTrazableVaca.Size = new System.Drawing.Size(88, 13);
            this.labelNumeroTrazableVaca.TabIndex = 0;
            this.labelNumeroTrazableVaca.Text = "Número trazable*";
            // 
            // FormEditarVaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxAgregarVaca);
            this.Controls.Add(this.botonEditar);
            this.Controls.Add(this.botonVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEditarVaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar vaca";
            this.groupBoxAgregarVaca.ResumeLayout(false);
            this.groupBoxAgregarVaca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.GroupBox groupBoxAgregarVaca;
        private System.Windows.Forms.TextBox textBoxRaza;
        private System.Windows.Forms.TextBox textBoxCaracteristicas;
        private System.Windows.Forms.Label labelCaracteristicas;
        protected internal System.Windows.Forms.ComboBox comboBoxModoPrennes;
        private System.Windows.Forms.Label labelModoPrennes;
        private System.Windows.Forms.ComboBox comboBoxIdPadre;
        private System.Windows.Forms.Label labelIdPadre;
        private System.Windows.Forms.ComboBox comboBoxIdMadre;
        private System.Windows.Forms.Label labelIdMadre;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.Label labelRaza;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNumeroTrazableVaca;
        private System.Windows.Forms.Label labelNumeroTrazableVaca;
    }
}