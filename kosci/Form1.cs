using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kosci
{
    public partial class Form1 : Form
    {
        static int rodzaj_gry = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //menu wyjdź wyłącza aplikacje
        private void wyjdźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //silnik gry rozpoznaje ktorą werje rozgrywki wybrał użytkownik
        private void silnik()
        {
            kostka1.Visible = true;
            kostka2.Visible = true;
            kostka3.Visible = true;
            kostka4.Visible = true;
            kostka5.Visible = true;

            if (rodzaj_gry == 1)
            {
                MessageBox.Show("Witaj w wersji standardowej");
            }
            else if (rodzaj_gry == 2)
            {
                MessageBox.Show("Witaj w wersji karcianej");
            }
        }

        private void wersjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rodzaj_gry = 1;
            silnik();
        }

        private void wersjaKarcianaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rodzaj_gry = 2;
            silnik();
        }
    }
}
