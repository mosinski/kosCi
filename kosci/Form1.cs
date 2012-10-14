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
        static int rodzaj_gry = 0, runda = 0;
        static int kostka1_los = 0, kostka2_los = 0, kostka3_los = 0, kostka4_los = 0, kostka5_los = 0;
        static string nazwa="_";

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
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.roll);
            simpleSound.Play();

            Random r = new Random();
            //losowanie liczb jeśli kostka jest wciśnięta
            //przypożadkowanie wylosowanej liczbie odpowiedniej kostki
            if (kostka1.Checked)
            {
                kostka1_los = r.Next(1,7);

                if (kostka1_los == 1)
                {
                    kostka1.Image = Properties.Resources._1;
                }
                else if (kostka1_los == 2)
                {
                    kostka1.Image = Properties.Resources._2;
                }
                else if (kostka1_los == 3)
                {
                    kostka1.Image = Properties.Resources._3;
                }
                else if (kostka1_los == 4)
                {
                    kostka1.Image = Properties.Resources._4;
                }
                else if (kostka1_los == 5)
                {
                    kostka1.Image = Properties.Resources._5;
                }
                else if (kostka1_los == 6)
                {
                    kostka1.Image = Properties.Resources._6;
                }
            }
            if (kostka2.Checked)
            {
                kostka2_los = r.Next(1, 7);

                if (kostka2_los == 1)
                {
                    kostka2.Image = Properties.Resources._1;
                }
                else if (kostka2_los == 2)
                {
                    kostka2.Image = Properties.Resources._2;
                }
                else if (kostka2_los == 3)
                {
                    kostka2.Image = Properties.Resources._3;
                }
                else if (kostka2_los == 4)
                {
                    kostka2.Image = Properties.Resources._4;
                }
                else if (kostka2_los == 5)
                {
                    kostka2.Image = Properties.Resources._5;
                }
                else if (kostka1_los == 6)
                {
                    kostka2.Image = Properties.Resources._6;
                }
            }
            if (kostka3.Checked)
            {
                kostka3_los = r.Next(1, 7);

                if (kostka3_los == 1)
                {
                    kostka3.Image = Properties.Resources._1;
                }
                else if (kostka3_los == 2)
                {
                    kostka3.Image = Properties.Resources._2;
                }
                else if (kostka3_los == 3)
                {
                    kostka3.Image = Properties.Resources._3;
                }
                else if (kostka3_los == 4)
                {
                    kostka3.Image = Properties.Resources._4;
                }
                else if (kostka3_los == 5)
                {
                    kostka3.Image = Properties.Resources._5;
                }
                else if (kostka3_los == 6)
                {
                    kostka3.Image = Properties.Resources._6;
                }
            }
            if (kostka4.Checked)
            {
                kostka4_los = r.Next(1, 7);

                if (kostka4_los == 1)
                {
                    kostka4.Image = Properties.Resources._1;
                }
                else if (kostka4_los == 2)
                {
                    kostka4.Image = Properties.Resources._2;
                }
                else if (kostka4_los == 3)
                {
                    kostka4.Image = Properties.Resources._3;
                }
                else if (kostka4_los == 4)
                {
                    kostka4.Image = Properties.Resources._4;
                }
                else if (kostka4_los == 5)
                {
                    kostka4.Image = Properties.Resources._5;
                }
                else if (kostka4_los == 6)
                {
                    kostka4.Image = Properties.Resources._6;
                }
            }
            if (kostka5.Checked)
            {
                kostka5_los = r.Next(1, 7);

                if (kostka5_los == 1)
                {
                    kostka5.Image = Properties.Resources._1;
                }
                else if (kostka5_los == 2)
                {
                    kostka5.Image = Properties.Resources._2;
                }
                else if (kostka5_los == 3)
                {
                    kostka5.Image = Properties.Resources._3;
                }
                else if (kostka5_los == 4)
                {
                    kostka5.Image = Properties.Resources._4;
                }
                else if (kostka5_los == 5)
                {
                    kostka5.Image = Properties.Resources._5;
                }
                else if (kostka1_los == 6)
                {
                    kostka5.Image = Properties.Resources._6;
                }
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

                runda++;
                MessageBox.Show("Runda nr: " + runda);
                silnik();
                if (runda == 3)
                {
                    runda = 0;
                    silnik();
                }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
