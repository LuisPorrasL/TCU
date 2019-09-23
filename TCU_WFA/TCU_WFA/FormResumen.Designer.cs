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
            this.labelNumeroHembrasConsideradas = new System.Windows.Forms.Label();
            this.labelHembrasHanParido = new System.Windows.Forms.Label();
            this.labelIEPPromHistoricoMeses = new System.Windows.Forms.Label();
            this.labelPromedioPartosHato = new System.Windows.Forms.Label();
            this.labelUltimoPorcentajeParicion = new System.Windows.Forms.Label();
            this.labelUltimoIEPVacaMeses = new System.Windows.Forms.Label();
            this.labelProcentajeParicionHistorico = new System.Windows.Forms.Label();
            this.labelHembrasConsideradasValue = new System.Windows.Forms.Label();
            this.labelHembrasParidoValue = new System.Windows.Forms.Label();
            this.labelPorcParicionHistoricoValue = new System.Windows.Forms.Label();
            this.labelPromHistoricoMesesValue = new System.Windows.Forms.Label();
            this.labelPromPartosHatoValue = new System.Windows.Forms.Label();
            this.labelUltimoPorcParicionValue = new System.Windows.Forms.Label();
            this.labelUltimoIEPVacaMesesValue = new System.Windows.Forms.Label();
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
            // labelNumeroHembrasConsideradas
            // 
            this.labelNumeroHembrasConsideradas.AutoSize = true;
            this.labelNumeroHembrasConsideradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroHembrasConsideradas.Location = new System.Drawing.Point(32, 46);
            this.labelNumeroHembrasConsideradas.Name = "labelNumeroHembrasConsideradas";
            this.labelNumeroHembrasConsideradas.Size = new System.Drawing.Size(311, 25);
            this.labelNumeroHembrasConsideradas.TabIndex = 4;
            this.labelNumeroHembrasConsideradas.Text = "Número hembras consideradas";
            // 
            // labelHembrasHanParido
            // 
            this.labelHembrasHanParido.AutoSize = true;
            this.labelHembrasHanParido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHembrasHanParido.Location = new System.Drawing.Point(32, 91);
            this.labelHembrasHanParido.Name = "labelHembrasHanParido";
            this.labelHembrasHanParido.Size = new System.Drawing.Size(248, 25);
            this.labelHembrasHanParido.TabIndex = 5;
            this.labelHembrasHanParido.Text = "Hembras que han parido";
            // 
            // labelIEPPromHistoricoMeses
            // 
            this.labelIEPPromHistoricoMeses.AutoSize = true;
            this.labelIEPPromHistoricoMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIEPPromHistoricoMeses.Location = new System.Drawing.Point(32, 136);
            this.labelIEPPromHistoricoMeses.Name = "labelIEPPromHistoricoMeses";
            this.labelIEPPromHistoricoMeses.Size = new System.Drawing.Size(272, 25);
            this.labelIEPPromHistoricoMeses.TabIndex = 6;
            this.labelIEPPromHistoricoMeses.Text = "IEP Prom. Histórico, meses";
            // 
            // labelPromedioPartosHato
            // 
            this.labelPromedioPartosHato.AutoSize = true;
            this.labelPromedioPartosHato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPromedioPartosHato.Location = new System.Drawing.Point(32, 316);
            this.labelPromedioPartosHato.Name = "labelPromedioPartosHato";
            this.labelPromedioPartosHato.Size = new System.Drawing.Size(217, 25);
            this.labelPromedioPartosHato.TabIndex = 10;
            this.labelPromedioPartosHato.Text = "Promedio partos hato";
            // 
            // labelUltimoPorcentajeParicion
            // 
            this.labelUltimoPorcentajeParicion.AutoSize = true;
            this.labelUltimoPorcentajeParicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUltimoPorcentajeParicion.Location = new System.Drawing.Point(32, 271);
            this.labelUltimoPorcentajeParicion.Name = "labelUltimoPorcentajeParicion";
            this.labelUltimoPorcentajeParicion.Size = new System.Drawing.Size(179, 25);
            this.labelUltimoPorcentajeParicion.TabIndex = 9;
            this.labelUltimoPorcentajeParicion.Text = "Último % parición";
            // 
            // labelUltimoIEPVacaMeses
            // 
            this.labelUltimoIEPVacaMeses.AutoSize = true;
            this.labelUltimoIEPVacaMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUltimoIEPVacaMeses.Location = new System.Drawing.Point(32, 226);
            this.labelUltimoIEPVacaMeses.Name = "labelUltimoIEPVacaMeses";
            this.labelUltimoIEPVacaMeses.Size = new System.Drawing.Size(291, 25);
            this.labelUltimoIEPVacaMeses.TabIndex = 8;
            this.labelUltimoIEPVacaMeses.Text = "Último IEP cada vaca, meses";
            // 
            // labelProcentajeParicionHistorico
            // 
            this.labelProcentajeParicionHistorico.AutoSize = true;
            this.labelProcentajeParicionHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcentajeParicionHistorico.Location = new System.Drawing.Point(32, 181);
            this.labelProcentajeParicionHistorico.Name = "labelProcentajeParicionHistorico";
            this.labelProcentajeParicionHistorico.Size = new System.Drawing.Size(202, 25);
            this.labelProcentajeParicionHistorico.TabIndex = 7;
            this.labelProcentajeParicionHistorico.Text = "% Parición histórico";
            // 
            // labelHembrasConsideradasValue
            // 
            this.labelHembrasConsideradasValue.AutoSize = true;
            this.labelHembrasConsideradasValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHembrasConsideradasValue.Location = new System.Drawing.Point(369, 50);
            this.labelHembrasConsideradasValue.Name = "labelHembrasConsideradasValue";
            this.labelHembrasConsideradasValue.Size = new System.Drawing.Size(45, 20);
            this.labelHembrasConsideradasValue.TabIndex = 11;
            this.labelHembrasConsideradasValue.Text = "####";
            // 
            // labelHembrasParidoValue
            // 
            this.labelHembrasParidoValue.AutoSize = true;
            this.labelHembrasParidoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHembrasParidoValue.Location = new System.Drawing.Point(369, 95);
            this.labelHembrasParidoValue.Name = "labelHembrasParidoValue";
            this.labelHembrasParidoValue.Size = new System.Drawing.Size(45, 20);
            this.labelHembrasParidoValue.TabIndex = 12;
            this.labelHembrasParidoValue.Text = "####";
            // 
            // labelPorcParicionHistoricoValue
            // 
            this.labelPorcParicionHistoricoValue.AutoSize = true;
            this.labelPorcParicionHistoricoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPorcParicionHistoricoValue.Location = new System.Drawing.Point(369, 185);
            this.labelPorcParicionHistoricoValue.Name = "labelPorcParicionHistoricoValue";
            this.labelPorcParicionHistoricoValue.Size = new System.Drawing.Size(45, 20);
            this.labelPorcParicionHistoricoValue.TabIndex = 14;
            this.labelPorcParicionHistoricoValue.Text = "####";
            // 
            // labelPromHistoricoMesesValue
            // 
            this.labelPromHistoricoMesesValue.AutoSize = true;
            this.labelPromHistoricoMesesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPromHistoricoMesesValue.Location = new System.Drawing.Point(369, 140);
            this.labelPromHistoricoMesesValue.Name = "labelPromHistoricoMesesValue";
            this.labelPromHistoricoMesesValue.Size = new System.Drawing.Size(45, 20);
            this.labelPromHistoricoMesesValue.TabIndex = 13;
            this.labelPromHistoricoMesesValue.Text = "####";
            // 
            // labelPromPartosHatoValue
            // 
            this.labelPromPartosHatoValue.AutoSize = true;
            this.labelPromPartosHatoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPromPartosHatoValue.Location = new System.Drawing.Point(369, 320);
            this.labelPromPartosHatoValue.Name = "labelPromPartosHatoValue";
            this.labelPromPartosHatoValue.Size = new System.Drawing.Size(45, 20);
            this.labelPromPartosHatoValue.TabIndex = 17;
            this.labelPromPartosHatoValue.Text = "####";
            // 
            // labelUltimoPorcParicionValue
            // 
            this.labelUltimoPorcParicionValue.AutoSize = true;
            this.labelUltimoPorcParicionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUltimoPorcParicionValue.Location = new System.Drawing.Point(369, 275);
            this.labelUltimoPorcParicionValue.Name = "labelUltimoPorcParicionValue";
            this.labelUltimoPorcParicionValue.Size = new System.Drawing.Size(45, 20);
            this.labelUltimoPorcParicionValue.TabIndex = 16;
            this.labelUltimoPorcParicionValue.Text = "####";
            // 
            // labelUltimoIEPVacaMesesValue
            // 
            this.labelUltimoIEPVacaMesesValue.AutoSize = true;
            this.labelUltimoIEPVacaMesesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUltimoIEPVacaMesesValue.Location = new System.Drawing.Point(369, 230);
            this.labelUltimoIEPVacaMesesValue.Name = "labelUltimoIEPVacaMesesValue";
            this.labelUltimoIEPVacaMesesValue.Size = new System.Drawing.Size(45, 20);
            this.labelUltimoIEPVacaMesesValue.TabIndex = 15;
            this.labelUltimoIEPVacaMesesValue.Text = "####";
            // 
            // FormResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPromPartosHatoValue);
            this.Controls.Add(this.labelUltimoPorcParicionValue);
            this.Controls.Add(this.labelUltimoIEPVacaMesesValue);
            this.Controls.Add(this.labelPorcParicionHistoricoValue);
            this.Controls.Add(this.labelPromHistoricoMesesValue);
            this.Controls.Add(this.labelHembrasParidoValue);
            this.Controls.Add(this.labelHembrasConsideradasValue);
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
        private System.Windows.Forms.Label labelNumeroHembrasConsideradas;
        private System.Windows.Forms.Label labelHembrasHanParido;
        private System.Windows.Forms.Label labelIEPPromHistoricoMeses;
        private System.Windows.Forms.Label labelPromedioPartosHato;
        private System.Windows.Forms.Label labelUltimoPorcentajeParicion;
        private System.Windows.Forms.Label labelUltimoIEPVacaMeses;
        private System.Windows.Forms.Label labelProcentajeParicionHistorico;
        private System.Windows.Forms.Label labelHembrasConsideradasValue;
        private System.Windows.Forms.Label labelHembrasParidoValue;
        private System.Windows.Forms.Label labelPorcParicionHistoricoValue;
        private System.Windows.Forms.Label labelPromHistoricoMesesValue;
        private System.Windows.Forms.Label labelPromPartosHatoValue;
        private System.Windows.Forms.Label labelUltimoPorcParicionValue;
        private System.Windows.Forms.Label labelUltimoIEPVacaMesesValue;
    }
}