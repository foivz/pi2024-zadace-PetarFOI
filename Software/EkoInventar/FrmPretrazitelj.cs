using DBLayer;
using EkoInventar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            string searchText = txtSearchBox.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                string query = $"SELECT * FROM MaterijaliEkoInventar WHERE strNaziv LIKE '%{searchText}%'";

                DB.OpenConnection();

                SqlDataReader reader = DB.GetDataReader(query);

                DataTable dt = new DataTable();
                dt.Load(reader);

                reader.Close();
                DB.CloseConnection();

                dgvMaterijali.DataSource = dt;
            }
            else
            {
                ShowMaterials();
            }
        }
    }
}
