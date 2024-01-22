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
    public partial class babyDGV : Form
    {
        public babyDGV()
        {
            InitializeComponent();
            FillDataGrid();
        }

        public void FillDataGrid()
        {
            try
            {

                MySqlConnection con = DbConnection.MySqlServerConnection();
                string query = "SELECT * FROM babies";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                baby_dgv.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Try Again" + "/n" + ex);
            }
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Babies form = new Babies();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = DbConnection.MySqlServerConnection();
            con.Open();
            string query = "DELETE FROM babies WHERE id= '" + txtId1.Text.Trim() + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record successfully deleted!", "Succesfull");
            FillDataGrid();
        }

        private void baby_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void babyDGV_Load(object sender, EventArgs e)
        {

        }

        private void babyDGV_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
