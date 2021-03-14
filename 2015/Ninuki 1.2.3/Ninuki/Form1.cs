using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Ninuki
{
    public partial class Form1 : Form
    {
        public int[,] area;
        public bool gameStart = false;
        public int HracNaTahu = 1;

        public int r = 15;
        public int d = 30;
        public int hrana35 = 35;
        public int caraZacatek = 17;
        public int caraOdsazeni = 35;
        public int caraKonec = 665;
        public int puntikZacatek = 122;
        public int puntikOdsazeni = 210;
        public int puntikKonec = 542;
        public int areaSize = 665;
        public int fontX = 3, fontY1 = 4, fontY2 = -2;
        public int LetterX = 35, LetterY = 33;
        public int UkazNaTahuOdsazeni = 8, UkazNaTahuVelikost = 60;
        
        public int BbW = 0;
        public int WbB = 0;
        public bool winBlack1, winBlack2, winBlack3, winBlack4 = false;
        public bool winWhite1, winWhite2, winWhite3, winWhite4 = false;
        public int white1, white2, white3, white4 = 0;
        public int black1, black2, black3, black4 = 0;
        public int PocetTahu = 1;
        public int winning = 0;
        public int pocether = 0;

        public bool zaznamtahu = false;

        public bool Czech = true;
        public bool English = false;
        public bool Deutsch = false;

        public Form1()
        {
            InitializeComponent();
            area = new int[30, 30];
        }

        private void Form1_Load(object sender, EventArgs e)
        { lbX.Hide(); lbY.Hide(); }

        private void hra_Paint(object sender, PaintEventArgs e)
        {
            
            if (!gameStart)
            { e.Graphics.Clear(Hra.BackColor); }

            else
            {
                Graphics kreslim = e.Graphics;
                Pen laiany = new Pen(Color.Black, 1);
                Pen obrysy = new Pen(Color.Black, 2);

                //čáry:
                for (int i = caraZacatek; i <= caraKonec; i += caraOdsazeni)
                { kreslim.DrawLine(laiany, 0, i, ClientSize.Width, i); }
                for (int i = caraZacatek; i <= caraKonec; i += caraOdsazeni)
                { kreslim.DrawLine(laiany, i, 0, i, ClientSize.Height); }

                //puntíky:
                for (int i = puntikZacatek; i <= puntikKonec; i += puntikOdsazeni)
                {
                    for (int j = puntikZacatek; j <= puntikKonec; j += puntikOdsazeni)
                    { kreslim.FillEllipse(Brushes.Black, i - 4, j - 4, 8, 8); }
                }
            }
        }

        private void Hra_MouseClick(object sender, MouseEventArgs e)
        {
            if (gameStart)
            {
                int x = e.X / hrana35 + 3;
                int y = e.Y / hrana35 + 3;

                if (area[x, y] == 1 || area[x, y] == 2) { return; } //obsazený => ukončení
                if (HracNaTahu == 1)
                {
                    area[x, y] = 1;
                    HracNaTahu = 2;
                }
                else
                {
                    area[x, y] = 2;
                    HracNaTahu = 1;
                }

                Nakresli(x, y);
                UkazNaTahu();

                BraniKamenu(x, y);


                if (HracNaTahu == 1)
                { Zaznam.Text = Zaznam.Text + "\r\n" + PocetTahu + ". tah: W - X: " + (x - 2) + ", Y: " + (y - 2) + "; "; PocetTahu = PocetTahu + 1; }  //Čtení souřadnic?

                if (HracNaTahu == 2)
                {
                    if (PocetTahu == 1)
                    { Zaznam.Text = Zaznam.Text + PocetTahu + ". tah: B - X: " + (x - 2) + ", Y: " + (y - 2) + "; "; PocetTahu = PocetTahu + 1; }
                    else
                    { Zaznam.Text = Zaznam.Text + Environment.NewLine + PocetTahu + ". tah: B - X: " + (x - 2) + ", Y: " + (y - 2) + "; "; PocetTahu = PocetTahu + 1; }
                }
                

                if (winning <= 1)
                {
                    if (winBlack1 == false)
                    { black1 = 0; }
                    if (winBlack2 == false)
                    { black2 = 0; }
                    if (winBlack3 == false)
                    { black3 = 0; }
                    if (winBlack4 == false)
                    { black4 = 0; }

                    if (winWhite1 == false)
                    { white1 = 0; }
                    if (winWhite2 == false)
                    { white2 = 0; }
                    if (winWhite3 == false)
                    { white3 = 0; }
                    if (winWhite4 == false)
                    { white4 = 0; }
                }

                if (cbPole.Checked == true)
                { SouradniceNaPoli(); }

                zaznamtahu = false;
            }
        }

        private void Nakresli(int x, int y)
        {
            using (Graphics g = Hra.CreateGraphics())
            {
                if (area[x, y] == 1)
                { g.FillEllipse(Brushes.Black, caraZacatek + (x - 3) * hrana35 - r, caraZacatek + (y - 3) * hrana35 - r, d, d); }

                if (area[x, y] == 2)
                { g.FillEllipse(Brushes.White, caraZacatek + (x - 3) * hrana35 - r, caraZacatek + (y - 3) * hrana35 - r, d, d); }

                Pen liana = new Pen(Color.Black, 1);
                for (int i = 3; i <= 22; i++)
                {
                    for (int j = 3; j <= 22; j++)
                    {
                        if (area[i, j] == 3)
                        {
                            g.FillEllipse(Brushes.Peru, caraZacatek + (i - 3) * hrana35 - r, 20 + (j - 3) * hrana35 - r - 3, d, d);

                            g.DrawLine(liana, (i - 2) * hrana35 - caraZacatek, (j - 2) * hrana35 - caraZacatek, (i - 2) * hrana35, (j - 2) * hrana35 - caraZacatek); //ixová 
                            g.DrawLine(liana, (i - 2) * hrana35 - caraZacatek, (j - 2) * hrana35 - caraZacatek, (i - 2) * hrana35 - caraZacatek, (j - 2) * hrana35); //ypsylonová
                        }
                    }
                }
            }
        }

        public void UkazNaTahu()
        {
            using (Graphics g = NaTahu.CreateGraphics())
            {
                if (HracNaTahu == 1)
                { g.FillEllipse(Brushes.Black, UkazNaTahuOdsazeni, UkazNaTahuOdsazeni, UkazNaTahuVelikost, UkazNaTahuVelikost); }
                else
                { g.FillEllipse(Brushes.White, UkazNaTahuOdsazeni, UkazNaTahuOdsazeni, UkazNaTahuVelikost, UkazNaTahuVelikost); }
            }
        }

        private void BraniKamenu(int x, int y)
        {
            //Black bere White
            if (area[x, y] == 1 && area[x + 1, y] == 2 && area[x + 2, y] == 2 && area[x + 3, y] == 1)
            { area[x + 1, y] = 3; area[x + 2, y] = 3; BbW = BbW + 1; }
            if (area[x, y] == 1 && area[x - 1, y] == 2 && area[x - 2, y] == 2 && area[x - 3, y] == 1)
            { area[x - 1, y] = 3; area[x - 2, y] = 3; BbW = BbW + 1; }

            if (area[x, y] == 1 && area[x, y + 1] == 2 && area[x, y + 2] == 2 && area[x, y + 3] == 1)
            { area[x, y + 1] = 3; area[x, y + 2] = 3; BbW = BbW + 1; }
            if (area[x, y] == 1 && area[x, y - 1] == 2 && area[x, y - 2] == 2 && area[x, y - 3] == 1)
            { area[x, y - 1] = 3; area[x, y - 2] = 3; BbW = BbW + 1; }

            if (area[x, y] == 1 && area[x + 1, y + 1] == 2 && area[x + 2, y + 2] == 2 && area[x + 3, y + 3] == 1)
            { area[x + 1, y + 1] = 3; area[x + 2, y + 2] = 3; BbW = BbW + 1; }
            if (area[x, y] == 1 && area[x - 1, y - 1] == 2 && area[x - 2, y - 2] == 2 && area[x - 3, y - 3] == 1)
            { area[x - 1, y - 1] = 3; area[x - 2, y - 2] = 3; BbW = BbW + 1; }
            if (area[x, y] == 1 && area[x + 1, y - 1] == 2 && area[x + 2, y - 2] == 2 && area[x + 3, y - 3] == 1)
            { area[x + 1, y - 1] = 3; area[x + 2, y - 2] = 3; BbW = BbW + 1; }
            if (area[x, y] == 1 && area[x - 1, y + 1] == 2 && area[x - 2, y + 2] == 2 && area[x - 3, y + 3] == 1)
            { area[x - 1, y + 1] = 3; area[x - 2, y + 2] = 3; BbW = BbW + 1; }

            //White bere Black
            if (area[x, y] == 2 && area[x + 1, y] == 1 && area[x + 2, y] == 1 && area[x + 3, y] == 2)
            { area[x + 1, y] = 3; area[x + 2, y] = 3; WbB = WbB + 1; }
            if (area[x, y] == 2 && area[x - 1, y] == 1 && area[x - 2, y] == 1 && area[x - 3, y] == 2)
            { area[x - 1, y] = 3; area[x - 2, y] = 3; WbB = WbB + 1; }

            if (area[x, y] == 2 && area[x, y + 1] == 1 && area[x, y + 2] == 1 && area[x, y + 3] == 2)
            { area[x, y + 1] = 3; area[x, y + 2] = 3; WbB = WbB + 1; }
            if (area[x, y] == 2 && area[x, y - 1] == 1 && area[x, y - 2] == 1 && area[x, y - 3] == 2)
            { area[x, y - 1] = 3; area[x, y - 2] = 3; WbB = WbB + 1; }

            if (area[x, y] == 2 && area[x + 1, y + 1] == 1 && area[x + 2, y + 2] == 1 && area[x + 3, y + 3] == 2)
            { area[x + 1, y + 1] = 3; area[x + 2, y + 2] = 3; WbB = WbB + 1; }
            if (area[x, y] == 2 && area[x - 1, y - 1] == 1 && area[x - 2, y - 2] == 1 && area[x - 3, y - 3] == 2)
            { area[x - 1, y - 1] = 3; area[x - 2, y - 2] = 3; WbB = WbB + 1; }
            if (area[x, y] == 2 && area[x + 1, y - 1] == 1 && area[x + 2, y - 2] == 1 && area[x + 3, y - 3] == 2)
            { area[x + 1, y - 1] = 3; area[x + 2, y - 2] = 3; WbB = WbB + 1; }
            if (area[x, y] == 2 && area[x - 1, y + 1] == 1 && area[x - 2, y + 2] == 1 && area[x - 3, y + 3] == 2)
            { area[x - 1, y + 1] = 3; area[x - 2, y + 2] = 3; WbB = WbB + 1; }


            labelB.Text = ("Počet zabraných bílých: " + BbW);
            labelW.Text = ("Počet zabraných černých: " + WbB);

            Konec konec = new Konec();
            if (winning < 1)
            {
                if (BbW >= 5)
                { MessageBox.Show("Černý vyhrál!"); BbW = BbW + 1; winning = winning + 1; konec.Show(); pocether = pocether + 1; }

                if (WbB >= 5)
                { MessageBox.Show("Bílý vyhrál!"); WbB = WbB + 1; winning = winning + 1; konec.Show(); pocether = pocether + 1; }

                Nakresli(x, y);
                Vyhra5();
            }
        }

        private void Vyhra5()
        {
            //black
            if (winBlack1 == true)
            {
                for (int x = 3; x < area.GetLength(0) - 5; x++)
                {
                    for (int y = 3; y < area.GetLength(0) - 5; y++)
                    {
                        if (area[x, y] * area[x + 1, y] * area[x + 2, y] * area[x + 3, y] * area[x + 4, y] != 1)
                        { winBlack1 = false; }
                    }
                }
            }
            if (winBlack1 == false)
            {
                for (int x = 3; x < area.GetLength(0) - 5; x++)
                {
                    for (int y = 3; y < area.GetLength(0) - 5; y++)
                    {
                        if (area[x, y] * area[x + 1, y] * area[x + 2, y] * area[x + 3, y] * area[x + 4, y] == 1 && area[x - 1, y] != 1 && area[x + 5, y] != 1)
                        { winBlack1 = true; }
                    }
                }
            }

            if (winBlack2 == true)
            {
                for (int x = 3; x < area.GetLength(0) - 5; x++)
                {
                    for (int y = 3; y < area.GetLength(0) - 5; y++)
                    {
                        if (area[x, y] * area[x, y + 1] * area[x, y + 2] * area[x, y + 3] * area[x, y + 4] != 1)
                        { winBlack2 = false; }
                    }
                }
            }
            if (winBlack2 == false)
            {
                for (int x = 3; x < area.GetLength(0) - 5; x++)
                {
                    for (int y = 3; y < area.GetLength(0) - 5; y++)
                    {
                        if (area[x, y] * area[x, y + 1] * area[x, y + 2] * area[x, y + 3] * area[x, y + 4] == 1 && area[x, y - 1] != 1 && area[x, y + 5] != 1)
                        { winBlack2 = true; }
                    }
                }
            }

            if (winBlack3 == true)
            {
                for (int x = 3; x < area.GetLength(0) - 5; x++)
                {
                    for (int y = 3; y < area.GetLength(0) - 5; y++)
                    {
                        if (area[x, y] * area[x + 1, y + 1] * area[x + 2, y + 2] * area[x + 3, y + 3] * area[x + 4, y + 4] != 1)
                        { winBlack3 = false; }
                    }
                }
            }
            if (winBlack3 == false)
            {
                for (int x = 3; x < area.GetLength(0) - 5; x++)
                {
                    for (int y = 3; y < area.GetLength(0) - 5; y++)
                    {
                        if (area[x, y] * area[x + 1, y + 1] * area[x + 2, y + 2] * area[x + 3, y + 3] * area[x + 4, y + 4] == 1 && area[x - 1, y - 1] != 1 && area[x + 5, y + 5] != 1)
                        { winBlack3 = true; }
                    }
                }
            }

            if (winBlack4 == true)
            {
                for (int x = 3; x < area.GetLength(0) - 5; x++)
                {
                    for (int y = 3; y < area.GetLength(0) - 5; y++)
                    {
                        if (area[x + 4, y] * area[x + 3, y + 1] * area[x + 2, y + 2] * area[x + 1, y + 3] * area[x, y + 4] != 1)
                        { winBlack4 = false; }
                    }
                }
            }
            if (winBlack4 == false)
            {
                for (int x = 3; x < area.GetLength(0) - 5; x++)
                {
                    for (int y = 3; y < area.GetLength(0) - 5; y++)
                    {
                        if (area[x + 4, y] * area[x + 3, y + 1] * area[x + 2, y + 2] * area[x + 1, y + 3] * area[x, y + 4] == 1 && area[x - 1, y + 5] != 1 && area[x + 5, y - 1] != 1)
                        { winBlack4 = true; }
                    }
                }
            }

            //white
            if (winWhite1 == true)
            {
                for (int x = 3; x < area.GetLength(0) - 5; x++)
                {
                    for (int y = 3; y < area.GetLength(0) - 5; y++)
                    {
                        if (area[x, y] * area[x + 1, y] * area[x + 2, y] * area[x + 3, y] * area[x + 4, y] != 32)
                        { winWhite1 = false; }
                    }
                }
            }
            if (winWhite1 == false)
            {
                for (int x = 3; x < area.GetLength(0) - 5; x++)
                {
                    for (int y = 3; y < area.GetLength(0) - 5; y++)
                    {
                        if (area[x, y] * area[x + 1, y] * area[x + 2, y] * area[x + 3, y] * area[x + 4, y] == 32 && area[x - 1, y] != 2 && area[x + 5, y] != 2)
                        { winWhite1 = true; }
                    }
                }
            }

            if (winWhite2 == true)
            {
                for (int x = 3; x < area.GetLength(0) - 5; x++)
                {
                    for (int y = 3; y < area.GetLength(0) - 5; y++)
                    {
                        if (area[x, y] * area[x, y + 1] * area[x, y + 2] * area[x, y + 3] * area[x, y + 4] != 32)
                        { winWhite2 = false; }
                    }
                }
            }
            if (winWhite2 == false)
            {
                for (int x = 3; x < area.GetLength(0) - 5; x++)
                {
                    for (int y = 3; y < area.GetLength(0) - 5; y++)
                    {
                        if (area[x, y] * area[x, y + 1] * area[x, y + 2] * area[x, y + 3] * area[x, y + 4] == 32 && area[x, y - 1] != 2 && area[x, y + 5] != 2)
                        { winWhite2 = true; }
                    }
                }
            }

            if (winWhite3 == true)
            {
                for (int x = 3; x < area.GetLength(0) - 5; x++)
                {
                    for (int y = 3; y < area.GetLength(0) - 5; y++)
                    {
                        if (area[x, y] * area[x + 1, y + 1] * area[x + 2, y + 2] * area[x + 3, y + 3] * area[x + 4, y + 4] != 32)
                        { winWhite3 = false; }
                    }
                }
            }
            if (winWhite3 == false)
            {
                for (int x = 3; x < area.GetLength(0) - 5; x++)
                {
                    for (int y = 3; y < area.GetLength(0) - 5; y++)
                    {
                        if (area[x, y] * area[x + 1, y + 1] * area[x + 2, y + 2] * area[x + 3, y + 3] * area[x + 4, y + 4] == 32 && area[x - 1, y - 1] != 2 && area[x + 5, y + 5] != 2)
                        { winWhite3 = true; }
                    }
                }
            }

            if (winWhite4 == true)
            {
                for (int x = 3; x < area.GetLength(0) - 5; x++)
                {
                    for (int y = 3; y < area.GetLength(0) - 5; y++)
                    {
                        if (area[x + 4, y] * area[x + 3, y + 1] * area[x + 2, y + 2] * area[x + 1, y + 3] * area[x, y + 4] != 32)
                        { winWhite4 = false; }
                    }
                }
            }
            if (winWhite4 == false)
            {
                for (int x = 3; x < area.GetLength(0) - 5; x++)
                {
                    for (int y = 3; y < area.GetLength(0) - 5; y++)
                    {
                        if (area[x + 4, y] * area[x + 3, y + 1] * area[x + 2, y + 2] * area[x + 1, y + 3] * area[x, y + 4] == 32 && area[x + 5, y - 1] != 2 && area[x - 1, y + 5] != 2)
                        { winWhite4 = true; }
                    }
                }
            }

            Konec konec = new Konec();

            if (winBlack1 == true)
            { black1 = black1 + 1; if (black1 == 2) { MessageBox.Show("Černý vyhrál!"); winning = winning + 1; konec.Show(); } }
            if (winBlack2 == true)
            { black2 = black2 + 1; if (black2 == 2) { MessageBox.Show("Černý vyhrál"); winning = winning + 1; konec.Show(); } }
            if (winBlack3 == true)
            { black3 = black3 + 1; if (black3 == 2) { MessageBox.Show("Černý vyhrál"); winning = winning + 1; konec.Show(); } }
            if (winBlack4 == true)
            { black4 = black4 + 1; if (black4 == 2) { MessageBox.Show("Černý vyhrál"); winning = winning + 1; konec.Show(); } }

            if (winWhite1 == true)
            { white1 = white1 + 1; if (white1 == 2) { MessageBox.Show("Bílý vyhrál!"); winning = winning + 1; konec.Show(); } }
            if (winWhite2 == true)
            { white2 = white2 + 1; if (white2 == 2) { MessageBox.Show("Bílý vyhrál"); winning = winning + 1; konec.Show(); } }
            if (winWhite3 == true)
            { white3 = white3 + 1; if (white3 == 2) { MessageBox.Show("Bílý vyhrál"); winning = winning + 1; konec.Show(); } }
            if (winWhite4 == true)
            { white4 = white4 + 1; if (white4 == 2) { MessageBox.Show("Bílý vyhrál"); winning = winning + 1; konec.Show(); } }
        }
        

        private void cbMys_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMys.Checked == true)
            { lbX.Show(); lbY.Show(); timer1.Enabled = true; }
            else
            { lbX.Hide(); lbY.Hide(); timer1.Enabled = false; }
        }

        private void Hra_MouseMove(object sender, MouseEventArgs e)
        {
            int x = (e.X + 26) / hrana35, y = (e.Y + 26) / hrana35;
            lbX.Location = new Point(x * hrana35 - (lbX.Width + 10), y * hrana35 - 13);
            if (x == 19 && y > 9)
            { lbY.Location = new Point(x * hrana35 - caraZacatek, y * hrana35 - (lbY.Height + 10)); }
            else
            { lbY.Location = new Point(x * hrana35 - 13, y * hrana35 - (lbY.Height + 10)); }
            lbX.Text = x.ToString(); lbY.Text = y.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (Graphics g = Hra.CreateGraphics())
                for (int x = 3; x <= 23; x++)
                {
                    for (int y = 3; y <= 23; y++)
                    {
                        if (area[x, y] == 1)
                        { g.FillEllipse(Brushes.Black, caraZacatek + (x - 3) * hrana35 - r, caraZacatek + (y - 3) * hrana35 - r, d, d); }

                        if (area[x, y] == 2)
                        { g.FillEllipse(Brushes.White, caraZacatek + (x - 3) * hrana35 - r, caraZacatek + (y - 3) * hrana35 - r, d, d); }
                    }
                }

            if (cbPole.Checked == true)
            { SouradniceNaPoli(); }
        }

        private void cbPole_CheckedChanged(object sender, EventArgs e)
        {
            using (Graphics g = Hra.CreateGraphics())

                if (cbPole.Checked == true)
                { SouradniceNaPoli(); }

                else
                {
                    Pen laiany = new Pen(Color.Black, 1);
                    g.FillRectangle(Brushes.Peru, 0, 0, areaSize, areaSize);
                    for (int i = caraZacatek; i <= caraKonec; i += caraOdsazeni)
                    { g.DrawLine(laiany, 0, i, ClientSize.Width, i); }
                    for (int i = caraZacatek; i <= caraKonec; i += caraOdsazeni)
                    { g.DrawLine(laiany, i, 0, i, ClientSize.Height); }

                    for (int i = puntikZacatek; i <= puntikKonec; i += puntikOdsazeni)
                    {
                        for (int j = puntikZacatek; j <= puntikKonec; j += puntikOdsazeni)
                        { g.FillEllipse(Brushes.Black, i - 4, j - 4, 8, 8); }
                    }
                    for (int x = 3; x <= 23; x++)
                    {
                        for (int y = 3; y <= 23; y++)
                        {
                            if (area[x, y] == 1)
                            { g.FillEllipse(Brushes.Black, caraZacatek + (x - 3) * hrana35 - r, caraZacatek + (y - 3) * hrana35 - r, d, d); }

                            if (area[x, y] == 2)
                            { g.FillEllipse(Brushes.White, caraZacatek + (x - 3) * hrana35 - r, caraZacatek + (y - 3) * hrana35 - r, d, d); }
                        }
                    }
                }
        }

        private void SouradniceNaPoli()
        {
            FontFamily fontFamily = new FontFamily("Microsoft Sans Serif");
            Font font = new Font(fontFamily, 10, FontStyle.Bold);
            using (Graphics g = Hra.CreateGraphics())

            for (int x = 1; x < 20; x++)
                { g.DrawString("" + x, font, Brushes.Blue, caraZacatek + hrana35 * (x - 1), fontX); }
            for (int y = 1; y < 20; y++)
            {
                using (Graphics g = Hra.CreateGraphics())
                    if (y < 10)
                    { g.DrawString("" + y, font, Brushes.Blue, fontY1, caraZacatek + hrana35 * (y - 1)); }
                using (Graphics g = Hra.CreateGraphics())
                    if (y > 9)
                    { g.DrawString("" + y, font, Brushes.Blue, fontY2, caraZacatek + hrana35 * (y - 1)); }
            }

            using (Graphics g = Hra.CreateGraphics())
            g.DrawString("X", font, Brushes.DarkRed, LetterX, 3);
            using (Graphics g = Hra.CreateGraphics())
            g.DrawString("Y", font, Brushes.DarkRed, 3, LetterY);
        }

        private void btnBug_Click(object sender, EventArgs e)
        {
            using (Graphics g = Hra.CreateGraphics())
                for (int x = 3; x <= 23; x++)
                {
                    for (int y = 3; y <= 23; y++)
                    {
                        if (area[x, y] == 1)
                        { g.FillEllipse(Brushes.Black, caraZacatek + (x - 3) * hrana35 - r, caraZacatek + (y - 3) * hrana35 - r, d, d); }

                        if (area[x, y] == 2)
                        { g.FillEllipse(Brushes.White, caraZacatek + (x - 3) * hrana35 - r, caraZacatek + (y - 3) * hrana35 - r, d, d); }
                    }
                }

            UkazNaTahu();

            if (cbPole.Checked == true)
            { SouradniceNaPoli(); }
        }

        public void Zaznam_TextChanged(object sender, EventArgs e)
        {
            Zaznam.SelectionStart = Zaznam.Text.Length;
            Zaznam.ScrollToCaret();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (PocetTahu >= 2)
            {
                if (zaznamtahu == false)
                {
                    switch (MessageBox.Show(this, "Můžete ještě uložit záznam tahů. \r\n Opravdu chcete začít novou hru? ", "Nová hra?", MessageBoxButtons.YesNo))
                    {
                        case DialogResult.No: break;
                        default: NG(); break;
                    }
                }
                else
                {
                    switch (MessageBox.Show(this, "Opravdu chcete začít novou hru?", "Nová hra?", MessageBoxButtons.YesNo))
                    {
                        case DialogResult.No: break;
                        default: NG(); break;
                    }
                }

                if (cbPole.Checked == true)
                { SouradniceNaPoli(); }
            }
            else
            { NG(); }
           /* pocether = pocether + 1;
            if (pocether == 1)
            {
                Form1 f1 = new Form1();
                f1.FormBorderStyle = FormBorderStyle.None;
            } */
        }

        public void NG()
        {
            area = new int[30, 30];
            for (int i = 0; i < area.GetLength(0); i++)
            {
                for (int j = 0; j < area.GetLength(1); j++)
                { area[i, j] = 0; }
            }

            gameStart = true;
            HracNaTahu = 1;
            PocetTahu = 1;
            BbW = 0; WbB = 0;
            black1 = 0; black2 = 0; black3 = 0; black4 = 0;
            white1 = 0; white2 = 0; white3 = 0; white4 = 0;
            winBlack1 = false; winBlack2 = false; winBlack3 = false; winBlack4 = false;
            winWhite1 = false; winWhite2 = false; winWhite3 = false; winWhite4 = false;
            winning = 0;

            UkazNaTahu();
            Zaznam.Clear();
            Hra.Refresh();
        }

        public void btnSave_Click(object sender, EventArgs e)
        { ab(); zaznamtahu = true; }

        private void btnEnd_Click(object sender, EventArgs e)
        { 
            ReallyKonec f3 = new ReallyKonec();
            if (PocetTahu <= 3)
            { this.Close(); }
            else
            { f3.Show(); }
        }
		
		protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (pocether >= 2)
            {
                switch (MessageBox.Show(this, "Toto je poslední okno hry, které vypne celou hru. \r\n Opravdu chcete ukončit hru?", "Vypnutí programu", MessageBoxButtons.YesNo))
                {
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }
        }

        public void abc()
        { System.Windows.Forms.Application.Exit(); }

        public void ab()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            sfd.RestoreDirectory = true;
            sfd.InitialDirectory = @"c:\";
            
            if (sfd.ShowDialog() == DialogResult.OK)
            {
               /* FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(fs);
                writer.Write(Zaznam.Text);
                fs.Close(); */

                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    foreach (string line in Zaznam.Lines)
                    { sw.WriteLine(line); }
                }
            }
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            using (Graphics g = Hra.CreateGraphics())
                for (int x = 3; x <= 23; x++)
                {
                    for (int y = 3; y <= 23; y++)
                    {
                        if (area[x, y] == 1)
                        { g.FillEllipse(Brushes.Black, 20 + (x - 3) * hrana35 - r, 20 + (y - 3) * hrana35 - r, d, d); }

                        if (area[x, y] == 2)
                        { g.FillEllipse(Brushes.White, 20 + (x - 3) * hrana35 - r, 20 + (y - 3) * hrana35 - r, d, d); }
                    }
                }

            UkazNaTahu();

            if (cbPole.Checked == true)
            { SouradniceNaPoli(); }
        }

        /*private void btnLoad
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Fuilse|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            { Zaznam.Text = System.IO.File.ReadAllText(ofd.FileName); }
        }*/

        private void českyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Czech = true;
            English = false;
            Deutsch = false;
            jazyk();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Czech = false;
            English = true;
            Deutsch = false;
            jazyk();
        }

        private void deutschToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Czech = false;
            English = false;
            Deutsch = true;
            jazyk();
        }

        public void jazyk()
        {
            if (Czech == true)
            {
                rozlišeníToolStripMenuItem.Text = "Rozlišení";
                lbNaTahu.Text = "Na tahu je:";
                lbHistorie.Text = "Historie tahů:";
            }

            if (English == true)
            {
                rozlišeníToolStripMenuItem.Text = "Resolution";
                lbNaTahu.Text = "On the turn:";
                lbHistorie.Text = "History of turns:";
            }

            if (Deutsch == true)
            {
                rozlišeníToolStripMenuItem.Text = "Rozlišení";
                lbNaTahu.Text = "Na tahu je:";
                lbHistorie.Text = "Historie tahů:";
            }
        }

        //auto-detect
        private void autoDetectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //4:3
        private void x600ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void x768ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void x864ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void x960ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void x1050ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void x1080ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void x1200ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //5:4
        private void x1024ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //16:9
        private void x720ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void x768ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void x900ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void x1080ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        //16:10
        private void x800ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void x900ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void x1050ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void x1200ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void rozlišeníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    } 
 }

