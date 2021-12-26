using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace WareHouse1.Forms.ListForms
{
    public partial class WarehouseSupervisorListForm : Form
    {
        public WarehouseSupervisorListForm()
        {
            InitializeComponent();
        }
        StoreDataSet.MotesadiTblDataTable mtDS = new StoreDataSet.MotesadiTblDataTable();
        StoreDataSetTableAdapters.MotesadiTblTableAdapter mtDSA = new StoreDataSetTableAdapters.MotesadiTblTableAdapter();


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mtDSA.Fill(mtDS);
                var query = (from i in mtDS
                             where i.name.StartsWith(textBox1.Text) || i.family.StartsWith(textBox1.Text)
                             select new { name = i.name, family = i.family });
                dataGridView1.DataSource = query.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            
            
            
        }
        
        private void PersonelFormList_Load(object sender, EventArgs e)
        {
            try 
	{	        
		mtDSA.Fill(mtDS);
        var query = (from i in mtDS
                     select new { name = i.name, family = i.family }).ToList();
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
