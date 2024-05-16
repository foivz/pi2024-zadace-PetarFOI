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
using EkoInventar.Models;
using EkoInventar.Repositories;

namespace EkoInventar
{
    public partial class EkoInventar : Form
    {
        public EkoInventar()
        {
            InitializeComponent();
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
                txtPass.PasswordChar = '●';
                txtPass.ForeColor = Color.Black;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.PasswordChar = '\0';
                txtPass.Text = "Lozinka";
                txtPass.ForeColor = Color.Silver;
            }
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

            Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        private void picLogo_MouseEnter(object sender, EventArgs e)
        {
            picLogo.Cursor = Cursors.Hand;
        }


        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Nista nista upisali", "Pogreška!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Administrator admin = AdminRepositories.GetAdmin(username);
            Korisnik korisnik = UserRepositories.GetKorisnik(username);

            if(admin != null && admin.ALozinka == password)
            {
                bool isAdmin = true;
                Hide();
                FrmPreglednik frmPreglednik = new FrmPreglednik(isAdmin);
                frmPreglednik.ShowDialog();
                Show();
            }
            else if (korisnik != null && korisnik.KLozinka == password)
            {
                bool isAdmin = false;
                FrmPreglednik frmPreglednik = new FrmPreglednik(isAdmin);
                frmPreglednik.Show();
                Show();

            }
            else
            {
                MessageBox.Show("Korisničko ime ili lozinka je krivno unesena!", "Neuspješnja prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked) { 
            txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '●';
            }
        }


    }
}