using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Models
{
    public class HuurContract
    {
        public int Id { get; set; }
        public DateTime StartDatum { get; set; }
        public DateTime EindDatum { get; set; }
        public BindingList<Boot> Boten { get; set; } 
        public BindingList<Artikel> Artikelen { get; set; } 
        public BindingList<Vaarwater> Vaarwateren { get; set; }

        public HuurContract(DateTime startDatum, DateTime eindDatum, BindingList<Boot> boten, BindingList<Artikel> artikelen,
            BindingList<Vaarwater> vaarwateren)
        {
            StartDatum = startDatum;
            EindDatum = eindDatum;
            Boten = boten;
            Artikelen = artikelen;
            Vaarwateren = vaarwateren;
        }

        public HuurContract(int id, DateTime startDatum, DateTime eindDatum, BindingList<Boot> boten,
            BindingList<Artikel> artikelen, BindingList<Vaarwater> vaarwateren)
        {
            Id = id;
            StartDatum = startDatum;
            EindDatum = eindDatum;
            Boten = boten;
            Artikelen = artikelen;
            Vaarwateren = vaarwateren;
        }
    }
}
