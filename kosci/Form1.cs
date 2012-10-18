using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Diagnostics;
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
            if (kostka1.Visible == false)
            {
                kostka1.Visible = true;
                kostka2.Visible = true;
                kostka3.Visible = true;
                kostka4.Visible = true;
                kostka5.Visible = true;
            }
            //wyświtlanie przycisku rzuć
            rzuc.Visible = true;
            if (rzuc.Enabled == false)
            {
                rzuc.Enabled = true;
            }
            groupBox1.Visible = true;
            
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            
            //wyświetlania punktacji
            if (button1.Enabled == false)
            { 
                button1.Enabled = true; 
            }
            if (button2.Enabled == false)
            { 
                button2.Enabled = true; 
            }
            if (button3.Enabled == false)
            { 
                button3.Enabled = true; 
            }
            if (button4.Enabled == false)
            { 
                button4.Enabled = true; 
            }
            if (button5.Enabled == false)
            { 
                button5.Enabled = true; 
            }
            if (button6.Enabled == false)
            {
                button6.Enabled = true;
            }

            if ((button1.Text != "") || (button2.Text != "") || (button3.Text != "") || (button4.Text != "") || (button5.Text != "") || (button6.Text != ""))
            {
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
            }
            //zerowanie zmiennych
            runda = 0; mnoznik = 0; suma = 0; wynik = 0;
            kostka1_los = 0; kostka2_los = 0; kostka3_los = 0; kostka4_los = 0; kostka5_los = 0;
            //zmiana kostek na 0
            if (kostka1.Image != Properties.Resources._0)
            {
                kostka1.Image = Properties.Resources._0;
                kostka2.Image = Properties.Resources._0;
                kostka3.Image = Properties.Resources._0;
                kostka4.Image = Properties.Resources._0;
                kostka5.Image = Properties.Resources._0;
            }
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
                //MessageBox.Show("Wylosowałem: "+kostka1_los+" "+kostka2_los+" "+kostka3_los+" "+kostka4_los+" "+kostka5_los);
            }
            else if (rodzaj_gry == 2)
            {
                MessageBox.Show("Witaj w wersji karcianej niestety nie jest jeszcze ona ukończona\nWybierz wersje klasyczną");
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
            //MessageBox.Show("Wynik to: "+wynik);
            suma = 0;
        }

        private void sumuj()
        {
            int jedynki = 0, dwojki = 0, trojki = 0, czworki = 0, piatki = 0, szostki = 0;
            if (button1.Text != "")
            {
                jedynki = Convert.ToInt32(button1.Text);
            }
            if (button2.Text != "")
            {
                dwojki = Convert.ToInt32(button2.Text);
            }
            if (button3.Text != "")
            {
                trojki = Convert.ToInt32(button3.Text);
            }
            if (button4.Text != "")
            {
                czworki = Convert.ToInt32(button4.Text);
            }
            if (button5.Text != "")
            {
                piatki = Convert.ToInt32(button5.Text);
            }
            if (button6.Text != "")
            {
                szostki = Convert.ToInt32(button6.Text);
            }
            int sumowanie = jedynki + dwojki + trojki + czworki + piatki + szostki;
            button7.Text = sumowanie.ToString();

            //przywrócenie możliwości 3 rzutów
            runda = 0;

            //wyświetlenie 3 obrazków symbolizujących rzuty
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;

            //zaznaczenie wszystkich kostek do rzutu w nowych turach
            kostka1.Checked = true;
            kostka2.Checked = true;
            kostka3.Checked = true;
            kostka4.Checked = true;
            kostka5.Checked = true;

            if ((button1.Enabled == false) & (button2.Enabled == false) & (button3.Enabled == false) & (button4.Enabled == false) & (button5.Enabled == false) & (button6.Enabled == false))
            {
                MessageBox.Show("Koniec Gry, Wynik to: " + sumowanie);
                rzuc.Enabled = false;
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
            if (runda == 3)
            {
                MessageBox.Show("\nPrzed kolejnym rzutem,\n należy wybrać pukty w górnej tabeli", "Nie wybrano puntów!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                runda++;
                //MessageBox.Show("Runda nr: " + runda);
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
            button1.Text = wynik.ToString();
            button1.Enabled = false;
            sumuj();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mnoznik = 2;
            podlicz();
            button2.Text = wynik.ToString();
            button2.Enabled = false;
            sumuj();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mnoznik = 3;
            podlicz();
            button3.Text = wynik.ToString();
            button3.Enabled = false;
            sumuj();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mnoznik = 4;
            podlicz();
            button4.Text = wynik.ToString();
            button4.Enabled = false;
            sumuj();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mnoznik = 5;
            podlicz();
            button5.Text = wynik.ToString();
            button5.Enabled = false;
            sumuj();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mnoznik = 6;
            podlicz();
            button6.Text = wynik.ToString();
            button6.Enabled = false;
            sumuj();
        }


        private void jakGraćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string zasady = "---------------------------------------------------------------------------\n";
            zasady +="1. Celem gry jest zdobycie jak najwyższej liczby punktów.\n\n";
            zasady +="2. Gracz w każdej turze ma do dyspozycji 3 rzuty kośćmi.\n\n";
            zasady +="3. Przed rzutem odznaczasz kości, którymi nie chcesz rzucać.\n\n";
            zasady +="4. Po każdej turze, wszystki kości automatycznie zaznaczają się do rzutu.\n\n";
            zasady +="5. Na koniec tury zaznaczamy pole, w które chcemy wpisać wynik.\n\n";
            zasady +="6. Gra dostępna jest w 2-óch wersjach klasycznej i karcianej.\n";
            zasady += "---------------------------------------------------------------------------\n";
            MessageBox.Show("Zasady gry są bardzo proste:\n"+zasady, "Jak grać?", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/mosinski");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/m1l05z");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:mylosz@yahoo.pl");
        }

        private void autorzyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autor.Visible = true;
            groupBox1.Visible = false;
            kostka1.Visible = false;
            kostka2.Visible = false;
            kostka3.Visible = false;
            kostka4.Visible = false;
            kostka5.Visible = false;
            rzuc.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            autor.Visible = false;
            groupBox1.Visible = true;
            kostka1.Visible = true;
            kostka2.Visible = true;
            kostka3.Visible = true;
            kostka4.Visible = true;
            kostka5.Visible = true;
            rzuc.Visible = true;
        }


    }
}
