using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class DnevnaIsporuka
    {

        public DnevnaIsporuka() 
        {
            ListaStavki = new BindingList<StavkaIsporuke> ();
        }
        int id;
        DateTime datum;
        Kurir kurir;
        Sluzbenik sluzbenik;
        BindingList<StavkaIsporuke> listaStavki;

        public int Id { get => id; set => id = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public Kurir Kurir { get => kurir; set => kurir = value; }
        public Sluzbenik Sluzbenik { get => sluzbenik; set => sluzbenik = value; }
        public BindingList<StavkaIsporuke> ListaStavki { get => listaStavki; set => listaStavki = value; }
    }
}
