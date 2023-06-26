using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_sys
{
    public partial class Operationofloanemployee : Form
    {
        public string SetValueForText1 { get;  set; }
        public string SetValueForText2 { get;  set; }
        public string SetValueForText3 { get;  set; }
        public string SetValueForText4 { get;  set; }
        public string SetValueForText5 { get; set; }
        public Operationofloanemployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B59K4U6;Initial Catalog=Bank_sys; Integrated Security=True ");
            con.Open();

            SqlCommand myCommand = new SqlCommand("insert into LOAN (branch_num,ACCOUNT_NUM,LOAN_NUMBER,LOAN_TYPE,LOAN_AMOUNT,EMPLOEE_ID) values ('" + Convert.ToInt32(label12.Text) + "','" + Convert.ToInt32(label8.Text) + "' ,'" + Convert.ToInt32(label9.Text) + "','" + label10.Text.ToString() + "','" + Convert.ToInt32(label11.Text) + "','" + textBox6.Text.ToString() + "')", con);

            myCommand.ExecuteNonQuery();
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Operationofloanemployee_Load(object sender, EventArgs e)
        {
            label12.Text = SetValueForText1;
            label8.Text = SetValueForText2;
            label9.Text = SetValueForText3;
            label10.Text = SetValueForText4;
            label11.Text = SetValueForText5;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f3 = new Form1();
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
    }
}
