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
    /// Model voor Vaarwater
    /// </summary>
    public class Vaarwater
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public int Aantal { get; set; }
        public Prijs Prijs { get; set; }

        public static BindingList<Vaarwater> Vaarwateren { get; } = new BindingList<Vaarwater>(); 

        /// <summary>
        /// Constructor for inserting a Fries Meer into the database
        /// </summary>
        /// <param name="naam"></param>
        /// <param name="aantal"></param>
        /// <param name="prijs"></param>
        public Vaarwater(string naam, int aantal, Prijs prijs)
        {
            Naam = naam;
            Aantal = aantal;
            Prijs = prijs;
        }

        /// <summary>
        /// Constructor for inserting a new Vaarwater into the databse
        /// </summary>
        /// <param name="naam"></param>
        /// <param name="prijs"></param>
        public Vaarwater(string naam, Prijs prijs)
        {
            Naam = naam;
            Prijs = prijs;
        }

        /// <summary>
        /// Constructor for getting a Fries Meer out of the database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="naam"></param>
        /// <param name="aantal"></param>
        /// <param name="prijs"></param>
        public Vaarwater(int id, string naam, int aantal, Prijs prijs)
        {
            Id = id;
            Naam = naam;
            Aantal = aantal;
            Prijs = prijs;
        }

        /// <summary>
        /// Constructor for getting a Vaarwater out of the database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="naam"></param>
        /// <param name="prijs"></param>
        public Vaarwater(int id, string naam, Prijs prijs)
        {
            Id = id;
            Naam = naam;
            Prijs = prijs;
        }

        /// <summary>
        /// Method that loads all vaarwaters into Vaarwateren
        /// </summary>
        public static void LoadAll()
        {
            VaarwaterDbContext.GetAll();
        }

        /// <summary>
        /// Method that determines how many Friese Meren one can use with its budget
        /// </summary>
        /// <param name="budget"></param>
        /// <param name="boten"></param>
        /// <param name="artikelen"></param>
        /// <param name="vaarwateren"></param>
        /// <returns></returns>
        public static Vaarwater VaarwaterBudget(double budget, List<Boot> boten, List<Artikel> artikelen, List<Vaarwater> vaarwateren)
        {
            int aantal;
            //auto generated LINQ expression by Visual Studio
            budget = boten.Aggregate(budget, (current, b) => current - b.Prijs.Waarde);
            budget = artikelen.Aggregate(budget, (current, a) => current - a.Prijs.Waarde);
            budget = vaarwateren.Aggregate(budget, (current, v) => current - v.Prijs.Waarde);

            if (budget >= 6)
            {
                budget = budget / 1.50;
                aantal = (int) budget;
            }
            if (budget >= 18)
            {
                aantal = 12;
            }
            else
            {
                aantal = (int) budget;
            }

            if (aantal == 0)
            {
                return null;
            }
            //http://stackoverflow.com/questions/11700697/find-in-bindinglistt
            Vaarwater vaarwater = Vaarwateren.SingleOrDefault(v => v.Aantal == aantal);
            return vaarwater;
        }

        /// <summary>
        /// Method that saves Vaarwater into the database
        /// </summary>
        /// <param name="v"></param>
        public void Save(Vaarwater v)
        {
            Vaarwateren.Add(VaarwaterDbContext.Save(v));
        }

        /// <summary>
        /// Method that determines if the chosen vaarwateren have no Friese Meer
        /// </summary>
        /// <param name="vaarwateren"></param>
        /// <returns></returns>
        public static bool VaarwaterenAllowed(IEnumerable<Vaarwater> vaarwateren)
        {
            foreach (var v in vaarwateren)
            {
                if (v.Naam.Contains("Friese Meer"))
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            return Naam + " " + Aantal;
        }
    }
}
