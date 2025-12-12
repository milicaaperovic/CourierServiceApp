using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Mesto
    {

        public override string ToString()
        {
            return naziv+ "-" +ptt;
        }


        int id;
        string ptt;
        string naziv;

        public int Id { get => id; set => id = value; }
        public string Ptt { get => ptt; set => ptt = value; }
        public string Naziv { get => naziv; set => naziv = value; }
    }
}
