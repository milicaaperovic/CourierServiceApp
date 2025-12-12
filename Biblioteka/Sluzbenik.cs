using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Sluzbenik
    {
        int id;
        string ime;
        string prezime;
        string user;
        string pass;

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
    }
}
