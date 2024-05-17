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
    public partial class FrmModifikacija : Form
    {
        private Materijal materijal;
        public FrmModifikacija()
        {
            InitializeComponent();
        }
        private void FrmModifikacija_Load(object sender, EventArgs e)
        {
            var materijali = MaterijaliRepo.GetMaterijali();
            cbPopis.DisplayMember = "Naziv";
            cbPopis.DataSource = materijali;
        }

        private void cbPopis_SelectedIndexChanged(object sender, EventArgs e)
        {
            var trenutniMaterijal = cbPopis.SelectedItem as Materijal;
            txtModIme.Text = trenutniMaterijal.Naziv;

            numModMax.Minimum = 0; numModMax.Maximum = 10000;
            numModMax.Value = trenutniMaterijal.maxKolicina;

            numModCurrent.Minimum = numModMax.Minimum; numModCurrent.Maximum = numModMax.Maximum;
            numModCurrent.Value = trenutniMaterijal.Kolicina;

            numModCritical.Minimum = 0;
            numModCritical.Maximum = 1;
            numModCritical.DecimalPlaces = 2; 
            numModCritical.Increment = 0.01m; 
            numModCritical.Value = Convert.ToDecimal(trenutniMaterijal.KriticniPostotak);

            numModCijena.Minimum = 0;
            numModCijena.Maximum = 1000;
            numModCijena.DecimalPlaces = 2; 
            numModCijena.Increment = 0.01m; 
            numModCijena.Value = Convert.ToDecimal(trenutniMaterijal.Cijena);

        }
       private void btnModSpremi_Click(object sender, EventArgs e)
        {
            var selectedMaterijal = cbPopis.SelectedItem as Materijal;

            selectedMaterijal.Naziv = txtModIme.Text;
            selectedMaterijal.maxKolicina = (int)numModMax.Value;
            selectedMaterijal.Kolicina = (int)numModCurrent.Value;
            selectedMaterijal.KriticniPostotak = (float)numModCritical.Value;
            selectedMaterijal.Cijena = (float)numModCijena.Value;

            if (selectedMaterijal.Kolicina > selectedMaterijal.maxKolicina)
            {
                selectedMaterijal.Kolicina = selectedMaterijal.maxKolicina;
            } 

            int selectedIndex = cbPopis.SelectedIndex;

            UpdateMaterijalInDatabase(selectedMaterijal);

            FrmModifikacija_Load(sender, e);

            if (selectedIndex >= 0 && selectedIndex < cbPopis.Items.Count)
            {
                cbPopis.SelectedIndex = selectedIndex;
            }
        }
        private void UpdateMaterijalInDatabase(Materijal materijal)
        {
            DB.OpenConnection();
            string query = $"UPDATE MaterijaliEkoInventar SET strNaziv = '{materijal.Naziv}', intMaxKolicina = {materijal.maxKolicina}, intKolicina = {materijal.Kolicina}, intKriticno = {materijal.KriticniPostotak}, intCijena = {materijal.Cijena} WHERE ID_mat = {materijal.ID_mat}";
            DB.ExecuteCommand(query);
            DB.CloseConnection();
        }

        private void DeleteMaterijalInDatabase(Materijal materijal)
        {
            DB.OpenConnection();
            string query = $"DELETE FROM MaterijaliEkoInventar WHERE ID_mat = {materijal.ID_mat}";
            DB.ExecuteCommand(query);
            DB.CloseConnection();
        }



        private void btnModDodaj_Click(object sender, EventArgs e)
        {
            Materijal newMaterijal = new Materijal();

            newMaterijal.Naziv = "Novi materijal";
            newMaterijal.maxKolicina = 0;
            newMaterijal.Kolicina = 0;
            newMaterijal.KriticniPostotak = 0.0f;
            newMaterijal.Cijena = 0.0f;
            AddMaterijalInDatabase(newMaterijal);

            FrmModifikacija_Load(sender, e);

            cbPopis.SelectedIndex = cbPopis.Items.Count - 1;

        }


        private void AddMaterijalInDatabase(Materijal materijal)
        {
            DB.OpenConnection();
            int lastInsertedID = GetLastInsertedIDMat();

            int newID = lastInsertedID + 1;

            materijal.ID_mat = newID;


            string query = $"INSERT INTO MaterijaliEkoInventar (ID_mat, strNaziv, intMaxKolicina, intKolicina, intKriticno, intCijena) " +
                           $"VALUES ({materijal.ID_mat}, '{materijal.Naziv}', {materijal.maxKolicina}, {materijal.Kolicina}, {materijal.KriticniPostotak}, {materijal.Cijena})";
            DB.ExecuteCommand(query);
            DB.CloseConnection();
        }

        private int GetLastInsertedIDMat()
        {
            int lastInsertedID = 0;

            string query = "SELECT MAX(ID_mat) AS LastID FROM MaterijaliEkoInventar";
            SqlDataReader reader = DB.GetDataReader(query);

            if (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("LastID")))
                {
                    lastInsertedID = reader.GetInt32(reader.GetOrdinal("LastID"));
                }
            }

            reader.Close();

            return lastInsertedID;
        }

        private void btnModBrisi_Click(object sender, EventArgs e)
        {
                var selectedMaterijal = cbPopis.SelectedItem as Materijal;

                DeleteMaterijalInDatabase(selectedMaterijal);
                FrmModifikacija_Load(sender, e);
            
        }
    }
}
