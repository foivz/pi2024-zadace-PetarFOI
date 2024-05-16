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
        public string KKorIme { get; set; }
        public string KLozinka { get; set; }
    }
}
