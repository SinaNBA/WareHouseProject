namespace WareHouse1.Forms.EditForms
{
    partial class GoodsEditsForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.goodslbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.delbtn = new System.Windows.Forms.Button();
            this.Editbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codetxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cotxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Destxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new WareHouse1.StoreDataSet();
            this.kalaTblTableAdapter = new WareHouse1.StoreDataSetTableAdapters.KalaTblTableAdapter();
            this.kalacodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moshakhasatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sherkatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.goodslbl);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.delbtn);
            this.groupBox3.Controls.Add(this.Editbtn);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.codetxt);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Cotxt);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.Destxt);
            this.groupBox3.Location = new System.Drawing.Point(471, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 398);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // goodslbl
            // 
            this.goodslbl.AutoSize = true;
            this.goodslbl.BackColor = System.Drawing.SystemColors.Info;
            this.goodslbl.Location = new System.Drawing.Point(126, 50);
            this.goodslbl.Name = "goodslbl";
            this.goodslbl.Size = new System.Drawing.Size(41, 17);
            this.goodslbl.TabIndex = 16;
            this.goodslbl.Text = "Code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "GoodsCode:";
            // 
            // delbtn
            // 
            this.delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.delbtn.Location = new System.Drawing.Point(6, 332);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(89, 38);
            this.delbtn.TabIndex = 14;
            this.delbtn.Text = "Delete";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // Editbtn
            // 
            this.Editbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Editbtn.Location = new System.Drawing.Point(181, 332);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(89, 38);
            this.Editbtn.TabIndex = 13;
            this.Editbtn.Text = "Edit";
            this.Editbtn.UseVisualStyleBackColor = true;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.DeepPink;
            this.label7.Location = new System.Drawing.Point(104, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 32);
            this.label7.TabIndex = 7;
            this.label7.Text = "Edit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // codetxt
            // 
            this.codetxt.Location = new System.Drawing.Point(129, 160);
            this.codetxt.Name = "codetxt";
            this.codetxt.Size = new System.Drawing.Size(100, 22);
            this.codetxt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Company:";
            // 
            // Cotxt
            // 
            this.Cotxt.Location = new System.Drawing.Point(129, 120);
            this.Cotxt.Name = "Cotxt";
            this.Cotxt.Size = new System.Drawing.Size(100, 22);
            this.Cotxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Barcode:";
            // 
            // Destxt
            // 
            this.Destxt.Location = new System.Drawing.Point(129, 80);
            this.Destxt.Name = "Destxt";
            this.Destxt.Size = new System.Drawing.Size(100, 22);
            this.Destxt.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(7, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 398);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(210, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "GoodsList";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Find";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kalacodeDataGridViewTextBoxColumn,
            this.moshakhasatDataGridViewTextBoxColumn,
            this.sherkatDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(9, 83);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(443, 287);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "KalaTbl";
            this.bindingSource1.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "StoreDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kalaTblTableAdapter
            // 
            this.kalaTblTableAdapter.ClearBeforeFill = true;
            // 
            // kalacodeDataGridViewTextBoxColumn
            // 
            this.kalacodeDataGridViewTextBoxColumn.DataPropertyName = "kalacode";
            this.kalacodeDataGridViewTextBoxColumn.HeaderText = "GoodsCode";
            this.kalacodeDataGridViewTextBoxColumn.Name = "kalacodeDataGridViewTextBoxColumn";
            this.kalacodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moshakhasatDataGridViewTextBoxColumn
            // 
            this.moshakhasatDataGridViewTextBoxColumn.DataPropertyName = "moshakhasat";
            this.moshakhasatDataGridViewTextBoxColumn.HeaderText = "Description";
            this.moshakhasatDataGridViewTextBoxColumn.Name = "moshakhasatDataGridViewTextBoxColumn";
            // 
            // sherkatDataGridViewTextBoxColumn
            // 
            this.sherkatDataGridViewTextBoxColumn.DataPropertyName = "sherkat";
            this.sherkatDataGridViewTextBoxColumn.HeaderText = "Company";
            this.sherkatDataGridViewTextBoxColumn.Name = "sherkatDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Tag = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GoodsEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 508);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "GoodsEditForm";
            this.Text = "GoodsEditForm";
            this.Load += new System.EventHandler(this.GoodsEditForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label goodslbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cotxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Destxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private StoreDataSet storeDataSet;
        private StoreDataSetTableAdapters.KalaTblTableAdapter kalaTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalacodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moshakhasatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sherkatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}