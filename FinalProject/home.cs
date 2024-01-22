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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            

            this.Hide();
            parentDGV form = new parentDGV();
            form.ShowDialog();
            form = null;
            this.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            babyDGV form = new babyDGV();
            form.ShowDialog();
            form = null;
            this.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            babysittersDGV form = new babysittersDGV();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Payment form = new Payment();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            salary form = new salary();
            form.ShowDialog();
            form = null;
            this.Show();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Aboutus form = new Aboutus();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
