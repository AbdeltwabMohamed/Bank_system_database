using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_sys
{
    public partial class Showtable : Form
    {
        public Showtable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            showloan f3 = new showloan();
            f3.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            showcustomers f3 = new showcustomers();
            f3.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            showloanandcustomerandemployee f3 = new showloanandcustomerandemployee();
            f3.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f3 = new Form1();
            f3.ShowDialog();
            this.Close();
        }
    }
}
