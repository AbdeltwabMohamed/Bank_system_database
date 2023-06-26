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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sign_up_for_customer f3 = new sign_up_for_customer();
            f3.ShowDialog();
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            sign_up_for_employee f3 = new sign_up_for_employee();
            f3.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Signup f3 = new Signup();
            f3.ShowDialog();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            update f3 = new update();
            f3.ShowDialog();
            this.Close();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin f3 = new admin();
            f3.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            employee f3 = new employee();
            f3.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();
            Showtable f3 = new Showtable();
            f3.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            SQLQuery f3 = new SQLQuery();
            f3.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer f3 = new Customer();
            f3.ShowDialog();
            this.Close();
        }

       
        }
}
