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

namespace bank_sys
{
    public partial class showloan : Form
    {
        public showloan()
        {
            InitializeComponent();
        }
        DataTable dtb = new DataTable();
        void viewdata()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B59K4U6;Initial Catalog=Bank_sys; Integrated Security=True ");
            con.Open();

            SqlCommand myCommand = new SqlCommand("select LOAN_NUMBER,LOAN_TYPE,LOAN_AMOUNT from LOAN", con);
            SqlDataAdapter adp = new SqlDataAdapter(myCommand);

            adp.Fill(dtb);
            con.Close();
            con.Dispose();
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtb.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B59K4U6;Initial Catalog=Bank_sys; Integrated Security=True ");
            con.Open();
            CrystalReport1 crp = new CrystalReport1();
            viewdata();
            crp.Database.Tables["LOAN"].SetDataSource(dtb);
            crystalReportViewer1.ReportSource = crp;
            con.Close();
        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
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
