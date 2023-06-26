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
    public partial class sql5 : Form
    {
        public sql5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B59K4U6;Initial Catalog=Bank_sys; Integrated Security=True ");
            con.Open();
            SqlCommand myCommand = new SqlCommand("select distinct(Customer.SSN),Customer.NAME,Customer.ADDRESS,Customer.PHONE from Customer , ACCOUNT, LOAN where Customer.SSN not in (select ACCOUNT.SSN from ACCOUNT) or (Customer.SSN = ACCOUNT.SSN  and ACCOUNT.ACCOUNT_NUM not in (select ACCOUNT_NUM from LOAN)); ; ", con);
            SqlDataAdapter cba = new SqlDataAdapter(myCommand);
            DataTable dt = new DataTable();
            cba.Fill(dt);
            dataGridView1.DataSource = dt;

            myCommand.ExecuteNonQuery();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
