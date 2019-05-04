using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrakyaDental.Sınıflar
{
    class HastaBilgisi
    {
        int HastaID, PersonelID, TCKimlikNo;
        string HastaAd, HastaSoyad, GSM, Ev_Tel, Email, Adres, Cinsiyet;
        DateTime Dog_Tarih;
    
        public HastaBilgisi(int hastaID, int personelID, int tCKimlikNo, string hastaAd, string hastaSoyad, string gSM, string ev_Tel, string email, string adres, string cinsiyet, DateTime dog_Tarih)
        {
            HastaID = hastaID;
            PersonelID = personelID;
            TCKimlikNo = tCKimlikNo;
            HastaAd = hastaAd;
            HastaSoyad = hastaSoyad;
            GSM = gSM;
            Ev_Tel = ev_Tel;
            Email = email;
            Adres = adres;
            Cinsiyet = cinsiyet;
            Dog_Tarih = dog_Tarih;


        }

        public int HastaID1 { get => HastaID; set => HastaID = value; }
        public int PersonelID1 { get => PersonelID; set => PersonelID = value; }
        public int TCKimlikNo1 { get => TCKimlikNo; set => TCKimlikNo = value; }
        public string HastaAd1 { get => HastaAd; set => HastaAd = value; }
        public string HastaSoyad1 { get => HastaSoyad; set => HastaSoyad = value; }
        public string GSM1 { get => GSM; set => GSM = value; }
        public string Ev_Tel1 { get => Ev_Tel; set => Ev_Tel = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Adres1 { get => Adres; set => Adres = value; }
        public string Cinsiyet1 { get => Cinsiyet; set => Cinsiyet = value; }
        public DateTime Dog_Tarih1 { get => Dog_Tarih; set => Dog_Tarih = value; }
    }
}
