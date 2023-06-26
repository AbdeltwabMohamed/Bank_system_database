using bank_sys.bin;
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
using System.Configuration;

namespace bank_sys
{
    public partial class showloanandcustomerandemployee : Form
    {
        public showloanandcustomerandemployee()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void showloanandcustomerandemployee_Load(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["bank_sys.Properties.Settings.Bank_sysConnectionString"].ConnectionString;
            SqlConnection sqll = new SqlConnection(mainconn);
            string sqlqu = "select LOAN.LOAN_NUMBER ,LOAN.LOAN_TYPE, LOAN.LOAN_AMOUNT ,Customer.NAME,EMPLOYEES.NAME";
            sqlqu += " from [dbo].[Customer] INNER join [dbo].[ACCOUNT] "; 
            sqlqu += "on Customer.SSN = ACCOUNT.SSN inner join [dbo].[LOAN] on LOAN.ACCOUNT_NUM = ACCOUNT.ACCOUNT_NUM inner join [dbo].[EMPLOYEES] on LOAN.EMPLOEE_ID = EMPLOYEES.EMPLOEE_ID";
            SqlCommand abc= new SqlCommand(sqlqu,sqll);
            sqll.Open();
            SqlDataAdapter cba = new SqlDataAdapter(abc);
            DataTable dt = new DataTable();
            cba.Fill(dt);
            dataGridView1.DataSource = dt;
            sqll.Close();
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
