using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Models
{
    public class Boot
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Soort { get; set; }
        public string Aandrijving { get; set; }
        public Boottype Boottype { get; set; }
        public Prijs Prijs { get; set; }

        public Boot(string naam, string soort, string aandrijving, Boottype boottype, Prijs prijs)
        {
            Naam = naam;
            Soort = soort;
            Aandrijving = aandrijving;
            Boottype = boottype;
            Prijs = prijs;
        }

        public Boot(int id, string naam, string soort, string aandrijving, Boottype boottype, Prijs prijs)
        {
            Id = id;
            Naam = naam;
            Soort = soort;
            Aandrijving = aandrijving;
            Boottype = boottype;
            Prijs = prijs;
        }
    }
}
