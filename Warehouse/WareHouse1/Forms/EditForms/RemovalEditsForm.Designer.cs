namespace WareHouse1.Forms.EditForms
{
    partial class RemovalEditsForm
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
            this.Datemtxt = new System.Windows.Forms.MaskedTextBox();
            this.Recodelbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.delbtn = new System.Windows.Forms.Button();
            this.Editbtn = new System.Windows.Forms.Button();
            this.Mcodetxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Notxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Goodstxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TRtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new WareHouse1.StoreDataSet();
            this.khorujTblTableAdapter = new WareHouse1.StoreDataSetTableAdapters.KhorujTblTableAdapter();
            this.khorujcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalacodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahvilgirandecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motesadicodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Datemtxt);
            this.groupBox3.Controls.Add(this.Recodelbl);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.delbtn);
            this.groupBox3.Controls.Add(this.Editbtn);
            this.groupBox3.Controls.Add(this.Mcodetxt);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.Notxt);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Goodstxt);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TRtxt);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(559, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 398);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // Datemtxt
            // 
            this.Datemtxt.Location = new System.Drawing.Point(145, 200);
            this.Datemtxt.Mask = "00/00/0000";
            this.Datemtxt.Name = "Datemtxt";
            this.Datemtxt.Size = new System.Drawing.Size(100, 22);
            this.Datemtxt.TabIndex = 17;
            this.Datemtxt.ValidatingType = typeof(System.DateTime);
            // 
            // Recodelbl
            // 
            this.Recodelbl.AutoSize = true;
            this.Recodelbl.BackColor = System.Drawing.SystemColors.Info;
            this.Recodelbl.Location = new System.Drawing.Point(142, 50);
            this.Recodelbl.Name = "Recodelbl";
            this.Recodelbl.Size = new System.Drawing.Size(41, 17);
            this.Recodelbl.TabIndex = 16;
            this.Recodelbl.Text = "Code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "RemovalCode:";
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
            // Mcodetxt
            // 
            this.Mcodetxt.Location = new System.Drawing.Point(145, 240);
            this.Mcodetxt.Name = "Mcodetxt";
            this.Mcodetxt.Size = new System.Drawing.Size(100, 22);
            this.Mcodetxt.TabIndex = 12;
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
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "GoodsCode:";
            // 
            // Notxt
            // 
            this.Notxt.Location = new System.Drawing.Point(145, 160);
            this.Notxt.Name = "Notxt";
            this.Notxt.Size = new System.Drawing.Size(100, 22);
            this.Notxt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "TrSupervisorCode:";
            // 
            // Goodstxt
            // 
            this.Goodstxt.Location = new System.Drawing.Point(145, 80);
            this.Goodstxt.Name = "Goodstxt";
            this.Goodstxt.Size = new System.Drawing.Size(100, 22);
            this.Goodstxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numbers:";
            // 
            // TRtxt
            // 
            this.TRtxt.Location = new System.Drawing.Point(145, 120);
            this.TRtxt.Name = "TRtxt";
            this.TRtxt.Size = new System.Drawing.Size(100, 22);
            this.TRtxt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "SupervisorCode:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dataGridView4);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.dataGridView3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 543);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(87, 47);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 10;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(226, 442);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Supervisor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(235, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Goods";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(212, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "TrSupervisor";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dataGridView4.Location = new System.Drawing.Point(9, 462);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(526, 75);
            this.dataGridView4.TabIndex = 6;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "motesadicode";
            this.Column10.HeaderText = "SupervisorCode";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "name";
            this.Column11.HeaderText = "Name";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "family";
            this.Column12.HeaderText = "Family";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "address";
            this.Column13.HeaderText = "Address";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "tell";
            this.Column14.HeaderText = "Tell";
            this.Column14.Name = "Column14";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView2.Location = new System.Drawing.Point(9, 266);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(526, 75);
            this.dataGridView2.TabIndex = 5;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "kalacode";
            this.Column6.HeaderText = "GoodsCode";
            this.Column6.Name = "Column6";
            this.Column6.Width = 90;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "moshakhasat";
            this.Column7.HeaderText = "Description";
            this.Column7.Name = "Column7";
            this.Column7.Width = 145;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "sherkat";
            this.Column8.HeaderText = "Company";
            this.Column8.Name = "Column8";
            this.Column8.Width = 145;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "code";
            this.Column9.HeaderText = "Barcode";
            this.Column9.Name = "Column9";
            this.Column9.Width = 110;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView3.Location = new System.Drawing.Point(9, 364);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(526, 75);
            this.dataGridView3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(204, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "RemovalList";
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
            this.khorujcodeDataGridViewTextBoxColumn,
            this.kalacodeDataGridViewTextBoxColumn,
            this.tahvilgirandecodeDataGridViewTextBoxColumn,
            this.tedadDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.motesadicodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(9, 83);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(526, 156);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "code";
            this.Column1.HeaderText = "TrSupervisorCode";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "family";
            this.Column3.HeaderText = "Family";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "address";
            this.Column4.HeaderText = "Address";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "tell";
            this.Column5.HeaderText = "Tell";
            this.Column5.Name = "Column5";
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
            this.khorujcodeDataGridViewTextBoxColumn.HeaderText = "RemovCode";
            this.khorujcodeDataGridViewTextBoxColumn.Name = "khorujcodeDataGridViewTextBoxColumn";
            this.khorujcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.khorujcodeDataGridViewTextBoxColumn.Width = 90;
            // 
            // kalacodeDataGridViewTextBoxColumn
            // 
            this.kalacodeDataGridViewTextBoxColumn.DataPropertyName = "kalacode";
            this.kalacodeDataGridViewTextBoxColumn.HeaderText = "GoodsCode";
            this.kalacodeDataGridViewTextBoxColumn.Name = "kalacodeDataGridViewTextBoxColumn";
            this.kalacodeDataGridViewTextBoxColumn.Width = 90;
            // 
            // tahvilgirandecodeDataGridViewTextBoxColumn
            // 
            this.tahvilgirandecodeDataGridViewTextBoxColumn.DataPropertyName = "tahvilgirandecode";
            this.tahvilgirandecodeDataGridViewTextBoxColumn.HeaderText = "TRSCode";
            this.tahvilgirandecodeDataGridViewTextBoxColumn.Name = "tahvilgirandecodeDataGridViewTextBoxColumn";
            this.tahvilgirandecodeDataGridViewTextBoxColumn.Width = 70;
            // 
            // tedadDataGridViewTextBoxColumn
            // 
            this.tedadDataGridViewTextBoxColumn.DataPropertyName = "tedad";
            this.tedadDataGridViewTextBoxColumn.HeaderText = "No";
            this.tedadDataGridViewTextBoxColumn.Name = "tedadDataGridViewTextBoxColumn";
            this.tedadDataGridViewTextBoxColumn.Width = 55;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // motesadicodeDataGridViewTextBoxColumn
            // 
            this.motesadicodeDataGridViewTextBoxColumn.DataPropertyName = "motesadicode";
            this.motesadicodeDataGridViewTextBoxColumn.HeaderText = "SPCode";
            this.motesadicodeDataGridViewTextBoxColumn.Name = "motesadicodeDataGridViewTextBoxColumn";
            this.motesadicodeDataGridViewTextBoxColumn.Width = 80;
            // 
            // RemovalEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 557);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "RemovalEditForm";
            this.Text = "RemovalEditForm";
            this.Load += new System.EventHandler(this.RemovalEditForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox Datemtxt;
        private System.Windows.Forms.Label Recodelbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.TextBox Mcodetxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Notxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Goodstxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TRtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private StoreDataSet storeDataSet;
        private StoreDataSetTableAdapters.KhorujTblTableAdapter khorujTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn khorujcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalacodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahvilgirandecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motesadicodeDataGridViewTextBoxColumn;

    }
}