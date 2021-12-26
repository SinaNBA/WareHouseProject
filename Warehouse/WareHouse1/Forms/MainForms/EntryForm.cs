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
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connstr = "Data Source=.;Initial Catalog=Store;Integrated Security=True";
                SqlConnection sqlcon1 = new SqlConnection(connstr);
                SqlConnection sqlcon2 = new SqlConnection(connstr);
                SqlConnection sqlcon3 = new SqlConnection(connstr);

                sqlCommand1.Parameters.Clear();
                sqlCommand1.CommandText = "INSERT INTO VorudTbl(forushandecode, kalacode, tedad, date, motesadicode) VALUES(@f,@k,@t,@d,@m)";

                SqlCommand com1 = new SqlCommand("SELECT forushandecode, family FROM ForushandeTbl WHERE (family LIKE @f)", sqlcon1);
                SqlCommand com2 = new SqlCommand("SELECT kalacode, moshakhasat FROM KalaTbl WHERE (moshakhasat LIKE @m)", sqlcon2);
                SqlCommand com3 = new SqlCommand("SELECT motesadicode, family FROM MotesadiTbl WHERE (family LIKE @f)", sqlcon3);
                com1.Parameters.Clear();
                com2.Parameters.Clear();
                com3.Parameters.Clear();
                com1.Parameters.AddWithValue("@f", comboBox1.Text);
                com2.Parameters.AddWithValue("@m", comboBox2.Text);
                com3.Parameters.AddWithValue("@f", comboBox3.Text);

                SqlDataReader dr1, dr2, dr3;
                sqlcon1.Open();
                dr1 = com1.ExecuteReader();
                sqlcon2.Open();
                dr2 = com2.ExecuteReader();
                sqlcon3.Open();
                dr3 = com3.ExecuteReader();
                dr1.Read();
                dr2.Read();
                dr3.Read();

                sqlCommand1.Parameters.AddWithValue("@f", dr1["forushandecode"]);
                sqlCommand1.Parameters.AddWithValue("@k", dr2["kalacode"]);
                sqlCommand1.Parameters.AddWithValue("@t", textBox1.Text);
                sqlCommand1.Parameters.AddWithValue("@d", maskedTextBox1.Text);
                sqlCommand1.Parameters.AddWithValue("@m", dr3["motesadicode"]);
                sqlcon1.Close();
                sqlcon2.Close();
                sqlcon3.Close();

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

        private void EntryForm_Load(object sender, EventArgs e)
        {
            SqlCommand com1 = new SqlCommand("SELECT forushandecode,family FROM ForushandeTbl", sqlConnection1);
            SqlCommand com2 = new SqlCommand("SELECT kalacode, moshakhasat FROM KalaTbl", sqlConnection1);
            SqlCommand com3 = new SqlCommand("SELECT motesadicode,family FROM MotesadiTbl", sqlConnection1);
            SqlDataReader dr1, dr2, dr3;
            if (sqlConnection1.State == ConnectionState.Closed)
                sqlConnection1.Open();
            dr1 = com1.ExecuteReader();
            
            
            
            while (dr1.Read())
            {                
                comboBox1.Items.Add(dr1["family"]);                
            }
            sqlConnection1.Close();
            sqlConnection1.Open();
            dr2 = com2.ExecuteReader();


            while (dr2.Read())
            {
                comboBox2.Items.Add(dr2["moshakhasat"]);
            }
            sqlConnection1.Close();
            sqlConnection1.Open();
            dr3 = com3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox3.Items.Add(dr3["family"]);
            }
            sqlConnection1.Close();

        }
    }
}
