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
    public partial class operationofloancustomer : Form
    {
       

        public operationofloancustomer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operationofloanemployee test = new Operationofloanemployee();
            test.SetValueForText1 = textBox1.Text;
            test.SetValueForText2 = textBox2.Text;
            test.SetValueForText3 = textBox3.Text;
            test.SetValueForText4 = textBox4.Text;
            test.SetValueForText5 = textBox5.Text;
            test.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f3 = new Form1();
            f3.ShowDialog();
            this.Close();
        }
    }
}
