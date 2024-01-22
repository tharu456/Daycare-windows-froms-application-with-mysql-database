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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            FillDataGrid();
        }


        String pay;
        int id;
       

        MySqlConnection con = DbConnection.MySqlServerConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();



        private void pmom_CheckedChanged(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (txtId.Text == "")
            {
                MessageBox.Show("please fill the fields", "Check Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string payment = "INSERT INTO payment SET payment_status ='"+pay+"',parent_id = (SELECT parent_id FROM parents WHERE parent_id = '"+txtId.Text.Trim()+"') " ;
                MySqlCommand cmd = new MySqlCommand(payment, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                txtId.Text = "";

                MessageBox.Show("Data has been entered");

                FillDataGrid();
                
            }
          

        }

        private void npaid_CheckedChanged(object sender, EventArgs e)
        {
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //new home().Show();
            //this.Hide();

            this.Hide();
            home form = new home();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pay = "paid";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pay = "Not paid";
        }

        private void Payment_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("please fill the fields", "Check Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string payment = "UPDATE payment SET payment_status = '"+pay+"' WHERE parent_id = '"+txtId.Text.Trim()+"' ";
                MySqlCommand cmd = new MySqlCommand(payment, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                txtId.Text = "";

                MessageBox.Show("Data has been entered");

                FillDataGrid();
            }
        }

        public void FillDataGrid()
        {
            try
            {

                MySqlConnection con = DbConnection.MySqlServerConnection();
                string query = "SELECT * FROM payment";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                paymentDGV.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Try Again" + "/n" + ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtPaymentId.Text == "")
            {
                MessageBox.Show("please fill the fields", "Check Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string payment = "DELETE FROM payment WHERE id = '" + txtPaymentId.Text.Trim() + "' ";
                MySqlCommand cmd = new MySqlCommand(payment, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                txtId.Text = "";

                MessageBox.Show("One row has been deleted");

                FillDataGrid();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
