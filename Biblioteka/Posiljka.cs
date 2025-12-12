using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace Biblioteka
{
    public class Posiljka
    {
        int id;
        string posiljalac;
        string primalac;
        string adresa;
        double masa;
        Mesto izMesto;
        Mesto uMesto;

        [Browsable(false)]
        public int Id { get => id; set => id = value; }
        public string Posiljalac { get => posiljalac; set => posiljalac = value; }
        public string Primalac { get => primalac; set => primalac = value; }

        [DisplayName("Adresa")]
        public string Vrati
        {
            get { return adresa + "," + uMesto.Ptt + "," + uMesto.Naziv; }
        }
        [Browsable(false)]
        public string Adresa { get => adresa; set => adresa = value; }

        [DisplayName("Salje se iz")]
        public Mesto IzMesto { get => izMesto; set => izMesto = value; }
        [Browsable(false)]
        public Mesto UMesto { get => uMesto; set => uMesto = value; }
        public double Masa { get => masa; set => masa = value; }
    }
}
