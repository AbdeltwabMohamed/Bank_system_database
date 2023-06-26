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
    public partial class sql1 : Form
    {
        public sql1()
        {
            InitializeComponent();
        }

        private void sql1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B59K4U6;Initial Catalog=Bank_sys; Integrated Security=True ");
            con.Open();
            SqlCommand myCommand = new SqlCommand("Select * from Branch where branch_num not in (select branch_num from Customer ); ", con);
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
