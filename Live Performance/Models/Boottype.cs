using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Data;

namespace Live_Performance.Models
{
    /// <summary>
    /// Model for Boottype
    /// </summary>
    public class Boottype
    {
        public int Id { get; set; }
        public string Naam { get; set; }

        /// <summary>
        /// Constructor for getting a Boottype out of the database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="naam"></param>
        public Boottype(int id, string naam)
        {
            Id = id;
            Naam = naam;
        }

        /// <summary>
        /// Method that adds a Boottype to the database
        /// </summary>
        /// <param name="boottype"></param>
        public void Add(Boottype boottype)
        {
            throw new NotImplementedException();
        }
    }
}
