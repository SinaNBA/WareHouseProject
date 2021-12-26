using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WareHouse1.Forms
{
    public partial class TransportationSupervisorForm : Form
    {
        public TransportationSupervisorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.InsertCommand.Parameters["@n"].Value = textBox1.Text;
            sqlDataAdapter1.InsertCommand.Parameters["@f"].Value = textBox2.Text;
            sqlDataAdapter1.InsertCommand.Parameters["@a"].Value = textBox3.Text;
            sqlDataAdapter1.InsertCommand.Parameters["@t"].Value = textBox4.Text;
            sqlConnection1.Open();
            sqlDataAdapter1.InsertCommand.ExecuteNonQuery();
            sqlConnection1.Close();
            MessageBox.Show("Added");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
