using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrakyaDental.Sınıflar
{
    class Bilgilendirme
    {
        int BilgilendirmeID, HastaID;
        string Mesaj;
        Boolean Gonderi_Tipi;
        DateTime Tarih;

        public Bilgilendirme(int bilgilendirmeID, int hastaID, string mesaj, bool gonderi_Tipi, DateTime tarih)
        {
            BilgilendirmeID = bilgilendirmeID;
            HastaID = hastaID;
            Mesaj = mesaj;
            Gonderi_Tipi = gonderi_Tipi;
            Tarih = tarih;
        }

        public int BilgilendirmeID1 { get => BilgilendirmeID; set => BilgilendirmeID = value; }
        public int HastaID1 { get => HastaID; set => HastaID = value; }
        public string Mesaj1 { get => Mesaj; set => Mesaj = value; }
        public bool Gonderi_Tipi1 { get => Gonderi_Tipi; set => Gonderi_Tipi = value; }
        public DateTime Tarih1 { get => Tarih; set => Tarih = value; }
    }
}
