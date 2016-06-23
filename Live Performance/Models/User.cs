using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Data;

namespace Live_Performance.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string EmailAdres { get; set; }
        public string Wachtwoord { get; set; }

        public User(string naam, string emailadres, string wachtwoord)
        {
            Naam = naam;
            EmailAdres = emailadres;
            Wachtwoord = wachtwoord;
        }

        public User(int id, string naam, string emailadres, string wachtwoord)
        {
            Id = id;
            Naam = naam;
            EmailAdres = emailadres;
            Wachtwoord = wachtwoord;
        }

        public void SaveUser(User user)
        {
            UserDbContext.Save(user);
        }
    }
}
