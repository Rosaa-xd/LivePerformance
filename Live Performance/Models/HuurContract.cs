using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Live_Performance.Data;

namespace Live_Performance.Models
{
    /// <summary>
    /// Model for HuurContract
    /// </summary>
    public class HuurContract
    {
        public int Id { get; set; }
        public DateTime StartDatum { get; private set; }
        public DateTime EindDatum { get; private set; }
        public List<Boot> Boten { get; private set; } 
        public List<Artikel> Artikelen { get; private set; } 
        public List<Vaarwater> Vaarwateren { get; private set; }
        public User Huurder { get; }

        public static BindingList<HuurContract> HuurContracten { get; } = new BindingList<HuurContract>(); 

        /// <summary>
        /// Constructor for inserting a Huurcontract into the database
        /// </summary>
        /// <param name="startDatum"></param>
        /// <param name="eindDatum"></param>
        /// <param name="boten"></param>
        /// <param name="artikelen"></param>
        /// <param name="vaarwateren"></param>
        /// <param name="huurder"></param>
        public HuurContract(DateTime startDatum, DateTime eindDatum, List<Boot> boten, List<Artikel> artikelen,
            List<Vaarwater> vaarwateren, User huurder)
        {
            StartDatum = startDatum;
            EindDatum = eindDatum;
            Boten = boten;
            Artikelen = artikelen;
            Vaarwateren = vaarwateren;
            Huurder = huurder;
        }

        /// <summary>
        /// Constructor for getting a Huurcontract out of the database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="startDatum"></param>
        /// <param name="eindDatum"></param>
        /// <param name="boten"></param>
        /// <param name="artikelen"></param>
        /// <param name="vaarwateren"></param>
        /// <param name="huurder"></param>
        public HuurContract(int id, DateTime startDatum, DateTime eindDatum, List<Boot> boten,
            List<Artikel> artikelen, List<Vaarwater> vaarwateren, User huurder)
        {
            Id = id;
            StartDatum = startDatum;
            EindDatum = eindDatum;
            Boten = boten;
            Artikelen = artikelen;
            Vaarwateren = vaarwateren;
            Huurder = huurder;
        }

        /// <summary>
        /// Method that saves a huurcontract into the database
        /// </summary>
        /// <param name="hc"></param>
        public void SaveHuurContract(HuurContract hc)
        {
            HuurContractDbContext.Save(hc, hc.Huurder);
        }

        /// <summary>
        /// Method that loads all Huurcontracts into huurcontracten
        /// </summary>
        public static void LoadAll()
        {
            HuurContractDbContext.GetAll();
        }

        /// <summary>
        /// Method that exports a Huurcontract to a chosen location by the user
        /// </summary>
        /// <param name="hc"></param>
        /// <param name="path"></param>
        public void Export(HuurContract hc, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                string json = JSonHelperClass.HuurContractToJson(hc);
                writer.WriteLine(json);
                //Making sure it'll write to file
                writer.Flush();
            }
        }

        /// <summary>
        /// Method that gets the gevoelstemperaturen for a certain period of time
        /// </summary>
        public void GetGevoelstemperatuur()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Huurder + " " + StartDatum.ToString("dd-MM-yyyy");
        }
    }
}
