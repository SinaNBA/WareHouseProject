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
    public partial class RemovalForm : Form
    {
        public RemovalForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                sqlCommand1.Parameters.Clear();
                sqlCommand1.CommandText = "INSERT INTO KhorujTbl(kalacode, tahvilgirandecode, tedad, date, motesadicode) VALUES(@k,@t,@te,@d,@m)";

                
                SqlCommand com1 = new SqlCommand("SELECT kalacode, moshakhasat FROM KalaTbl WHERE (moshakhasat LIKE @m)", sqlConnection2);
                SqlCommand com2 = new SqlCommand("SELECT code, family FROM TahvilgirandeTbl WHERE (family LIKE @f)", sqlConnection3);
                SqlCommand com3 = new SqlCommand("SELECT motesadicode, family FROM MotesadiTbl WHERE (family LIKE @f)", sqlConnection4);
                com1.Parameters.Clear();
                com2.Parameters.Clear();
                com3.Parameters.Clear();
                com1.Parameters.AddWithValue("@m", comboBox1.Text);
                com2.Parameters.AddWithValue("@f", comboBox2.Text);
                com3.Parameters.AddWithValue("@f", comboBox3.Text);

                SqlDataReader dr1, dr2, dr3;
                sqlConnection2.Open();
                dr1 = com1.ExecuteReader();
                sqlConnection3.Open();
                dr2 = com2.ExecuteReader();
                sqlConnection4.Open();
                dr3 = com3.ExecuteReader();
                dr1.Read();
                dr2.Read();
                dr3.Read();

                sqlCommand1.Parameters.AddWithValue("@k", dr1["kalacode"]);
                sqlCommand1.Parameters.AddWithValue("@t", dr2["code"]);
                sqlCommand1.Parameters.AddWithValue("@te", textBox1.Text);
                sqlCommand1.Parameters.AddWithValue("@d", maskedTextBox1.Text);
                sqlCommand1.Parameters.AddWithValue("@m", dr3["motesadicode"]);
                sqlConnection2.Close();
                sqlConnection3.Close();
                sqlConnection4.Close();

                if (sqlConnection1.State == ConnectionState.Closed)
                    sqlConnection1.Open();

                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                MessageBox.Show("Added");
                textBox1.Clear();
                maskedTextBox1.Clear();
            }
            catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
                //throw;
            }
            
            

        }

        private void RemovalForm_Load(object sender, EventArgs e)
        {
            string connstr="Data Source=.;Initial Catalog=Store;Integrated Security=True";
            SqlConnection sqlcon1 = new SqlConnection(connstr);
            SqlConnection sqlcon2 = new SqlConnection(connstr);
            SqlConnection sqlcon3 = new SqlConnection(connstr);
            SqlCommand com1 = new SqlCommand("SELECT family FROM tahvilgirandeTbl", sqlcon1);
            SqlCommand com2 = new SqlCommand("SELECT moshakhasat FROM KalaTbl", sqlcon2);
            SqlCommand com3 = new SqlCommand("SELECT family FROM MotesadiTbl", sqlcon3);
            sqlcon1.Open();
            sqlcon2.Open();
            sqlcon3.Open();
            SqlDataReader dr1, dr2, dr3;
            dr1 = com1.ExecuteReader();
            dr2 = com2.ExecuteReader();
            dr3 = com3.ExecuteReader();
            while (dr1.Read())
                comboBox2.Items.Add(dr1["family"]);
            sqlcon1.Close();
            while (dr2.Read())
                comboBox1.Items.Add(dr2["moshakhasat"]);
            sqlcon2.Close();
            while (dr3.Read())
                comboBox3.Items.Add(dr3["family"]);
            sqlcon3.Close();


            
        }
    }
}
