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
        static int rodzaj_gry = 0, runda = 0;
        static int kostka1_los = 0, kostka2_los = 0, kostka3_los = 0, kostka4_los = 0, kostka5_los = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //menu wyjdź wyłącza aplikacje
        private void wyjdźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //wyswietlanie elementów po wybraniu rodzaju gry
        private void pokaz()
        {
            kostka1.Visible = true;
            kostka2.Visible = true;
            kostka3.Visible = true;
            kostka4.Visible = true;
            kostka5.Visible = true;
            rzuc.Visible = true;
        }

        //silnik gry rozpoznaje ktorą werje rozgrywki wybrał użytkownik
        private void silnik()
        {
            Random r = new Random();
            //losowanie liczb jeśli kostka jest wciśnięta
            if (kostka1.Checked)
            {
                kostka1_los = r.Next(1,6);
            }
            if (kostka2.Checked)
            {
                kostka2_los = r.Next(1, 6);
            }
            if (kostka3.Checked)
            {
                kostka3_los = r.Next(1, 6);
            }
            if (kostka4.Checked)
            {
                kostka4_los = r.Next(1, 6);
            }
            if (kostka5.Checked)
            {
                kostka5_los = r.Next(1, 6);
            }

            //
            if (rodzaj_gry == 1)
            {
                MessageBox.Show("Wylosowałem: "+kostka1_los+" "+kostka2_los+" "+kostka3_los+" "+kostka4_los+" "+kostka5_los);
            }
            else if (rodzaj_gry == 2)
            {
                MessageBox.Show("Witaj w wersji karcianej");
            }
        }

        private void wersjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rodzaj_gry = 1;
            pokaz();
        }

        private void wersjaKarcianaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rodzaj_gry = 2;
            pokaz();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (runda > 3)
            {
                runda = 0;
            }
            else
            {
                MessageBox.Show("Runda nr: " + runda);
                runda++;
                silnik();
            }
        }
    }
}
