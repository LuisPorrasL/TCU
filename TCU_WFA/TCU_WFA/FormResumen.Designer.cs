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
            this.labelHembrasConsideradasValue = new System.Windows.Forms.TextBox();
            this.labelHembrasParidoValue = new System.Windows.Forms.TextBox();
            this.labelPorcParicionHistoricoValue = new System.Windows.Forms.TextBox();
            this.labelPromHistoricoMesesValue = new System.Windows.Forms.TextBox();
            this.labelPromPartosHatoValue = new System.Windows.Forms.TextBox();
            this.labelUltimoPorcParicionValue = new System.Windows.Forms.TextBox();
            this.labelUltimoIEPVacaMesesValue = new System.Windows.Forms.TextBox();
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
            // labelHembrasConsideradasValue
            // 
            this.labelHembrasConsideradasValue.Location = new System.Drawing.Point(284, 39);
            this.labelHembrasConsideradasValue.Name = "labelHembrasConsideradasValue";
            this.labelHembrasConsideradasValue.ReadOnly = true;
            this.labelHembrasConsideradasValue.Size = new System.Drawing.Size(165, 20);
            this.labelHembrasConsideradasValue.TabIndex = 32;
            // 
            // labelHembrasParidoValue
            // 
            this.labelHembrasParidoValue.Location = new System.Drawing.Point(284, 84);
            this.labelHembrasParidoValue.Name = "labelHembrasParidoValue";
            this.labelHembrasParidoValue.ReadOnly = true;
            this.labelHembrasParidoValue.Size = new System.Drawing.Size(165, 20);
            this.labelHembrasParidoValue.TabIndex = 33;
            // 
            // labelPorcParicionHistoricoValue
            // 
            this.labelPorcParicionHistoricoValue.Location = new System.Drawing.Point(284, 173);
            this.labelPorcParicionHistoricoValue.Name = "labelPorcParicionHistoricoValue";
            this.labelPorcParicionHistoricoValue.ReadOnly = true;
            this.labelPorcParicionHistoricoValue.Size = new System.Drawing.Size(165, 20);
            this.labelPorcParicionHistoricoValue.TabIndex = 35;
            // 
            // labelPromHistoricoMesesValue
            // 
            this.labelPromHistoricoMesesValue.Location = new System.Drawing.Point(284, 128);
            this.labelPromHistoricoMesesValue.Name = "labelPromHistoricoMesesValue";
            this.labelPromHistoricoMesesValue.ReadOnly = true;
            this.labelPromHistoricoMesesValue.Size = new System.Drawing.Size(165, 20);
            this.labelPromHistoricoMesesValue.TabIndex = 34;
            // 
            // labelPromPartosHatoValue
            // 
            this.labelPromPartosHatoValue.Location = new System.Drawing.Point(284, 307);
            this.labelPromPartosHatoValue.Name = "labelPromPartosHatoValue";
            this.labelPromPartosHatoValue.ReadOnly = true;
            this.labelPromPartosHatoValue.Size = new System.Drawing.Size(165, 20);
            this.labelPromPartosHatoValue.TabIndex = 38;
            // 
            // labelUltimoPorcParicionValue
            // 
            this.labelUltimoPorcParicionValue.Location = new System.Drawing.Point(284, 262);
            this.labelUltimoPorcParicionValue.Name = "labelUltimoPorcParicionValue";
            this.labelUltimoPorcParicionValue.ReadOnly = true;
            this.labelUltimoPorcParicionValue.Size = new System.Drawing.Size(165, 20);
            this.labelUltimoPorcParicionValue.TabIndex = 37;
            // 
            // labelUltimoIEPVacaMesesValue
            // 
            this.labelUltimoIEPVacaMesesValue.Location = new System.Drawing.Point(284, 218);
            this.labelUltimoIEPVacaMesesValue.Name = "labelUltimoIEPVacaMesesValue";
            this.labelUltimoIEPVacaMesesValue.ReadOnly = true;
            this.labelUltimoIEPVacaMesesValue.Size = new System.Drawing.Size(165, 20);
            this.labelUltimoIEPVacaMesesValue.TabIndex = 36;
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
        private System.Windows.Forms.Label labelPromedioPartosHato;
        private System.Windows.Forms.Label labelUltimoPorcentajeParicion;
        private System.Windows.Forms.Label labelUltimoIEPVacaMeses;
        private System.Windows.Forms.Label labelProcentajeParicionHistorico;
        private System.Windows.Forms.Label labelIEPPromHistoricoMeses;
        private System.Windows.Forms.Label labelHembrasHanParido;
        private System.Windows.Forms.Label labelNumeroHembrasConsideradas;
        private System.Windows.Forms.TextBox labelHembrasConsideradasValue;
        private System.Windows.Forms.TextBox labelHembrasParidoValue;
        private System.Windows.Forms.TextBox labelPorcParicionHistoricoValue;
        private System.Windows.Forms.TextBox labelPromHistoricoMesesValue;
        private System.Windows.Forms.TextBox labelPromPartosHatoValue;
        private System.Windows.Forms.TextBox labelUltimoPorcParicionValue;
        private System.Windows.Forms.TextBox labelUltimoIEPVacaMesesValue;
    }
}