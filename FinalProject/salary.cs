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
    public partial class salary : Form
    {
        public salary()
        {
            InitializeComponent();
        }
        MySqlConnection con = DbConnection.MySqlServerConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            float sal = 0;
            float oth=0;

            if (oth > 0)
            {
                sal = 1500 + (oth * 200);

            }
            else
            {
                sal = 1500;
            }


            if (sname.Text == ""|| ot.Text == "" || txtbabyid.Text == "")
            {
                MessageBox.Show("please fill the fields", "Check Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                string salary = "INSERT INTO salaryinfo SET daily_salary = '"+sal+"',ot = '"+ot.Text+"',babysitter_Id = (SELECT id FROM babysitters WHERE id = '" + sname.Text.Trim() + "'),baby_Id = (SELECT id FROM babies WHERE id = '" + txtbabyid.Text.Trim() + "'),babysitter_name = (SELECT name FROM babysitters WHERE id = '" + sname.Text.Trim() + "') ";

                MySqlCommand cmd = new MySqlCommand(salary, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                sname.Text = "";
                txtbabyid.Text = "";
                ot.Text = "";

                MessageBox.Show("Data has been entered");
                this.Hide();
                salaryDGV form = new salaryDGV();
                form.ShowDialog();
                form = null;
                this.Show();

              
            }
             
        }

        private void button2_Click(object sender, EventArgs e)
        {

          
  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //new home().Show();
            this.Close();

            //this.Hide();
            //home form = new home();
            //form.ShowDialog();
            //this.Dispose();
        }

        private void salary_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
