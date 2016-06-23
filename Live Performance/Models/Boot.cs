using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Data;

namespace Live_Performance.Models
{
    public class Boot
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Soort { get; set; }
        public string Aandrijving { get; set; }
        public int Tankinhoud { get; set; }
        public Boottype Boottype { get; set; }
        public Prijs Prijs { get; set; }

        public static BindingList<Boot> Boten { get; } = new BindingList<Boot>();

        public Boot(string naam, string soort, string aandrijving, int tankinhoud, Boottype boottype, Prijs prijs)
        {
            Naam = naam;
            Soort = soort;
            Aandrijving = aandrijving;
            Tankinhoud = tankinhoud;
            Boottype = boottype;
            Prijs = prijs;
        }

        public Boot(int id, string naam, string soort, string aandrijving, int tankinhoud, Boottype boottype, Prijs prijs)
        {
            Id = id;
            Naam = naam;
            Soort = soort;
            Aandrijving = aandrijving;
            Tankinhoud = tankinhoud;
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

        public static void LoadAll()
        {
            BootDbContext.GetAll();
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
