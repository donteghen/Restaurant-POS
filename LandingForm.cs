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
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }

        private void closepictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginNow_Clicked(object sender, MouseEventArgs e)
        {

            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
