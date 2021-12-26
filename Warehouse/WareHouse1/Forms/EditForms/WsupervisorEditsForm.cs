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
    public partial class WsupervisorEditsForm : Form
    {
        public WsupervisorEditsForm()
        {
            InitializeComponent();
        }

        private void WsupervisorEditsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.MotesadiTbl' table. You can move, or remove it, as needed.
            this.motesadiTblTableAdapter.Fill(this.storeDataSet.MotesadiTbl);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MotesadiTbl q = new MotesadiTbl();
                int i = e.RowIndex;
                if (i == -1)
                    return;
                else
                {
                    int i1 = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    q = LogicalManagerSupervisor.seletItem(i1);
                    mcodetxt.Text = (q.motesadicode).ToString();
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
                    List<MotesadiTbl> q1 = new List<MotesadiTbl>();
                    EntityLayer.StoreEntities db = new StoreEntities();
                    string s = textBox1.Text;
                    q1 = (from b in db.MotesadiTbl
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

                MotesadiTbl q = new MotesadiTbl();
                int code = int.Parse(mcodetxt.Text);
                Int64 r = LogicalManagerSupervisor.delete(code);
                if (r > -1)
                {
                    mcodetxt.Text = "Code";
                    nametxt.Clear();
                    familytxt.Clear();
                    addtxt.Clear();
                    telltxt.Clear();

                    MessageBox.Show("Deleted");
                    List<MotesadiTbl> q1 = new List<MotesadiTbl>();
                    q1 = LogicalManagerSupervisor.seletlist();
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
                MotesadiTbl q1 = new MotesadiTbl();
                int code = Convert.ToInt32(mcodetxt.Text);
                q1 = LogicalManagerSupervisor.seletItem(code);
                q1.name = nametxt.Text;
                q1.family = familytxt.Text;
                q1.address = addtxt.Text;
                q1.tell = telltxt.Text;
                Int64 r = LogicalManagerSupervisor.update(q1);
                if (r > -1)
                {
                    mcodetxt.Text = "Code";
                    nametxt.Clear();
                    familytxt.Clear();
                    addtxt.Clear();
                    telltxt.Clear();
                    MessageBox.Show("Edited");
                    List<MotesadiTbl> q2 = new List<MotesadiTbl>();
                    q2 = LogicalManagerSupervisor.seletlist();
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
