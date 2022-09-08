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
    public partial class PersonForm : Form
    {
        public static int PersonFormId = 0;
        public PersonForm()
        {
            InitializeComponent();
        }

        private void PersonsForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            PersonAddEditForm frm = new PersonAddEditForm();
            frm.PersonFormId = PersonFormId;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            };
        }

        private void BindGrid()
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                dgvPerson.AutoGenerateColumns = false;
                switch (PersonFormId)
                {
                    case 1:
                        dgvPerson.DataSource = db.CustomerRepository.GetAll();
                        this.Text = "Customers";
                        break;
                    case 2:
                        dgvPerson.DataSource = db.StaffRepository.GetAll();
                        this.Text = "Staffs";

                        break;
                    case 3:
                        dgvPerson.DataSource = db.SupplierRepository.GetAll();
                        this.Text = "Suppliers";
                        break;


                    default:
                        MessageBox.Show("Person Form Id is not correct!");
                        break;
                }

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPerson.CurrentRow != null)
            {
                string name = dgvPerson.CurrentRow.Cells[1].Value.ToString();
                if (MessageBox.Show($"Are you sure you want to delete {name} ?", "Delete Row", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = int.Parse(dgvPerson.CurrentRow.Cells[0].Value.ToString());
                    using (WarehouseContext db = new WarehouseContext())
                    {
                        switch (PersonFormId)
                        {
                            case 1:
                                db.CustomerRepository.Delete(id);
                                break;
                            case 2:
                                db.StaffRepository.Delete(id);
                                break;
                            case 3:
                                db.SupplierRepository.Delete(id);
                                break;
                            default:
                                MessageBox.Show("Person Form Id is not correct!");
                                break;
                        }
                        db.Save();
                        BindGrid();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            PersonAddEditForm frm = new PersonAddEditForm();
            frm.PersonFormId = PersonFormId;
            if (dgvPerson.CurrentRow != null)
            {
                int id = int.Parse(dgvPerson.CurrentRow.Cells[0].Value.ToString());
                frm.PersonId = id;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                };
            }
            else
            {
                MessageBox.Show("Please select from the list below");
            }

        }
    }
}
