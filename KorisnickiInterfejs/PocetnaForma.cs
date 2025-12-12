using Biblioteka;
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
    public partial class PocetnaForma : Form
    {
        private Sluzbenik s;

        public PocetnaForma()
        {
            InitializeComponent();
        }

        public PocetnaForma(Sluzbenik s)
        {
            InitializeComponent();
            this.s = s;
            this.Text = "Dobro dosli: " + s.Ime +" "+ s.Prezime +" ,Vreme prijave: " + DateTime.Now.ToString("hh:mm tt");

        }

        private void dnevniToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PocetnaForma_Load(object sender, EventArgs e)
        {

        }

        private void krajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UnosPosiljke().ShowDialog();
        }
    }
}
