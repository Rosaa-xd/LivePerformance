using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Models
{
    public class User
    {
        public string Naam { get; set; }
        public string EmailAdres { get; set; }
        public string Wachtwoord { get; set; }

        public User(string naam, string emailadres, string wachtwoord)
        {
            Naam = naam;
            EmailAdres = emailadres;
            Wachtwoord = wachtwoord;
        }
    }
}
