using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrakyaDental.Sınıflar
{
    class Recete
    {
        int ReceteID, HastaID, UrunID, PersonelID;
        DateTime Tarih;

        public Recete(int receteID, int hastaID, int urunID, int personelID, DateTime tarih)
        {
            ReceteID = receteID;
            HastaID = hastaID;
            UrunID = urunID;
            PersonelID = personelID;
            Tarih = tarih;
        }

        public int ReceteID1 { get => ReceteID; set => ReceteID = value; }
        public int HastaID1 { get => HastaID; set => HastaID = value; }
        public int UrunID1 { get => UrunID; set => UrunID = value; }
        public int PersonelID1 { get => PersonelID; set => PersonelID = value; }
        public DateTime Tarih1 { get => Tarih; set => Tarih = value; }
    }
}
