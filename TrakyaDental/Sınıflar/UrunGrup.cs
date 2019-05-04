using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrakyaDental.Sınıflar
{
    class UrunGrup
    {

        int GrupID;
        string Grup_Aciklama;

        public UrunGrup(int grupID, string grup_Aciklama)
        {
            GrupID = grupID;
            Grup_Aciklama = grup_Aciklama;
        }

        public int GrupID1 { get => GrupID; set => GrupID = value; }
        public string Grup_Aciklama1 { get => Grup_Aciklama; set => Grup_Aciklama = value; }
    }
}
