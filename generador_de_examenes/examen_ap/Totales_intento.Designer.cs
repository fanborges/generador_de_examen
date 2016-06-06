namespace examen_ap
{
    partial class Totales_intento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Totales_intento));
            this.main_dbDataSet = new examen_ap.main_dbDataSet();
            this.vISTA1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vISTA1TableAdapter = new examen_ap.main_dbDataSetTableAdapters.VISTA1TableAdapter();
            this.tableAdapterManager = new examen_ap.main_dbDataSetTableAdapters.TableAdapterManager();
            this.vISTA1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vISTA1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vISTA1DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_totales_por_alumno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.main_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTA1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTA1BindingNavigator)).BeginInit();
            this.vISTA1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vISTA1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // main_dbDataSet
            // 
            this.main_dbDataSet.DataSetName = "main_dbDataSet";
            this.main_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vISTA1BindingSource
            // 
            this.vISTA1BindingSource.DataMember = "VISTA1";
            this.vISTA1BindingSource.DataSource = this.main_dbDataSet;
            // 
            // vISTA1TableAdapter
            // 
            this.vISTA1TableAdapter.ClearBeforeFill = true;
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
            // vISTA1BindingNavigator
            // 
            this.vISTA1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vISTA1BindingNavigator.BindingSource = this.vISTA1BindingSource;
            this.vISTA1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vISTA1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vISTA1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vISTA1BindingNavigatorSaveItem});
            this.vISTA1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vISTA1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vISTA1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vISTA1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vISTA1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vISTA1BindingNavigator.Name = "vISTA1BindingNavigator";
            this.vISTA1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vISTA1BindingNavigator.Size = new System.Drawing.Size(634, 25);
            this.vISTA1BindingNavigator.TabIndex = 0;
            this.vISTA1BindingNavigator.Text = "bindingNavigator1";
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
            // vISTA1BindingNavigatorSaveItem
            // 
            this.vISTA1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vISTA1BindingNavigatorSaveItem.Enabled = false;
            this.vISTA1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vISTA1BindingNavigatorSaveItem.Image")));
            this.vISTA1BindingNavigatorSaveItem.Name = "vISTA1BindingNavigatorSaveItem";
            this.vISTA1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vISTA1BindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // vISTA1DataGridView
            // 
            this.vISTA1DataGridView.AllowUserToAddRows = false;
            this.vISTA1DataGridView.AllowUserToDeleteRows = false;
            this.vISTA1DataGridView.AutoGenerateColumns = false;
            this.vISTA1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vISTA1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.vISTA1DataGridView.DataSource = this.vISTA1BindingSource;
            this.vISTA1DataGridView.Location = new System.Drawing.Point(35, 108);
            this.vISTA1DataGridView.Name = "vISTA1DataGridView";
            this.vISTA1DataGridView.ReadOnly = true;
            this.vISTA1DataGridView.Size = new System.Drawing.Size(551, 179);
            this.vISTA1DataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total por intentos";
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
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CALIFICACION";
            this.dataGridViewTextBoxColumn5.HeaderText = "CALIFICACION";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(457, 293);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(129, 23);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_totales_por_alumno
            // 
            this.btn_totales_por_alumno.Location = new System.Drawing.Point(273, 293);
            this.btn_totales_por_alumno.Name = "btn_totales_por_alumno";
            this.btn_totales_por_alumno.Size = new System.Drawing.Size(129, 23);
            this.btn_totales_por_alumno.TabIndex = 5;
            this.btn_totales_por_alumno.Text = "Totales por alumno";
            this.btn_totales_por_alumno.UseVisualStyleBackColor = true;
            this.btn_totales_por_alumno.Click += new System.EventHandler(this.btn_totales_por_alumno_Click);
            // 
            // Totales_intento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 375);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_totales_por_alumno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vISTA1DataGridView);
            this.Controls.Add(this.vISTA1BindingNavigator);
            this.Name = "Totales_intento";
            this.Text = "Totales_intento";
            this.Load += new System.EventHandler(this.Totales_intento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.main_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTA1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTA1BindingNavigator)).EndInit();
            this.vISTA1BindingNavigator.ResumeLayout(false);
            this.vISTA1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vISTA1DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private main_dbDataSet main_dbDataSet;
        private System.Windows.Forms.BindingSource vISTA1BindingSource;
        private main_dbDataSetTableAdapters.VISTA1TableAdapter vISTA1TableAdapter;
        private main_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vISTA1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vISTA1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView vISTA1DataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_totales_por_alumno;
    }
}