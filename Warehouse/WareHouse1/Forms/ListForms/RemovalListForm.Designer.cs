namespace WareHouse1.Forms.ListForms
{
    partial class RemovalListForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new WareHouse1.StoreDataSet();
            this.khorujTblTableAdapter = new WareHouse1.StoreDataSetTableAdapters.KhorujTblTableAdapter();
            this.khorujcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalacodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahvilgirandecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daterealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motesadicodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.khorujcodeDataGridViewTextBoxColumn,
            this.kalacodeDataGridViewTextBoxColumn,
            this.tahvilgirandecodeDataGridViewTextBoxColumn,
            this.tedadDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.daterealDataGridViewTextBoxColumn,
            this.motesadicodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(639, 498);
            this.dataGridView1.TabIndex = 1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "KhorujTbl";
            this.bindingSource1.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "StoreDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khorujTblTableAdapter
            // 
            this.khorujTblTableAdapter.ClearBeforeFill = true;
            // 
            // khorujcodeDataGridViewTextBoxColumn
            // 
            this.khorujcodeDataGridViewTextBoxColumn.DataPropertyName = "khorujcode";
            this.khorujcodeDataGridViewTextBoxColumn.HeaderText = "khorujcode";
            this.khorujcodeDataGridViewTextBoxColumn.Name = "khorujcodeDataGridViewTextBoxColumn";
            this.khorujcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kalacodeDataGridViewTextBoxColumn
            // 
            this.kalacodeDataGridViewTextBoxColumn.DataPropertyName = "kalacode";
            this.kalacodeDataGridViewTextBoxColumn.HeaderText = "kalacode";
            this.kalacodeDataGridViewTextBoxColumn.Name = "kalacodeDataGridViewTextBoxColumn";
            // 
            // tahvilgirandecodeDataGridViewTextBoxColumn
            // 
            this.tahvilgirandecodeDataGridViewTextBoxColumn.DataPropertyName = "tahvilgirandecode";
            this.tahvilgirandecodeDataGridViewTextBoxColumn.HeaderText = "tahvilgirandecode";
            this.tahvilgirandecodeDataGridViewTextBoxColumn.Name = "tahvilgirandecodeDataGridViewTextBoxColumn";
            // 
            // tedadDataGridViewTextBoxColumn
            // 
            this.tedadDataGridViewTextBoxColumn.DataPropertyName = "tedad";
            this.tedadDataGridViewTextBoxColumn.HeaderText = "tedad";
            this.tedadDataGridViewTextBoxColumn.Name = "tedadDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // daterealDataGridViewTextBoxColumn
            // 
            this.daterealDataGridViewTextBoxColumn.DataPropertyName = "datereal";
            this.daterealDataGridViewTextBoxColumn.HeaderText = "datereal";
            this.daterealDataGridViewTextBoxColumn.Name = "daterealDataGridViewTextBoxColumn";
            // 
            // motesadicodeDataGridViewTextBoxColumn
            // 
            this.motesadicodeDataGridViewTextBoxColumn.DataPropertyName = "motesadicode";
            this.motesadicodeDataGridViewTextBoxColumn.HeaderText = "motesadicode";
            this.motesadicodeDataGridViewTextBoxColumn.Name = "motesadicodeDataGridViewTextBoxColumn";
            // 
            // RemovalListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 534);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RemovalListForm";
            this.Text = "RemovalListForm";
            this.Load += new System.EventHandler(this.RemovalListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private StoreDataSet storeDataSet;
        private StoreDataSetTableAdapters.KhorujTblTableAdapter khorujTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn khorujcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalacodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahvilgirandecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daterealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motesadicodeDataGridViewTextBoxColumn;
    }
}