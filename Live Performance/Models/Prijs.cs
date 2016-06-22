using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Models
{
    public class Prijs
    {
        public int Id { get; set; }
        public double Waarde { get; set; }

        public Prijs(int id, double waarde)
        {
            Id = id;
            Waarde = waarde;
        }
    }
}
