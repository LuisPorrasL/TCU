namespace TCU_WFA
{
    partial class FormAlertas : DefaultForm
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
            this.tabControlAlertas = new System.Windows.Forms.TabControl();
            this.tabPageAlertasIEP = new System.Windows.Forms.TabPage();
            this.tabPageAlertasPartos = new System.Windows.Forms.TabPage();
            this.AlertasPalpaciones = new System.Windows.Forms.TabPage();
            this.labelAlertasIEP = new System.Windows.Forms.Label();
            this.labelAlertasPartos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAlertasPalpaciones = new System.Windows.Forms.DataGridView();
            this.dataGridViewAlertasPartos = new System.Windows.Forms.DataGridView();
            this.dataGridViewAlertasIEP = new System.Windows.Forms.DataGridView();
            this.tabControlAlertas.SuspendLayout();
            this.tabPageAlertasIEP.SuspendLayout();
            this.tabPageAlertasPartos.SuspendLayout();
            this.AlertasPalpaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlertasPalpaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlertasPartos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlertasIEP)).BeginInit();
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
            // tabControlAlertas
            // 
            this.tabControlAlertas.Controls.Add(this.tabPageAlertasIEP);
            this.tabControlAlertas.Controls.Add(this.tabPageAlertasPartos);
            this.tabControlAlertas.Controls.Add(this.AlertasPalpaciones);
            this.tabControlAlertas.Location = new System.Drawing.Point(1, 1);
            this.tabControlAlertas.Name = "tabControlAlertas";
            this.tabControlAlertas.SelectedIndex = 0;
            this.tabControlAlertas.Size = new System.Drawing.Size(799, 408);
            this.tabControlAlertas.TabIndex = 1;
            // 
            // tabPageAlertasIEP
            // 
            this.tabPageAlertasIEP.Controls.Add(this.dataGridViewAlertasIEP);
            this.tabPageAlertasIEP.Controls.Add(this.labelAlertasIEP);
            this.tabPageAlertasIEP.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlertasIEP.Name = "tabPageAlertasIEP";
            this.tabPageAlertasIEP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlertasIEP.Size = new System.Drawing.Size(791, 382);
            this.tabPageAlertasIEP.TabIndex = 0;
            this.tabPageAlertasIEP.Text = "Alertas IEP";
            this.tabPageAlertasIEP.UseVisualStyleBackColor = true;
            // 
            // tabPageAlertasPartos
            // 
            this.tabPageAlertasPartos.Controls.Add(this.dataGridViewAlertasPartos);
            this.tabPageAlertasPartos.Controls.Add(this.labelAlertasPartos);
            this.tabPageAlertasPartos.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlertasPartos.Name = "tabPageAlertasPartos";
            this.tabPageAlertasPartos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlertasPartos.Size = new System.Drawing.Size(791, 382);
            this.tabPageAlertasPartos.TabIndex = 2;
            this.tabPageAlertasPartos.Text = "Alertas Partos";
            this.tabPageAlertasPartos.UseVisualStyleBackColor = true;
            // 
            // AlertasPalpaciones
            // 
            this.AlertasPalpaciones.Controls.Add(this.dataGridViewAlertasPalpaciones);
            this.AlertasPalpaciones.Controls.Add(this.label1);
            this.AlertasPalpaciones.Location = new System.Drawing.Point(4, 22);
            this.AlertasPalpaciones.Name = "AlertasPalpaciones";
            this.AlertasPalpaciones.Padding = new System.Windows.Forms.Padding(3);
            this.AlertasPalpaciones.Size = new System.Drawing.Size(791, 382);
            this.AlertasPalpaciones.TabIndex = 1;
            this.AlertasPalpaciones.Text = "Alertas Palpaciones";
            this.AlertasPalpaciones.UseVisualStyleBackColor = true;
            // 
            // labelAlertasIEP
            // 
            this.labelAlertasIEP.AutoSize = true;
            this.labelAlertasIEP.Location = new System.Drawing.Point(3, 4);
            this.labelAlertasIEP.Name = "labelAlertasIEP";
            this.labelAlertasIEP.Size = new System.Drawing.Size(257, 13);
            this.labelAlertasIEP.TabIndex = 0;
            this.labelAlertasIEP.Text = "Alerta, las siguientes vacas tienen un IEP mayor a  ...";
            // 
            // labelAlertasPartos
            // 
            this.labelAlertasPartos.AutoSize = true;
            this.labelAlertasPartos.Location = new System.Drawing.Point(3, 4);
            this.labelAlertasPartos.Name = "labelAlertasPartos";
            this.labelAlertasPartos.Size = new System.Drawing.Size(306, 13);
            this.labelAlertasPartos.TabIndex = 0;
            this.labelAlertasPartos.Text = "Alerta, las siguientes vacas podían parir en los proximos ... días";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alerta, las siguentes vacas deberían ser palpadas hoy";
            // 
            // dataGridViewAlertasPalpaciones
            // 
            this.dataGridViewAlertasPalpaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlertasPalpaciones.Location = new System.Drawing.Point(0, 20);
            this.dataGridViewAlertasPalpaciones.Name = "dataGridViewAlertasPalpaciones";
            this.dataGridViewAlertasPalpaciones.Size = new System.Drawing.Size(791, 362);
            this.dataGridViewAlertasPalpaciones.TabIndex = 1;
            // 
            // dataGridViewAlertasPartos
            // 
            this.dataGridViewAlertasPartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlertasPartos.Location = new System.Drawing.Point(0, 20);
            this.dataGridViewAlertasPartos.Name = "dataGridViewAlertasPartos";
            this.dataGridViewAlertasPartos.Size = new System.Drawing.Size(791, 362);
            this.dataGridViewAlertasPartos.TabIndex = 2;
            // 
            // dataGridViewAlertasIEP
            // 
            this.dataGridViewAlertasIEP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlertasIEP.Location = new System.Drawing.Point(0, 20);
            this.dataGridViewAlertasIEP.Name = "dataGridViewAlertasIEP";
            this.dataGridViewAlertasIEP.Size = new System.Drawing.Size(791, 362);
            this.dataGridViewAlertasIEP.TabIndex = 2;
            // 
            // FormAlertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlAlertas);
            this.Controls.Add(this.botonVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAlertas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alertas";
            this.Load += new System.EventHandler(this.FormAlertas_Load);
            this.tabControlAlertas.ResumeLayout(false);
            this.tabPageAlertasIEP.ResumeLayout(false);
            this.tabPageAlertasIEP.PerformLayout();
            this.tabPageAlertasPartos.ResumeLayout(false);
            this.tabPageAlertasPartos.PerformLayout();
            this.AlertasPalpaciones.ResumeLayout(false);
            this.AlertasPalpaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlertasPalpaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlertasPartos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlertasIEP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.TabControl tabControlAlertas;
        private System.Windows.Forms.TabPage tabPageAlertasIEP;
        private System.Windows.Forms.TabPage AlertasPalpaciones;
        private System.Windows.Forms.TabPage tabPageAlertasPartos;
        private System.Windows.Forms.Label labelAlertasIEP;
        private System.Windows.Forms.Label labelAlertasPartos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAlertasPalpaciones;
        private System.Windows.Forms.DataGridView dataGridViewAlertasPartos;
        private System.Windows.Forms.DataGridView dataGridViewAlertasIEP;
    }
}