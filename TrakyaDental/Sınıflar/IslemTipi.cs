using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrakyaDental.Sınıflar
{
    class IslemTipi
    {
        int TipId;
        string Tip_Aciklama;

        public IslemTipi(int tipId, string tip_Aciklama)
        {
            TipId = tipId;
            Tip_Aciklama = tip_Aciklama;
        }

        public int TipId1 { get => TipId; set => TipId = value; }
        public string Tip_Aciklama1 { get => Tip_Aciklama; set => Tip_Aciklama = value; }
    }
}
