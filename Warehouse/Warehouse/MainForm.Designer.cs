namespace Warehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnReceive = new System.Windows.Forms.ToolStripButton();
            this.btnProduct = new System.Windows.Forms.ToolStripButton();
            this.btnShip = new System.Windows.Forms.ToolStripButton();
            this.btnStaff = new System.Windows.Forms.ToolStripButton();
            this.btnCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnSupplier = new System.Windows.Forms.ToolStripButton();
            this.btnBrand = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReceive,
            this.btnProduct,
            this.btnShip,
            this.btnStaff,
            this.btnCustomer,
            this.btnSupplier,
            this.btnBrand});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(799, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(116, 686);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnReceive
            // 
            this.btnReceive.Image = global::Warehouse.Properties.Resources.shopcartdown__1_;
            this.btnReceive.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReceive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReceive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReceive.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnReceive.Size = new System.Drawing.Size(115, 72);
            this.btnReceive.Text = "Receive";
            this.btnReceive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnProduct
            // 
            this.btnProduct.Image = global::Warehouse.Properties.Resources.archive_icon;
            this.btnProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProduct.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnProduct.Size = new System.Drawing.Size(115, 56);
            this.btnProduct.Text = "Product";
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnShip
            // 
            this.btnShip.Image = ((System.Drawing.Image)(resources.GetObject("btnShip.Image")));
            this.btnShip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnShip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShip.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnShip.Name = "btnShip";
            this.btnShip.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnShip.Size = new System.Drawing.Size(115, 72);
            this.btnShip.Text = "Ship";
            this.btnShip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnStaff
            // 
            this.btnStaff.Image = global::Warehouse.Properties.Resources.student_id;
            this.btnStaff.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStaff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStaff.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnStaff.Size = new System.Drawing.Size(115, 72);
            this.btnStaff.Text = "Staff";
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Image = global::Warehouse.Properties.Resources.student_id;
            this.btnCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnCustomer.Size = new System.Drawing.Size(115, 72);
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Image = global::Warehouse.Properties.Resources.student_id;
            this.btnSupplier.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSupplier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSupplier.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnSupplier.Size = new System.Drawing.Size(115, 72);
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnBrand
            // 
            this.btnBrand.Image = global::Warehouse.Properties.Resources.icons8_branding_48;
            this.btnBrand.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBrand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBrand.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnBrand.Size = new System.Drawing.Size(115, 72);
            this.btnBrand.Text = "Brands";
            this.btnBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Warehouse.Properties.Resources.shutterstock_153410534;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 686);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Warehouse";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnReceive;
        private System.Windows.Forms.ToolStripButton btnProduct;
        private System.Windows.Forms.ToolStripButton btnShip;
        private System.Windows.Forms.ToolStripButton btnBrand;
        private System.Windows.Forms.ToolStripButton btnStaff;
        private System.Windows.Forms.ToolStripButton btnCustomer;
        private System.Windows.Forms.ToolStripButton btnSupplier;
    }
}

