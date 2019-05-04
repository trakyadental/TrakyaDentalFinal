using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrakyaDental.Sınıflar
{
    class Envanter
    {
        int EnvanterID, UrunID;
        DateTime SKT;

        public Envanter(int envanterID, int urunID, DateTime sKT)
        {
            EnvanterID = envanterID;
            UrunID = urunID;
            SKT = sKT;
        }

        public int EnvanterID1 { get => EnvanterID; set => EnvanterID = value; }
        public int UrunID1 { get => UrunID; set => UrunID = value; }
        public DateTime SKT1 { get => SKT; set => SKT = value; }
    }
}
