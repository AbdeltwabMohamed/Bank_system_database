﻿using System;
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
    public partial class createaccount : Form
    {
        public createaccount()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B59K4U6;Initial Catalog=Bank_sys; Integrated Security=True ");
            con.Open();

            SqlCommand myCommand = new SqlCommand("insert into ACCOUNT (SSN,ACCOUNT_NUM,ACCOUNT_TYPE,BALANCE) values ('" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "' ,'" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "')", con);

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
