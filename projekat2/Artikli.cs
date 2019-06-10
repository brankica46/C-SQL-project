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
    public partial class Artikli : Form
    {
        public Artikli()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ADMINRG-JTP3OOH\\SQLEXPRESS;Initial Catalog=projekat;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO artikal (sifraVrste, naziv) VALUES ('" + comboBox1.Text + "',  '" + textBox2.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ADMINRG-JTP3OOH\\SQLEXPRESS;Initial Catalog=projekat;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM artikal WHERE sifraVrste = '" + comboBox1.Text + "' AND sifra = '" + textBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Artikli_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
