using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Live_Performance.Models
{
    public class JSonHelperClass
    {
        private const string HNAAM_KEY = "Naam Huurder";
        private const string HEMAIL_KEY = "Email Huurder";
        private const string DATUMSTART_KEY = "Startdatum";
        private const string DATUMEIND_KEY = "Einddatum";
        private const string BOOTNAAM_KEY = "Naam Boot";
        private const string ARTIKELNAAM_KEY = "Naam Artikel";
        private const string VAARWATER_KEY = "Vaarwater";

        public static string HuurContractToJson(HuurContract hc)
        {
            JArray array = new JArray();
            JObject obj = new JObject();
            obj[HNAAM_KEY] = hc.Huurder.Naam;
            obj[HEMAIL_KEY] = hc.Huurder.EmailAdres;
            obj[DATUMSTART_KEY] = hc.StartDatum;
            obj[DATUMEIND_KEY] = hc.EindDatum;

            foreach (var b in hc.Boten)
            {
                obj[BOOTNAAM_KEY] = b.Naam;
            }
            foreach (var a in hc.Artikelen)
            {
                obj[ARTIKELNAAM_KEY] = a.Naam;
            }
            foreach (var v in hc.Vaarwateren)
            {
                obj[VAARWATER_KEY] = v.Naam;
            }

            array.Add(obj);
            return array.ToString();
        }

    }
}
