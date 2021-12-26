using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WareHouse1.Forms;
using WareHouse1.Forms.ListForms;
using WareHouse1.Forms.EditForms;

namespace WareHouse1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            EntryForm frm = new EntryForm();
            this.AddOwnedForm(frm);
            frm.Show();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            GoodsForm frm = new GoodsForm();
            this.AddOwnedForm(frm);
            frm.Show();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SellerForm frm = new SellerForm();
            this.AddOwnedForm(frm);
            frm.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            WarehouseSupervisorForm frm = new WarehouseSupervisorForm();
            this.AddOwnedForm(frm);
            frm.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            RemovalForm frm = new RemovalForm();
            this.AddOwnedForm(frm);
            frm.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            TransportationSupervisorForm frm = new TransportationSupervisorForm();
            this.AddOwnedForm(frm);
            frm.Show();
        }

        private void entryListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntryListForm frm = new EntryListForm();
            this.AddOwnedForm(frm);
            frm.Show();
        }

        private void goodsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsListForm frm = new GoodsListForm();
            this.AddOwnedForm(frm);
            frm.Show();
        }

        private void goodsListToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GoodsListForm frm = new GoodsListForm();
            this.AddOwnedForm(frm);
            frm.Show();
        }

        private void personelListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WarehouseSupervisorListForm frm = new WarehouseSupervisorListForm();
            this.AddOwnedForm(frm);
            frm.Show();
        }

        private void removalFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemovalListForm frm = new RemovalListForm();
            this.AddOwnedForm(frm);
            frm.Show();
        }

        private void entryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntryEditsForm frm = new EntryEditsForm();
            this.AddOwnedForm(frm);
            frm.Show();
        }

        private void sellerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellerListForm frm = new SellerListForm();
            this.AddOwnedForm(frm);
            frm.Show();
        }

        private void warehouseSupervisorListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WarehouseSupervisorListForm frm = new WarehouseSupervisorListForm();
            this.AddOwnedForm(frm);
            frm.Show();
        }

        private void goodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsEditsForm frm = new GoodsEditsForm();
            this.AddOwnedForm(frm);
            frm.Show();
        }

        private void removalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemovalEditsForm frm = new RemovalEditsForm();
            this.AddOwnedForm(frm);
            frm.Show();

        }

        private void sellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellerEditsForm frm = new SellerEditsForm();
            this.AddOwnedForm(frm);
            frm.Show();
        }

        private void transportationSupervisorListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransportationSupervisorListForm frm = new TransportationSupervisorListForm();
            this.AddOwnedForm(frm);
            frm.Show();
        }

        private void transportationSupervisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TsupervisorEditsForm frm = new TsupervisorEditsForm();
            this.AddOwnedForm(frm);
            frm.Show();
        }

        private void warehouseSupervisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WsupervisorEditsForm frm = new WsupervisorEditsForm();
            this.AddOwnedForm(frm);
            frm.Show();
        }

    }
}
