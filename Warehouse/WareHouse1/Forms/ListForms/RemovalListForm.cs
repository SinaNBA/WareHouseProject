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
    public partial class RemovalListForm : Form
    {
        public RemovalListForm()
        {
            InitializeComponent();
        }

        private void RemovalListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.KhorujTbl' table. You can move, or remove it, as needed.
            this.khorujTblTableAdapter.Fill(this.storeDataSet.KhorujTbl);

        }
        




    }
}
