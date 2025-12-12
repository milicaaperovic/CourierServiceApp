using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class StavkaIsporuke
    {
        int isporukaID;
        int rBr;
        bool hitno;
        Posiljka posiljka;

        public int IsporukaID { get => isporukaID; set => isporukaID = value; }
        public int RBr { get => rBr; set => rBr = value; }
        public bool Hitno { get => hitno; set => hitno = value; }
        public Posiljka Posiljka { get => posiljka; set => posiljka = value; }
    }
}
