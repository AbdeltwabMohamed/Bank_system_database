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
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            addcustomerbyem f3 = new addcustomerbyem();
            f3.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Operationofloanemployee f3 = new Operationofloanemployee();
            f3.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f3 = new Form1();
            f3.ShowDialog();
            this.Close();
        }
    }
}
