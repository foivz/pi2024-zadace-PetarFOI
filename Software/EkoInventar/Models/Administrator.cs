using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoInventar.Models
{
    public class Administrator : Korisnik
    { 
        public int ID_Admin {  get; set; }
        
        public string AKorIme {  get; set; }
        public string ALozinka { get; set; }
    }
}
