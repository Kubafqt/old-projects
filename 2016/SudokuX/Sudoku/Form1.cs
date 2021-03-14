using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;


namespace Sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        { InitializeComponent(); }

        #region VARiables
        Form1 form;
        Vstup vstup;

        Random random = new Random();

        int[,] areaXY;
        int[,] areaZ;
        int[,] PotenXY;
        int[,] ShodyXY; //označení shod čísla
        int[,] vstpXY; //hráč / komp / help

        int x = 1;
        int y = 1;
        int z = 1;
        int canna = 1;
        int generat; //generovaný číslo
        bool pripocet = false;

        //Pro PAINT:
        int odsz100 = 100;
        int vel450 = 450;

        //Opravy():
        int Px, Py;
        int Pz, Pcanna;
        int a; //switch

        int odZ;
        int doZ;
        bool run = true;
        bool first = true;

        bool ShodaX = false;
        bool ShodaXjeTU = false;
        int pos = 0;
        int[] SaveX;

        //Obtížnost; mazání čísel:
        int yesno;          //Náhoda: 1 = yes, smazat; 0 = no, nesmazat; 
        int cleared;        //počet smazaných.
        int maxclear;       //limit pro smazání.
        int clear;          //ošetření na hodně smazání po sobě

        //nove:
        bool hledani = false;
        bool firstChange = true;
        int g;                  //uložení generatu
        int saveNum;            //uložení čísla z řady, které lze dosadit na současnou pozici
        int newNum;             //nové číslo na původní posici z řady
        int pocetTahu = 0;
        bool shodator = true;   //označování shod

        //uživatelský vstup:
        string vstp;
        int vstpInt;
        double number;
        bool Win = false; //dokončení sudoku
        int napovedy = 0; //počet použití nápovědy
        int pc = 0; //počítadlo

        //levelmode:
        int maxlevel = 1;
        int level = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            //hlavní:
            areaXY = new int[16, 16];
            areaZ = new int[16, 16];
            PotenXY = new int[16, 16];
            SaveX = new int[16];
            //vstup:
            vstpXY = new int[16, 16]; //označení vstup (1 = PC, 2 = hráč)
            //označení shod:
            ShodyXY = new int[16, 16];
            //custom difficulty:
            for (int i = 0; i <= 81; i++)
            { tbOdecet.Items.Add(i + ""); }
            tbOdecet.SelectedIndex = 0;
            //LevelMode:
            tbLevel.Items.Add(1 + "");
            tbLevel.SelectedIndex = 0;
            //Class & Forms:
            vstup = new Vstup();
            form = new Form1();
        }
        #endregion VARiables

        #region Main
        //generování:
        private void generator()
        {
            if (x != 9 || y != 9)
            {
                generat = random.Next(1, 9);
                hledani = true;

                if (pripocet)
                {
                    x++; Px = x;
                    Py = y;
                    pripocet = false;
                }
                if (x > 9)
                {
                    x = 1; Px = x;
                    y++; Py = y;

                    if (y > 9)
                    { return; }
                }
                z = ((x - 1) / 3) + 1 + 3 * ((y - 1) / 3);
                canna = ((x - 1) % 3) + 1 + ((y - 1) % 3) * 3;

                while (hledani)
                {
                    for (int i = 1; i <= 9; i++) //Hledání shod s generatem
                    {
                        if (areaXY[i, y] == generat || areaXY[x, i] == generat || areaZ[z, i] == generat) //Shoda je na X či Y či Z.
                        {
                            if (firstChange)
                            { g = generat; firstChange = false; }
                            if (generat < 9)
                            { generat++; }
                            else { generat = 1; }

                            if (generat == g) //vrátil se na původní pozici -> Už nic nejde... repairX();
                            { Px = x; hledani = false; a = 1; repairX(); break; }
                            break;
                        }
                        else if (i == 9) //Číslo k lze vložit => posun (x++) a další generator();
                        {
                            areaXY[x, y] = generat;
                            areaZ[z, canna] = generat;
                            PotenXY[x, y] = generat;
                            vstpXY[x, y] = 1;
                            pripocet = true;
                            firstChange = true;

                            hledani = false;
                            nextGen();
                            return;
                        }
                    }
                }
            }
            else
            { Difficulty(); }
        }

        //oprava:
        private void repairX()
        {
            switch (a)
            {
                case 1: //vyhledá číslo z areaXY[Px, y], které jde dosadit na areaXY[x, y].
                    {
                        newNum = 0;

                        if (Px > 1)
                        {
                            Px--; Py = y;
                            Pz = ((Px - 1) / 3) + 1 + 3 * ((y - 1) / 3);
                            Pcanna = ((Px - 1) % 3) + 1 + ((y - 1) % 3) * 3;

                            for (int k = 1; k <= 9; k++) //vyhledá číslo z Px, y, které jde na x, y.
                            {
                                if (areaXY[x, k] == areaXY[Px, y] || areaZ[z, k] == areaXY[Px, y]) //číslo má shodu na Y či Z.
                                { repairX(); break; }
                                else if (k == 9) //číslo z řady jde dosadit na místo x, y -> posun.
                                {
                                    saveNum = areaXY[Px, y];

                                    a = 2;
                                    repairX();
                                    break;
                                }
                            }
                        }
                        else //Px < 1; došel na konec -> Vertikální oprava. (prohození ve čtverci nad y)
                        {
                            a = 3; pos = 0;
                            repairX();
                        }
                        break;
                    }

                case 2: //vyhledá nové číslo, které lze dosadit na areaXY[Px, y].
                    {
                        if (newNum < 9)
                        {
                            newNum++;
                            for (int k = 1; k <= 9; k++)
                            {
                                if (areaXY[k, y] == newNum || areaXY[Px, k] == newNum || areaZ[Pz, k] == newNum) //číslo se shoduje na X, Y či Z.
                                { repairX(); break; }
                                else if (k == 9) //vše v pořádku -> číslo tam lze dosadit.
                                {
                                    areaXY[x, y] = saveNum;
                                    areaZ[z, canna] = saveNum;
                                    areaXY[Px, Py] = newNum;
                                    areaZ[Pz, Pcanna] = newNum;

                                    a = 1;
                                    PotenXY[x, y] = saveNum;
                                    PotenXY[Px, Py] = newNum;
                                    vstpXY[x, y] = 1;
                                    vstpXY[Px, Py] = 1;
                                    
                                    nextGen();
                                    break;
                                }
                            }
                        }
                        else
                        { a = 1; newNum = 0; repairX(); break; } //Nic nejde dosadit.
                        break;
                    }

                case 3: //vyhledání čísla, které nejde pouze na Y.
                    {
                        if (newNum < 9)
                        {
                            newNum++;
                            ShodaX = false;
                            Py = 0;
                            for (int k = 1; k <= 9; k++)
                            {
                                if (areaZ[z, k] == newNum) //newNum má shodu v Z.
                                { repairX(); break; }
                                else if (areaXY[x, k] == newNum) //newNum má shodu v Y. (správně, uložení Py)
                                { Py = k; }
                                if (areaXY[k, y] == newNum) //newNum má shodu v X.
                                { ShodaX = true; pos = k; }

                                if (k == 9 && ShodaX == true) //uložení čísla newNum, která má shodu pouze na X a Y.
                                { SaveX[pos] = newNum; ShodaXjeTU = true; repairX(); }
                                else if (k == 9 && Py > 0)
                                { a = 4; repairX(); }
                            }
                        }
                        else if (ShodaXjeTU)
                        { ShodaXjeTU = false; a = 5; repairX(); }
                        else
                        { timer.Enabled = true; }
                        break;
                    }

                case 4: //zkouška prohození čísel ve shodě Y s newNum.
                    {
                        if (first) //vložení základních hodnot
                        {
                            int odZx = (Px + 2) / 3;                //zjištění počtu čtverce v řadě.
                            odZ = odZx * odZx - ((odZx / 3) * 2);   //první pozice v čtverci.
                            doZ = odZ + 2;                          //poslední pozïce ve čtverci.
                            Px = odZ;
                            first = false;
                        }
                        else { Px++; } //přípočet

                        if (Px <= doZ) //hlavní část
                        {
                            for (int k = 1; k <= 9; k++) //test jestli čísla ve čtverci jdou prohodit.
                            {
                                if (areaXY[Px, Py] == areaXY[x, k] || areaXY[x, Py] == areaXY[Px, k])
                                { repairX(); break; } //Jedno z čísel se shoduje na Y.
                                else if (k == 9) //Shoda v Y není -> můžou se prohodit.
                                {
                                    areaXY[Px, Py] = areaXY[x, Py]; //areaXY[Px, Py], tam se hodí číslo ze shody na Y.
                                    Pz = ((Px - 1) / 3) + 1 + 3 * ((Py - 1) / 3);
                                    Pcanna = ((Px - 1) % 3) + 1 + ((Py - 1) % 3) * 3;
                                    areaZ[Pz, Pcanna] = areaXY[Px, Py];

                                    areaXY[x, Py] = PotenXY[Px, Py]; //Pozice shody Y, tam se hodí číslo z areaXY[x, Py].
                                    Pcanna = ((x - 1) % 3) + 1 + ((Py - 1) % 3) * 3;
                                    areaZ[Pz, Pcanna] = areaXY[x, Py];

                                    areaXY[x, y] = newNum; //Současná pozice x, y (nové číslo).
                                    areaZ[z, canna] = areaXY[x, y];

                                    PotenXY[Px, Py] = areaXY[Px, Py]; //potenciální pole
                                    PotenXY[x, Py] = areaXY[x, Py];
                                    PotenXY[x, y] = areaXY[x, y];
                                    vstpXY[Px, Py] = 1;
                                    vstpXY[x, Py] = 1;
                                    vstpXY[x, y] = 1;

                                    a = 1;
                                    nextGen();
                                }
                            }
                        }
                        else  //nic nejde prohodit -> test dalšího nového čísla.
                        { pos = 0; a = 3; repairX(); }

                        break;
                    }

                case 5: //zkouška čísla z řady, na prohození v Y.
                    {
                        if (pos < 9)
                        {
                            pos++;
                            if (SaveX[pos] == 0)
                            { repairX(); }
                            else
                             {
                                for (int i = 1; i <= 9; i++) //Nalezení shody ve sloupečku (Py).
                                {
                                    if (areaXY[x, i] == SaveX[pos])
                                    { Py = i; break; }         
                                }

                                for (int k = 1; k <= 9; k++) //prohození čísel
                                {
                                    if (areaXY[Px, Py] == areaXY[x, k] || areaXY[x, Py] == areaXY[Px, k])
                                    { repairX(); break; } //Jedno z čísel se shoduje na Y.
                                    else if (k == 9) //Shoda v Y není, můžou se prohodit.
                                    { a = 6; repairX(); }
                                }
                            }
                        }
                        else
                        { timer.Enabled = true; }

                        break;
                    }

                case 6: //vyhledání nového čísla, které půjde na vyjmutou pozici z řady.
                    {
                        for (int k = 1; k <= 9 && run; k++) //nové číslo, které půjde na Px, y.
                        {
                            for (int i = 1; i <= 9; i++) //test jestli tam fakt jde
                            {
                                Pz = ((pos - 1) / 3) + 1 + 3 * ((y - 1) / 3);
                                if (areaXY[pos, i] == k || areaXY[i, y] == k || areaZ[Pz, i] == k) // Na X, Y či Z je shoda s novým číslem k.
                                { if (k == 9) { a = 5; repairX(); } break; }
                                else if (i == 9) //shoda není nikde, jde to použít.
                                {
                                    areaXY[pos, y] = k;                 // nové číslo do řady (areaXY[pos, y]).
                                    Pcanna = ((pos - 1) % 3) + 1 + ((y - 1) % 3) * 3;
                                    areaZ[Pz, Pcanna] = k;

                                    areaXY[Px, Py] = areaXY[x, Py];     // 1. pozice ve čtverci nad Y, kde se vymění.
                                    Pz = ((Px - 1) / 3) + 1 + 3 * ((Py - 1) / 3);
                                    Pcanna = ((Px - 1) % 3) + 1 + ((Py - 1) % 3) * 3;
                                    areaZ[Pz, Pcanna] = areaXY[Px, Py];

                                    areaXY[x, Py] = PotenXY[Px, Py];    // 2. pozice ve čtverci nad Y, kde bylo třeba vyměnit.
                                    Pcanna = ((x - 1) % 3) + 1 + ((Py - 1) % 3) * 3;
                                    areaZ[Pz, Pcanna] = areaXY[x, Py];

                                    areaXY[x, y] = SaveX[pos];          // současná pozice x, y (nové číslo)
                                    areaZ[z, canna] = areaXY[x, y];

                                    PotenXY[pos, y] = k;                //potenciální pole
                                    PotenXY[Px, Py] = areaXY[Px, Py];
                                    PotenXY[x, Py] = areaXY[x, Py];
                                    PotenXY[x, y] = areaXY[x, y];
                                    vstpXY[pos, y] = 1;                 //vstupní pole
                                    vstpXY[Px, Py] = 1;
                                    vstpXY[x, Py] = 1;
                                    vstpXY[x, y] = 1;

                                    run = false;
                                    a = 1;
                                    nextGen();
                                    break;
                                }
                            }
                        }
                        break;
                    }
            }
        }

        //Poslaní dalšího generatoru();
        private void nextGen()
        {
            if (y < 9 || x < 9)
            {
                g = 0; //reset uložení generátu
                firstChange = true;
                pripocet = true;

                first = true;
                for (int i = 1; i <= 10; i++)
                { SaveX[i] = 0; }

                generator();
            }
            else
            { Difficulty(); }
        }
        

        // výběr obtížnosti (promazávání pole):
        private void Difficulty()
        {
            if (rbEasy.Checked == true)
            { maxclear = random.Next(23, 33); label.Text = rbEasy.Text + " (" + maxclear + ")"; }
            else if (rbMedium.Checked == true)
            { maxclear = random.Next(35, 45); label.Text = rbMedium.Text + " (" + maxclear + ")"; }
            else if (rbHard.Checked == true)
            { maxclear = random.Next(48, 59); label.Text = rbHard.Text + " (" + maxclear + ")"; }
            else if (rbUser.Checked == true)
            { maxclear = Convert.ToInt32(tbOdecet.Text); label.Text = rbUser.Text + ": " + Convert.ToInt32(tbOdecet.Text); }
            else if (rbLevelmode.Checked == true)
            { maxclear = Convert.ToInt32(tbLevel.Text); label.Text = "LevelMode: " + maxclear; }

            int a = 1; //x
            int b = 1; //y

            if (maxclear == 0)
            { Refresh(); }

            while (cleared < maxclear) //Smazání random čísel do limitu podle obtížnosti.
            {
                a++;

                if (b > 9)
                { a = 0; b = 1; }
                else if (a > 9)
                { a = 0; b++; }
                else if (clear == (maxclear + 6) / 7)
                { clear = 0; } //ošetření na smazání hodně políček po sobě.
                else
                {
                    yesno = random.Next(0, 2); //náhoda (0, 1)
                    if (yesno == 1)
                    {
                        if (areaXY[a, b] > 0) //jestli se už nemazalo
                        {
                            areaXY[a, b] = 0;
                            vstpXY[a, b] = 0;
                            clear++; //ošetření na smazání spoustu po sobě.
                            cleared++; //počet smazaných
                            if (cleared == maxclear)
                            { Refresh(); }
                        }
                    }
                }
            }
        }
        // výběr obtížnosti \\
        #endregion Main

        #region Vstup
        //MouseClick:
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.X > 100 && e.X < 550 && e.Y > 100 && e.Y < 550)
            {
                vstup.mysX = (e.X - odsz100) / 50 + 1;
                vstup.mysY = (e.Y - odsz100) / 50 + 1;
                vstup.mysZ = ((vstup.mysX - 1) / 3) + 1 + 3 * ((vstup.mysY - 1) / 3);
                vstup.mysCanna = ((vstup.mysX - 1) % 3) + 1 + ((vstup.mysY - 1) % 3) * 3;

                vstup.select = true;
                Refresh();
            }
            else
            {
                vstup.select = false;
                Refresh();
            }

            //odkliknutí čísla při kliku:
            if (vstpXY[vstup.mysX, vstup.mysY] == 2 && e.Button == MouseButtons.Right)
            {
                areaXY[vstup.mysX, vstup.mysY] = 0;
                areaZ[vstup.mysZ, vstup.mysCanna] = 0;

                Refresh();
            }
        }
        //**MouseClick\\

        //KeyDown:
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            vstp = Regex.Match(keyData.ToString(), @"\d+").Value; //keyData je tam to nejdůležitější (/vstup\)
            //vložení čísla:
            if (vstup.select == true && double.TryParse(vstp, out number) && Convert.ToInt32(vstp) != 0 && vstpXY[vstup.mysX, vstup.mysY] != 1)
            { //hráč zadá větší jak 0, na pozici kde PC nezadalo číslo
                pocetTahu++;
                vstpInt = Convert.ToInt32(vstp);
                areaXY[vstup.mysX, vstup.mysY] = vstpInt;
                areaZ[vstup.mysZ, vstup.mysCanna] = vstpInt;
                vstpXY[vstup.mysX, vstup.mysY] = 2; //je to číslo zadané hráčem


                //Ukazování shody u posledního vloženého čísla:
                if (shodator)
                {   //aktual shoda:
                    for (int l = 1; l <= 9; l++)
                    {
                        if (areaXY[vstup.mysX, vstup.mysY] == areaXY[vstup.mysX, l] && l != vstup.mysY)
                        { ShodyXY[vstup.mysX, vstup.mysY] = 1; break; }
                        else if (areaXY[vstup.mysX, vstup.mysY] == areaXY[l, y] && l != vstup.mysX)
                        { ShodyXY[vstup.mysX, vstup.mysY] = 1; break; }
                        else if (areaXY[vstup.mysX, vstup.mysY] == areaZ[vstup.mysZ, l] && l != vstup.mysCanna)
                        { ShodyXY[vstup.mysX, vstup.mysY] = 1; break; }
                    }

                    Refresh();
                }

                //ověření konce hry:
                if (!Win)
                {
                    for (int k = 1; k <= 81; k++)
                    {
                        int x = (k - 1) % 9 + 1;
                        int y = (k + 8) / 9;
                        if (ShodyXY[x, y] > 0 || areaXY[x, y] < 1) // někde je shoda nebo nějaký políčko chybí
                        { break; }
                        else if (k == 81) //Je konec výhry
                        {
                            Win = true;
                            Refresh();

                            //Rozhrání pro levelmode a jazyky:
                            if (btnLang1.BackColor == Color.DarkOrange) //čeština
                            {
                                if (rbLevelmode.Checked) //Je LevelMode.
                                {
                                    if (level == maxlevel) //posun do dalšího levelu
                                    { maxlevel++; tbLevel.Items.Add(maxlevel);  }
                                    level++; tbLevel.SelectedIndex = level - 1;
                                    lbLevelMode.Text = "LevelMode: " + (100 / 81) * maxlevel + "%";

                                    switch (MessageBox.Show(this, "Level dokončen! Spustit další level: " + level + "?", "Level Up!", MessageBoxButtons.YesNo))
                                    {
                                        case DialogResult.No: lbNextLevel.Visible = true; break;
                                        default: NewGame(); break;
                                    }
                                }
                                else //když není levelmode
                                { MessageBox.Show("Dořešil jsi tohle sudoku zadání. Gratuluji!"); }
                            }
                            else if (btnLang2.BackColor == Color.DarkOrange) //angličtina
                            {
                                if (rbLevelmode.Checked) //pokud je levelmode
                                {
                                    if (level == maxlevel) 
                                    { maxlevel++; tbLevel.Items.Add(maxlevel); }
                                    level++; tbLevel.SelectedIndex = level - 1;
                                    lbLevelMode.Text = "LevelMode: " + (100 / 81) * maxlevel + "%";

                                    switch (MessageBox.Show(this, "Level complete! Run level: " + level + "?", "Level Up!", MessageBoxButtons.YesNo))
                                    {
                                        case DialogResult.No: lbNextLevel.Visible = true; break;
                                        default: NewGame(); break;
                                    }
                                }
                                else //když není levelmode
                                { MessageBox.Show("You have complete this Sudoku. Congratulations!"); }
                            }
                            else if (btnLang3.BackColor == Color.DarkOrange) //němčina
                            {
                                if (rbLevelmode.Checked) //pokud je levelmode
                                {
                                    if (level == maxlevel) 
                                    { maxlevel++; tbLevel.Items.Add(maxlevel); }
                                    level++; tbLevel.SelectedIndex = level - 1;
                                    double levelmodPercent = 100 / 81 * maxlevel;
                                    lbLevelMode.Text = "LevelMode: " + levelmodPercent + "%";

                                    switch (MessageBox.Show(this, "Level gemacht! Starten Sie ein anderes level: " + level + "?", "Level Up!", MessageBoxButtons.YesNo))
                                    {
                                        case DialogResult.No: lbNextLevel.Visible = true; break;
                                        default: NewGame(); break;
                                    }
                                }
                                else //když není levelmode
                                { MessageBox.Show("Sie lösen dieses Sudoku gut. Glückwünsche!"); }
                            }
                        }
                    }
                }
            }
            else if (vstup.select == true && double.TryParse(vstp, out number) && Convert.ToInt32(vstp) == 0 && vstpXY[vstup.mysX, vstup.mysY] != 1) //hráč zadá 0.
            {
                pocetTahu++;
                areaXY[vstup.mysX, vstup.mysY] = 0;
                areaZ[vstup.mysZ, vstup.mysCanna] = 0;
                //číslo je zadané hráčem:
                vstpXY[vstup.mysX, vstup.mysY] = 2; 
            }

            //šipky:
            switch (keyData)
            {
                case Keys.Up:
                    if (vstup.mysY > 1)
                    {
                        vstup.mysY--;
                        vstup.mysZ = ((vstup.mysX - 1) / 3) + 1 + 3 * ((vstup.mysY - 1) / 3);
                        vstup.mysCanna = ((vstup.mysX - 1) % 3) + 1 + ((vstup.mysY - 1) % 3) * 3;
                        Refresh();
                    }
                    break;
                case Keys.Down:
                    if (vstup.mysY < 9)
                    {
                        vstup.mysY++;
                        vstup.mysZ = ((vstup.mysX - 1) / 3) + 1 + 3 * ((vstup.mysY - 1) / 3);
                        vstup.mysCanna = ((vstup.mysX - 1) % 3) + 1 + ((vstup.mysY - 1) % 3) * 3;
                    }
                    break;
                case Keys.Left:
                    if (vstup.mysX > 1)
                    {
                        vstup.mysX--;
                        vstup.mysZ = ((vstup.mysX - 1) / 3) + 1 + 3 * ((vstup.mysY - 1) / 3);
                        vstup.mysCanna = ((vstup.mysX - 1) % 3) + 1 + ((vstup.mysY - 1) % 3) * 3;
                    }
                    break;
                case Keys.Right:
                    if (vstup.mysX < 9)
                    {
                        vstup.mysX++;
                        vstup.mysZ = ((vstup.mysX - 1) / 3) + 1 + 3 * ((vstup.mysY - 1) / 3);
                        vstup.mysCanna = ((vstup.mysX - 1) % 3) + 1 + ((vstup.mysY - 1) % 3) * 3;
                    }
                    break;
            }
            Refresh();
            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }
        //**KeyDown\\
        #endregion Vstup

        #region PAINT
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;

            FontFamily fontFamily = new FontFamily("Microsoft Sans Serif");
            Font font = new Font(fontFamily, 14, FontStyle.Bold);
            Pen Selector = new Pen(Color.Red, 5);
            Pen ShodaSelector = new Pen(Color.DarkRed, 5);

            Pen obrys = new Pen(Color.Black, 3);
            Pen ctverec = new Pen(Color.Black, 2);
            gfx.DrawRectangle(obrys, odsz100, odsz100, 450, 450);
            if (Win)
            { Pen okolo = new Pen(Color.DarkOrange, 4); gfx.DrawRectangle(okolo, 99, 99, 452, 452); }
            //čtverečkování:
            for (var k = 1; k <= 8; k++)
            {
                gfx.DrawLine(Pens.Black, odsz100, odsz100 + (k * 50), odsz100 + vel450, odsz100 + (k * 50)); //horizontal lines
                gfx.DrawLine(Pens.Black, odsz100 + (k * 50), odsz100, odsz100 + (k * 50), odsz100 + vel450); //vertical lines
            }
            //Z-čtverce:
            for (var k = 1; k <= 2; k++)
            {
                gfx.DrawLine(ctverec, odsz100, odsz100 + k * 150, odsz100 + vel450, odsz100 + k * 150); //horizontal lines
                gfx.DrawLine(ctverec, odsz100 + k * 150, odsz100, odsz100 + k * 150, odsz100 + vel450); //vertical lines
            }

            //reset označení shod:
            for (int x = 1; x <= 9; x++)
            {
                for (int y = 1; y <= 9; y++)
                { ShodyXY[x, y] = 0; }
            }
            //vyhledání shod:
            for (int k = 1; k <= 81; k++)
            {
                int x = (k - 1) % 9 + 1;
                int y = (k + 8) / 9;
                int z = ((x - 1) / 3) + 1 + 3 * ((y - 1) / 3);
                int canna = ((x - 1) % 3) + 1 + ((y - 1) % 3) * 3;

                for (int i = 1; i <= 9; i++)
                {
                    if (areaXY[x, y] == areaXY[x, i] && i != y)
                    { ShodyXY[x, y] = 1; ShodyXY[x, i] = 1; }
                    if (areaXY[x, y] == areaXY[i, y] && i != x)
                    { ShodyXY[x, y] = 1; ShodyXY[i, y] = 1; }
                    if (areaXY[x, y] == areaZ[z, i] && i != canna)
                    {
                        ShodyXY[x, y] = 1;
                        int ex = ((z - 1) % 3) * 3 + (i - 1) % 3 + 1; //převod na x
                        int ey = ((z - 1) / 3) * 3 + (i - 1) / 3 + 1; //převod na y
                        ShodyXY[ex, ey] = 1;
                    }
                }
            }

            //Číslice & Označení shod:
            for (int x = 1; x <= 9; x++)
            {
                for (int y = 1; y <= 9; y++)
                {
                    if (areaXY[x, y] > 0) //pokud není prázdná
                    {
                        if (shodator)
                        {
                            if (ShodyXY[x, y] == 1) //Označení shod.
                            {
                                if (vstpXY[x, y] == 1)
                                { gfx.DrawRectangle(ShodaSelector, 50 + x * 50, 50 + y * 50, 50, 50); }
                                else
                                { gfx.DrawRectangle(Selector, 50 + x * 50, 50 + y * 50, 50, 50); }
                            }
                        }

                        if (vstpXY[x, y] == 3) //Vstup nápovědy (helpu)
                        { gfx.DrawString("" + areaXY[x, y], font, Brushes.YellowGreen, 50 + 15 + x * 50, 50 + 15 + y * 50); }
                        else if (vstpXY[x, y] == 2) //Vstup hráče
                        { gfx.DrawString("" + areaXY[x, y], font, Brushes.Aqua, 50 + 15 + x * 50, 50 + 15 + y * 50); }
                        else if (vstpXY[x, y] == 1)//Vstup počítače
                        { gfx.DrawString("" + areaXY[x, y], font, Brushes.White, 50 + 15 + x * 50, 50 + 15 + y * 50); }
                    }
                }
            }

            //Vstup:
            Pen selector = new Pen(Color.DarkSlateGray, 5);
            //Pen selector = new Pen(Color.DarkSlateBlue, 5);
            if (vstup.select == true)
            { gfx.DrawRectangle(selector, 50 + vstup.mysX * 50, 50 + vstup.mysY * 50, 50, 50); }
        }
        #endregion PAINT       

        #region Buttony
        //Vygenerování Sudoku:
        private void btnGen_Click(object sender, EventArgs e)
        {
            if (pocetTahu < 5)
            { NewGame(); }
            else
            {
                switch (MessageBox.Show(this, "Opravdu začít novou hru?", "Nová hra", MessageBoxButtons.YesNo))
                {
                    case DialogResult.No: break;
                    default: NewGame(); break;
                }
            }
            pc = 0;
        }

        private void NewGame()
        {
            x = 1; y = 1;
            z = 1; canna = 1;
            Px = x; Py = y;
            pocetTahu = 0;
            napovedy = 0;
            lbNapoveda.Visible = false;
            cleared = 0;
            level = Convert.ToInt32(tbLevel.Text);

            for (var a = 1; a <= 9; a++)
            {
                for (var b = 1; b <= 9; b++)
                {
                    areaXY[a, b] = 0;
                    PotenXY[a, b] = 0;
                    areaZ[a, b] = 0;
                    vstpXY[a, b] = 0;
                    ShodyXY[a, b] = 0;
                }
            }

            if (rbLevelmode.Checked)
            { bgImage(); }

            Win = false;
            first = true;
            pripocet = false;
            generator();
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            pc++;
            lbTimer.Text = "Počet opakování cyklu: " + pc;
            //lbTimer.Visible = true; 

            timer.Enabled = false;
            NewGame();
        }

        //Ukazatel nápovědy:
        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (vstup.select)
            {
                run = true;
                for (int k = 1; k <= 9 && run; k++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        if (vstpXY[vstup.mysX, vstup.mysY] == 1)
                        { run = false; break; }
                        else if (areaXY[vstup.mysX, j] == k && j != vstup.mysY)
                        { break; }
                        else if (areaXY[j, vstup.mysY] == k && j != vstup.mysX)
                        { break; }
                        else if (areaZ[vstup.mysZ, j] == k && j != vstup.mysCanna)
                        { break; }
                        else if (j == 9)
                        {
                            areaXY[vstup.mysX, vstup.mysY] = k;
                            areaZ[vstup.mysZ, vstup.mysCanna] = k;
                            vstpXY[vstup.mysX, vstup.mysY] = 3;
                            napovedy++;
                            lbNapoveda.Visible = true;
                            lbNapoveda.Text = "Počet nápověd: " + napovedy;
                            run = false; Refresh();
                        }
                    }
                }
            }
        }

        //Libovolná obtížnost:
        private void rbUser_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUser.Checked)
            { lbOdecet.Visible = true; tbOdecet.Visible = true; }
            else
            { lbOdecet.Visible = false; tbOdecet.Visible = false; }
        }

        //LevelMode:
        private void rbLevelmode_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLevelmode.Checked)
            { 
                lbLevel.Visible = true;
                lbLevel23.Visible = true;
                lbLevelMode.Visible = true;
                lbLevelMode.Text = "Levelmode: " + (100 / 81) * maxlevel + "%";
                tbLevel.Visible = true;
                btnSave.Visible = true;
                btnLoad.Visible = true;

                Refresh();
            }
            else
            { 
                tbLevel.Visible = false;
                lbLevelMode.Visible = false;
                lbLevel.Visible = false;
                lbLevel23.Visible = false;
                btnSave.Visible = false;
                btnLoad.Visible = false;

                Refresh();
            }
        }
        //změna background podle levelu:
        private void bgImage()
        {
            switch ((level + 7) / 8)
            {
                case 1:
                    {
                        this.BackgroundImage = base.BackgroundImage;
                        this.BackColor = System.Drawing.Color.FromArgb(23, 123, 23);
                        break;
                    }
                case 2:
                    {
                        this.BackgroundImage = base.BackgroundImage;
                        this.BackColor = System.Drawing.Color.FromArgb(123, 123, 23);
                        break;
                    }
                case 3:
                    {
                        this.BackgroundImage = base.BackgroundImage;
                        this.BackColor = System.Drawing.Color.FromArgb(123, 23, 123);
                        break;
                    }
            }
        }
        
        //Save level:
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            sfd.RestoreDirectory = true;
            sfd.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath)  + @"\savegame";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName)) 
                { sw.Write(maxlevel + "; " + level); }
            }
        }
        //Load level:
        private void btnLoad_Click(object sender, EventArgs e)
        {
            tbLevel.Items.Clear();

            string radek;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File|*.txt";
            ofd.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\savegame";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader SR = new StreamReader(ofd.FileName);
                while ((radek = SR.ReadLine()) != null)
                {
                    string[] hodnota = radek.Split(';');
                    maxlevel = Convert.ToInt32(hodnota[0].Trim());
                    level = Convert.ToInt32(hodnota[1].Trim());
                    for (int k = 1; k <= maxlevel; k++)
                    { tbLevel.Items.Add("" + k); }
                    tbLevel.SelectedIndex = level - 1;

                    NewGame();
                }
            }
        }
        //Další level label:
        private void lbNextLevel_Click(object sender, EventArgs e)
        { NewGame(); lbNextLevel.Visible = false; }
        private void lbNextLevel_MouseHover(object sender, EventArgs e)
        { Cursor.Current = Cursors.Hand; }

        //Vypnutí ukazování shod:
        private void cbShowMatch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowMatch.Checked)
            { shodator = true; }
            else
            { shodator = false; }
            Refresh();
        }

        //Konec programu:
        private void btnExit_Click(object sender, EventArgs e)
        { this.Close(); }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            {
                switch (MessageBox.Show(this, "Opravdu chcete ukončit hru?", "Vypnutí programu", MessageBoxButtons.YesNo))
                {
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }
        }

        #region LANGuages
        //Čeština:
        private void btnLang1_Click(object sender, EventArgs e)
        {
            btnLang1.BackColor = Color.DarkOrange;
            btnLang2.BackColor = Color.CadetBlue;
            btnLang3.BackColor = Color.CadetBlue;

            cbShowMatch.Text = "Ukazuj shody";

            btnGen.Text = "Nová hra";
            btnHelp.Text = "poraď mi!";
            btnExit.Text = "konec";

            rbEasy.Text = "Lehká";
            rbMedium.Text = "Střední";
            rbHard.Text = "Těžká";
            rbUser.Text = "Libovolně";
        }

        //English:
        private void btnLang2_Click(object sender, EventArgs e)
        {
            btnLang2.BackColor = Color.DarkOrange;
            btnLang3.BackColor = Color.CadetBlue;
            btnLang1.BackColor = Color.CadetBlue;

            cbShowMatch.Text = "Show matches";

            btnGen.Text = "New game";
            btnHelp.Text = "help me!";
            btnExit.Text = "exit";

            rbEasy.Text = "Easy";
            rbMedium.Text = "Medium";
            rbHard.Text = "Hard";
            rbUser.Text = "Custom";
        }

        //Deutsch:
        private void btnLang3_Click(object sender, EventArgs e)
        {
            btnLang3.BackColor = Color.DarkOrange;
            btnLang2.BackColor = Color.CadetBlue;
            btnLang1.BackColor = Color.CadetBlue;

            cbShowMatch.Text = "Zeigen Beachtung an";

            btnGen.Text = "Neues Spiel";
            btnHelp.Text = "hilf mir!";
            btnExit.Text = "ende";

            rbEasy.Text = "Leicht";
            rbMedium.Text = "Mittel";
            rbHard.Text = "Hart";
            rbUser.Text = "Beliebig";
        }
        #endregion LANGs
        private void lbTimer_Click(object sender, EventArgs e)
        { lbTimer.Visible = false; }
        #endregion Buttony

    }
}