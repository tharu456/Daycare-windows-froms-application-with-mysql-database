using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace FinalProject
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Fileds are empty ", "Login Faill", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtusername.Text == "ADMIN"&& txtpassword.Text == "123") // CHECK DATA IS TRUE
            {

                //new home().Show(); //if data is tru MainHome_page
                //this.Hide();
                this.Hide();
                home form = new home();
                form.ShowDialog();
                this.Close();

            }

            else if (txtusername.Text != "ADMIN"|| txtpassword.Text == "123")
            {
                MessageBox.Show("Incorrect User Name Or Password ", "Login Faill", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Text = "";
                txtusername.Text = "";
                txtusername.Focus();
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // new register().Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtusername.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else 
            { 
                txtpassword.UseSystemPasswordChar = false; 
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
