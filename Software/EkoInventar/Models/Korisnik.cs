using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoInventar.Models
{
    public class Korisnik : Osoba
    {
        public int ID_korisnik { get; set; }
        public string Korime { get; set; }
        public string Lozinka { get; set; }

        public Materijal GetMaterijals(string naziv)
        {
        }
    }
}
