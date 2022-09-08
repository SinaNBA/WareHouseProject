using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.Forms.AddOrEditForms;

namespace Warehouse.Forms.WarehouseForms
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void BindGrid()
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                dgvProduct.AutoGenerateColumns = false;
                dgvProduct.DataSource = db.ViewModels.GetAllProducts();
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ProductAddEditForm frm = new ProductAddEditForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }
    }
}
