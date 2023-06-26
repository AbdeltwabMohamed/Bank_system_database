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
    public partial class showcustomers : Form
    {
        public showcustomers()
        {
            InitializeComponent();
        }
        DataTable dtb = new DataTable();
        void viewdata()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B59K4U6;Initial Catalog=Bank_sys; Integrated Security=True ");
            con.Open();

            SqlCommand myCommand = new SqlCommand("select SSN,NAME,PHONE,ADDRESS from Customer", con);
            SqlDataAdapter adp = new SqlDataAdapter(myCommand);

            adp.Fill(dtb);
            con.Close();
            con.Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dtb.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B59K4U6;Initial Catalog=Bank_sys; Integrated Security=True ");
            con.Open();
            CrystalReport2 crp = new CrystalReport2();
            viewdata();
            crp.Database.Tables["Customer"].SetDataSource(dtb);
            crystalReportViewer1.ReportSource = crp;
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
