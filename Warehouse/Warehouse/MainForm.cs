using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.Forms.WarehouseForms;

namespace Warehouse
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            BrandForm frm = new BrandForm();
            frm.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            PersonForm.PersonFormId = 1;
            PersonFormShowDialog();
        }


        private void btnStaff_Click(object sender, EventArgs e)
        {
            PersonForm.PersonFormId = 2;
            PersonFormShowDialog();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            PersonForm.PersonFormId = 3;
            PersonFormShowDialog();
        }

        public void PersonFormShowDialog()
        {
            PersonForm frm = new PersonForm();
            frm.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductForm frm = new ProductForm();
            frm.ShowDialog();
        }
    }
}
