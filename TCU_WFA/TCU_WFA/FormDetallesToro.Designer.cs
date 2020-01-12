namespace TCU_WFA
{
    partial class FormDetallesToro : DefaultForm
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
            this.tabPageExamenes = new System.Windows.Forms.TabPage();
            this.botonDetalles = new System.Windows.Forms.Button();
            this.dataGridViewExamenesToro = new System.Windows.Forms.DataGridView();
            this.tabPageInformacionGeneral = new System.Windows.Forms.TabPage();
            this.groupBoxDetallesToroGeneral = new System.Windows.Forms.GroupBox();
            this.textBoxRaza = new System.Windows.Forms.TextBox();
            this.labelRaza = new System.Windows.Forms.Label();
            this.textBoxCaracteristicas = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelCaracteristicas = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNumeroTrazableToro = new System.Windows.Forms.TextBox();
            this.labelNumeroTrazableVaca = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageExamenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamenesToro)).BeginInit();
            this.tabPageInformacionGeneral.SuspendLayout();
            this.groupBoxDetallesToroGeneral.SuspendLayout();
            this.tabControl.SuspendLayout();
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
            // tabPageExamenes
            // 
            this.tabPageExamenes.Controls.Add(this.botonDetalles);
            this.tabPageExamenes.Controls.Add(this.dataGridViewExamenesToro);
            this.tabPageExamenes.Location = new System.Drawing.Point(4, 22);
            this.tabPageExamenes.Name = "tabPageExamenes";
            this.tabPageExamenes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExamenes.Size = new System.Drawing.Size(794, 383);
            this.tabPageExamenes.TabIndex = 1;
            this.tabPageExamenes.Text = "Examenes andrológicos";
            this.tabPageExamenes.UseVisualStyleBackColor = true;
            // 
            // botonDetalles
            // 
            this.botonDetalles.Location = new System.Drawing.Point(710, 6);
            this.botonDetalles.Name = "botonDetalles";
            this.botonDetalles.Size = new System.Drawing.Size(75, 23);
            this.botonDetalles.TabIndex = 9;
            this.botonDetalles.Text = "Detalles";
            this.botonDetalles.UseVisualStyleBackColor = true;
            this.botonDetalles.Click += new System.EventHandler(this.botonDetalles_Click);
            // 
            // dataGridViewExamenesToro
            // 
            this.dataGridViewExamenesToro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExamenesToro.Location = new System.Drawing.Point(9, 35);
            this.dataGridViewExamenesToro.Name = "dataGridViewExamenesToro";
            this.dataGridViewExamenesToro.Size = new System.Drawing.Size(776, 342);
            this.dataGridViewExamenesToro.TabIndex = 0;
            // 
            // tabPageInformacionGeneral
            // 
            this.tabPageInformacionGeneral.Controls.Add(this.groupBoxDetallesToroGeneral);
            this.tabPageInformacionGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageInformacionGeneral.Name = "tabPageInformacionGeneral";
            this.tabPageInformacionGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInformacionGeneral.Size = new System.Drawing.Size(794, 383);
            this.tabPageInformacionGeneral.TabIndex = 0;
            this.tabPageInformacionGeneral.Text = "Información general";
            this.tabPageInformacionGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBoxDetallesToroGeneral
            // 
            this.groupBoxDetallesToroGeneral.Controls.Add(this.textBoxRaza);
            this.groupBoxDetallesToroGeneral.Controls.Add(this.labelRaza);
            this.groupBoxDetallesToroGeneral.Controls.Add(this.textBoxCaracteristicas);
            this.groupBoxDetallesToroGeneral.Controls.Add(this.textBoxNombre);
            this.groupBoxDetallesToroGeneral.Controls.Add(this.labelCaracteristicas);
            this.groupBoxDetallesToroGeneral.Controls.Add(this.labelNombre);
            this.groupBoxDetallesToroGeneral.Controls.Add(this.textBoxNumeroTrazableToro);
            this.groupBoxDetallesToroGeneral.Controls.Add(this.labelNumeroTrazableVaca);
            this.groupBoxDetallesToroGeneral.Location = new System.Drawing.Point(228, 12);
            this.groupBoxDetallesToroGeneral.Name = "groupBoxDetallesToroGeneral";
            this.groupBoxDetallesToroGeneral.Size = new System.Drawing.Size(345, 257);
            this.groupBoxDetallesToroGeneral.TabIndex = 4;
            this.groupBoxDetallesToroGeneral.TabStop = false;
            // 
            // textBoxRaza
            // 
            this.textBoxRaza.Location = new System.Drawing.Point(136, 91);
            this.textBoxRaza.Name = "textBoxRaza";
            this.textBoxRaza.ReadOnly = true;
            this.textBoxRaza.Size = new System.Drawing.Size(200, 20);
            this.textBoxRaza.TabIndex = 16;
            // 
            // labelRaza
            // 
            this.labelRaza.AutoSize = true;
            this.labelRaza.Location = new System.Drawing.Point(6, 94);
            this.labelRaza.Name = "labelRaza";
            this.labelRaza.Size = new System.Drawing.Size(32, 13);
            this.labelRaza.TabIndex = 4;
            this.labelRaza.Text = "Raza";
            // 
            // textBoxCaracteristicas
            // 
            this.textBoxCaracteristicas.Location = new System.Drawing.Point(103, 129);
            this.textBoxCaracteristicas.MinimumSize = new System.Drawing.Size(236, 50);
            this.textBoxCaracteristicas.Multiline = true;
            this.textBoxCaracteristicas.Name = "textBoxCaracteristicas";
            this.textBoxCaracteristicas.ReadOnly = true;
            this.textBoxCaracteristicas.Size = new System.Drawing.Size(236, 113);
            this.textBoxCaracteristicas.TabIndex = 17;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(136, 51);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombre.TabIndex = 3;
            // 
            // labelCaracteristicas
            // 
            this.labelCaracteristicas.AutoSize = true;
            this.labelCaracteristicas.Location = new System.Drawing.Point(6, 135);
            this.labelCaracteristicas.Name = "labelCaracteristicas";
            this.labelCaracteristicas.Size = new System.Drawing.Size(78, 13);
            this.labelCaracteristicas.TabIndex = 16;
            this.labelCaracteristicas.Text = "Características";
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
            // textBoxNumeroTrazableToro
            // 
            this.textBoxNumeroTrazableToro.Location = new System.Drawing.Point(136, 13);
            this.textBoxNumeroTrazableToro.Name = "textBoxNumeroTrazableToro";
            this.textBoxNumeroTrazableToro.ReadOnly = true;
            this.textBoxNumeroTrazableToro.Size = new System.Drawing.Size(200, 20);
            this.textBoxNumeroTrazableToro.TabIndex = 1;
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageInformacionGeneral);
            this.tabControl.Controls.Add(this.tabPageExamenes);
            this.tabControl.Location = new System.Drawing.Point(-1, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(802, 409);
            this.tabControl.TabIndex = 4;
            // 
            // FormDetallesToro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.botonVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormDetallesToro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetallesToro";
            this.Load += new System.EventHandler(this.FormDetallesToro_Load);
            this.tabPageExamenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamenesToro)).EndInit();
            this.tabPageInformacionGeneral.ResumeLayout(false);
            this.groupBoxDetallesToroGeneral.ResumeLayout(false);
            this.groupBoxDetallesToroGeneral.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.TabPage tabPageExamenes;
        private System.Windows.Forms.DataGridView dataGridViewExamenesToro;
        private System.Windows.Forms.TabPage tabPageInformacionGeneral;
        private System.Windows.Forms.GroupBox groupBoxDetallesToroGeneral;
        private System.Windows.Forms.TextBox textBoxRaza;
        private System.Windows.Forms.Label labelRaza;
        private System.Windows.Forms.TextBox textBoxCaracteristicas;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelCaracteristicas;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNumeroTrazableToro;
        private System.Windows.Forms.Label labelNumeroTrazableVaca;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button botonDetalles;
    }
}