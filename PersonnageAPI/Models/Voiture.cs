using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personnages.Models
{
    public class Voiture
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Marque { get; set; }
        public int Kilometrage  { get; set; }
        public string assurance { get; set; }
    }
}
