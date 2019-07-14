namespace TCU_WFA
{
    partial class FormRegistroVacas : DefaultForm
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
            this.vACABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCUDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCU_DBDataSet = new TCU_WFA.TCU_DBDataSet();
            this.vACATableAdapter = new TCU_WFA.TCU_DBDataSetTableAdapters.VACATableAdapter();
            this.botonEditar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonDetalles = new System.Windows.Forms.Button();
            this.vACABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cKFKNUMEROTRAZABLEVACABindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vACABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCUDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCU_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vACABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKFKNUMEROTRAZABLEVACABindingSource)).BeginInit();
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
            this.botonAgregarVaca.Click += new System.EventHandler(this.botonAgregarVaca_Click);
            // 
            // botonBuscarVaca
            // 
            this.botonBuscarVaca.Location = new System.Drawing.Point(705, 12);
            this.botonBuscarVaca.Name = "botonBuscarVaca";
            this.botonBuscarVaca.Size = new System.Drawing.Size(83, 27);
            this.botonBuscarVaca.TabIndex = 2;
            this.botonBuscarVaca.Text = "Buscar vaca";
            this.botonBuscarVaca.UseVisualStyleBackColor = true;
            this.botonBuscarVaca.Click += new System.EventHandler(this.botonBuscarVaca_Click);
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
            this.dataGridViewVacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVacas.Location = new System.Drawing.Point(12, 107);
            this.dataGridViewVacas.MultiSelect = false;
            this.dataGridViewVacas.Name = "dataGridViewVacas";
            this.dataGridViewVacas.ReadOnly = true;
            this.dataGridViewVacas.Size = new System.Drawing.Size(776, 302);
            this.dataGridViewVacas.TabIndex = 4;
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
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(632, 78);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonEliminar.TabIndex = 6;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonDetalles
            // 
            this.botonDetalles.Location = new System.Drawing.Point(551, 78);
            this.botonDetalles.Name = "botonDetalles";
            this.botonDetalles.Size = new System.Drawing.Size(75, 23);
            this.botonDetalles.TabIndex = 7;
            this.botonDetalles.Text = "Detalles";
            this.botonDetalles.UseVisualStyleBackColor = true;
            this.botonDetalles.Click += new System.EventHandler(this.botonDetalles_Click);
            // 
            // vACABindingSource1
            // 
            this.vACABindingSource1.DataMember = "VACA";
            this.vACABindingSource1.DataSource = this.tCUDBDataSetBindingSource;
            // 
            // cKFKNUMEROTRAZABLEVACABindingSource
            // 
            this.cKFKNUMEROTRAZABLEVACABindingSource.DataMember = "CK_FK_NUMERO_TRAZABLE_VACA";
            this.cKFKNUMEROTRAZABLEVACABindingSource.DataSource = this.vACABindingSource1;
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
            ((System.ComponentModel.ISupportInitialize)(this.vACABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKFKNUMEROTRAZABLEVACABindingSource)).EndInit();
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
        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonDetalles;
        private System.Windows.Forms.BindingSource vACABindingSource1;
        private System.Windows.Forms.BindingSource cKFKNUMEROTRAZABLEVACABindingSource;
    }
}