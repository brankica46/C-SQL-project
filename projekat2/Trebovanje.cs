using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projekat2
{
    public partial class Trebovanje : Form
    {
        public Trebovanje()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ADMINRG-JTP3OOH\\SQLEXPRESS;Initial Catalog=projekat;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO temeljnica (sifraVrste, sifraArtikla, datum, cena, kolicinaIzlaz, izlaz) VALUES ('" + comboBox1.Text + "', '" + textBox1.Text + "', '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + true + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
            textBox3.Clear();
            textBox4.Clear();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ADMINRG-JTP3OOH\\SQLEXPRESS;Initial Catalog=projekat;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM temeljnica WHERE sifra='"  + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Clear();
            
            textBox3.Clear();
            textBox4.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             string conString = "Data Source=ADMINRG-JTP3OOH\\SQLEXPRESS;Initial Catalog=projekat;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);

            string selectSql = "select * from artikal WHERE sifraVrste= '" + comboBox1.Text + "'";
            SqlCommand com = new SqlCommand(selectSql, con);

            try
            {
                con.Open();
                comboBox2.Items.Clear();

                using (SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {
                        string naziv = read["naziv"].ToString();
                        comboBox2.Items.Add(naziv);
                        //richTextBox1.Text = (read["naziv"].ToString());
                    }
                }
            }
            finally
            {
                con.Close();
              
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Trebovanje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.temeljnica' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'DataSet1.temeljnica' table. You can move, or remove it, as needed.
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conString = "Data Source=ADMINRG-JTP3OOH\\SQLEXPRESS;Initial Catalog=projekat;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);

            string selectSql = "select * from artikal WHERE naziv= '" + comboBox2.Text + "'";
            SqlCommand com = new SqlCommand(selectSql, con);


            this.temeljnicaTableAdapter.Fill(this.DataSet1.temeljnica, comboBox2.Text);

            this.reportViewer1.RefreshReport();
            

            try
            {
                con.Open();

                using (SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {
                        textBox1.Text = (read["sifra"].ToString());
                    }
                }
            }
            finally
            {
                con.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
