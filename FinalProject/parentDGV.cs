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
    public partial class parentDGV : Form
    {
        public parentDGV()
        {
            InitializeComponent();
            FillDataGrid();
        }

        public void FillDataGrid()
        {
            try
            {
                
                MySqlConnection con = DbConnection.MySqlServerConnection();
                string query = "SELECT * FROM parents";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                parent_dgv.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Try Again" + "/n" + ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            parents form = new parents();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection con = DbConnection.MySqlServerConnection();
            con.Open();
            string query = "DELETE FROM parents WHERE parent_id= '"+parentId.Text.Trim()+"'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record successfully deleted!", "Succesfull");
            FillDataGrid();        
        }

        private void parentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void parentDGV_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void parentDGV_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
