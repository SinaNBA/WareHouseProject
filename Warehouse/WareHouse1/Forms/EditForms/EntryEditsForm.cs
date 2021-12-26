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
    public partial class EntryEditsForm : Form
    {
        public EntryEditsForm()
        {
            InitializeComponent();
        }
       
        private void EntryEditsForm_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'storeDataSet.VorudTbl' table. You can move, or remove it, as needed.
            this.vorudTblTableAdapter.Fill(this.storeDataSet.VorudTbl);

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
                    var q = (from b in db.ForushandeTbl
                             where b.forushandecode == i1
                             select new { b.forushandecode, b.name, b.family, b.address, b.tell }).ToList();
                    dataGridView2.DataSource = q;
                    var q2 = (from b in db.KalaTbl
                              where b.kalacode == i2
                              select new { b.kalacode, b.moshakhasat, b.sherkat, b.code }).ToList();
                    dataGridView3.DataSource = q2;
                    var q3 = (from b in db.MotesadiTbl
                              where b.motesadicode == i3
                              select new { b.motesadicode, b.name, b.family, b.address, b.tell }).ToList();
                    dataGridView4.DataSource = q3;
                    VorudTbl q4 = new VorudTbl();
                    q4 = LogicalManagerEntry.seletItem(i4);

                    vorudlbl.Text = (q4.vorudcode).ToString();
                    Sellertxt.Text = (q4.forushandecode).ToString();
                    Goodstxt.Text = (q4.kalacode).ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                VorudTbl q = new VorudTbl();
                int code = int.Parse(vorudlbl.Text);
                q = LogicalManagerEntry.seletItem(code);
                
                                
                q.forushandecode = int.Parse(Sellertxt.Text);
                q.kalacode = int.Parse(Goodstxt.Text);
                q.tedad = int.Parse(Notxt.Text);
                q.date = Datemtxt.Text;
                q.motesadicode = int.Parse(Mcodetxt.Text);
                Int64 r=LogicalManagerEntry.update(q);
                if (r > -1)
                {
                    vorudlbl.Text = "Code";
                    Sellertxt.Clear();
                    Goodstxt.Clear();
                    Notxt.Clear();
                    Datemtxt.Clear();
                    Mcodetxt.Clear();
                    MessageBox.Show("Edited");
                    List<VorudTbl> q1 = new List<VorudTbl>();
                    q1 = LogicalManagerEntry.seletlist();
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
                VorudTbl q = new VorudTbl();
                int code = int.Parse(vorudlbl.Text);
                Int64 r=LogicalManagerEntry.delete(code);
                if (r > -1)
                {
                    vorudlbl.Text = "Code";
                    Sellertxt.Clear();
                    Goodstxt.Clear();
                    Notxt.Clear();
                    Datemtxt.Clear();
                    Mcodetxt.Clear();
                    MessageBox.Show("Deleted");
                    List<VorudTbl> q1 = new List<VorudTbl>();
                    q1 = LogicalManagerEntry.seletlist();
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

        private void button3_Click(object sender, EventArgs e)
        {
            List<VorudTbl> q = new List<VorudTbl>();
            StoreEntities db = new StoreEntities();
            string s=maskedTextBox1.Text;
            q = (from b in db.VorudTbl
                 where b.date.StartsWith(s)     
                 select b).ToList();
            dataGridView1.DataSource = q;
        }


    }
}
