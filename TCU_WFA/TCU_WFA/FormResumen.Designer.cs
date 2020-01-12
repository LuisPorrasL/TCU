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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxSeleccionarFechas = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.labelFechaFinal = new System.Windows.Forms.Label();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelTipoResumen = new System.Windows.Forms.Label();
            this.comboBoxTipoResumen = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxSeleccionarFechas.SuspendLayout();
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
            this.botonGenerarInformeExcel.Location = new System.Drawing.Point(589, 415);
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
            this.labelPromedioPartosHato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPromedioPartosHato.Location = new System.Drawing.Point(116, 346);
            this.labelPromedioPartosHato.Name = "labelPromedioPartosHato";
            this.labelPromedioPartosHato.Size = new System.Drawing.Size(107, 13);
            this.labelPromedioPartosHato.TabIndex = 24;
            this.labelPromedioPartosHato.Text = "Promedio partos hato";
            // 
            // labelUltimoPorcentajeParicion
            // 
            this.labelUltimoPorcentajeParicion.AutoSize = true;
            this.labelUltimoPorcentajeParicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUltimoPorcentajeParicion.Location = new System.Drawing.Point(116, 306);
            this.labelUltimoPorcentajeParicion.Name = "labelUltimoPorcentajeParicion";
            this.labelUltimoPorcentajeParicion.Size = new System.Drawing.Size(87, 13);
            this.labelUltimoPorcentajeParicion.TabIndex = 23;
            this.labelUltimoPorcentajeParicion.Text = "Último % parición";
            // 
            // labelUltimoIEPVacaMeses
            // 
            this.labelUltimoIEPVacaMeses.AutoSize = true;
            this.labelUltimoIEPVacaMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUltimoIEPVacaMeses.Location = new System.Drawing.Point(116, 266);
            this.labelUltimoIEPVacaMeses.Name = "labelUltimoIEPVacaMeses";
            this.labelUltimoIEPVacaMeses.Size = new System.Drawing.Size(146, 13);
            this.labelUltimoIEPVacaMeses.TabIndex = 22;
            this.labelUltimoIEPVacaMeses.Text = "Último IEP cada vaca, meses";
            // 
            // labelProcentajeParicionHistorico
            // 
            this.labelProcentajeParicionHistorico.AutoSize = true;
            this.labelProcentajeParicionHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcentajeParicionHistorico.Location = new System.Drawing.Point(116, 226);
            this.labelProcentajeParicionHistorico.Name = "labelProcentajeParicionHistorico";
            this.labelProcentajeParicionHistorico.Size = new System.Drawing.Size(98, 13);
            this.labelProcentajeParicionHistorico.TabIndex = 21;
            this.labelProcentajeParicionHistorico.Text = "% Parición histórico";
            // 
            // labelIEPPromHistoricoMeses
            // 
            this.labelIEPPromHistoricoMeses.AutoSize = true;
            this.labelIEPPromHistoricoMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIEPPromHistoricoMeses.Location = new System.Drawing.Point(116, 186);
            this.labelIEPPromHistoricoMeses.Name = "labelIEPPromHistoricoMeses";
            this.labelIEPPromHistoricoMeses.Size = new System.Drawing.Size(134, 13);
            this.labelIEPPromHistoricoMeses.TabIndex = 20;
            this.labelIEPPromHistoricoMeses.Text = "IEP Prom. Histórico, meses";
            // 
            // labelHembrasHanParido
            // 
            this.labelHembrasHanParido.AutoSize = true;
            this.labelHembrasHanParido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHembrasHanParido.Location = new System.Drawing.Point(116, 146);
            this.labelHembrasHanParido.Name = "labelHembrasHanParido";
            this.labelHembrasHanParido.Size = new System.Drawing.Size(123, 13);
            this.labelHembrasHanParido.TabIndex = 19;
            this.labelHembrasHanParido.Text = "Hembras que han parido";
            // 
            // labelNumeroHembrasConsideradas
            // 
            this.labelNumeroHembrasConsideradas.AutoSize = true;
            this.labelNumeroHembrasConsideradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelNumeroHembrasConsideradas.Location = new System.Drawing.Point(116, 106);
            this.labelNumeroHembrasConsideradas.Name = "labelNumeroHembrasConsideradas";
            this.labelNumeroHembrasConsideradas.Size = new System.Drawing.Size(153, 13);
            this.labelNumeroHembrasConsideradas.TabIndex = 18;
            this.labelNumeroHembrasConsideradas.Text = "Número hembras consideradas";
            // 
            // textBoxHembrasConsideradasValue
            // 
            this.textBoxHembrasConsideradasValue.Location = new System.Drawing.Point(292, 105);
            this.textBoxHembrasConsideradasValue.Name = "textBoxHembrasConsideradasValue";
            this.textBoxHembrasConsideradasValue.ReadOnly = true;
            this.textBoxHembrasConsideradasValue.Size = new System.Drawing.Size(165, 20);
            this.textBoxHembrasConsideradasValue.TabIndex = 32;
            // 
            // textBoxHembrasParidoValue
            // 
            this.textBoxHembrasParidoValue.Location = new System.Drawing.Point(292, 145);
            this.textBoxHembrasParidoValue.Name = "textBoxHembrasParidoValue";
            this.textBoxHembrasParidoValue.ReadOnly = true;
            this.textBoxHembrasParidoValue.Size = new System.Drawing.Size(165, 20);
            this.textBoxHembrasParidoValue.TabIndex = 33;
            // 
            // textBoxPorcParicionHistoricoValue
            // 
            this.textBoxPorcParicionHistoricoValue.Location = new System.Drawing.Point(292, 224);
            this.textBoxPorcParicionHistoricoValue.Name = "textBoxPorcParicionHistoricoValue";
            this.textBoxPorcParicionHistoricoValue.ReadOnly = true;
            this.textBoxPorcParicionHistoricoValue.Size = new System.Drawing.Size(165, 20);
            this.textBoxPorcParicionHistoricoValue.TabIndex = 35;
            // 
            // textBoxPromHistoricoMesesValue
            // 
            this.textBoxPromHistoricoMesesValue.Location = new System.Drawing.Point(292, 184);
            this.textBoxPromHistoricoMesesValue.Name = "textBoxPromHistoricoMesesValue";
            this.textBoxPromHistoricoMesesValue.ReadOnly = true;
            this.textBoxPromHistoricoMesesValue.Size = new System.Drawing.Size(165, 20);
            this.textBoxPromHistoricoMesesValue.TabIndex = 34;
            // 
            // textBoxPromPartosHatoValue
            // 
            this.textBoxPromPartosHatoValue.Location = new System.Drawing.Point(292, 343);
            this.textBoxPromPartosHatoValue.Name = "textBoxPromPartosHatoValue";
            this.textBoxPromPartosHatoValue.ReadOnly = true;
            this.textBoxPromPartosHatoValue.Size = new System.Drawing.Size(165, 20);
            this.textBoxPromPartosHatoValue.TabIndex = 38;
            // 
            // textBoxUltimoPorcParicionValue
            // 
            this.textBoxUltimoPorcParicionValue.Location = new System.Drawing.Point(292, 303);
            this.textBoxUltimoPorcParicionValue.Name = "textBoxUltimoPorcParicionValue";
            this.textBoxUltimoPorcParicionValue.ReadOnly = true;
            this.textBoxUltimoPorcParicionValue.Size = new System.Drawing.Size(165, 20);
            this.textBoxUltimoPorcParicionValue.TabIndex = 37;
            // 
            // textBoxUltimoIEPVacaMesesValue
            // 
            this.textBoxUltimoIEPVacaMesesValue.Location = new System.Drawing.Point(292, 264);
            this.textBoxUltimoIEPVacaMesesValue.Name = "textBoxUltimoIEPVacaMesesValue";
            this.textBoxUltimoIEPVacaMesesValue.ReadOnly = true;
            this.textBoxUltimoIEPVacaMesesValue.Size = new System.Drawing.Size(165, 20);
            this.textBoxUltimoIEPVacaMesesValue.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxSeleccionarFechas);
            this.groupBox1.Controls.Add(this.labelTipoResumen);
            this.groupBox1.Controls.Add(this.comboBoxTipoResumen);
            this.groupBox1.Controls.Add(this.textBoxPromPartosHatoValue);
            this.groupBox1.Controls.Add(this.textBoxUltimoPorcParicionValue);
            this.groupBox1.Controls.Add(this.textBoxUltimoIEPVacaMesesValue);
            this.groupBox1.Controls.Add(this.textBoxPorcParicionHistoricoValue);
            this.groupBox1.Controls.Add(this.textBoxPromHistoricoMesesValue);
            this.groupBox1.Controls.Add(this.textBoxHembrasParidoValue);
            this.groupBox1.Controls.Add(this.textBoxHembrasConsideradasValue);
            this.groupBox1.Controls.Add(this.labelPromedioPartosHato);
            this.groupBox1.Controls.Add(this.labelUltimoPorcentajeParicion);
            this.groupBox1.Controls.Add(this.labelUltimoIEPVacaMeses);
            this.groupBox1.Controls.Add(this.labelProcentajeParicionHistorico);
            this.groupBox1.Controls.Add(this.labelIEPPromHistoricoMeses);
            this.groupBox1.Controls.Add(this.labelHembrasHanParido);
            this.groupBox1.Controls.Add(this.labelNumeroHembrasConsideradas);
            this.groupBox1.Location = new System.Drawing.Point(93, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 397);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // groupBoxSeleccionarFechas
            // 
            this.groupBoxSeleccionarFechas.Controls.Add(this.dateTimePickerFinal);
            this.groupBoxSeleccionarFechas.Controls.Add(this.labelFechaFinal);
            this.groupBoxSeleccionarFechas.Controls.Add(this.dateTimePickerInicio);
            this.groupBoxSeleccionarFechas.Controls.Add(this.labelFechaInicio);
            this.groupBoxSeleccionarFechas.Location = new System.Drawing.Point(24, 38);
            this.groupBoxSeleccionarFechas.Name = "groupBoxSeleccionarFechas";
            this.groupBoxSeleccionarFechas.Size = new System.Drawing.Size(532, 56);
            this.groupBoxSeleccionarFechas.TabIndex = 45;
            this.groupBoxSeleccionarFechas.TabStop = false;
            this.groupBoxSeleccionarFechas.Visible = false;
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.Location = new System.Drawing.Point(320, 21);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFinal.TabIndex = 42;
            this.dateTimePickerFinal.ValueChanged += new System.EventHandler(this.dateTimePickerFinal_ValueChanged);
            // 
            // labelFechaFinal
            // 
            this.labelFechaFinal.AutoSize = true;
            this.labelFechaFinal.Location = new System.Drawing.Point(279, 25);
            this.labelFechaFinal.Name = "labelFechaFinal";
            this.labelFechaFinal.Size = new System.Drawing.Size(35, 13);
            this.labelFechaFinal.TabIndex = 41;
            this.labelFechaFinal.Text = "Hasta";
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(59, 21);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerInicio.TabIndex = 40;
            this.dateTimePickerInicio.ValueChanged += new System.EventHandler(this.dateTimePickerInicio_ValueChanged);
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Location = new System.Drawing.Point(14, 25);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(38, 13);
            this.labelFechaInicio.TabIndex = 39;
            this.labelFechaInicio.Text = "Desde";
            // 
            // labelTipoResumen
            // 
            this.labelTipoResumen.AutoSize = true;
            this.labelTipoResumen.Location = new System.Drawing.Point(21, 22);
            this.labelTipoResumen.Name = "labelTipoResumen";
            this.labelTipoResumen.Size = new System.Drawing.Size(66, 13);
            this.labelTipoResumen.TabIndex = 44;
            this.labelTipoResumen.Text = "Ver resumen";
            // 
            // comboBoxTipoResumen
            // 
            this.comboBoxTipoResumen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoResumen.FormattingEnabled = true;
            this.comboBoxTipoResumen.Location = new System.Drawing.Point(93, 19);
            this.comboBoxTipoResumen.Name = "comboBoxTipoResumen";
            this.comboBoxTipoResumen.Size = new System.Drawing.Size(137, 21);
            this.comboBoxTipoResumen.TabIndex = 43;
            this.comboBoxTipoResumen.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoResumen_SelectedIndexChanged);
            // 
            // FormResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botonGenerarInformeExcel);
            this.Controls.Add(this.botonVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormResumen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumen";
            this.Load += new System.EventHandler(this.FormResumen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSeleccionarFechas.ResumeLayout(false);
            this.groupBoxSeleccionarFechas.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelFechaFinal;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.ComboBox comboBoxTipoResumen;
        private System.Windows.Forms.Label labelTipoResumen;
        private System.Windows.Forms.GroupBox groupBoxSeleccionarFechas;
    }
}