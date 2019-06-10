using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekat2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Artikli artikli = new Artikli();
            artikli.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nabavke nabavke = new Nabavke();
            nabavke.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Trebovanje trebovanje = new Trebovanje();
            trebovanje.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Datum datum = new Datum();
            datum.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
