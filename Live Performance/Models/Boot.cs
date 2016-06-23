using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Data;

namespace Live_Performance.Models
{
    /// <summary>
    /// Model for Boot
    /// </summary>
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

        /// <summary>
        /// Constructor for inserting a Boot into the database
        /// </summary>
        /// <param name="naam"></param>
        /// <param name="soort"></param>
        /// <param name="aandrijving"></param>
        /// <param name="tankinhoud"></param>
        /// <param name="boottype"></param>
        /// <param name="prijs"></param>
        public Boot(string naam, string soort, string aandrijving, int tankinhoud, Boottype boottype, Prijs prijs)
        {
            Naam = naam;
            Soort = soort;
            Aandrijving = aandrijving;
            Tankinhoud = tankinhoud;
            Boottype = boottype;
            Prijs = prijs;
        }

        /// <summary>
        /// Constructor for getting a motorboot out of the database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="naam"></param>
        /// <param name="soort"></param>
        /// <param name="aandrijving"></param>
        /// <param name="tankinhoud"></param>
        /// <param name="boottype"></param>
        /// <param name="prijs"></param>
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

        /// <summary>
        /// Constructor for getting a spierkracht boot out of the database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="naam"></param>
        /// <param name="soort"></param>
        /// <param name="aandrijving"></param>
        /// <param name="boottype"></param>
        /// <param name="prijs"></param>
        public Boot(int id, string naam, string soort, string aandrijving, Boottype boottype, Prijs prijs)
        {
            Id = id;
            Naam = naam;
            Soort = soort;
            Aandrijving = aandrijving;
            Boottype = boottype;
            Prijs = prijs;
        }

        /// <summary>
        /// Method that loads all Boots into boten
        /// </summary>
        public static void LoadAll()
        {
            BootDbContext.GetAll();
        }

        /// <summary>
        /// Method that calculates the ActionRaius of a motorboot
        /// </summary>
        /// <param name="boot"></param>
        /// <returns></returns>
        public int GetActieRadius(Boot boot)
        {
            return boot.Tankinhoud*15;
        }

        /// <summary>
        /// Method that determines if there is a Boottype, if not it will not display it's name, otherwise it will
        /// </summary>
        /// <param name="boot"></param>
        /// <returns></returns>
        public string GetBoottypeNaam(Boot boot)
        {
            if (boot.Boottype == null)
            {
                return " ";
            }
            return boot.Boottype.Naam;
        }

        /// <summary>
        /// Method that determines if in the list Boten is a motorboot, so they can use certain Vaarwaters
        /// </summary>
        /// <param name="boten"></param>
        /// <returns></returns>
        public static bool BootTypeAllowed(IEnumerable<Boot> boten)
        {
            foreach (var b in boten)
            {
                if (b.Aandrijving == "Motorboot")
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Method that adds a boot to the database
        /// </summary>
        /// <param name="boot"></param>
        public void Add(Boot boot)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Method that edits a boot and uploads it to the database
        /// </summary>
        /// <param name="boot"></param>
        public void Edit(Boot boot)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Method that deletes a boot from the database
        /// </summary>
        /// <param name="boot"></param>
        public void Delete(Boot boot)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
