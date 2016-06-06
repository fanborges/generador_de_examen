namespace examen_ap
{
    partial class Totales_alumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Totales_alumnos));
            this.main_dbDataSet = new examen_ap.main_dbDataSet();
            this.tOTALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tOTALESTableAdapter = new examen_ap.main_dbDataSetTableAdapters.TOTALESTableAdapter();
            this.tableAdapterManager = new examen_ap.main_dbDataSetTableAdapters.TableAdapterManager();
            this.tOTALESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tOTALESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tOTALESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_totales_por_intento = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.main_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOTALESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOTALESBindingNavigator)).BeginInit();
            this.tOTALESBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tOTALESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // main_dbDataSet
            // 
            this.main_dbDataSet.DataSetName = "main_dbDataSet";
            this.main_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tOTALESBindingSource
            // 
            this.tOTALESBindingSource.DataMember = "TOTALES";
            this.tOTALESBindingSource.DataSource = this.main_dbDataSet;
            // 
            // tOTALESTableAdapter
            // 
            this.tOTALESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ALUMNOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.INCORRECTATableAdapter = null;
            this.tableAdapterManager.INTENTOTableAdapter = null;
            this.tableAdapterManager.PREGUNTATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = examen_ap.main_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tOTALESBindingNavigator
            // 
            this.tOTALESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tOTALESBindingNavigator.BindingSource = this.tOTALESBindingSource;
            this.tOTALESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tOTALESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tOTALESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tOTALESBindingNavigatorSaveItem});
            this.tOTALESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tOTALESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tOTALESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tOTALESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tOTALESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tOTALESBindingNavigator.Name = "tOTALESBindingNavigator";
            this.tOTALESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tOTALESBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tOTALESBindingNavigator.TabIndex = 0;
            this.tOTALESBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // tOTALESBindingNavigatorSaveItem
            // 
            this.tOTALESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tOTALESBindingNavigatorSaveItem.Enabled = false;
            this.tOTALESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tOTALESBindingNavigatorSaveItem.Image")));
            this.tOTALESBindingNavigatorSaveItem.Name = "tOTALESBindingNavigatorSaveItem";
            this.tOTALESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tOTALESBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // tOTALESDataGridView
            // 
            this.tOTALESDataGridView.AllowUserToAddRows = false;
            this.tOTALESDataGridView.AllowUserToDeleteRows = false;
            this.tOTALESDataGridView.AutoGenerateColumns = false;
            this.tOTALESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tOTALESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.tOTALESDataGridView.DataSource = this.tOTALESBindingSource;
            this.tOTALESDataGridView.Location = new System.Drawing.Point(12, 129);
            this.tOTALESDataGridView.Name = "tOTALESDataGridView";
            this.tOTALESDataGridView.ReadOnly = true;
            this.tOTALESDataGridView.Size = new System.Drawing.Size(747, 220);
            this.tOTALESDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NOMBRE";
            this.dataGridViewTextBoxColumn1.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PATERNO";
            this.dataGridViewTextBoxColumn2.HeaderText = "APELLIDO PATERNO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MATERNO";
            this.dataGridViewTextBoxColumn3.HeaderText = "APELLIDO MATERNO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MATRICULA";
            this.dataGridViewTextBoxColumn4.HeaderText = "MATRICULA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CANTIDAD";
            this.dataGridViewTextBoxColumn5.HeaderText = "No DE INTENTOS";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PROMEDIO";
            this.dataGridViewTextBoxColumn6.HeaderText = "PORCENTAJE DE APROVECHAMIENTO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ALTA";
            this.dataGridViewTextBoxColumn7.HeaderText = "CALIFICACIÓN MÁS ALTA";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Totales por alumno";
            // 
            // btn_totales_por_intento
            // 
            this.btn_totales_por_intento.Location = new System.Drawing.Point(446, 355);
            this.btn_totales_por_intento.Name = "btn_totales_por_intento";
            this.btn_totales_por_intento.Size = new System.Drawing.Size(129, 23);
            this.btn_totales_por_intento.TabIndex = 3;
            this.btn_totales_por_intento.Text = "Totales por intento";
            this.btn_totales_por_intento.UseVisualStyleBackColor = true;
            this.btn_totales_por_intento.Click += new System.EventHandler(this.btn_totales_por_intento_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(630, 355);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(129, 23);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Totales_alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_totales_por_intento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tOTALESDataGridView);
            this.Controls.Add(this.tOTALESBindingNavigator);
            this.Name = "Totales_alumnos";
            this.Text = "Totales por alumno";
            this.Load += new System.EventHandler(this.Totales_alumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.main_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOTALESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOTALESBindingNavigator)).EndInit();
            this.tOTALESBindingNavigator.ResumeLayout(false);
            this.tOTALESBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tOTALESDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private main_dbDataSet main_dbDataSet;
        private System.Windows.Forms.BindingSource tOTALESBindingSource;
        private main_dbDataSetTableAdapters.TOTALESTableAdapter tOTALESTableAdapter;
        private main_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tOTALESBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tOTALESBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tOTALESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_totales_por_intento;
        private System.Windows.Forms.Button btn_salir;
    }
}