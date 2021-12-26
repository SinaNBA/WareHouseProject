using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WareHouse1.Forms
{
    public partial class WarehouseSupervisorForm : Form
    {
        public WarehouseSupervisorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlCommand1.Parameters.Clear();
            sqlCommand1.CommandText = "INSERT INTO MotesadiTbl(name, family, address, tell)VALUES(@n,@f,@a,@t)";
            sqlCommand1.Parameters.AddWithValue("@n", textBox1.Text);
            sqlCommand1.Parameters.AddWithValue("@f", textBox2.Text);
            sqlCommand1.Parameters.AddWithValue("@a", textBox3.Text);
            sqlCommand1.Parameters.AddWithValue("@t", textBox4.Text);
            if (sqlConnection1.State == ConnectionState.Closed)
                sqlConnection1.Open();

            sqlCommand1.ExecuteNonQuery();
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
