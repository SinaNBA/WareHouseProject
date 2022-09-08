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

namespace Warehouse.Forms.WarehouseForms
{
    public partial class BrandForm : Form
    {
        public BrandForm()
        {
            InitializeComponent();
        }

        private void BrandForm_Load(object sender, EventArgs e)
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                dgvBrand.AutoGenerateColumns = false;
                dgvBrand.DataSource = db.BrandRepository.GetAll();
            }

        }
    }
}
