using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteka;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace Sesija
{
    public class Broker
    {
        SqlCommand komanda;
        SqlConnection konekcija;
        SqlTransaction transakcija;

        void konketujSe()
        {
            konekcija = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=KurirskaSluzba;Integrated Security=True");
            komanda = konekcija.CreateCommand();
        }

        //singleton pattern
        Broker()
        {
            konketujSe();
        }

        static Broker instanca;
        public static Broker dajSesiju()
        {
            if (instanca == null) instanca = new Broker();
            return instanca;
        }

        //metode
        public Sluzbenik login(Sluzbenik s)
        {
            try
            {
                konekcija.Open();
                // simplified for practice purposes, not production-ready
                komanda.CommandText = "Select * from  Sluzbenik where [User]='" + s.User + "' and Pass='" + s.Pass + "'";
                SqlDataReader citac = komanda.ExecuteReader();
                if (citac.Read())
                {
                    s.Id = citac.GetInt32(0);
                    s.Ime = citac.GetString(1);
                    s.Prezime = citac.GetString(2);
                    return s;

                    //ostali nacini
                    //s.Id = Convert.ToInt32(citac.GetString(0));
                    //s.Ime = citac["Ime"].ToString();

                    //ako nismo sigurni koji je tip podatka
                    // s.Id=Convert.ToInt32(citac.GetValue(0));
                }
                citac.Close();
                return null;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }


        }

        public List<Mesto> vratiSvaMesta()
        {
            List<Mesto> lista = new List<Mesto>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Mesto";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    Mesto m = new Mesto();
                    m.Id = citac.GetInt32(0);
                    m.Ptt = citac["PTT"].ToString();
                    m.Naziv = citac.GetString(2);
                    lista.Add(m);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public int vratiSifruPosiljke()
        {
            try
            {
                komanda.CommandText = "Select max(ID) from Posiljka";
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {
                    return 1;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int sacuvajPosiljku(Posiljka p)
        {
            try
            {
                konekcija.Open();
                //prvo treba posiljci da dodelimo sifru
                p.Id = vratiSifruPosiljke();

                komanda.CommandText = "Insert into Posiljka values("+p.Id+",'"+p.Posiljalac+"', '"+p.Primalac+"', '"+p.Adresa+"',"+p.Masa+", "+p.IzMesto.Id+", "+p.UMesto.Id+")";
                return komanda.ExecuteNonQuery(); // za insert, update, delete
            }
            catch (Exception)
            {
                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public int sacuvajPosiljke(List<Posiljka> lista)
        {
            try
            {
                konekcija.Open();
                transakcija = konekcija.BeginTransaction();
                komanda = new SqlCommand("", konekcija, transakcija);


                foreach (Posiljka p in lista)
                {
                    //prvo treba posiljci da dodelimo sifru
                    p.Id = vratiSifruPosiljke();

                    komanda.CommandText = "Insert into Posiljka values(" + p.Id + ",'" + p.Posiljalac + "', '" + p.Primalac + "', '" + p.Adresa + "'," + p.Masa + ", " + p.IzMesto.Id + ", " + p.UMesto.Id + ")";
                    komanda.ExecuteNonQuery(); // za insert, update, delete
                }
                transakcija.Commit(); //ovo upisuje podatke u tabelu
                return 1;
            }
            catch (Exception)
            {
                transakcija.Rollback();
                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }
    }
}
