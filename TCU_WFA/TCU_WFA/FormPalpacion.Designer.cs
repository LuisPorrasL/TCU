namespace TCU_WFA
{
    partial class FormPalpacion : DefaultForm
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
            this.radioButtonVacia = new System.Windows.Forms.RadioButton();
            this.radioButtonPositiva = new System.Windows.Forms.RadioButton();
            this.comboBoxNumeroTrazable = new System.Windows.Forms.ComboBox();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.labelCausaAborto = new System.Windows.Forms.Label();
            this.labelMuertePrematura = new System.Windows.Forms.Label();
            this.comboBoxCondicionCorporal = new System.Windows.Forms.ComboBox();
            this.labelIdMadre = new System.Windows.Forms.Label();
            this.dateTimePickerFechaPalpacion = new System.Windows.Forms.DateTimePicker();
            this.labelFechaPalpacion = new System.Windows.Forms.Label();
            this.labelNumeroTrazable = new System.Windows.Forms.Label();
            this.botonsRegistrar = new System.Windows.Forms.Button();
            this.labelActualizarInformacionVaca = new System.Windows.Forms.Label();
            this.groupBoxNuevoModoPrennes = new System.Windows.Forms.GroupBox();
            this.comboBoxNuevoModoPrennes = new System.Windows.Forms.ComboBox();
            this.labelNuevoModoPrennes = new System.Windows.Forms.Label();
            this.groupBoxAgregarVaca.SuspendLayout();
            this.groupBoxNuevoModoPrennes.SuspendLayout();
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
            this.groupBoxAgregarVaca.Controls.Add(this.radioButtonVacia);
            this.groupBoxAgregarVaca.Controls.Add(this.radioButtonPositiva);
            this.groupBoxAgregarVaca.Controls.Add(this.comboBoxNumeroTrazable);
            this.groupBoxAgregarVaca.Controls.Add(this.textBoxResultado);
            this.groupBoxAgregarVaca.Controls.Add(this.labelCausaAborto);
            this.groupBoxAgregarVaca.Controls.Add(this.labelMuertePrematura);
            this.groupBoxAgregarVaca.Controls.Add(this.comboBoxCondicionCorporal);
            this.groupBoxAgregarVaca.Controls.Add(this.labelIdMadre);
            this.groupBoxAgregarVaca.Controls.Add(this.dateTimePickerFechaPalpacion);
            this.groupBoxAgregarVaca.Controls.Add(this.labelFechaPalpacion);
            this.groupBoxAgregarVaca.Controls.Add(this.labelNumeroTrazable);
            this.groupBoxAgregarVaca.Location = new System.Drawing.Point(224, 12);
            this.groupBoxAgregarVaca.Name = "groupBoxAgregarVaca";
            this.groupBoxAgregarVaca.Size = new System.Drawing.Size(345, 266);
            this.groupBoxAgregarVaca.TabIndex = 4;
            this.groupBoxAgregarVaca.TabStop = false;
            // 
            // radioButtonVacia
            // 
            this.radioButtonVacia.AutoSize = true;
            this.radioButtonVacia.Location = new System.Drawing.Point(204, 158);
            this.radioButtonVacia.Name = "radioButtonVacia";
            this.radioButtonVacia.Size = new System.Drawing.Size(54, 17);
            this.radioButtonVacia.TabIndex = 18;
            this.radioButtonVacia.TabStop = true;
            this.radioButtonVacia.Text = "Vacía";
            this.radioButtonVacia.UseVisualStyleBackColor = true;
            this.radioButtonVacia.CheckedChanged += new System.EventHandler(this.radioButtonVacia_CheckedChanged);
            // 
            // radioButtonPositiva
            // 
            this.radioButtonPositiva.AutoSize = true;
            this.radioButtonPositiva.Location = new System.Drawing.Point(136, 158);
            this.radioButtonPositiva.Name = "radioButtonPositiva";
            this.radioButtonPositiva.Size = new System.Drawing.Size(62, 17);
            this.radioButtonPositiva.TabIndex = 17;
            this.radioButtonPositiva.TabStop = true;
            this.radioButtonPositiva.Text = "Positiva";
            this.radioButtonPositiva.UseVisualStyleBackColor = true;
            this.radioButtonPositiva.CheckedChanged += new System.EventHandler(this.radioButtonPositiva_CheckedChanged);
            // 
            // comboBoxNumeroTrazable
            // 
            this.comboBoxNumeroTrazable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumeroTrazable.FormattingEnabled = true;
            this.comboBoxNumeroTrazable.Location = new System.Drawing.Point(136, 67);
            this.comboBoxNumeroTrazable.Name = "comboBoxNumeroTrazable";
            this.comboBoxNumeroTrazable.Size = new System.Drawing.Size(200, 21);
            this.comboBoxNumeroTrazable.TabIndex = 16;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(100, 202);
            this.textBoxResultado.MinimumSize = new System.Drawing.Size(236, 50);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(236, 50);
            this.textBoxResultado.TabIndex = 15;
            // 
            // labelCausaAborto
            // 
            this.labelCausaAborto.AutoSize = true;
            this.labelCausaAborto.Location = new System.Drawing.Point(6, 205);
            this.labelCausaAborto.Name = "labelCausaAborto";
            this.labelCausaAborto.Size = new System.Drawing.Size(55, 13);
            this.labelCausaAborto.TabIndex = 14;
            this.labelCausaAborto.Text = "Resultado";
            // 
            // labelMuertePrematura
            // 
            this.labelMuertePrematura.AutoSize = true;
            this.labelMuertePrematura.Location = new System.Drawing.Point(6, 160);
            this.labelMuertePrematura.Name = "labelMuertePrematura";
            this.labelMuertePrematura.Size = new System.Drawing.Size(72, 13);
            this.labelMuertePrematura.TabIndex = 12;
            this.labelMuertePrematura.Text = "Confirmación*";
            // 
            // comboBoxCondicionCorporal
            // 
            this.comboBoxCondicionCorporal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCondicionCorporal.FormattingEnabled = true;
            this.comboBoxCondicionCorporal.Location = new System.Drawing.Point(136, 113);
            this.comboBoxCondicionCorporal.Name = "comboBoxCondicionCorporal";
            this.comboBoxCondicionCorporal.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCondicionCorporal.TabIndex = 9;
            // 
            // labelIdMadre
            // 
            this.labelIdMadre.AutoSize = true;
            this.labelIdMadre.Location = new System.Drawing.Point(6, 116);
            this.labelIdMadre.Name = "labelIdMadre";
            this.labelIdMadre.Size = new System.Drawing.Size(99, 13);
            this.labelIdMadre.TabIndex = 8;
            this.labelIdMadre.Text = "Condición corporal*";
            // 
            // dateTimePickerFechaPalpacion
            // 
            this.dateTimePickerFechaPalpacion.Location = new System.Drawing.Point(136, 19);
            this.dateTimePickerFechaPalpacion.Name = "dateTimePickerFechaPalpacion";
            this.dateTimePickerFechaPalpacion.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaPalpacion.TabIndex = 7;
            // 
            // labelFechaPalpacion
            // 
            this.labelFechaPalpacion.AutoSize = true;
            this.labelFechaPalpacion.Location = new System.Drawing.Point(6, 25);
            this.labelFechaPalpacion.Name = "labelFechaPalpacion";
            this.labelFechaPalpacion.Size = new System.Drawing.Size(90, 13);
            this.labelFechaPalpacion.TabIndex = 6;
            this.labelFechaPalpacion.Text = "Fecha palpacion*";
            // 
            // labelNumeroTrazable
            // 
            this.labelNumeroTrazable.AutoSize = true;
            this.labelNumeroTrazable.Location = new System.Drawing.Point(6, 70);
            this.labelNumeroTrazable.Name = "labelNumeroTrazable";
            this.labelNumeroTrazable.Size = new System.Drawing.Size(88, 13);
            this.labelNumeroTrazable.TabIndex = 4;
            this.labelNumeroTrazable.Text = "Número trazable*";
            // 
            // botonsRegistrar
            // 
            this.botonsRegistrar.Location = new System.Drawing.Point(632, 415);
            this.botonsRegistrar.Name = "botonsRegistrar";
            this.botonsRegistrar.Size = new System.Drawing.Size(75, 23);
            this.botonsRegistrar.TabIndex = 5;
            this.botonsRegistrar.Text = "Registrar";
            this.botonsRegistrar.UseVisualStyleBackColor = true;
            this.botonsRegistrar.Click += new System.EventHandler(this.botonsRegistrar_Click);
            // 
            // labelActualizarInformacionVaca
            // 
            this.labelActualizarInformacionVaca.AutoSize = true;
            this.labelActualizarInformacionVaca.Location = new System.Drawing.Point(230, 291);
            this.labelActualizarInformacionVaca.Name = "labelActualizarInformacionVaca";
            this.labelActualizarInformacionVaca.Size = new System.Drawing.Size(170, 13);
            this.labelActualizarInformacionVaca.TabIndex = 15;
            this.labelActualizarInformacionVaca.Text = "Actualizar modo preñes de la vaca";
            // 
            // groupBoxNuevoModoPrennes
            // 
            this.groupBoxNuevoModoPrennes.Controls.Add(this.comboBoxNuevoModoPrennes);
            this.groupBoxNuevoModoPrennes.Controls.Add(this.labelNuevoModoPrennes);
            this.groupBoxNuevoModoPrennes.Location = new System.Drawing.Point(224, 312);
            this.groupBoxNuevoModoPrennes.Name = "groupBoxNuevoModoPrennes";
            this.groupBoxNuevoModoPrennes.Size = new System.Drawing.Size(345, 58);
            this.groupBoxNuevoModoPrennes.TabIndex = 19;
            this.groupBoxNuevoModoPrennes.TabStop = false;
            // 
            // comboBoxNuevoModoPrennes
            // 
            this.comboBoxNuevoModoPrennes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNuevoModoPrennes.FormattingEnabled = true;
            this.comboBoxNuevoModoPrennes.Location = new System.Drawing.Point(139, 19);
            this.comboBoxNuevoModoPrennes.Name = "comboBoxNuevoModoPrennes";
            this.comboBoxNuevoModoPrennes.Size = new System.Drawing.Size(200, 21);
            this.comboBoxNuevoModoPrennes.TabIndex = 16;
            // 
            // labelNuevoModoPrennes
            // 
            this.labelNuevoModoPrennes.AutoSize = true;
            this.labelNuevoModoPrennes.Location = new System.Drawing.Point(9, 22);
            this.labelNuevoModoPrennes.Name = "labelNuevoModoPrennes";
            this.labelNuevoModoPrennes.Size = new System.Drawing.Size(107, 13);
            this.labelNuevoModoPrennes.TabIndex = 4;
            this.labelNuevoModoPrennes.Text = "Nuevo modo preñes*";
            // 
            // FormPalpacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxNuevoModoPrennes);
            this.Controls.Add(this.labelActualizarInformacionVaca);
            this.Controls.Add(this.botonsRegistrar);
            this.Controls.Add(this.groupBoxAgregarVaca);
            this.Controls.Add(this.botonVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPalpacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palpación";
            this.Load += new System.EventHandler(this.FormPalpacion_Load);
            this.groupBoxAgregarVaca.ResumeLayout(false);
            this.groupBoxAgregarVaca.PerformLayout();
            this.groupBoxNuevoModoPrennes.ResumeLayout(false);
            this.groupBoxNuevoModoPrennes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.GroupBox groupBoxAgregarVaca;
        private System.Windows.Forms.RadioButton radioButtonVacia;
        private System.Windows.Forms.RadioButton radioButtonPositiva;
        protected internal System.Windows.Forms.ComboBox comboBoxNumeroTrazable;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Label labelCausaAborto;
        private System.Windows.Forms.Label labelMuertePrematura;
        private System.Windows.Forms.ComboBox comboBoxCondicionCorporal;
        private System.Windows.Forms.Label labelIdMadre;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaPalpacion;
        private System.Windows.Forms.Label labelFechaPalpacion;
        private System.Windows.Forms.Label labelNumeroTrazable;
        private System.Windows.Forms.Button botonsRegistrar;
        private System.Windows.Forms.Label labelActualizarInformacionVaca;
        private System.Windows.Forms.GroupBox groupBoxNuevoModoPrennes;
        protected internal System.Windows.Forms.ComboBox comboBoxNuevoModoPrennes;
        private System.Windows.Forms.Label labelNuevoModoPrennes;
    }
}