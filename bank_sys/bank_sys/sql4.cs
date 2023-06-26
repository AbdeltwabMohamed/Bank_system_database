using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_sys
{
    public partial class sql4 : Form
    {
        public sql4()
        {
            InitializeComponent();
        }

        private void sql4_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B59K4U6;Initial Catalog=Bank_sys; Integrated Security=True ");
            con.Open();
            SqlCommand myCommand = new SqlCommand("select top 1 with ties count(Customer.SSN) as 'number of loan' ,Customer.NAME,Customer.SSN,Customer.ADDRESS,Customer.PHONE from Customer , ACCOUNT, LOAN where Customer.SSN = ACCOUNT.SSN AND LOAN.ACCOUNT_NUM = ACCOUNT.ACCOUNT_NUM group by Customer.NAME, Customer.SSN, Customer.ADDRESS, Customer.PHONE order by count(Customer.SSN) desc; ; ", con);
            SqlDataAdapter cba = new SqlDataAdapter(myCommand);
            DataTable dt = new DataTable();
            cba.Fill(dt);
            dataGridView1.DataSource = dt;

            myCommand.ExecuteNonQuery();
            con.Close();
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
