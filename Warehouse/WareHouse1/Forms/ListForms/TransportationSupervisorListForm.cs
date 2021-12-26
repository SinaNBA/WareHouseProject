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
    public partial class TransportationSupervisorListForm : Form
    {
        StoreDataSet.TahvilgirandeTblDataTable mtDS = new StoreDataSet.TahvilgirandeTblDataTable();
        StoreDataSetTableAdapters.TahvilgirandeTblTableAdapter mtDSA = new StoreDataSetTableAdapters.TahvilgirandeTblTableAdapter();
        public TransportationSupervisorListForm()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
                try
                {
                    mtDSA.Fill(mtDS);
                    var query = (from i in mtDS
                                 where i.name.StartsWith(textBox1.Text) || i.family.StartsWith(textBox1.Text)
                                 select new { name = i.name, family = i.family, Address = i.address, Tell = i.tell });
                    dataGridView1.DataSource = query.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }
        

        private void TransportationSupervisorListForm_Load(object sender, EventArgs e)
        {
            try
            {
                mtDSA.Fill(mtDS);
                var query = (from i in mtDS
                             select new { name = i.name, family = i.family, Address=i.address, Tell=i.tell }).ToList();
                dataGridView1.DataSource = query;
                int queryCount = (from i in mtDS
                                  select i).Count();
                label2.Text = (queryCount).ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
    }
}
