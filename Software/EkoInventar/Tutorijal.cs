using EkoInventar.Models;
using EkoInventar.Repositories;
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
    public partial class Tutorijal : Form
    {
        public Tutorijal()
        {
            InitializeComponent();
        }

        private void ShowMaterials()
        {
            var admin = AdminRepositories.GetAdmin();

            dgv_Admini.DataSource = admin;

            dgv_Admini.Columns["AKorIme"].DisplayIndex = 0;
            dgv_Admini.Columns["ALozinka"].DisplayIndex = 1;

            foreach (DataGridViewColumn column in dgv_Admini.Columns)
            {
                if (column.Name != "AKorIme" && column.Name != "ALozinka")
                {
                    column.Visible = false;
                }
            }
        }

        private void ShowMaterials2()
        {
            var korisnik = UserRepositories.GetKorisnik();

            dgv_Korisnici.DataSource = korisnik;

            dgv_Korisnici.Columns["KKorIme"].DisplayIndex = 0;
            dgv_Korisnici.Columns["KLozinka"].DisplayIndex = 1;

            foreach (DataGridViewColumn column in dgv_Korisnici.Columns)
            {
                if (column.Name != "KKorIme" && column.Name != "KLozinka")
                {
                    column.Visible = false;
                }
            }
        }

        private void Tutorijal_Load(object sender, EventArgs e)
        {
            ShowMaterials();
            ShowMaterials2();
        }
    }
}
