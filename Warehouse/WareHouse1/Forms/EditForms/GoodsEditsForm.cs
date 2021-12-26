using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EntityLayer;
using Logical;
using System.Data.Entity;

namespace WareHouse1.Forms.EditForms
{
    public partial class GoodsEditsForm : Form
    {
        public GoodsEditsForm()
        {
            InitializeComponent();
        }

        private void GoodsEditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.KalaTbl' table. You can move, or remove it, as needed.
            this.kalaTblTableAdapter.Fill(this.storeDataSet.KalaTbl);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (textBox1.Text.Trim() == "")
                {
                    errorProvider1.SetError(textBox1, "Enter the Description");
                }
                else
                {
                    List<KalaTbl> q1 = new List<KalaTbl>();
                    EntityLayer.StoreEntities db = new StoreEntities();
                    string s = textBox1.Text;
                    q1 = (from b in db.KalaTbl
                          where b.moshakhasat.StartsWith(s)
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
                KalaTbl q1 = new KalaTbl();
                int code = Convert.ToInt32(goodslbl.Text);
                q1 = LogicalManagerGoods.selectItem(code);
                q1.moshakhasat = Destxt.Text;
                q1.sherkat = Cotxt.Text;
                q1.code = codetxt.Text;
                Int64 r = LogicalManagerGoods.update(q1);
                if (r > -1)
                {
                    goodslbl.Text = "Code";
                    Destxt.Clear();
                    Cotxt.Clear();
                    codetxt.Clear();
                    MessageBox.Show("Edited");
                    List<KalaTbl> q2 = new List<KalaTbl>();
                    q2 = LogicalManagerGoods.selectList();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                KalaTbl q = new KalaTbl();
                int i = e.RowIndex;
                if (i == -1)
                    return;
                else
                {
                    int i1=Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    q = LogicalManagerGoods.selectItem(i1);
                    goodslbl.Text = (q.kalacode).ToString();
                    Destxt.Text = q.moshakhasat;
                    Cotxt.Text = q.sherkat;
                    codetxt.Text = q.code;
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
                
                KalaTbl q = new KalaTbl();
                int code = int.Parse(goodslbl.Text);
                Int64 r=LogicalManagerGoods.delete(code);
                if (r > -1)
                {
                    goodslbl.Text = "Code";
                    Destxt.Clear();
                    Cotxt.Clear();
                    codetxt.Clear();
                    
                    MessageBox.Show("Deleted");
                    List<KalaTbl> q1 = new List<KalaTbl>();
                    q1 = LogicalManagerGoods.selectList();
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

    }
}
