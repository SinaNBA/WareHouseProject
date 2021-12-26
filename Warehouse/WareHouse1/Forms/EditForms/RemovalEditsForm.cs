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
    public partial class RemovalEditsForm : Form
    {
        public RemovalEditsForm()
        {
            InitializeComponent();
        }

        private void RemovalEditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.KhorujTbl' table. You can move, or remove it, as needed.
            this.khorujTblTableAdapter.Fill(this.storeDataSet.KhorujTbl);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<KhorujTbl> q = new List<KhorujTbl>();
            StoreEntities db = new StoreEntities();
            string s = maskedTextBox1.Text;
            q = (from b in db.KhorujTbl
                 where b.date.StartsWith(s)
                 select b).ToList();
            dataGridView1.DataSource = q;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                StoreEntities db = new StoreEntities();

                int i;
                i = e.RowIndex;
                if (i == -1)
                    return;
                else
                {
                    int i1 = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                    int i2 = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                    int i3 = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                    int i4 = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    var q = (from b in db.KalaTbl
                             where b.kalacode == i1
                             select new { b.kalacode, b.moshakhasat, b.sherkat, b.code }).ToList();
                    dataGridView2.DataSource = q;
                    var q2 = (from b in db.TahvilgirandeTbl
                              where b.code == i2
                              select new { b.code, b.name, b.family, b.address, b.tell }).ToList();
                    dataGridView3.DataSource = q2;
                    var q3 = (from b in db.MotesadiTbl
                              where b.motesadicode == i3
                              select new { b.motesadicode, b.name, b.family, b.address, b.tell }).ToList();
                    dataGridView4.DataSource = q3;
                    KhorujTbl q4 = new KhorujTbl();
                    q4 = LogicalManagerRemoval.seletItem(i4);

                    Recodelbl.Text = (q4.khorujcode).ToString();
                    Goodstxt.Text = (q4.kalacode).ToString();
                    TRtxt.Text = (q4.tahvilgirandecode).ToString();
                    Notxt.Text = (q4.tedad).ToString();
                    Datemtxt.Text = (q4.date).ToString();
                    Mcodetxt.Text = (q4.motesadicode).ToString();

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
                KhorujTbl q = new KhorujTbl();
                int code = int.Parse(Recodelbl.Text);
                q = LogicalManagerRemoval.seletItem(code);


                q.tahvilgirandecode = int.Parse(TRtxt.Text);
                q.kalacode = int.Parse(Goodstxt.Text);
                q.tedad = int.Parse(Notxt.Text);
                q.date = Datemtxt.Text;
                q.motesadicode = int.Parse(Mcodetxt.Text);
                Int64 r = LogicalManagerRemoval.update(q);
                if (r > -1)
                {
                    Recodelbl.Text = "Code";
                    TRtxt.Clear();
                    Goodstxt.Clear();
                    Notxt.Clear();
                    Datemtxt.Clear();
                    Mcodetxt.Clear();
                    MessageBox.Show("Edited");
                    List<KhorujTbl> q1 = new List<KhorujTbl>();
                    q1 = LogicalManagerRemoval.seletlist();
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

        private void delbtn_Click(object sender, EventArgs e)
        {
            try
            {
                KhorujTbl q = new KhorujTbl();
                int code = int.Parse(Recodelbl.Text);
                Int64 r = LogicalManagerRemoval.delete(code);
                if (r > -1)
                {
                    Recodelbl.Text = "Code";
                    TRtxt.Clear();
                    Goodstxt.Clear();
                    Notxt.Clear();
                    Datemtxt.Clear();
                    Mcodetxt.Clear();
                    MessageBox.Show("Deleted");
                    List<KhorujTbl> q1 = new List<KhorujTbl>();
                    q1 = LogicalManagerRemoval.seletlist();
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
