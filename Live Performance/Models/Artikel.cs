using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Data;

namespace Live_Performance.Models
{
    public class Artikel
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public Prijs Prijs { get; set; }

        public static BindingList<Artikel> Artikelen { get; } = new BindingList<Artikel>(); 

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

        public static void LoadAll()
        {
            ArtikelDbContext.GetAll();
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
