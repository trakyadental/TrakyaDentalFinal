using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrakyaDental.Sınıflar
{
    class Personel
    {
        int PersonelID, Maas;
        string PersonelAd, PersonelSoyad, Unvan;

        public Personel(int personelID, int maas, string personelAd, string personelSoyad, string unvan)
        {
            PersonelID = personelID;
            Maas = maas;
            PersonelAd = personelAd;
            PersonelSoyad = personelSoyad;
            Unvan = unvan;
        }

        public int PersonelID1 { get => PersonelID; set => PersonelID = value; }
        public int Maas1 { get => Maas; set => Maas = value; }
        public string PersonelAd1 { get => PersonelAd; set => PersonelAd = value; }
        public string PersonelSoyad1 { get => PersonelSoyad; set => PersonelSoyad = value; }
        public string Unvan1 { get => Unvan; set => Unvan = value; }
    }

}
