using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace FinalProject
{
    public partial class Babies : Form
    {

        MySqlConnection con = DbConnection.MySqlServerConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();

        String bgender;

        public Babies()
        {
            InitializeComponent();


            
        }
        

        private void btn1_Click(object sender, EventArgs e)
        {


            if (radioButton1.Checked == true)
            {
                bgender = "male";
            }
            else
            {
                bgender = "female";
            }


            string name = bname.Text;
            string age = bage.Text;
            string all = ballergies.Text;
            string spc = bspecial.Text;


            if (bname.Text == "" ||bage.Text == "" || ballergies.Text == "" || bspecial.Text == "")
            {
                MessageBox.Show("please fill the fields", "Check Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else
            {
               
                
                string baby = "insert into babies (name,gender,age,special,allergies,parent_Id) values ('" + name + "','" + bgender + "','" + age + "','" + spc + "','" + all + "','"+txtparent.Text.Trim()+"' )";
                MySqlCommand cmd = new MySqlCommand(baby, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                bname.Text = "";
                bage.Text = "";
                ballergies.Text = "";
                bspecial.Text = "";
                txtparent.Text = "";

                MessageBox.Show("Data has been entered");

                //babyDGV form = new babyDGV();
                //form.Show();

                this.Hide();
                babyDGV form = new babyDGV();
                form.ShowDialog();
                form = null;
                this.Show();

            }
           
        }

        private void bmale_CheckedChanged(object sender, EventArgs e)
        {
             
        }

        private void bfemale_CheckedChanged(object sender, EventArgs e)
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
            //bgender = "male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //bgender = "female";
        }
       

        private void Babies_Load(object sender, EventArgs e)
        {

        }

        private void Babies_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            
        }

        private void cmbParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbParent_MouseClick(object sender, MouseEventArgs e)
        {
            
         

        }
    }
}
