using EkoInventar.Models;
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
    public partial class FrmPretrazitelj : Form
    {
        public FrmPretrazitelj()
        {
            InitializeComponent();
        }

        private void FrmPregled_Load(object sender, EventArgs e)
        {
        ShowMaterials();
        }

        private void ShowMaterials()
        {
            var materijali = MaterijaliRepo.GetMaterijali();
            dgvMaterijali.DataSource = materijali;

            dgvMaterijali.Columns["ID_mat"].DisplayIndex = 0;
            dgvMaterijali.Columns["Naziv"].DisplayIndex = 1;
            dgvMaterijali.Columns["Kolicina"].DisplayIndex = 2;
            dgvMaterijali.Columns["Cijena"].DisplayIndex = 3;
            dgvMaterijali.Columns["KriticniPostotak"].DisplayIndex = 4;
            dgvMaterijali.Columns["maxKolicina"].DisplayIndex = 5;
        }


        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
