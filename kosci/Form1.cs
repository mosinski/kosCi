using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kosci
{
    public partial class Form1 : Form
    {
        static int rodzaj_gry = 0, runda = 0, mnoznik = 0, suma = 0, wynik = 0;
        static int kostka1_los = 0, kostka2_los = 0, kostka3_los = 0, kostka4_los = 0, kostka5_los = 0;
        static string nazwa = "_";
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
            groupBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
        }


        //silnik gry rozpoznaje ktorą werje rozgrywki wybrał użytkownik
        private void silnik()
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.roll);
            simpleSound.Play();

            Random r = new Random();
            //losowanie liczb jeśli kostka jest wciśnięta
            //przypożadkowanie wylosowanej liczbie odpowiedniej kostki
            if (kostka1.Checked)
            {
                kostka1_los = r.Next(1,7);
                nazwa += Convert.ToString(kostka1_los); ;
                kostka1.Image = Properties.Resources.ResourceManager.GetObject(nazwa) as Image;
                nazwa = "_";
            }
            if (kostka2.Checked)
            {
                kostka2_los = r.Next(1, 7);
                nazwa += Convert.ToString(kostka2_los); ;
                kostka2.Image = Properties.Resources.ResourceManager.GetObject(nazwa) as Image;
                nazwa = "_";
            }
            if (kostka3.Checked)
            {
                kostka3_los = r.Next(1, 7);
                nazwa += Convert.ToString(kostka3_los); ;
                kostka3.Image = Properties.Resources.ResourceManager.GetObject(nazwa) as Image;
                nazwa = "_"; 
            }
            if (kostka4.Checked)
            {
                kostka4_los = r.Next(1, 7);
                nazwa += Convert.ToString(kostka4_los); ;
                kostka4.Image = Properties.Resources.ResourceManager.GetObject(nazwa) as Image;
                nazwa = "_";
            }
            if (kostka5.Checked)
            {
                kostka5_los = r.Next(1, 7);
                nazwa += Convert.ToString(kostka5_los); ;
                kostka5.Image = Properties.Resources.ResourceManager.GetObject(nazwa) as Image;
                nazwa = "_";
            }

            //
            if (rodzaj_gry == 1)
            {
                MessageBox.Show("Wylosowałem: "+kostka1_los+" "+kostka2_los+" "+kostka3_los+" "+kostka4_los+" "+kostka5_los);
            }
            else if (rodzaj_gry == 2)
            {
                MessageBox.Show("Witaj w wersji karcianej niestety nie jest jeszcze ona ukończona");
            }
        }

        private void podlicz()
        {
            if (kostka1_los == mnoznik)
            {
                suma++;
            }
            if (kostka2_los == mnoznik)
            {
                suma++;
            }
            if (kostka3_los == mnoznik)
            {
                suma++;
            }
            if (kostka4_los == mnoznik)
            {
                suma++;
            }
            if (kostka5_los == mnoznik)
            {
                suma++;
            }
            wynik = suma * mnoznik;
            MessageBox.Show("Wynik to: "+wynik);

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
            if (runda == 3)
            {
                MessageBox.Show("Runda nr: " + runda+"\nWybierz punkty");
            }
            else
            {
                runda++;
                MessageBox.Show("Runda nr: " + runda);
                silnik();
                if (runda == 1)
                {
                    pictureBox1.Visible = false;
                }
                if (runda == 2)
                {
                    pictureBox2.Visible = false;
                }
                if (runda == 3)
                {
                    pictureBox3.Visible = false;
                }
            } 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mnoznik = 1;
            podlicz();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mnoznik = 2;
            podlicz();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mnoznik = 3;
            podlicz();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mnoznik = 4;
            podlicz();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mnoznik = 5;
            podlicz();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mnoznik = 6;
            podlicz();
        }
    }
}
