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

        public void SaveHuurContract(HuurContract hc)
        {
            HuurContractDbContext.Save(hc, hc.Huurder);
        }

        public static void LoadAll()
        {
            HuurContractDbContext.GetAll();
        }

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

        public override string ToString()
        {
            return Huurder + " " + StartDatum.ToString("dd-MM-yyyy");
        }
    }
}
