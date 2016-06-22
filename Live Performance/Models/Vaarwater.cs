using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Models
{
    public class Vaarwater
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public int Aantal { get; set; }
        public Prijs Prijs { get; set; }

        public Vaarwater(string naam, int aantal, Prijs prijs)
        {
            Naam = naam;
            Aantal = aantal;
            Prijs = prijs;
        }

        public Vaarwater(string naam, Prijs prijs)
        {
            Naam = naam;
            Prijs = prijs;
        }

        public Vaarwater(int id, string naam, int aantal, Prijs prijs)
        {
            Id = id;
            Naam = naam;
            Aantal = aantal;
            Prijs = prijs;
        }

        public Vaarwater(int id, string naam, Prijs prijs)
        {
            Id = id;
            Naam = naam;
            Prijs = prijs;
        }
    }
}
