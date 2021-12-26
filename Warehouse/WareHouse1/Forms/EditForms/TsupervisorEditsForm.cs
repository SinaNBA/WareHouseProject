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
    public partial class TsupervisorEditsForm : Form
    {
        public TsupervisorEditsForm()
        {
            InitializeComponent();
        }

        private void TsupervisorEditsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.TahvilgirandeTbl' table. You can move, or remove it, as needed.
            this.tahvilgirandeTblTableAdapter.Fill(this.storeDataSet.TahvilgirandeTbl);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TahvilgirandeTbl q = new TahvilgirandeTbl();
                int i = e.RowIndex;
                if (i == -1)
                    return;
                else
                {
                    int i1 = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    q = LogicalManagerTsupervisor.seletItem(i1);
                    tcodelbl.Text = (q.code).ToString();
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
                    List<TahvilgirandeTbl> q1 = new List<TahvilgirandeTbl>();
                    EntityLayer.StoreEntities db = new StoreEntities();
                    string s = textBox1.Text;
                    q1 = (from b in db.TahvilgirandeTbl
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

        private void Editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                TahvilgirandeTbl q1 = new TahvilgirandeTbl();
                int code = Convert.ToInt32(tcodelbl.Text);
                q1 = LogicalManagerTsupervisor.seletItem(code);
                q1.name = nametxt.Text;
                q1.family = familytxt.Text;
                q1.address = addtxt.Text;
                q1.tell = telltxt.Text;
                Int64 r = LogicalManagerTsupervisor.update(q1);
                if (r > -1)
                {
                    tcodelbl.Text = "Code";
                    nametxt.Clear();
                    familytxt.Clear();
                    addtxt.Clear();
                    telltxt.Clear();
                    MessageBox.Show("Edited");
                    List<TahvilgirandeTbl> q2 = new List<TahvilgirandeTbl>();
                    q2 = LogicalManagerTsupervisor.seletlist();
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

        private void delbtn_Click(object sender, EventArgs e)
        {
            try
            {

                TahvilgirandeTbl q = new TahvilgirandeTbl();
                int code = int.Parse(tcodelbl.Text);
                Int64 r = LogicalManagerTsupervisor.delete(code);
                if (r > -1)
                {
                    tcodelbl.Text = "Code";
                    nametxt.Clear();
                    familytxt.Clear();
                    addtxt.Clear();
                    telltxt.Clear();

                    MessageBox.Show("Deleted");
                    List<TahvilgirandeTbl> q1 = new List<TahvilgirandeTbl>();
                    q1 = LogicalManagerTsupervisor.seletlist();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
