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
    public partial class SellerListForm : Form
    {
        public SellerListForm()
        {
            InitializeComponent();
        }

        private void SellerListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.ForushandeTbl' table. You can move, or remove it, as needed.
            this.forushandeTblTableAdapter.Fill(this.storeDataSet.ForushandeTbl);

        }
    }
}
