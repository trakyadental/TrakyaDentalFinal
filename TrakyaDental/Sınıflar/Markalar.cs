using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrakyaDental.Sınıflar
{
    class Markalar
    {
        int MarkaID;
        string MarkaAd, IletisimAdres_Tel, IletisimAdres_Mail;

        public Markalar(int markaID, string markaAd, string ıletisimAdres_Tel, string ıletisimAdres_Mail)
        {
            MarkaID = markaID;
            MarkaAd = markaAd;
            IletisimAdres_Tel = ıletisimAdres_Tel;
            IletisimAdres_Mail = ıletisimAdres_Mail;
        }

        public int MarkaID1 { get => MarkaID; set => MarkaID = value; }
        public string MarkaAd1 { get => MarkaAd; set => MarkaAd = value; }
        public string IletisimAdres_Tel1 { get => IletisimAdres_Tel; set => IletisimAdres_Tel = value; }
        public string IletisimAdres_Mail1 { get => IletisimAdres_Mail; set => IletisimAdres_Mail = value; }
    }
}
