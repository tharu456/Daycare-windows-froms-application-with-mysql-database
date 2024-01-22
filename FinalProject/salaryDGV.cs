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
    public partial class salaryDGV : Form
    {
        public salaryDGV()
        {
            InitializeComponent();
            FillDataGrid();
        }

        public void FillDataGrid()
        {
            try
            {

                MySqlConnection con = DbConnection.MySqlServerConnection();
                string query = "SELECT * FROM salaryinfo";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                salary_dgv.DataSource = dt;


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
            //this.Hide();
            //salaryDGV form = new salaryDGV();
            //form.ShowDialog();
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
