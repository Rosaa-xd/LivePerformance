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
    /// Model class voor Artikel
    /// </summary>
    public class Artikel
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public Prijs Prijs { get; set; }

        public static BindingList<Artikel> Artikelen { get; } = new BindingList<Artikel>(); 

        /// <summary>
        /// Constructor for inserting an Artikel into the database
        /// </summary>
        /// <param name="naam"></param>
        /// <param name="prijs"></param>
        public Artikel(string naam, Prijs prijs)
        {
            Naam = naam;
            Prijs = prijs;
        }

        /// <summary>
        /// Constructor for getting an Artikel out of the database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="naam"></param>
        /// <param name="prijs"></param>
        public Artikel(int id, string naam, Prijs prijs)
        {
            Id = id;
            Naam = naam;
            Prijs = prijs;
        }

        /// <summary>
        /// Method that loads all Artikels into Artikelen
        /// </summary>
        public static void LoadAll()
        {
            ArtikelDbContext.GetAll();
        }

        /// <summary>
        /// Method that adds an artikel to the database
        /// </summary>
        /// <param name="artikel"></param>
        public void Add(Artikel artikel)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Method that edits an artikel and uploads it to the database
        /// </summary>
        /// <param name="artikel"></param>
        public void Edit(Artikel artikel)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Method that deletes an artikel from the database
        /// </summary>
        /// <param name="artikel"></param>
        public void Delete(Artikel artikel)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
