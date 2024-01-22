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
    public partial class passwordbox : Form
    {
        public passwordbox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String mpw = tbx1.Text;

            if (tbx1.Text == "")
            {
                MessageBox.Show("please fill the field", "Check Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbx1.Text == "TMR@887")
            {
                new Payment().Show();
                this.Hide();
            }
            else if (tbx1.Text != "TMR@887")
            {
                MessageBox.Show("password is incorreect", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbx1.UseSystemPasswordChar = true;
            }
            else
            {
                tbx1.UseSystemPasswordChar = false;
            }
        }
    }
}
