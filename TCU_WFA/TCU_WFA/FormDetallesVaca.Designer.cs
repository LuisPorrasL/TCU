namespace TCU_WFA
{
    partial class FormDetallesVaca
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageInformacionGeneral = new System.Windows.Forms.TabPage();
            this.groupBoxDetallesVacaEspecifico = new System.Windows.Forms.GroupBox();
            this.textBoxCaracteristicas = new System.Windows.Forms.TextBox();
            this.labelCaracteristicas = new System.Windows.Forms.Label();
            this.comboBoxFechasDestetes = new System.Windows.Forms.ComboBox();
            this.labelFechasDestetes = new System.Windows.Forms.Label();
            this.comboBoxFechasSaltos = new System.Windows.Forms.ComboBox();
            this.labelFechasSaltos = new System.Windows.Forms.Label();
            this.groupBoxDetallesVacaGeneral = new System.Windows.Forms.GroupBox();
            this.textBoxFechaNacimiento = new System.Windows.Forms.TextBox();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.labelEdad = new System.Windows.Forms.Label();
            this.textBoxIdPadre = new System.Windows.Forms.TextBox();
            this.textBoxIdMadre = new System.Windows.Forms.TextBox();
            this.textBoxModoPrennes = new System.Windows.Forms.TextBox();
            this.textBoxRaza = new System.Windows.Forms.TextBox();
            this.labelModoPrennes = new System.Windows.Forms.Label();
            this.labelIdPadre = new System.Windows.Forms.Label();
            this.labelIdMadre = new System.Windows.Forms.Label();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.labelRaza = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNumeroTrazableVaca = new System.Windows.Forms.TextBox();
            this.labelNumeroTrazableVaca = new System.Windows.Forms.Label();
            this.tabPagePalpacion = new System.Windows.Forms.TabPage();
            this.dataGridViewPalpacionesVaca = new System.Windows.Forms.DataGridView();
            this.tabPagePartos = new System.Windows.Forms.TabPage();
            this.dataGridViewPartosVacas = new System.Windows.Forms.DataGridView();
            this.exameN_ANTROPOLOGICOTableAdapter1 = new TCU_WFA.TCU_DBDataSetTableAdapters.EXAMEN_ANTROPOLOGICOTableAdapter();
            this.tabControl.SuspendLayout();
            this.tabPageInformacionGeneral.SuspendLayout();
            this.groupBoxDetallesVacaEspecifico.SuspendLayout();
            this.groupBoxDetallesVacaGeneral.SuspendLayout();
            this.tabPagePalpacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPalpacionesVaca)).BeginInit();
            this.tabPagePartos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartosVacas)).BeginInit();
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageInformacionGeneral);
            this.tabControl.Controls.Add(this.tabPagePalpacion);
            this.tabControl.Controls.Add(this.tabPagePartos);
            this.tabControl.Location = new System.Drawing.Point(-1, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(802, 409);
            this.tabControl.TabIndex = 3;
            // 
            // tabPageInformacionGeneral
            // 
            this.tabPageInformacionGeneral.Controls.Add(this.groupBoxDetallesVacaEspecifico);
            this.tabPageInformacionGeneral.Controls.Add(this.groupBoxDetallesVacaGeneral);
            this.tabPageInformacionGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageInformacionGeneral.Name = "tabPageInformacionGeneral";
            this.tabPageInformacionGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInformacionGeneral.Size = new System.Drawing.Size(794, 383);
            this.tabPageInformacionGeneral.TabIndex = 0;
            this.tabPageInformacionGeneral.Text = "Información general";
            this.tabPageInformacionGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBoxDetallesVacaEspecifico
            // 
            this.groupBoxDetallesVacaEspecifico.Controls.Add(this.textBoxCaracteristicas);
            this.groupBoxDetallesVacaEspecifico.Controls.Add(this.labelCaracteristicas);
            this.groupBoxDetallesVacaEspecifico.Controls.Add(this.comboBoxFechasDestetes);
            this.groupBoxDetallesVacaEspecifico.Controls.Add(this.labelFechasDestetes);
            this.groupBoxDetallesVacaEspecifico.Controls.Add(this.comboBoxFechasSaltos);
            this.groupBoxDetallesVacaEspecifico.Controls.Add(this.labelFechasSaltos);
            this.groupBoxDetallesVacaEspecifico.Location = new System.Drawing.Point(360, 6);
            this.groupBoxDetallesVacaEspecifico.Name = "groupBoxDetallesVacaEspecifico";
            this.groupBoxDetallesVacaEspecifico.Size = new System.Drawing.Size(345, 181);
            this.groupBoxDetallesVacaEspecifico.TabIndex = 5;
            this.groupBoxDetallesVacaEspecifico.TabStop = false;
            // 
            // textBoxCaracteristicas
            // 
            this.textBoxCaracteristicas.Location = new System.Drawing.Point(103, 88);
            this.textBoxCaracteristicas.MinimumSize = new System.Drawing.Size(236, 50);
            this.textBoxCaracteristicas.Multiline = true;
            this.textBoxCaracteristicas.Name = "textBoxCaracteristicas";
            this.textBoxCaracteristicas.ReadOnly = true;
            this.textBoxCaracteristicas.Size = new System.Drawing.Size(236, 79);
            this.textBoxCaracteristicas.TabIndex = 17;
            // 
            // labelCaracteristicas
            // 
            this.labelCaracteristicas.AutoSize = true;
            this.labelCaracteristicas.Location = new System.Drawing.Point(6, 94);
            this.labelCaracteristicas.Name = "labelCaracteristicas";
            this.labelCaracteristicas.Size = new System.Drawing.Size(78, 13);
            this.labelCaracteristicas.TabIndex = 16;
            this.labelCaracteristicas.Text = "Características";
            // 
            // comboBoxFechasDestetes
            // 
            this.comboBoxFechasDestetes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFechasDestetes.FormattingEnabled = true;
            this.comboBoxFechasDestetes.Location = new System.Drawing.Point(139, 51);
            this.comboBoxFechasDestetes.Name = "comboBoxFechasDestetes";
            this.comboBoxFechasDestetes.Size = new System.Drawing.Size(200, 21);
            this.comboBoxFechasDestetes.TabIndex = 3;
            // 
            // labelFechasDestetes
            // 
            this.labelFechasDestetes.AutoSize = true;
            this.labelFechasDestetes.Location = new System.Drawing.Point(6, 54);
            this.labelFechasDestetes.Name = "labelFechasDestetes";
            this.labelFechasDestetes.Size = new System.Drawing.Size(85, 13);
            this.labelFechasDestetes.TabIndex = 2;
            this.labelFechasDestetes.Text = "Fechas destetes";
            // 
            // comboBoxFechasSaltos
            // 
            this.comboBoxFechasSaltos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFechasSaltos.FormattingEnabled = true;
            this.comboBoxFechasSaltos.Location = new System.Drawing.Point(139, 13);
            this.comboBoxFechasSaltos.Name = "comboBoxFechasSaltos";
            this.comboBoxFechasSaltos.Size = new System.Drawing.Size(200, 21);
            this.comboBoxFechasSaltos.TabIndex = 1;
            // 
            // labelFechasSaltos
            // 
            this.labelFechasSaltos.AutoSize = true;
            this.labelFechasSaltos.Location = new System.Drawing.Point(6, 16);
            this.labelFechasSaltos.Name = "labelFechasSaltos";
            this.labelFechasSaltos.Size = new System.Drawing.Size(72, 13);
            this.labelFechasSaltos.TabIndex = 0;
            this.labelFechasSaltos.Text = "Fechas saltos";
            // 
            // groupBoxDetallesVacaGeneral
            // 
            this.groupBoxDetallesVacaGeneral.Controls.Add(this.textBoxFechaNacimiento);
            this.groupBoxDetallesVacaGeneral.Controls.Add(this.textBoxEdad);
            this.groupBoxDetallesVacaGeneral.Controls.Add(this.labelEdad);
            this.groupBoxDetallesVacaGeneral.Controls.Add(this.textBoxIdPadre);
            this.groupBoxDetallesVacaGeneral.Controls.Add(this.textBoxIdMadre);
            this.groupBoxDetallesVacaGeneral.Controls.Add(this.textBoxModoPrennes);
            this.groupBoxDetallesVacaGeneral.Controls.Add(this.textBoxRaza);
            this.groupBoxDetallesVacaGeneral.Controls.Add(this.labelModoPrennes);
            this.groupBoxDetallesVacaGeneral.Controls.Add(this.labelIdPadre);
            this.groupBoxDetallesVacaGeneral.Controls.Add(this.labelIdMadre);
            this.groupBoxDetallesVacaGeneral.Controls.Add(this.labelFechaNacimiento);
            this.groupBoxDetallesVacaGeneral.Controls.Add(this.labelRaza);
            this.groupBoxDetallesVacaGeneral.Controls.Add(this.textBoxNombre);
            this.groupBoxDetallesVacaGeneral.Controls.Add(this.labelNombre);
            this.groupBoxDetallesVacaGeneral.Controls.Add(this.textBoxNumeroTrazableVaca);
            this.groupBoxDetallesVacaGeneral.Controls.Add(this.labelNumeroTrazableVaca);
            this.groupBoxDetallesVacaGeneral.Location = new System.Drawing.Point(9, 6);
            this.groupBoxDetallesVacaGeneral.Name = "groupBoxDetallesVacaGeneral";
            this.groupBoxDetallesVacaGeneral.Size = new System.Drawing.Size(345, 337);
            this.groupBoxDetallesVacaGeneral.TabIndex = 4;
            this.groupBoxDetallesVacaGeneral.TabStop = false;
            // 
            // textBoxFechaNacimiento
            // 
            this.textBoxFechaNacimiento.Location = new System.Drawing.Point(136, 88);
            this.textBoxFechaNacimiento.Name = "textBoxFechaNacimiento";
            this.textBoxFechaNacimiento.ReadOnly = true;
            this.textBoxFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.textBoxFechaNacimiento.TabIndex = 22;
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(136, 297);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.ReadOnly = true;
            this.textBoxEdad.Size = new System.Drawing.Size(200, 20);
            this.textBoxEdad.TabIndex = 21;
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(6, 300);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(32, 13);
            this.labelEdad.TabIndex = 20;
            this.labelEdad.Text = "Edad";
            // 
            // textBoxIdPadre
            // 
            this.textBoxIdPadre.Location = new System.Drawing.Point(136, 259);
            this.textBoxIdPadre.Name = "textBoxIdPadre";
            this.textBoxIdPadre.ReadOnly = true;
            this.textBoxIdPadre.Size = new System.Drawing.Size(200, 20);
            this.textBoxIdPadre.TabIndex = 19;
            // 
            // textBoxIdMadre
            // 
            this.textBoxIdMadre.Location = new System.Drawing.Point(136, 216);
            this.textBoxIdMadre.Name = "textBoxIdMadre";
            this.textBoxIdMadre.ReadOnly = true;
            this.textBoxIdMadre.Size = new System.Drawing.Size(200, 20);
            this.textBoxIdMadre.TabIndex = 18;
            // 
            // textBoxModoPrennes
            // 
            this.textBoxModoPrennes.Location = new System.Drawing.Point(136, 172);
            this.textBoxModoPrennes.Name = "textBoxModoPrennes";
            this.textBoxModoPrennes.ReadOnly = true;
            this.textBoxModoPrennes.Size = new System.Drawing.Size(200, 20);
            this.textBoxModoPrennes.TabIndex = 17;
            // 
            // textBoxRaza
            // 
            this.textBoxRaza.Location = new System.Drawing.Point(136, 131);
            this.textBoxRaza.Name = "textBoxRaza";
            this.textBoxRaza.ReadOnly = true;
            this.textBoxRaza.Size = new System.Drawing.Size(200, 20);
            this.textBoxRaza.TabIndex = 16;
            // 
            // labelModoPrennes
            // 
            this.labelModoPrennes.AutoSize = true;
            this.labelModoPrennes.Location = new System.Drawing.Point(6, 175);
            this.labelModoPrennes.Name = "labelModoPrennes";
            this.labelModoPrennes.Size = new System.Drawing.Size(69, 13);
            this.labelModoPrennes.TabIndex = 12;
            this.labelModoPrennes.Text = "Modo preñes";
            // 
            // labelIdPadre
            // 
            this.labelIdPadre.AutoSize = true;
            this.labelIdPadre.Location = new System.Drawing.Point(6, 262);
            this.labelIdPadre.Name = "labelIdPadre";
            this.labelIdPadre.Size = new System.Drawing.Size(46, 13);
            this.labelIdPadre.TabIndex = 10;
            this.labelIdPadre.Text = "Id padre";
            // 
            // labelIdMadre
            // 
            this.labelIdMadre.AutoSize = true;
            this.labelIdMadre.Location = new System.Drawing.Point(6, 219);
            this.labelIdMadre.Name = "labelIdMadre";
            this.labelIdMadre.Size = new System.Drawing.Size(48, 13);
            this.labelIdMadre.TabIndex = 8;
            this.labelIdMadre.Text = "Id madre";
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Location = new System.Drawing.Point(6, 94);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(106, 13);
            this.labelFechaNacimiento.TabIndex = 6;
            this.labelFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // labelRaza
            // 
            this.labelRaza.AutoSize = true;
            this.labelRaza.Location = new System.Drawing.Point(6, 134);
            this.labelRaza.Name = "labelRaza";
            this.labelRaza.Size = new System.Drawing.Size(32, 13);
            this.labelRaza.TabIndex = 4;
            this.labelRaza.Text = "Raza";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(136, 51);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombre.TabIndex = 3;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(6, 54);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNumeroTrazableVaca
            // 
            this.textBoxNumeroTrazableVaca.Location = new System.Drawing.Point(136, 13);
            this.textBoxNumeroTrazableVaca.Name = "textBoxNumeroTrazableVaca";
            this.textBoxNumeroTrazableVaca.ReadOnly = true;
            this.textBoxNumeroTrazableVaca.Size = new System.Drawing.Size(200, 20);
            this.textBoxNumeroTrazableVaca.TabIndex = 1;
            // 
            // labelNumeroTrazableVaca
            // 
            this.labelNumeroTrazableVaca.AutoSize = true;
            this.labelNumeroTrazableVaca.Location = new System.Drawing.Point(6, 16);
            this.labelNumeroTrazableVaca.Name = "labelNumeroTrazableVaca";
            this.labelNumeroTrazableVaca.Size = new System.Drawing.Size(84, 13);
            this.labelNumeroTrazableVaca.TabIndex = 0;
            this.labelNumeroTrazableVaca.Text = "Número trazable";
            // 
            // tabPagePalpacion
            // 
            this.tabPagePalpacion.Controls.Add(this.dataGridViewPalpacionesVaca);
            this.tabPagePalpacion.Location = new System.Drawing.Point(4, 22);
            this.tabPagePalpacion.Name = "tabPagePalpacion";
            this.tabPagePalpacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePalpacion.Size = new System.Drawing.Size(794, 383);
            this.tabPagePalpacion.TabIndex = 1;
            this.tabPagePalpacion.Text = "Palpaciones";
            this.tabPagePalpacion.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPalpacionesVaca
            // 
            this.dataGridViewPalpacionesVaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPalpacionesVaca.Location = new System.Drawing.Point(9, 6);
            this.dataGridViewPalpacionesVaca.Name = "dataGridViewPalpacionesVaca";
            this.dataGridViewPalpacionesVaca.Size = new System.Drawing.Size(776, 371);
            this.dataGridViewPalpacionesVaca.TabIndex = 0;
            // 
            // tabPagePartos
            // 
            this.tabPagePartos.Controls.Add(this.dataGridViewPartosVacas);
            this.tabPagePartos.Location = new System.Drawing.Point(4, 22);
            this.tabPagePartos.Name = "tabPagePartos";
            this.tabPagePartos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePartos.Size = new System.Drawing.Size(794, 383);
            this.tabPagePartos.TabIndex = 2;
            this.tabPagePartos.Text = "Partos";
            this.tabPagePartos.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPartosVacas
            // 
            this.dataGridViewPartosVacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPartosVacas.Location = new System.Drawing.Point(9, 6);
            this.dataGridViewPartosVacas.Name = "dataGridViewPartosVacas";
            this.dataGridViewPartosVacas.Size = new System.Drawing.Size(776, 371);
            this.dataGridViewPartosVacas.TabIndex = 1;
            // 
            // exameN_ANTROPOLOGICOTableAdapter1
            // 
            this.exameN_ANTROPOLOGICOTableAdapter1.ClearBeforeFill = true;
            // 
            // FormDetallesVaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.botonVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormDetallesVaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles vaca";
            this.Load += new System.EventHandler(this.FormDetallesVaca_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageInformacionGeneral.ResumeLayout(false);
            this.groupBoxDetallesVacaEspecifico.ResumeLayout(false);
            this.groupBoxDetallesVacaEspecifico.PerformLayout();
            this.groupBoxDetallesVacaGeneral.ResumeLayout(false);
            this.groupBoxDetallesVacaGeneral.PerformLayout();
            this.tabPagePalpacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPalpacionesVaca)).EndInit();
            this.tabPagePartos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartosVacas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageInformacionGeneral;
        private System.Windows.Forms.GroupBox groupBoxDetallesVacaGeneral;
        private System.Windows.Forms.TextBox textBoxRaza;
        private System.Windows.Forms.Label labelModoPrennes;
        private System.Windows.Forms.Label labelIdPadre;
        private System.Windows.Forms.Label labelIdMadre;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.Label labelRaza;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNumeroTrazableVaca;
        private System.Windows.Forms.Label labelNumeroTrazableVaca;
        private System.Windows.Forms.TabPage tabPagePalpacion;
        private TCU_DBDataSetTableAdapters.EXAMEN_ANTROPOLOGICOTableAdapter exameN_ANTROPOLOGICOTableAdapter1;
        private System.Windows.Forms.GroupBox groupBoxDetallesVacaEspecifico;
        private System.Windows.Forms.Label labelFechasSaltos;
        private System.Windows.Forms.TextBox textBoxIdPadre;
        private System.Windows.Forms.TextBox textBoxIdMadre;
        private System.Windows.Forms.TextBox textBoxModoPrennes;
        private System.Windows.Forms.ComboBox comboBoxFechasSaltos;
        private System.Windows.Forms.ComboBox comboBoxFechasDestetes;
        private System.Windows.Forms.Label labelFechasDestetes;
        private System.Windows.Forms.TextBox textBoxCaracteristicas;
        private System.Windows.Forms.Label labelCaracteristicas;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.TextBox textBoxFechaNacimiento;
        private System.Windows.Forms.TabPage tabPagePartos;
        private System.Windows.Forms.DataGridView dataGridViewPalpacionesVaca;
        private System.Windows.Forms.DataGridView dataGridViewPartosVacas;
    }
}