using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Models
{
    public class Artikel
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public Prijs Prijs { get; set; }

        public Artikel(string naam, Prijs prijs)
        {
            Naam = naam;
            Prijs = prijs;
        }

        public Artikel(int id, string naam, Prijs prijs)
        {
            Id = id;
            Naam = naam;
            Prijs = prijs;
        }
    }
}
