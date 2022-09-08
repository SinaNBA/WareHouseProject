using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse.Forms.AddOrEditForms
{
    public partial class PersonAddEditForm : Form
    {
        public int PersonFormId = 0;
        public int PersonId = 0;
        public PersonAddEditForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFile.FileName;
            }
        }

        private void PersonAddEditForm_Load(object sender, EventArgs e)
        {
            if (PersonId != 0)
            {
                this.Text = "Edit";
                PersonModel person = new PersonModel();
                using (WarehouseContext db = new WarehouseContext())
                {
                    if (PersonFormId == 1)
                    {
                        person = db.CustomerRepository.GetById(PersonId).ToPersonModel();
                    }
                    else if (PersonFormId == 2)
                    {
                        person = db.StaffRepository.GetById(PersonId).ToPersonModel();
                    }
                    else if (PersonFormId == 3)
                    {
                        person = db.SupplierRepository.GetById(PersonId).ToPersonModel();
                    }
                }
                txtName.Text = person.Name;
                txtPhone.Text = person.Phone;
                txtEmail.Text = person.Email;
                txtAddress.Text = person.Address;
                pictureBox1.ImageLocation = Application.StartupPath + "/Images/" + person.Image;
            }
            else
            {
                switch (PersonFormId)
                {
                    case 1:
                        this.Text = "New Customers";
                        break;
                    case 2:
                        this.Text = "New Staffs";

                        break;
                    case 3:
                        this.Text = "New Suppliers";
                        break;

                    default:
                        MessageBox.Show("Person Form Id is not correct!");
                        break;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pictureBox1.ImageLocation);
                string path = Application.StartupPath + "/Images/";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                pictureBox1.Image.Save(path + imageName);
                PersonModel personModel = new PersonModel()
                {
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    Image = imageName
                };
                bool isSuccess = false;
                switch (PersonFormId)
                {
                    case 1:
                        Customers customer = new Customers();
                        if (PersonId == 0)
                        {
                            customer = personModel.ToCustomer();
                            isSuccess = db.CustomerRepository.Insert(customer);
                        }
                        else
                        {
                            customer = personModel.ToCustomer();
                            customer.Id = PersonId;
                            isSuccess = db.CustomerRepository.Update(customer);
                        }
                        break;
                    case 2:
                        Staffs staff = new Staffs();
                        if (PersonId == 0)
                        {
                            staff = personModel.ToStaff();
                            isSuccess = db.StaffRepository.Insert(staff);
                        }
                        else
                        {
                            staff = personModel.ToStaff();
                            staff.Id = PersonId;
                            isSuccess = db.StaffRepository.Update(staff);
                        }
                        break;
                    case 3:
                        Suppliers supplier = new Suppliers();
                        if (PersonId == 0)
                        {
                            supplier = personModel.ToSupplier();
                            isSuccess = db.SupplierRepository.Insert(supplier);
                        }
                        else
                        {
                            supplier = personModel.ToSupplier();
                            supplier.Id = PersonId;
                            isSuccess = db.SupplierRepository.Update(supplier);
                        }
                        break;

                    default:
                        MessageBox.Show("Person Form Id is not correct!");
                        break;
                }
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
