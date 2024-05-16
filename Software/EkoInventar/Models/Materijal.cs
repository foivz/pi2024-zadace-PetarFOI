using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoInventar.Models
{
    public class Materijal
    {

        public int ID_mat { get; set; }
        public string Naziv {  get; set; }
        public int Cijena { get; set; }
        public int Kolicina { get; set; }
        public int KriticniPostotak { get; set; }
        public int maxKolicina { get; set; }
    }
}
