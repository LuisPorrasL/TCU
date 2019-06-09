namespace TCU_WFA
{
    partial class FormRegistroVacas
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
            this.botonAgregarVaca = new System.Windows.Forms.Button();
            this.botonBuscarVaca = new System.Windows.Forms.Button();
            this.textBoxBuscarVaca = new System.Windows.Forms.TextBox();
            this.dataGridViewVacas = new System.Windows.Forms.DataGridView();
            this.pKNUMEROTRAZABLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAZADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARACTERISTICASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKIDMODOPRENNESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHANACIMIENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKNUMEROTRAZABLEVACADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKNUMEROTRAZABLETORODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vACABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCUDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCU_DBDataSet = new TCU_WFA.TCU_DBDataSet();
            this.vACATableAdapter = new TCU_WFA.TCU_DBDataSetTableAdapters.VACATableAdapter();
            this.botonEditar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonDetalles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vACABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCUDBDataSetBindingSource)).BeginInit();
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
            // botonAgregarVaca
            // 
            this.botonAgregarVaca.Location = new System.Drawing.Point(12, 12);
            this.botonAgregarVaca.Name = "botonAgregarVaca";
            this.botonAgregarVaca.Size = new System.Drawing.Size(163, 27);
            this.botonAgregarVaca.TabIndex = 1;
            this.botonAgregarVaca.Text = "Agregar vaca";
            this.botonAgregarVaca.UseVisualStyleBackColor = true;
            // 
            // botonBuscarVaca
            // 
            this.botonBuscarVaca.Location = new System.Drawing.Point(705, 12);
            this.botonBuscarVaca.Name = "botonBuscarVaca";
            this.botonBuscarVaca.Size = new System.Drawing.Size(83, 27);
            this.botonBuscarVaca.TabIndex = 2;
            this.botonBuscarVaca.Text = "Buscar vaca";
            this.botonBuscarVaca.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscarVaca
            // 
            this.textBoxBuscarVaca.Location = new System.Drawing.Point(541, 16);
            this.textBoxBuscarVaca.Name = "textBoxBuscarVaca";
            this.textBoxBuscarVaca.Size = new System.Drawing.Size(158, 20);
            this.textBoxBuscarVaca.TabIndex = 3;
            // 
            // dataGridViewVacas
            // 
            this.dataGridViewVacas.AutoGenerateColumns = false;
            this.dataGridViewVacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVacas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pKNUMEROTRAZABLEDataGridViewTextBoxColumn,
            this.rAZADataGridViewTextBoxColumn,
            this.cARACTERISTICASDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.fKIDMODOPRENNESDataGridViewTextBoxColumn,
            this.fECHANACIMIENTODataGridViewTextBoxColumn,
            this.fKNUMEROTRAZABLEVACADataGridViewTextBoxColumn,
            this.fKNUMEROTRAZABLETORODataGridViewTextBoxColumn});
            this.dataGridViewVacas.DataSource = this.vACABindingSource;
            this.dataGridViewVacas.Location = new System.Drawing.Point(12, 107);
            this.dataGridViewVacas.Name = "dataGridViewVacas";
            this.dataGridViewVacas.Size = new System.Drawing.Size(776, 302);
            this.dataGridViewVacas.TabIndex = 4;
            // 
            // pKNUMEROTRAZABLEDataGridViewTextBoxColumn
            // 
            this.pKNUMEROTRAZABLEDataGridViewTextBoxColumn.DataPropertyName = "PK_NUMERO_TRAZABLE";
            this.pKNUMEROTRAZABLEDataGridViewTextBoxColumn.HeaderText = "PK_NUMERO_TRAZABLE";
            this.pKNUMEROTRAZABLEDataGridViewTextBoxColumn.Name = "pKNUMEROTRAZABLEDataGridViewTextBoxColumn";
            // 
            // rAZADataGridViewTextBoxColumn
            // 
            this.rAZADataGridViewTextBoxColumn.DataPropertyName = "RAZA";
            this.rAZADataGridViewTextBoxColumn.HeaderText = "RAZA";
            this.rAZADataGridViewTextBoxColumn.Name = "rAZADataGridViewTextBoxColumn";
            // 
            // cARACTERISTICASDataGridViewTextBoxColumn
            // 
            this.cARACTERISTICASDataGridViewTextBoxColumn.DataPropertyName = "CARACTERISTICAS";
            this.cARACTERISTICASDataGridViewTextBoxColumn.HeaderText = "CARACTERISTICAS";
            this.cARACTERISTICASDataGridViewTextBoxColumn.Name = "cARACTERISTICASDataGridViewTextBoxColumn";
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            // 
            // fKIDMODOPRENNESDataGridViewTextBoxColumn
            // 
            this.fKIDMODOPRENNESDataGridViewTextBoxColumn.DataPropertyName = "FK_ID_MODO_PRENNES";
            this.fKIDMODOPRENNESDataGridViewTextBoxColumn.HeaderText = "FK_ID_MODO_PRENNES";
            this.fKIDMODOPRENNESDataGridViewTextBoxColumn.Name = "fKIDMODOPRENNESDataGridViewTextBoxColumn";
            // 
            // fECHANACIMIENTODataGridViewTextBoxColumn
            // 
            this.fECHANACIMIENTODataGridViewTextBoxColumn.DataPropertyName = "FECHA_NACIMIENTO";
            this.fECHANACIMIENTODataGridViewTextBoxColumn.HeaderText = "FECHA_NACIMIENTO";
            this.fECHANACIMIENTODataGridViewTextBoxColumn.Name = "fECHANACIMIENTODataGridViewTextBoxColumn";
            // 
            // fKNUMEROTRAZABLEVACADataGridViewTextBoxColumn
            // 
            this.fKNUMEROTRAZABLEVACADataGridViewTextBoxColumn.DataPropertyName = "FK_NUMERO_TRAZABLE_VACA";
            this.fKNUMEROTRAZABLEVACADataGridViewTextBoxColumn.HeaderText = "FK_NUMERO_TRAZABLE_VACA";
            this.fKNUMEROTRAZABLEVACADataGridViewTextBoxColumn.Name = "fKNUMEROTRAZABLEVACADataGridViewTextBoxColumn";
            // 
            // fKNUMEROTRAZABLETORODataGridViewTextBoxColumn
            // 
            this.fKNUMEROTRAZABLETORODataGridViewTextBoxColumn.DataPropertyName = "FK_NUMERO_TRAZABLE_TORO";
            this.fKNUMEROTRAZABLETORODataGridViewTextBoxColumn.HeaderText = "FK_NUMERO_TRAZABLE_TORO";
            this.fKNUMEROTRAZABLETORODataGridViewTextBoxColumn.Name = "fKNUMEROTRAZABLETORODataGridViewTextBoxColumn";
            // 
            // vACABindingSource
            // 
            this.vACABindingSource.DataMember = "VACA";
            this.vACABindingSource.DataSource = this.tCUDBDataSetBindingSource;
            // 
            // tCUDBDataSetBindingSource
            // 
            this.tCUDBDataSetBindingSource.DataSource = this.tCU_DBDataSet;
            this.tCUDBDataSetBindingSource.Position = 0;
            // 
            // tCU_DBDataSet
            // 
            this.tCU_DBDataSet.DataSetName = "TCU_DBDataSet";
            this.tCU_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vACATableAdapter
            // 
            this.vACATableAdapter.ClearBeforeFill = true;
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(713, 78);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(75, 23);
            this.botonEditar.TabIndex = 5;
            this.botonEditar.Text = "Editar";
            this.botonEditar.UseVisualStyleBackColor = true;
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(632, 78);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonEliminar.TabIndex = 6;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            // 
            // botonDetalles
            // 
            this.botonDetalles.Location = new System.Drawing.Point(551, 78);
            this.botonDetalles.Name = "botonDetalles";
            this.botonDetalles.Size = new System.Drawing.Size(75, 23);
            this.botonDetalles.TabIndex = 7;
            this.botonDetalles.Text = "Detalles";
            this.botonDetalles.UseVisualStyleBackColor = true;
            // 
            // FormRegistroVacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonDetalles);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonEditar);
            this.Controls.Add(this.dataGridViewVacas);
            this.Controls.Add(this.textBoxBuscarVaca);
            this.Controls.Add(this.botonBuscarVaca);
            this.Controls.Add(this.botonAgregarVaca);
            this.Controls.Add(this.botonVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormRegistroVacas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro vacas";
            this.Load += new System.EventHandler(this.FormRegistroVacas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vACABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCUDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCU_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonAgregarVaca;
        private System.Windows.Forms.Button botonBuscarVaca;
        private System.Windows.Forms.TextBox textBoxBuscarVaca;
        private System.Windows.Forms.DataGridView dataGridViewVacas;
        private System.Windows.Forms.BindingSource tCUDBDataSetBindingSource;
        private TCU_DBDataSet tCU_DBDataSet;
        private System.Windows.Forms.BindingSource vACABindingSource;
        private TCU_DBDataSetTableAdapters.VACATableAdapter vACATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKNUMEROTRAZABLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAZADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARACTERISTICASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKIDMODOPRENNESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHANACIMIENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKNUMEROTRAZABLEVACADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKNUMEROTRAZABLETORODataGridViewTextBoxColumn;
        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonDetalles;
    }
}