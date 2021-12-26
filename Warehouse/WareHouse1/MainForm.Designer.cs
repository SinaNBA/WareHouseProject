namespace WareHouse1
{
    partial class MainForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseSupervisorListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportationSupervisorListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removalFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.transportationSupervisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseSupervisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(539, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(160, 489);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listsToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listsToolStripMenuItem
            // 
            this.listsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entryListToolStripMenuItem,
            this.sellerListToolStripMenuItem,
            this.warehouseSupervisorListToolStripMenuItem,
            this.transportationSupervisorListToolStripMenuItem,
            this.goodsListToolStripMenuItem,
            this.personelListToolStripMenuItem,
            this.removalFormToolStripMenuItem});
            this.listsToolStripMenuItem.Name = "listsToolStripMenuItem";
            this.listsToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.listsToolStripMenuItem.Text = "List\'s";
            // 
            // entryListToolStripMenuItem
            // 
            this.entryListToolStripMenuItem.Name = "entryListToolStripMenuItem";
            this.entryListToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
            this.entryListToolStripMenuItem.Text = "EntryList";
            this.entryListToolStripMenuItem.Click += new System.EventHandler(this.entryListToolStripMenuItem_Click);
            // 
            // sellerListToolStripMenuItem
            // 
            this.sellerListToolStripMenuItem.Name = "sellerListToolStripMenuItem";
            this.sellerListToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
            this.sellerListToolStripMenuItem.Text = "SellerList";
            this.sellerListToolStripMenuItem.Click += new System.EventHandler(this.sellerListToolStripMenuItem_Click);
            // 
            // warehouseSupervisorListToolStripMenuItem
            // 
            this.warehouseSupervisorListToolStripMenuItem.Name = "warehouseSupervisorListToolStripMenuItem";
            this.warehouseSupervisorListToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
            this.warehouseSupervisorListToolStripMenuItem.Text = "WarehouseSupervisorList";
            this.warehouseSupervisorListToolStripMenuItem.Click += new System.EventHandler(this.warehouseSupervisorListToolStripMenuItem_Click);
            // 
            // transportationSupervisorListToolStripMenuItem
            // 
            this.transportationSupervisorListToolStripMenuItem.Name = "transportationSupervisorListToolStripMenuItem";
            this.transportationSupervisorListToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
            this.transportationSupervisorListToolStripMenuItem.Text = "TransportationSupervisorList";
            this.transportationSupervisorListToolStripMenuItem.Click += new System.EventHandler(this.transportationSupervisorListToolStripMenuItem_Click);
            // 
            // goodsListToolStripMenuItem
            // 
            this.goodsListToolStripMenuItem.Name = "goodsListToolStripMenuItem";
            this.goodsListToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
            this.goodsListToolStripMenuItem.Text = "GoodsList";
            this.goodsListToolStripMenuItem.Click += new System.EventHandler(this.goodsListToolStripMenuItem_Click_1);
            // 
            // personelListToolStripMenuItem
            // 
            this.personelListToolStripMenuItem.Name = "personelListToolStripMenuItem";
            this.personelListToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
            this.personelListToolStripMenuItem.Text = "PersonelList";
            this.personelListToolStripMenuItem.Click += new System.EventHandler(this.personelListToolStripMenuItem_Click);
            // 
            // removalFormToolStripMenuItem
            // 
            this.removalFormToolStripMenuItem.Name = "removalFormToolStripMenuItem";
            this.removalFormToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
            this.removalFormToolStripMenuItem.Text = "RemovalFormList";
            this.removalFormToolStripMenuItem.Click += new System.EventHandler(this.removalFormToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entryToolStripMenuItem,
            this.goodsToolStripMenuItem,
            this.removalToolStripMenuItem,
            this.sellerToolStripMenuItem,
            this.transportationSupervisorToolStripMenuItem,
            this.warehouseSupervisorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // entryToolStripMenuItem
            // 
            this.entryToolStripMenuItem.Name = "entryToolStripMenuItem";
            this.entryToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.entryToolStripMenuItem.Text = "Entry";
            this.entryToolStripMenuItem.Click += new System.EventHandler(this.entryToolStripMenuItem_Click);
            // 
            // goodsToolStripMenuItem
            // 
            this.goodsToolStripMenuItem.Name = "goodsToolStripMenuItem";
            this.goodsToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.goodsToolStripMenuItem.Text = "Goods";
            this.goodsToolStripMenuItem.Click += new System.EventHandler(this.goodsToolStripMenuItem_Click);
            // 
            // removalToolStripMenuItem
            // 
            this.removalToolStripMenuItem.Name = "removalToolStripMenuItem";
            this.removalToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.removalToolStripMenuItem.Text = "Removal";
            this.removalToolStripMenuItem.Click += new System.EventHandler(this.removalToolStripMenuItem_Click);
            // 
            // sellerToolStripMenuItem
            // 
            this.sellerToolStripMenuItem.Name = "sellerToolStripMenuItem";
            this.sellerToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.sellerToolStripMenuItem.Text = "Seller";
            this.sellerToolStripMenuItem.Click += new System.EventHandler(this.sellerToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::WareHouse1.Properties.Resources.shopcartdown__1_;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(158, 72);
            this.toolStripButton1.Text = "Entry";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::WareHouse1.Properties.Resources.archive_icon;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(158, 56);
            this.toolStripButton2.Text = "Goods";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::WareHouse1.Properties.Resources.add_group2;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(158, 88);
            this.toolStripButton3.Text = "Add Seller";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton4.Image = global::WareHouse1.Properties.Resources.add_group2;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(158, 85);
            this.toolStripButton4.Text = "Add Warehouse Supervisor";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton5.Image = global::WareHouse1.Properties.Resources.add_group2;
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(158, 85);
            this.toolStripButton5.Text = "Add Transportation Supervisor";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = global::WareHouse1.Properties.Resources.shopcartdown__1_1;
            this.toolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(158, 72);
            this.toolStripButton6.Text = "Removal";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // transportationSupervisorToolStripMenuItem
            // 
            this.transportationSupervisorToolStripMenuItem.Name = "transportationSupervisorToolStripMenuItem";
            this.transportationSupervisorToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.transportationSupervisorToolStripMenuItem.Text = "TransportationSupervisor";
            this.transportationSupervisorToolStripMenuItem.Click += new System.EventHandler(this.transportationSupervisorToolStripMenuItem_Click);
            // 
            // warehouseSupervisorToolStripMenuItem
            // 
            this.warehouseSupervisorToolStripMenuItem.Name = "warehouseSupervisorToolStripMenuItem";
            this.warehouseSupervisorToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.warehouseSupervisorToolStripMenuItem.Text = "WarehouseSupervisor";
            this.warehouseSupervisorToolStripMenuItem.Click += new System.EventHandler(this.warehouseSupervisorToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WareHouse1.Properties.Resources.shutterstock_153410534;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(699, 517);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entryListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellerListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehouseSupervisorListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportationSupervisorListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removalFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportationSupervisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehouseSupervisorToolStripMenuItem;
    }
}

