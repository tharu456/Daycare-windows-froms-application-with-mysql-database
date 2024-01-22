using MySql.Data.MySqlClient;
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

namespace FinalProject
{
    public partial class babysittersDGV : Form
    {
        public babysittersDGV()
        {
            InitializeComponent();
            FillDataGrid();
        }

        public void FillDataGrid()
        {
            try
            {

                MySqlConnection con = DbConnection.MySqlServerConnection();
                string query = "SELECT * FROM babysitters";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                babysitters_dgv.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Try Again" + "/n" + ex);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            //new babysitters().Show();
            //this.Hide();

            this.Hide();
            babysitters form = new babysitters();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = DbConnection.MySqlServerConnection();
            con.Open();
            string query = "DELETE FROM babysitters WHERE id= '" + textBox2.Text.Trim() + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record successfully deleted!", "Succesfull");
            FillDataGrid();
        }

        private void babysittersDGV_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
