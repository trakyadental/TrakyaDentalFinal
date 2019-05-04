using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrakyaDental.Sınıflar
{
    class Islem
    {
        int IslemID, PersonelID, IslemTipiID, Gelir, Gider;

        public Islem(int ıslemID, int personelID, int ıslemTipiID, int gelir, int gider)
        {
            IslemID = ıslemID;
            PersonelID = personelID;
            IslemTipiID = ıslemTipiID;
            Gelir = gelir;
            Gider = gider;
        }

        public int IslemID1 { get => IslemID; set => IslemID = value; }
        public int PersonelID1 { get => PersonelID; set => PersonelID = value; }
        public int IslemTipiID1 { get => IslemTipiID; set => IslemTipiID = value; }
        public int Gelir1 { get => Gelir; set => Gelir = value; }
        public int Gider1 { get => Gider; set => Gider = value; }
    }
}
