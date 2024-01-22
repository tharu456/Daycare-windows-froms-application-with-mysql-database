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
    public partial class parents : Form
    {
        MySqlConnection con = DbConnection.MySqlServerConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();

        string gender;
        public parents()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (pname.Text == "" && pemail.Text == "" && pmobile.Text == "" && paddress.Text == "" && pcareer.Text == "")
            {
                MessageBox.Show("please fill the fields", "Check Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

  
            }
            else if (pname.Text == "" ||pemail.Text == "" ||pmobile.Text == "" || paddress.Text == "" || pcareer.Text == "")
            {
                MessageBox.Show("please fill the fields", "Check Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = pname.Text;
                string email = pemail.Text;
                string mobile = pmobile.Text;
                string address = paddress.Text;
                string career = pcareer.Text;


                if (radioButton1.Checked == true)
                {
                    gender = "male";
                }
                else
                {
                    gender = "female";
                }

               
                    string parents = "insert into parents(name,mobile,career,gender,email,address) values ('" + name + "','" + mobile + "','" + career + "','" + gender + "','" + email + "','" + address + "')";

                    MySqlCommand cmd = new MySqlCommand(parents, con);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    con.Close();

                    pname.Text = "";
                    pemail.Text = "";
                    pmobile.Text = "";
                    paddress.Text = "";
                    pcareer.Text = "";

                    MessageBox.Show("Data has been entered");

                this.Hide();
                parentDGV form = new parentDGV();
                form.ShowDialog();
                form = null;
                this.Show(); ;

                //parentDGV form = new parentDGV();
                //form.Show();
                //this.Close();

                //new parentDGV().Show();
                //this.Hide();9




            }



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pmom_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void pdad_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
           

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "mom";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "dad";
        }

        private void parents_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

       
    }
}
