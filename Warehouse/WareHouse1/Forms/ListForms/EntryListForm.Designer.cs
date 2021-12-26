namespace WareHouse1.Forms.ListForms
{
    partial class EntryListForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vorudcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forushandecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalacodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motesadicodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet1 = new WareHouse1.StoreDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.vorudTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vorudTblTableAdapter = new WareHouse1.StoreDataSetTableAdapters.VorudTblTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vorudTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(210, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "EntryList";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vorudcodeDataGridViewTextBoxColumn,
            this.forushandecodeDataGridViewTextBoxColumn,
            this.kalacodeDataGridViewTextBoxColumn,
            this.tedadDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.motesadicodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "VorudTbl";
            this.dataGridView1.DataSource = this.storeDataSet1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(535, 448);
            this.dataGridView1.TabIndex = 0;
            // 
            // vorudcodeDataGridViewTextBoxColumn
            // 
            this.vorudcodeDataGridViewTextBoxColumn.DataPropertyName = "vorudcode";
            this.vorudcodeDataGridViewTextBoxColumn.HeaderText = "vorudcode";
            this.vorudcodeDataGridViewTextBoxColumn.Name = "vorudcodeDataGridViewTextBoxColumn";
            this.vorudcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vorudcodeDataGridViewTextBoxColumn.Width = 80;
            // 
            // forushandecodeDataGridViewTextBoxColumn
            // 
            this.forushandecodeDataGridViewTextBoxColumn.DataPropertyName = "forushandecode";
            this.forushandecodeDataGridViewTextBoxColumn.HeaderText = "forushandecode";
            this.forushandecodeDataGridViewTextBoxColumn.Name = "forushandecodeDataGridViewTextBoxColumn";
            this.forushandecodeDataGridViewTextBoxColumn.Width = 115;
            // 
            // kalacodeDataGridViewTextBoxColumn
            // 
            this.kalacodeDataGridViewTextBoxColumn.DataPropertyName = "kalacode";
            this.kalacodeDataGridViewTextBoxColumn.HeaderText = "kalacode";
            this.kalacodeDataGridViewTextBoxColumn.Name = "kalacodeDataGridViewTextBoxColumn";
            this.kalacodeDataGridViewTextBoxColumn.Width = 65;
            // 
            // tedadDataGridViewTextBoxColumn
            // 
            this.tedadDataGridViewTextBoxColumn.DataPropertyName = "tedad";
            this.tedadDataGridViewTextBoxColumn.HeaderText = "tedad";
            this.tedadDataGridViewTextBoxColumn.Name = "tedadDataGridViewTextBoxColumn";
            this.tedadDataGridViewTextBoxColumn.Width = 45;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 90;
            // 
            // motesadicodeDataGridViewTextBoxColumn
            // 
            this.motesadicodeDataGridViewTextBoxColumn.DataPropertyName = "motesadicode";
            this.motesadicodeDataGridViewTextBoxColumn.HeaderText = "motesadicode";
            this.motesadicodeDataGridViewTextBoxColumn.Name = "motesadicodeDataGridViewTextBoxColumn";
            // 
            // storeDataSet1BindingSource
            // 
            this.storeDataSet1BindingSource.DataSource = this.storeDataSet1;
            this.storeDataSet1BindingSource.Position = 0;
            // 
            // storeDataSet1
            // 
            this.storeDataSet1.DataSetName = "StoreDataSet";
            this.storeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(6, 431);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(363, 26);
            this.textBox1.MaximumSize = new System.Drawing.Size(170, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 22);
            this.textBox1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(282, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Find";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=Store;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT VorudTbl.*\r\nFROM     VorudTbl";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM VorudTbl\r\nWHERE  (vorudcode = @v)";
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@v", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "vorudcode", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // vorudTblBindingSource
            // 
            this.vorudTblBindingSource.DataMember = "VorudTbl";
            this.vorudTblBindingSource.DataSource = this.storeDataSet1;
            // 
            // vorudTblTableAdapter
            // 
            this.vorudTblTableAdapter.ClearBeforeFill = true;
            // 
            // EntryListForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(549, 499);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "EntryListForm";
            this.Text = "EntryListForm";
            this.Load += new System.EventHandler(this.EntryListForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vorudTblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private StoreDataSet storeDataSet1;
        private System.Windows.Forms.BindingSource storeDataSet1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn vorudcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forushandecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalacodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motesadicodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource vorudTblBindingSource;
        private StoreDataSetTableAdapters.VorudTblTableAdapter vorudTblTableAdapter;

    }
}