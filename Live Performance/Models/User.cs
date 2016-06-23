using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Data;

namespace Live_Performance.Models
{
    /// <summary>
    /// Model for User
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string EmailAdres { get; set; }
        public string Wachtwoord { get; set; }

        /// <summary>
        /// Constructor for inserting a User into the database
        /// </summary>
        /// <param name="naam"></param>
        /// <param name="emailadres"></param>
        /// <param name="wachtwoord"></param>
        public User(string naam, string emailadres, string wachtwoord)
        {
            Naam = naam;
            EmailAdres = emailadres;
            Wachtwoord = wachtwoord;
        }

        /// <summary>
        /// Constructor for getting a User out of the database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="naam"></param>
        /// <param name="emailadres"></param>
        /// <param name="wachtwoord"></param>
        public User(int id, string naam, string emailadres, string wachtwoord)
        {
            Id = id;
            Naam = naam;
            EmailAdres = emailadres;
            Wachtwoord = wachtwoord;
        }

        /// <summary>
        /// Method that inserts the user into the database
        /// </summary>
        /// <param name="user"></param>
        public void SaveUser(User user)
        {
            UserDbContext.Save(user);
        }

        /// <summary>
        /// Method that determines if a User is allowed to log in or not
        /// </summary>
        /// <param name="naam"></param>
        /// <param name="wachtwoord"></param>
        /// <returns></returns>
        public static bool Login(string naam, string wachtwoord)
        {
            User user = UserDbContext.LogIn(naam, wachtwoord);

            if (user == null)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return Naam + " " + EmailAdres;
        }
    }
}
