using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace EkoInventar
{
    public partial class EkoInventar : Form
    {
        public EkoInventar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Korisničko ime")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }

        }

        private void txtUser_Leave(object sender, EventArgs e)
        {

            if (txtUser.Text == "")
            {
                txtUser.Text = "Korisničko ime";
                txtUser.ForeColor = Color.Silver;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Lozinka")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Lozinka";
                txtPass.ForeColor = Color.Silver;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }
    }
}