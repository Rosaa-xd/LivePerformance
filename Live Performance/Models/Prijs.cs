using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Models
{
    /// <summary>
    /// Model voor Prijs
    /// </summary>
    public class Prijs
    {
        public int Id { get; set; }
        public double Waarde { get; set; }

        /// <summary>
        /// Constructor for getting Prijs out of the database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="waarde"></param>
        public Prijs(int id, double waarde)
        {
            Id = id;
            Waarde = waarde;
        }

        /// <summary>
        /// Method that adds a Prijs into the database
        /// </summary>
        /// <param name="prijs"></param>
        public void Add(Prijs prijs)
        {
            throw new NotImplementedException();
        }
    }
}
