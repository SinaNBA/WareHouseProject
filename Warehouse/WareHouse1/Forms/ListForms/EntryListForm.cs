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
    public partial class EntryListForm : Form
    {
        public EntryListForm()
        {
            InitializeComponent();
        }

        private void EntryListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet1.VorudTbl' table. You can move, or remove it, as needed.
            this.vorudTblTableAdapter.Fill(this.storeDataSet1.VorudTbl);
            sqlDataAdapter1.Fill(storeDataSet1.VorudTbl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            object o = dataGridView1.SelectedRows;
        }
    }
}
