using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkoInventar
{
    public partial class FrmPreglednik : Form
    {
        private bool _isAdmin;
        public FrmPreglednik(bool isAdmin)
        {
            InitializeComponent();
            _isAdmin = isAdmin;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (!_isAdmin)
            {
                MessageBox.Show("NISTE ADMIN!", "UPS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmModifikacija frmModifikacija = new FrmModifikacija();
                frmModifikacija.Show();
            }
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPreglednik_Load(object sender, EventArgs e)
        {
            if (_isAdmin)
            {
                lblAdminStatus.Text = "Ulogirani ste kao admin";
                lblAdminStatus.ForeColor = Color.Green;
            }
            else
            {
                lblAdminStatus.Text = "Niste ulogirani kao admin";
                lblAdminStatus.ForeColor = Color.Red;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
                FrmPretrazitelj frmPretrazitelj = new FrmPretrazitelj();
                frmPretrazitelj.Show();
        }
    }
}
