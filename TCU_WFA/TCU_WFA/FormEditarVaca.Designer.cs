namespace TCU_WFA
{
    partial class FormEditarVaca : DefaultForm
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
            this.groupBoxEditarVaca = new System.Windows.Forms.GroupBox();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.labelPeso = new System.Windows.Forms.Label();
            this.comboBoxDesarrollo = new System.Windows.Forms.ComboBox();
            this.labelDesarrollo = new System.Windows.Forms.Label();
            this.comboBoxRaza = new System.Windows.Forms.ComboBox();
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
            this.groupBoxEditarVaca.SuspendLayout();
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
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // groupBoxEditarVaca
            // 
            this.groupBoxEditarVaca.Controls.Add(this.textBoxPeso);
            this.groupBoxEditarVaca.Controls.Add(this.labelPeso);
            this.groupBoxEditarVaca.Controls.Add(this.comboBoxDesarrollo);
            this.groupBoxEditarVaca.Controls.Add(this.labelDesarrollo);
            this.groupBoxEditarVaca.Controls.Add(this.comboBoxRaza);
            this.groupBoxEditarVaca.Controls.Add(this.textBoxCaracteristicas);
            this.groupBoxEditarVaca.Controls.Add(this.labelCaracteristicas);
            this.groupBoxEditarVaca.Controls.Add(this.comboBoxModoPrennes);
            this.groupBoxEditarVaca.Controls.Add(this.labelModoPrennes);
            this.groupBoxEditarVaca.Controls.Add(this.comboBoxIdPadre);
            this.groupBoxEditarVaca.Controls.Add(this.labelIdPadre);
            this.groupBoxEditarVaca.Controls.Add(this.comboBoxIdMadre);
            this.groupBoxEditarVaca.Controls.Add(this.labelIdMadre);
            this.groupBoxEditarVaca.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.groupBoxEditarVaca.Controls.Add(this.labelFechaNacimiento);
            this.groupBoxEditarVaca.Controls.Add(this.labelRaza);
            this.groupBoxEditarVaca.Controls.Add(this.textBoxNombre);
            this.groupBoxEditarVaca.Controls.Add(this.labelNombre);
            this.groupBoxEditarVaca.Controls.Add(this.textBoxNumeroTrazableVaca);
            this.groupBoxEditarVaca.Controls.Add(this.labelNumeroTrazableVaca);
            this.groupBoxEditarVaca.Location = new System.Drawing.Point(224, 12);
            this.groupBoxEditarVaca.Name = "groupBoxEditarVaca";
            this.groupBoxEditarVaca.Size = new System.Drawing.Size(345, 426);
            this.groupBoxEditarVaca.TabIndex = 5;
            this.groupBoxEditarVaca.TabStop = false;
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(136, 153);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(200, 20);
            this.textBoxPeso.TabIndex = 20;
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(6, 156);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(53, 13);
            this.labelPeso.TabIndex = 19;
            this.labelPeso.Text = "Peso (Kg)";
            // 
            // comboBoxDesarrollo
            // 
            this.comboBoxDesarrollo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDesarrollo.FormattingEnabled = true;
            this.comboBoxDesarrollo.Location = new System.Drawing.Point(136, 221);
            this.comboBoxDesarrollo.Name = "comboBoxDesarrollo";
            this.comboBoxDesarrollo.Size = new System.Drawing.Size(200, 21);
            this.comboBoxDesarrollo.TabIndex = 18;
            // 
            // labelDesarrollo
            // 
            this.labelDesarrollo.AutoSize = true;
            this.labelDesarrollo.Location = new System.Drawing.Point(6, 224);
            this.labelDesarrollo.Name = "labelDesarrollo";
            this.labelDesarrollo.Size = new System.Drawing.Size(92, 13);
            this.labelDesarrollo.TabIndex = 17;
            this.labelDesarrollo.Text = "Estado desarrollo*";
            // 
            // comboBoxRaza
            // 
            this.comboBoxRaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRaza.FormattingEnabled = true;
            this.comboBoxRaza.Location = new System.Drawing.Point(136, 116);
            this.comboBoxRaza.Name = "comboBoxRaza";
            this.comboBoxRaza.Size = new System.Drawing.Size(200, 21);
            this.comboBoxRaza.TabIndex = 16;
            // 
            // textBoxCaracteristicas
            // 
            this.textBoxCaracteristicas.Location = new System.Drawing.Point(100, 329);
            this.textBoxCaracteristicas.MinimumSize = new System.Drawing.Size(236, 50);
            this.textBoxCaracteristicas.Multiline = true;
            this.textBoxCaracteristicas.Name = "textBoxCaracteristicas";
            this.textBoxCaracteristicas.Size = new System.Drawing.Size(236, 81);
            this.textBoxCaracteristicas.TabIndex = 15;
            // 
            // labelCaracteristicas
            // 
            this.labelCaracteristicas.AutoSize = true;
            this.labelCaracteristicas.Location = new System.Drawing.Point(6, 332);
            this.labelCaracteristicas.Name = "labelCaracteristicas";
            this.labelCaracteristicas.Size = new System.Drawing.Size(82, 13);
            this.labelCaracteristicas.TabIndex = 14;
            this.labelCaracteristicas.Text = "Características*";
            // 
            // comboBoxModoPrennes
            // 
            this.comboBoxModoPrennes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModoPrennes.FormattingEnabled = true;
            this.comboBoxModoPrennes.Location = new System.Drawing.Point(136, 188);
            this.comboBoxModoPrennes.Name = "comboBoxModoPrennes";
            this.comboBoxModoPrennes.Size = new System.Drawing.Size(200, 21);
            this.comboBoxModoPrennes.TabIndex = 13;
            // 
            // labelModoPrennes
            // 
            this.labelModoPrennes.AutoSize = true;
            this.labelModoPrennes.Location = new System.Drawing.Point(6, 191);
            this.labelModoPrennes.Name = "labelModoPrennes";
            this.labelModoPrennes.Size = new System.Drawing.Size(73, 13);
            this.labelModoPrennes.TabIndex = 12;
            this.labelModoPrennes.Text = "Modo preñes*";
            // 
            // comboBoxIdPadre
            // 
            this.comboBoxIdPadre.FormattingEnabled = true;
            this.comboBoxIdPadre.Location = new System.Drawing.Point(136, 293);
            this.comboBoxIdPadre.Name = "comboBoxIdPadre";
            this.comboBoxIdPadre.Size = new System.Drawing.Size(200, 21);
            this.comboBoxIdPadre.TabIndex = 11;
            // 
            // labelIdPadre
            // 
            this.labelIdPadre.AutoSize = true;
            this.labelIdPadre.Location = new System.Drawing.Point(6, 296);
            this.labelIdPadre.Name = "labelIdPadre";
            this.labelIdPadre.Size = new System.Drawing.Size(46, 13);
            this.labelIdPadre.TabIndex = 10;
            this.labelIdPadre.Text = "Id padre";
            // 
            // comboBoxIdMadre
            // 
            this.comboBoxIdMadre.FormattingEnabled = true;
            this.comboBoxIdMadre.Location = new System.Drawing.Point(136, 257);
            this.comboBoxIdMadre.Name = "comboBoxIdMadre";
            this.comboBoxIdMadre.Size = new System.Drawing.Size(200, 21);
            this.comboBoxIdMadre.TabIndex = 9;
            // 
            // labelIdMadre
            // 
            this.labelIdMadre.AutoSize = true;
            this.labelIdMadre.Location = new System.Drawing.Point(6, 260);
            this.labelIdMadre.Name = "labelIdMadre";
            this.labelIdMadre.Size = new System.Drawing.Size(48, 13);
            this.labelIdMadre.TabIndex = 8;
            this.labelIdMadre.Text = "Id madre";
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(136, 79);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaNacimiento.TabIndex = 7;
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Location = new System.Drawing.Point(6, 85);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(106, 13);
            this.labelFechaNacimiento.TabIndex = 6;
            this.labelFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // labelRaza
            // 
            this.labelRaza.AutoSize = true;
            this.labelRaza.Location = new System.Drawing.Point(6, 119);
            this.labelRaza.Name = "labelRaza";
            this.labelRaza.Size = new System.Drawing.Size(32, 13);
            this.labelRaza.TabIndex = 4;
            this.labelRaza.Text = "Raza";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(136, 46);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombre.TabIndex = 3;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(6, 49);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNumeroTrazableVaca
            // 
            this.textBoxNumeroTrazableVaca.Enabled = false;
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
            this.Controls.Add(this.groupBoxEditarVaca);
            this.Controls.Add(this.botonEditar);
            this.Controls.Add(this.botonVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEditarVaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar vaca";
            this.Load += new System.EventHandler(this.FormEditarVaca_Load);
            this.groupBoxEditarVaca.ResumeLayout(false);
            this.groupBoxEditarVaca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.GroupBox groupBoxEditarVaca;
        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.ComboBox comboBoxDesarrollo;
        private System.Windows.Forms.Label labelDesarrollo;
        private System.Windows.Forms.ComboBox comboBoxRaza;
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