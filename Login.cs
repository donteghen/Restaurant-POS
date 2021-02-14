using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please get in touch with your staff manager!");
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (usertextBox.TextLength > 0 && passwordtextBox.TextLength > 0)
            {
                if (usertextBox.Text == "admin" && passwordtextBox.Text == "123")
                {
                    Admin ad = new Admin();
                    ad.Show();
                    this.Close();
                }
                else if (usertextBox.Text == "cashier" && passwordtextBox.Text == "abc")
                {
                    Form1 form = new Form1();
                    form.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Please enter correct details!", "Wrong details entered :(", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Please make sure all the text fields are filled :)");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LandingForm landing = new LandingForm();
            landing.Show();
            this.Close();
        }

        private void passwordtextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordtextBox.TextLength > 2) 
            {
                loginbutton.Focus();
            }
        }
    }
}
