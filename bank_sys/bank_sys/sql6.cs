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
    public partial class sql6 : Form
    {
        public sql6()
        {
            InitializeComponent();
        }

        private void sql6_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B59K4U6;Initial Catalog=Bank_sys; Integrated Security=True ");
            con.Open();
            SqlCommand myCommand = new SqlCommand("select count(loan.EMPLOEE_ID) as 'number of employees', Customer.SSN,Customer.NAME,Customer.ADDRESS,Customer.PHONE from Customer left join ACCOUNT on Customer.SSN = ACCOUNT.SSN left join LOAN on LOAN.ACCOUNT_NUM = ACCOUNT.ACCOUNT_NUM group by Customer.SSN, Customer.NAME, Customer.ADDRESS, Customer.PHONE; ", con);
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
