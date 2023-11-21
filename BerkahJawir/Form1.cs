using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Reflection.Metadata.Ecma335;
using System.Linq.Expressions;

namespace BerkahJawir
{
    public partial class Form1 : Form
    {
        //connection
        connection con = new connection();
        string nama, pass;

        public Form1()
        {
            InitializeComponent();
        }


        // login to cashier 
        private void btn_loginCash_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_username.Text != "" && tb_pass.Text != "")
                {
                    con.Open();
                    string query = "SELECT * FROM user WHERE username = '" + tb_username.Text + "' AND pass = '" + tb_pass.Text + "'";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            nama = row["username"].ToString();
                            pass = row["pass"].ToString();
                        }
                        MessageBox.Show("Welcome back" + " " + nama + " " + "to Cashier Dashboard!");

                        // Intent ke dashboard inventory
                        FormCashier form3 = new FormCashier();

                        form3.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Your data is invalid", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("Name or Password is Empty!", "Information");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }
        }

        // login to inventory
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_username.Text != "" && tb_pass.Text != "")
                {
                    con.Open();
                    string query = "SELECT * FROM user WHERE username = '" + tb_username.Text + "' AND pass = '" + tb_pass.Text + "'";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            nama = row["username"].ToString();
                            pass = row["pass"].ToString();
                        }
                        MessageBox.Show("Welcome back" + " " + nama + " " +  "to Inventory Dashboard!");

                        // Intent ke dashboard inventory
                        btn_save2 form2 = new btn_save2();

                        form2.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Your data is invalid", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("Name or Password is Empty!", "Information");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }
        }
    }
}