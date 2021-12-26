using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WareHouse1.Forms.ListForms
{
    public partial class GoodsListForm : Form
    {
        public GoodsListForm()
        {
            InitializeComponent();
        }
        StoreDataSet.KalaTblDataTable kalaDS = new StoreDataSet.KalaTblDataTable();
        StoreDataSetTableAdapters.KalaTblTableAdapter kalaDSTA = new StoreDataSetTableAdapters.KalaTblTableAdapter();

        private void GoodsListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kalaDS;
            kalaDSTA.Fill(kalaDS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dt = kalaDS.NewRow();
            dt["moshakhasat"] = textBox1.Text;
            dt["sherkat"] = textBox2.Text;
            dt["code"] = textBox3.Text;
            kalaDS.Rows.Add(dt);
            kalaDSTA.Update(kalaDS);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //BindingContext[kalaDS].Position =Convert.ToInt32 (dataGridView1.se);
            kalaDS[BindingContext[kalaDS].Position].Delete();
            kalaDSTA.Update(kalaDS);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kalaDSTA.Update(kalaDS);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kalaDS.Clear();
            kalaDSTA.Fill(kalaDS);
        }


    }
}
