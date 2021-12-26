using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using EntityLayer;
using Logical;

namespace WareHouse1.Forms.EditForms
{
    public partial class SellerEditsForm : Form
    {
        public SellerEditsForm()
        {
            InitializeComponent();
        }

        private void SellerEditsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.ForushandeTbl' table. You can move, or remove it, as needed.
            this.forushandeTblTableAdapter.Fill(this.storeDataSet.ForushandeTbl);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ForushandeTbl q = new ForushandeTbl();
                int i = e.RowIndex;
                if (i == -1)
                    return;
                else
                {
                    int i1 = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    q = LogicalManagerSeller.seletItem(i1);
                    sellercodelbl.Text = (q.forushandecode).ToString();
                    nametxt.Text = q.name;
                    familytxt.Text = q.family;
                    addtxt.Text = q.address;
                    telltxt.Text = q.tell;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (textBox1.Text.Trim() == "")
                {
                    errorProvider1.SetError(textBox1, "Enter the Name or Family");
                }
                else
                {
                    List<ForushandeTbl> q1 = new List<ForushandeTbl>();
                    EntityLayer.StoreEntities db = new StoreEntities();
                    string s = textBox1.Text;
                    q1 = (from b in db.ForushandeTbl
                          where (b.name.StartsWith(s) || b.family.StartsWith(s))
                          select b).ToList();
                    dataGridView1.DataSource = q1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            try
            {

                ForushandeTbl q = new ForushandeTbl();
                int code = int.Parse(sellercodelbl.Text);
                Int64 r = LogicalManagerSeller.delete(code);
                if (r > -1)
                {
                    sellercodelbl.Text = "Code";
                    nametxt.Clear();
                    familytxt.Clear();
                    addtxt.Clear();
                    telltxt.Clear();

                    MessageBox.Show("Deleted");
                    List<ForushandeTbl> q1 = new List<ForushandeTbl>();
                    q1 = LogicalManagerSeller.seletlist();
                    dataGridView1.DataSource = q1;
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ForushandeTbl q1 = new ForushandeTbl();
                int code = Convert.ToInt32(sellercodelbl.Text);
                q1 = LogicalManagerSeller.seletItem(code);
                q1.name = nametxt.Text;
                q1.family = familytxt.Text;
                q1.address = addtxt.Text;
                q1.tell = telltxt.Text;
                Int64 r = LogicalManagerSeller.update(q1);
                if (r > -1)
                {
                    sellercodelbl.Text = "Code";
                    nametxt.Clear();
                    familytxt.Clear();
                    addtxt.Clear();
                    telltxt.Clear();
                    MessageBox.Show("Edited");
                    List<ForushandeTbl> q2 = new List<ForushandeTbl>();
                    q2 = LogicalManagerSeller.seletlist();
                    dataGridView1.DataSource = q2;
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
