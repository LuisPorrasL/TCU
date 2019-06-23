namespace TCU_WFA
{
    partial class FormRegistroToros : DefaultForm
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
            this.components = new System.ComponentModel.Container();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonAgregarToro = new System.Windows.Forms.Button();
            this.botonBuscarToro = new System.Windows.Forms.Button();
            this.textBoxBuscarToro = new System.Windows.Forms.TextBox();
            this.dataGridViewToros = new System.Windows.Forms.DataGridView();
            this.tOROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCU_DBDataSet = new TCU_WFA.TCU_DBDataSet();
            this.tOROTableAdapter = new TCU_WFA.TCU_DBDataSetTableAdapters.TOROTableAdapter();
            this.botonEditar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonDetalles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCU_DBDataSet)).BeginInit();
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
            // botonAgregarToro
            // 
            this.botonAgregarToro.Location = new System.Drawing.Point(12, 12);
            this.botonAgregarToro.Name = "botonAgregarToro";
            this.botonAgregarToro.Size = new System.Drawing.Size(163, 27);
            this.botonAgregarToro.TabIndex = 2;
            this.botonAgregarToro.Text = "Agregar toro";
            this.botonAgregarToro.UseVisualStyleBackColor = true;
            this.botonAgregarToro.Click += new System.EventHandler(this.botonAgregarToro_Click);
            // 
            // botonBuscarToro
            // 
            this.botonBuscarToro.Location = new System.Drawing.Point(705, 12);
            this.botonBuscarToro.Name = "botonBuscarToro";
            this.botonBuscarToro.Size = new System.Drawing.Size(83, 27);
            this.botonBuscarToro.TabIndex = 3;
            this.botonBuscarToro.Text = "Buscar toro";
            this.botonBuscarToro.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscarToro
            // 
            this.textBoxBuscarToro.Location = new System.Drawing.Point(541, 16);
            this.textBoxBuscarToro.Name = "textBoxBuscarToro";
            this.textBoxBuscarToro.Size = new System.Drawing.Size(158, 20);
            this.textBoxBuscarToro.TabIndex = 4;
            // 
            // dataGridViewToros
            // 
            this.dataGridViewToros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToros.Location = new System.Drawing.Point(12, 107);
            this.dataGridViewToros.Name = "dataGridViewToros";
            this.dataGridViewToros.RowHeadersWidth = 21;
            this.dataGridViewToros.Size = new System.Drawing.Size(776, 302);
            this.dataGridViewToros.TabIndex = 5;
            // 
            // tOROBindingSource
            // 
            this.tOROBindingSource.DataMember = "TORO";
            this.tOROBindingSource.DataSource = this.tCU_DBDataSet;
            // 
            // tCU_DBDataSet
            // 
            this.tCU_DBDataSet.DataSetName = "TCU_DBDataSet";
            this.tCU_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tOROTableAdapter
            // 
            this.tOROTableAdapter.ClearBeforeFill = true;
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(713, 78);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(75, 23);
            this.botonEditar.TabIndex = 6;
            this.botonEditar.Text = "Editar";
            this.botonEditar.UseVisualStyleBackColor = true;
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(632, 78);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonEliminar.TabIndex = 7;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            // 
            // botonDetalles
            // 
            this.botonDetalles.Location = new System.Drawing.Point(551, 78);
            this.botonDetalles.Name = "botonDetalles";
            this.botonDetalles.Size = new System.Drawing.Size(75, 23);
            this.botonDetalles.TabIndex = 8;
            this.botonDetalles.Text = "Detalles";
            this.botonDetalles.UseVisualStyleBackColor = true;
            // 
            // FormRegistroToros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonDetalles);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonEditar);
            this.Controls.Add(this.dataGridViewToros);
            this.Controls.Add(this.textBoxBuscarToro);
            this.Controls.Add(this.botonBuscarToro);
            this.Controls.Add(this.botonAgregarToro);
            this.Controls.Add(this.botonVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormRegistroToros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro toros";
            this.Load += new System.EventHandler(this.FormRegistroToros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCU_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonAgregarToro;
        private System.Windows.Forms.Button botonBuscarToro;
        private System.Windows.Forms.TextBox textBoxBuscarToro;
        private System.Windows.Forms.DataGridView dataGridViewToros;
        private TCU_DBDataSet tCU_DBDataSet;
        private System.Windows.Forms.BindingSource tOROBindingSource;
        private TCU_DBDataSetTableAdapters.TOROTableAdapter tOROTableAdapter;
        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonDetalles;
    }
}