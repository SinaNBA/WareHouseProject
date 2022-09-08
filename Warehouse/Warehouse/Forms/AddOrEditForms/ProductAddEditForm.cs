using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModels;

namespace Warehouse.Forms.AddOrEditForms
{
    public partial class ProductAddEditForm : Form
    {
        public ProductAddEditForm()
        {
            InitializeComponent();
        }

        private void ProductAddEditForm_Load(object sender, EventArgs e)
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                // Filling Brands ComboBox
                List<BrandViewModel> brandViewsList = new List<BrandViewModel>();
                brandViewsList.Add(new BrandViewModel { Id = 0, Title = "Choose" });
                brandViewsList.AddRange(db.ViewModels.GetAllBrandNameId());
                cbBrands.DataSource = brandViewsList;
                cbBrands.DisplayMember = "Title";
                cbBrands.ValueMember = "Id";

                // Filling  ComboBox QuantityType
                List<QuantityTypeViewModel> typeViewModels = new List<QuantityTypeViewModel>();
                typeViewModels.Add(new QuantityTypeViewModel { Id = 0, Type = "Choose" });
                typeViewModels.AddRange(db.ViewModels.GetAllQuantityTypes());
                cbQuantityType.DataSource = typeViewModels;
                cbQuantityType.DisplayMember = "Type";
                cbQuantityType.ValueMember = "Id";
            }


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                Products product = new Products()
                {
                    Name = txtName.Text,
                    Stock = int.Parse(txtStock.Text),
                    QuantityTypeId = (int)cbQuantityType.SelectedValue,
                    BrandId = (int)cbBrands.SelectedValue,
                };
                bool isSuccess = db.ProductRepository.Insert(product);
                db.Save();
                if (!isSuccess)
                {
                    MessageBox.Show("The operation failed");

                }
                else
                {
                    MessageBox.Show("Done");
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
