namespace TCU_WFA
{
    partial class FormResumen
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
            this.botonGenerarInformeExcel = new System.Windows.Forms.Button();
            this.labelPromedioPartosHato = new System.Windows.Forms.Label();
            this.labelUltimoPorcentajeParicion = new System.Windows.Forms.Label();
            this.labelUltimoIEPVacaMeses = new System.Windows.Forms.Label();
            this.labelProcentajeParicionHistorico = new System.Windows.Forms.Label();
            this.labelIEPPromHistoricoMeses = new System.Windows.Forms.Label();
            this.labelHembrasHanParido = new System.Windows.Forms.Label();
            this.labelNumeroHembrasConsideradas = new System.Windows.Forms.Label();
            this.textBoxHembrasConsideradasValue = new System.Windows.Forms.TextBox();
            this.textBoxHembrasParidoValue = new System.Windows.Forms.TextBox();
            this.textBoxPorcParicionHistoricoValue = new System.Windows.Forms.TextBox();
            this.textBoxPromHistoricoMesesValue = new System.Windows.Forms.TextBox();
            this.textBoxPromPartosHatoValue = new System.Windows.Forms.TextBox();
            this.textBoxUltimoPorcParicionValue = new System.Windows.Forms.TextBox();
            this.textBoxUltimoIEPVacaMesesValue = new System.Windows.Forms.TextBox();
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
            // 
            // botonGenerarInformeExcel
            // 
            this.botonGenerarInformeExcel.Location = new System.Drawing.Point(12, 415);
            this.botonGenerarInformeExcel.Name = "botonGenerarInformeExcel";
            this.botonGenerarInformeExcel.Size = new System.Drawing.Size(118, 23);
            this.botonGenerarInformeExcel.TabIndex = 2;
            this.botonGenerarInformeExcel.Text = "Generar Excel";
            this.botonGenerarInformeExcel.UseVisualStyleBackColor = true;
            this.botonGenerarInformeExcel.Click += new System.EventHandler(this.botonGenerarInformeExcel_Click);
            // 
            // labelPromedioPartosHato
            // 
            this.labelPromedioPartosHato.AutoSize = true;
            this.labelPromedioPartosHato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPromedioPartosHato.Location = new System.Drawing.Point(42, 306);
            this.labelPromedioPartosHato.Name = "labelPromedioPartosHato";
            this.labelPromedioPartosHato.Size = new System.Drawing.Size(161, 20);
            this.labelPromedioPartosHato.TabIndex = 24;
            this.labelPromedioPartosHato.Text = "Promedio partos hato";
            // 
            // labelUltimoPorcentajeParicion
            // 
            this.labelUltimoPorcentajeParicion.AutoSize = true;
            this.labelUltimoPorcentajeParicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUltimoPorcentajeParicion.Location = new System.Drawing.Point(42, 261);
            this.labelUltimoPorcentajeParicion.Name = "labelUltimoPorcentajeParicion";
            this.labelUltimoPorcentajeParicion.Size = new System.Drawing.Size(131, 20);
            this.labelUltimoPorcentajeParicion.TabIndex = 23;
            this.labelUltimoPorcentajeParicion.Text = "Último % parición";
            // 
            // labelUltimoIEPVacaMeses
            // 
            this.labelUltimoIEPVacaMeses.AutoSize = true;
            this.labelUltimoIEPVacaMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUltimoIEPVacaMeses.Location = new System.Drawing.Point(42, 216);
            this.labelUltimoIEPVacaMeses.Name = "labelUltimoIEPVacaMeses";
            this.labelUltimoIEPVacaMeses.Size = new System.Drawing.Size(215, 20);
            this.labelUltimoIEPVacaMeses.TabIndex = 22;
            this.labelUltimoIEPVacaMeses.Text = "Último IEP cada vaca, meses";
            // 
            // labelProcentajeParicionHistorico
            // 
            this.labelProcentajeParicionHistorico.AutoSize = true;
            this.labelProcentajeParicionHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcentajeParicionHistorico.Location = new System.Drawing.Point(42, 171);
            this.labelProcentajeParicionHistorico.Name = "labelProcentajeParicionHistorico";
            this.labelProcentajeParicionHistorico.Size = new System.Drawing.Size(146, 20);
            this.labelProcentajeParicionHistorico.TabIndex = 21;
            this.labelProcentajeParicionHistorico.Text = "% Parición histórico";
            // 
            // labelIEPPromHistoricoMeses
            // 
            this.labelIEPPromHistoricoMeses.AutoSize = true;
            this.labelIEPPromHistoricoMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIEPPromHistoricoMeses.Location = new System.Drawing.Point(42, 126);
            this.labelIEPPromHistoricoMeses.Name = "labelIEPPromHistoricoMeses";
            this.labelIEPPromHistoricoMeses.Size = new System.Drawing.Size(201, 20);
            this.labelIEPPromHistoricoMeses.TabIndex = 20;
            this.labelIEPPromHistoricoMeses.Text = "IEP Prom. Histórico, meses";
            // 
            // labelHembrasHanParido
            // 
            this.labelHembrasHanParido.AutoSize = true;
            this.labelHembrasHanParido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHembrasHanParido.Location = new System.Drawing.Point(42, 81);
            this.labelHembrasHanParido.Name = "labelHembrasHanParido";
            this.labelHembrasHanParido.Size = new System.Drawing.Size(184, 20);
            this.labelHembrasHanParido.TabIndex = 19;
            this.labelHembrasHanParido.Text = "Hembras que han parido";
            // 
            // labelNumeroHembrasConsideradas
            // 
            this.labelNumeroHembrasConsideradas.AutoSize = true;
            this.labelNumeroHembrasConsideradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroHembrasConsideradas.Location = new System.Drawing.Point(42, 36);
            this.labelNumeroHembrasConsideradas.Name = "labelNumeroHembrasConsideradas";
            this.labelNumeroHembrasConsideradas.Size = new System.Drawing.Size(230, 20);
            this.labelNumeroHembrasConsideradas.TabIndex = 18;
            this.labelNumeroHembrasConsideradas.Text = "Número hembras consideradas";
            // 
            // textBoxHembrasConsideradasValue
            // 
            this.textBoxHembrasConsideradasValue.Location = new System.Drawing.Point(284, 39);
            this.textBoxHembrasConsideradasValue.Name = "textBoxHembrasConsideradasValue";
            this.textBoxHembrasConsideradasValue.ReadOnly = true;
            this.textBoxHembrasConsideradasValue.Size = new System.Drawing.Size(165, 20);
            this.textBoxHembrasConsideradasValue.TabIndex = 32;
            // 
            // textBoxHembrasParidoValue
            // 
            this.textBoxHembrasParidoValue.Location = new System.Drawing.Point(284, 84);
            this.textBoxHembrasParidoValue.Name = "textBoxHembrasParidoValue";
            this.textBoxHembrasParidoValue.ReadOnly = true;
            this.textBoxHembrasParidoValue.Size = new System.Drawing.Size(165, 20);
            this.textBoxHembrasParidoValue.TabIndex = 33;
            // 
            // textBoxPorcParicionHistoricoValue
            // 
            this.textBoxPorcParicionHistoricoValue.Location = new System.Drawing.Point(284, 173);
            this.textBoxPorcParicionHistoricoValue.Name = "textBoxPorcParicionHistoricoValue";
            this.textBoxPorcParicionHistoricoValue.ReadOnly = true;
            this.textBoxPorcParicionHistoricoValue.Size = new System.Drawing.Size(165, 20);
            this.textBoxPorcParicionHistoricoValue.TabIndex = 35;
            // 
            // textBoxPromHistoricoMesesValue
            // 
            this.textBoxPromHistoricoMesesValue.Location = new System.Drawing.Point(284, 128);
            this.textBoxPromHistoricoMesesValue.Name = "textBoxPromHistoricoMesesValue";
            this.textBoxPromHistoricoMesesValue.ReadOnly = true;
            this.textBoxPromHistoricoMesesValue.Size = new System.Drawing.Size(165, 20);
            this.textBoxPromHistoricoMesesValue.TabIndex = 34;
            // 
            // textBoxPromPartosHatoValue
            // 
            this.textBoxPromPartosHatoValue.Location = new System.Drawing.Point(284, 307);
            this.textBoxPromPartosHatoValue.Name = "textBoxPromPartosHatoValue";
            this.textBoxPromPartosHatoValue.ReadOnly = true;
            this.textBoxPromPartosHatoValue.Size = new System.Drawing.Size(165, 20);
            this.textBoxPromPartosHatoValue.TabIndex = 38;
            // 
            // textBoxUltimoPorcParicionValue
            // 
            this.textBoxUltimoPorcParicionValue.Location = new System.Drawing.Point(284, 262);
            this.textBoxUltimoPorcParicionValue.Name = "textBoxUltimoPorcParicionValue";
            this.textBoxUltimoPorcParicionValue.ReadOnly = true;
            this.textBoxUltimoPorcParicionValue.Size = new System.Drawing.Size(165, 20);
            this.textBoxUltimoPorcParicionValue.TabIndex = 37;
            // 
            // textBoxUltimoIEPVacaMesesValue
            // 
            this.textBoxUltimoIEPVacaMesesValue.Location = new System.Drawing.Point(284, 218);
            this.textBoxUltimoIEPVacaMesesValue.Name = "textBoxUltimoIEPVacaMesesValue";
            this.textBoxUltimoIEPVacaMesesValue.ReadOnly = true;
            this.textBoxUltimoIEPVacaMesesValue.Size = new System.Drawing.Size(165, 20);
            this.textBoxUltimoIEPVacaMesesValue.TabIndex = 36;
            // 
            // FormResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPromPartosHatoValue);
            this.Controls.Add(this.textBoxUltimoPorcParicionValue);
            this.Controls.Add(this.textBoxUltimoIEPVacaMesesValue);
            this.Controls.Add(this.textBoxPorcParicionHistoricoValue);
            this.Controls.Add(this.textBoxPromHistoricoMesesValue);
            this.Controls.Add(this.textBoxHembrasParidoValue);
            this.Controls.Add(this.textBoxHembrasConsideradasValue);
            this.Controls.Add(this.labelPromedioPartosHato);
            this.Controls.Add(this.labelUltimoPorcentajeParicion);
            this.Controls.Add(this.labelUltimoIEPVacaMeses);
            this.Controls.Add(this.labelProcentajeParicionHistorico);
            this.Controls.Add(this.labelIEPPromHistoricoMeses);
            this.Controls.Add(this.labelHembrasHanParido);
            this.Controls.Add(this.labelNumeroHembrasConsideradas);
            this.Controls.Add(this.botonGenerarInformeExcel);
            this.Controls.Add(this.botonVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormResumen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumen";
            this.Load += new System.EventHandler(this.FormResumen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonGenerarInformeExcel;
        private System.Windows.Forms.Label labelPromedioPartosHato;
        private System.Windows.Forms.Label labelUltimoPorcentajeParicion;
        private System.Windows.Forms.Label labelUltimoIEPVacaMeses;
        private System.Windows.Forms.Label labelProcentajeParicionHistorico;
        private System.Windows.Forms.Label labelIEPPromHistoricoMeses;
        private System.Windows.Forms.Label labelHembrasHanParido;
        private System.Windows.Forms.Label labelNumeroHembrasConsideradas;
        private System.Windows.Forms.TextBox textBoxHembrasConsideradasValue;
        private System.Windows.Forms.TextBox textBoxHembrasParidoValue;
        private System.Windows.Forms.TextBox textBoxPorcParicionHistoricoValue;
        private System.Windows.Forms.TextBox textBoxPromHistoricoMesesValue;
        private System.Windows.Forms.TextBox textBoxPromPartosHatoValue;
        private System.Windows.Forms.TextBox textBoxUltimoPorcParicionValue;
        private System.Windows.Forms.TextBox textBoxUltimoIEPVacaMesesValue;
    }
}