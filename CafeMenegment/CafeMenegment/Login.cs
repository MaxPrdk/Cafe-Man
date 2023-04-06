using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CafeMenegment
{
    public partial class Login : Form
    {
 
        public Login()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
      
        if (UnameTb.Text == "" | PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Info");
            } else if (UnameTb.Text == "User" && PasswordTb.Text == "Pass")
            {
                Billing Obj = new Billing();
                Obj.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Wrong Data");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            User user = new User();
            user.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
