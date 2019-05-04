using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrakyaDental.Sınıflar
{
    class Randevu
    {
        int RandevuID, PersonelID, HastaID;
        DateTime tarih;
        string Aciklama;

        public Randevu(int randevuID, int personelID, int hastaID, DateTime tarih, string aciklama)
        {
            RandevuID = randevuID;
            PersonelID = personelID;
            HastaID = hastaID;
            this.tarih = tarih;
            Aciklama = aciklama;
        }

        public int RandevuID1 { get => RandevuID; set => RandevuID = value; }
        public int PersonelID1 { get => PersonelID; set => PersonelID = value; }
        public int HastaID1 { get => HastaID; set => HastaID = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
        public string Aciklama1 { get => Aciklama; set => Aciklama = value; }
    }
}
