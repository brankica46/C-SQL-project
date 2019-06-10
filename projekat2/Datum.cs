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
    public partial class Datum : Form
    {
        public Datum()
        {
            InitializeComponent();
        }

        private void Datum_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.temeljnica' table. You can move, or remove it, as needed.
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.temeljnicaTableAdapter.Fill(this.DataSet2.temeljnica, dateTimePicker1.Value.Date.ToString(), dateTimePicker2.Value.Date.ToString());

            this.reportViewer1.RefreshReport();
        }
    }
}
