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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Sluzbenik s = new Sluzbenik();
            s.User = textUser.Text;
            s.Pass = textPass.Text;
            try
            {
                s = Broker.dajSesiju().login(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (s == null)
            {
                MessageBox.Show("Sluzbenik ne postoji u sistemu!");
            }
            else
            {
                this.Hide();
                new PocetnaForma(s).ShowDialog();
                this.Show();
            }
        }
    }
}
