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
    public partial class GoodsForm : Form
    {
        public GoodsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlCommand1.Parameters.Clear();
            sqlCommand1.CommandText = "INSERT INTO KalaTbl(moshakhasat, sherkat, Code)VALUES(@m,@s,@c)";
            sqlCommand1.Parameters.AddWithValue("@m", textBox1.Text);
            sqlCommand1.Parameters.AddWithValue("@s", textBox2.Text);
            sqlCommand1.Parameters.AddWithValue("@c", textBox3.Text);
            if (sqlConnection1.State == ConnectionState.Closed)
                sqlConnection1.Open();

            sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
            MessageBox.Show("Added");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            





        }
    }
}
