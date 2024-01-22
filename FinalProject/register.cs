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
    public partial class register : Form
    {
       
        public register()
        {
            InitializeComponent();
        }
        //connection string
        MySqlConnection con = DbConnection.MySqlServerConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();

   

        string gender;
        private void register_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtconpassword.Text != txtpassword.Text)
            {
                MessageBox.Show("Password Is incorrect","Check Again", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtpassword.Text = "";
                txtconpassword.Text = "";
                txtpassword.Focus();
            }
            else if (txtpassword.Text == "" && txtconpassword.Text == "" && txtname.Text==""&& txtemail.Text=="" && txtmobile.Text==""&& txtaddress.Text=="" ) 
            {
                MessageBox.Show("please fill the fields","Check Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtpassword.Text == "" || txtconpassword.Text == "" || txtname.Text == "" || txtemail.Text == "" || txtmobile.Text == "" || txtaddress.Text == "")
            {
                MessageBox.Show("please fill the fields", "Check Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtpassword.Text == txtconpassword.Text)
            {
                string name = Convert.ToString(txtname.Text);
                string email = Convert.ToString(txtemail.Text);
                int mobile = Convert.ToInt32(txtmobile.Text);
                string address = Convert.ToString(txtaddress.Text);
                string career = Convert.ToString(txtcareer.Text);
                string pw = Convert.ToString(txtpassword.Text);
                string cpw = Convert.ToString(txtconpassword.Text);

                string register = "insert into RegistationTable values ('" + name + "','" + email + "','" + mobile + "','" + address + "','" + career + "','" + gender + "','"+pw+"')";
                MySqlCommand cmd = new MySqlCommand(register, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                txtname.Text = "";
                txtemail.Text = "";
                txtmobile.Text = "";
                txtaddress.Text = "";
                txtcareer.Text = "";
                txtpassword.Text = "";
                txtconpassword.Text = "";
                MessageBox.Show("Account has been succesfully created", "Thank You", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Please Try again", "Error occured ", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void showpw_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void showpw_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
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
    }
}
