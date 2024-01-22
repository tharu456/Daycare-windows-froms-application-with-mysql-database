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
using MySql.Data.MySqlClient;

namespace FinalProject
{
    public partial class babysitters : Form
    {
       
        MySqlConnection con = DbConnection.MySqlServerConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        String gender;

        public babysitters()
        {
            InitializeComponent();
        }
        private void Babysitters_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {


            string name = aname.Text;
            string email = aemail.Text;
            String mobile = amobile.Text;
            string address = aaddress.Text;


            if (aname.Text == "" || aemail.Text == "" || aaddress.Text == "")
            {
                MessageBox.Show("please fill the fields", "Check Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string babysitters = "insert into babysitters(name,email,gender,address,mobile) values ('" + name + "','" + email + "','" + gender + "','" + address + "','" + mobile + "')";
                MySqlCommand cmd = new MySqlCommand(babysitters, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                aname.Text = "";
                aemail.Text = "";
                aaddress.Text = "";
                amobile.Text = "";

                MessageBox.Show("Data has been entered");

                //babysittersDGV form = new babysittersDGV();
                //form.Show();

                this.Hide();
                babysittersDGV form = new babysittersDGV();
                form.ShowDialog();
                form = null;
                this.Show();
            }
        }

        private void amale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void afemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new home().Show();
            //this.Hide();
            this.Hide();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }

        private void Babysitters_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void babysitters_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
