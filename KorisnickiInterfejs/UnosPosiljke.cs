using Biblioteka;
using Sesija;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public partial class UnosPosiljke : Form
    {
        BindingList<Posiljka> listaPosiljki;

        public UnosPosiljke()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UnosPosiljke_Load(object sender, EventArgs e)
        {
            //popunjavanje comboBox-a
            cmbMestoIZ.DataSource = Broker.dajSesiju().vratiSvaMesta();
            cmbMestoIZ.DisplayMember = "Naziv";

            foreach(Mesto m in Broker.dajSesiju().vratiSvaMesta())
            {
                cmbMestoU.Items.Add(m);
            }

            cmbMestoIZ.Text = "Odaberite mesto!";
            cmbMestoU.Text = "Odaberite mesto!";
            
            //popunjavanje grida
            listaPosiljki = new BindingList<Posiljka>();
            dataGridView1.DataSource = listaPosiljki;

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Posiljka p = new Posiljka();

            p.Posiljalac = txtPosiljalac.Text;
            if (p.Posiljalac == "")
            {
                MessageBox.Show("Niste uneli posiljaoca!");
                txtPosiljalac.Focus();
                return;
            }
            p.Primalac = txtPrimalac.Text;
            if (p.Primalac == "")
            {
                MessageBox.Show("Niste uneli primaoca!");
                txtPrimalac.Focus();
                return;
            }
            p.Adresa = txtAdresa.Text;
            if (p.Adresa == "")
            {
                MessageBox.Show("Niste uneli adresu!");
                txtAdresa.Focus();
                return;
            }
            try
            {
                p.Masa = Convert.ToDouble(txtMasa.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nije dobra masa!");
                txtMasa.Focus();
                return;
            }
            if (p.Masa <= 0)
            {
                MessageBox.Show("Nije dobra masa!");
                txtMasa.Focus();
                return;
            }

            p.IzMesto = cmbMestoIZ.SelectedItem as Mesto;
            if(p.IzMesto == null)
            {
                MessageBox.Show("Niste odabrali mesto!");
                return;
            }

            p.UMesto = cmbMestoU.SelectedItem as Mesto;
            if (p.UMesto == null)
            {
                MessageBox.Show("Niste odabrali mesto!");
                return;
            }

            try
            {
                int rez = Broker.dajSesiju().sacuvajPosiljku(p);
                if(rez == 0)
                {
                    MessageBox.Show("Nije sacuvana!");
                }
                else
                {
                    MessageBox.Show("Sacuvana!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Posiljka p = new Posiljka();

            p.Posiljalac = txtPosiljalac.Text;
            if (p.Posiljalac == "")
            {
                MessageBox.Show("Niste uneli posiljaoca!");
                txtPosiljalac.Focus();
                return;
            }
            p.Primalac = txtPrimalac.Text;
            if (p.Primalac == "")
            {
                MessageBox.Show("Niste uneli primaoca!");
                txtPrimalac.Focus();
                return;
            }
            p.Adresa = txtAdresa.Text;
            if (p.Adresa == "")
            {
                MessageBox.Show("Niste uneli adresu!");
                txtAdresa.Focus();
                return;
            }
            try
            {
                p.Masa = Convert.ToDouble(txtMasa.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nije dobra masa!");
                txtMasa.Focus();
                return;
            }
            if (p.Masa <= 0)
            {
                MessageBox.Show("Nije dobra masa!");
                txtMasa.Focus();
                return;
            }

            p.IzMesto = cmbMestoIZ.SelectedItem as Mesto;
            if (p.IzMesto == null)
            {
                MessageBox.Show("Niste odabrali mesto!");
                return;
            }

            p.UMesto = cmbMestoU.SelectedItem as Mesto;
            if (p.UMesto == null)
            {
                MessageBox.Show("Niste odabrali mesto!");
                return;
            }

            listaPosiljki.Add(p);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Posiljka p = dataGridView1.CurrentRow.DataBoundItem as Posiljka;
                listaPosiljki.Remove(p);
            }
            catch (Exception)
            {
                MessageBox.Show("Niste odabrali!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listaPosiljki.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int rez = Broker.dajSesiju().sacuvajPosiljke(new List<Posiljka>(listaPosiljki));
                //ovako se binding prevodi u obicnu listu

                if (rez == 0)
                {
                    MessageBox.Show("Nisu sacuvane!");
                }
                else
                {
                    MessageBox.Show("Sacuvane!");
                    listaPosiljki.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
