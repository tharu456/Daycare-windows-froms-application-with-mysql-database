using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class paymentDGV : Form
    {
        public paymentDGV()
        {
            InitializeComponent();
            FillDataGrid();
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
                payment_dgv.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Try Again" + "/n" + ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //new home().Show();
            //this.Hide();

            this.Hide();
            
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = DbConnection.MySqlServerConnection();
            con.Open();
            string query = "DELETE FROM payement WHERE id= '" + txtId.Text.Trim() + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record successfully deleted!", "Succesfull");
            FillDataGrid();
        }

        private void paymentDGV_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
