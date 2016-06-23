using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Data;

namespace Live_Performance.Models
{
    public class Boottype
    {
        public int Id { get; set; }
        public string Naam { get; set; }

        public Boottype(int id, string naam)
        {
            Id = id;
            Naam = naam;
        }
    }
}
