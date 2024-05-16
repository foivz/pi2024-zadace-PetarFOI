using DBLayer;
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
            // Get the selected material from the combo box
            var selectedMaterijal = cbPopis.SelectedItem as Materijal;

            // Update the properties of the selected material with the values from form controls
            selectedMaterijal.Naziv = txtModIme.Text;
            selectedMaterijal.maxKolicina = (int)numModMax.Value;
            selectedMaterijal.Kolicina = (int)numModCurrent.Value;
            selectedMaterijal.KriticniPostotak = (float)numModCritical.Value;
            selectedMaterijal.Cijena = (float)numModCijena.Value;

            // Call the method to update the material in the database
            UpdateMaterijalInDatabase(selectedMaterijal);
        }
        private void UpdateMaterijalInDatabase(Materijal materijal)
        {
            DB.OpenConnection();
            string query = $"UPDATE MaterijaliEkoInventar SET strNaziv = '{materijal.Naziv}', intMaxKolicina = {materijal.maxKolicina}, intKolicina = {materijal.Kolicina}, intKriticno = {materijal.KriticniPostotak}, intCijena = {materijal.Cijena} WHERE ID_mat = {materijal.ID_mat}";
            DB.ExecuteCommand(query);
            DB.CloseConnection();
        }

    }
}
