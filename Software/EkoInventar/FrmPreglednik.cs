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
        public FrmPreglednik()
        {
            InitializeComponent();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmPretrazitelj frmPretrazitelj = new FrmPretrazitelj();
            frmPretrazitelj.Show();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();

            EkoInventar ekoInventar = new EkoInventar();
            ekoInventar.Show();
        }
    }
}
