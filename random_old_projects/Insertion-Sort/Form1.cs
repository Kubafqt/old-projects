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
using System.Text.RegularExpressions;

namespace Insertion_Sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int pozice;
        public static int[] pole;
        public static int[] sorted;
        oop_sort[] numbers = new oop_sort[] { };

        Label vypispole;
        Label lbfPole;
        Label lbfSorted;
        RichTextBox rtbPole;
        public static RichTextBox rtbSorted;
        ListBox lboxPole;
        public static ListBox lboxSorted;
        public static bool cbQuick;

        private void Form1_Load(object sender, EventArgs e)
        {
            pozice = 0;
            pole = new int[50000];
            sorted = new int[50000];
            numbers = new oop_sort[50000];
            //základní controls:
            vypispole = new Label();
            vypispole.Font = new Font("Arial", 11, FontStyle.Bold);
            vypispole.Size = new Size(370, 16);
            rtbPole = new RichTextBox();
            rtbPole.Font = new Font("Arial", 10);
            rtbPole.Size = new Size(340, 420);
            rtbSorted = new RichTextBox();
            rtbSorted.Font = new Font("Arial", 10);
            rtbSorted.Size = new Size(342, 423);
            lboxPole = new ListBox();
            lboxPole.Font = new Font("Arial", 10);
            lboxPole.Size = new Size(340, 420);
            lboxSorted = new ListBox();
            lboxSorted.Font = new Font("Arial", 10);
            lboxSorted.Size = new Size(340, 420);
            vypispole.Location = new Point(lbInfo.Left + 3, lbInfo.Bottom + 15);
            rtbPole.Location = new Point(vypispole.Left + 20, vypispole.Bottom + 50);
            rtbSorted.Location = new Point(rtbPole.Left + rtbPole.Width + 42, rtbPole.Top);
            lboxPole.Location = new Point(rtbPole.Location.X, rtbPole.Location.Y);
            lboxSorted.Location = new Point(rtbPole.Left + rtbPole.Width + 42, rtbPole.Top);
            this.Controls.Add(vypispole);
            this.Controls.Add(rtbPole);
            this.Controls.Add(rtbSorted);
            this.Controls.Add(lboxPole);
            this.Controls.Add(lboxSorted);
            lboxSorted.Visible = false;
            lbfPole = new Label();
            lbfSorted = new Label();
            lbfPole.Location = new Point(rtbPole.Left + 5, rtbPole.Top - 20);
            lbfSorted.Location = new Point(rtbSorted.Left + 5, rtbSorted.Top - 20);
            lbfPole.Text = "Unsorted:";
            lbfSorted.Text = "Sorted:";
            lbfPole.Font = new Font("Arial", 11, FontStyle.Bold);
            lbfSorted.Font = new Font("Arial", 11, FontStyle.Bold);
            this.Controls.Add(lbfPole);
            this.Controls.Add(lbfSorted);
            //set random controls:
            btnSetRandom.Size = new Size(75, 23);
            btnSetRandom.Location = new Point(this.Width - btnSetRandom.Width - 150, this.Height - btnSetRandom.Height - 37);
            btnSetRandom.Text = "Potvrdit";
            this.Controls.Add(btnSetRandom);
            btnSetRandom.Visible = false;
            tbrandMax.Location = new Point(btnSetRandom.Location.X - tbrandMax.Width - 18, btnSetRandom.Location.Y + 1);
            tbrandMin.Location = new Point(tbrandMax.Location.X - tbrandMin.Width - 14, btnSetRandom.Location.Y + 1);
            tbrandNum.Location = new Point(tbrandMin.Location.X - tbrandNum.Width - 14, btnSetRandom.Location.Y + 1);
            lbSetRandom.Font = new Font("Arial", 10, FontStyle.Bold);
            lbSetRandom.Location = new Point(tbrandNum.Location.X - lbSetRandom.Width + 4, btnSetRandom.Location.Y + 2);
            lbSetRandom.Text = "Set random: ";
            this.Controls.Add(tbrandMax);
            this.Controls.Add(tbrandMin);
            this.Controls.Add(tbrandNum);
            this.Controls.Add(lbSetRandom);
            tbrandMax.Visible = false;
            tbrandMin.Visible = false;
            tbrandNum.Visible = false;
            lbSetRandom.Visible = false;
            //nahraj hodnoty rtbPole button:
            btnUkazPole.Size = new Size(75, 25);
            btnUkazPole.Location = new Point(rtbPole.Left + 5, rtbPole.Bottom + 15);
            btnUkazPole.Text = "hodnoty";
            this.Controls.Add(btnUkazPole);
            btnUkazPole.Click += new EventHandler(ukazPole);
            btnUkazPole.Visible = false;
        }

        // Sortování:
        private void btSort_Click(object sender, EventArgs e)  //insertion_sort
        {
            rtbSorted.Clear();
            lboxSorted.Items.Clear();
            for (int x = 0; x < pozice; x++)
                sorted[x] = pole[x];
            insertion.maximum = pozice;
            insertion.sort(1);
        }

        private void btRadix_Click(object sender, EventArgs e)  //radix_sort(lsd)
        {
            rtbSorted.Clear();
            lboxSorted.Items.Clear();
            for (int x = 0; x < pozice; x++)
                sorted[x] = pole[x];
            radix.lsd(sorted, pozice);
            if (!cbQuick)
            { Thread th = new Thread(vypis); th.Start(); }
            else vypis();
        }

        private void btTest_Click(object sender, EventArgs e)  //OOP_sort 
        {
            numbers = new oop_sort[]
            {
                new oop_sort() { number = 65 },
                new oop_sort() { number = 42 },
                new oop_sort() { number = 23 },
                new oop_sort() { number = 11 },
                new oop_sort() { number = 42 },
                new oop_sort() { number = 78 },
                new oop_sort() { number = 64 },
                new oop_sort() { number = 32 },
            };

            // Z nějakého důvodu nefunguje Array.Sort(numbers) na tuto použitelnou metodu! : - (
            //numbers[0] = new oop_sort { number = 65 };
            //numbers[1] = new oop_sort { number = 42 };
            //numbers[2] = new oop_sort { number = 23 };
            //numbers[3] = new oop_sort { number = 11 };
            //numbers[4] = new oop_sort { number = 42 };
            //numbers[5] = new oop_sort { number = 78 };
            //numbers[6] = new oop_sort { number = 64 };
            //numbers[7] = new oop_sort { number = 32 };

            Array.Sort(numbers);

            string text = "";
            for (int x = 0; x < 8; x++)
                text += numbers[x].number + " ; ";
            MessageBox.Show(text);

            rtbSorted.Clear();
            lboxSorted.Items.Clear();

            ///rtbSorted.Visible = false;
            ///lboxSorted.Visible = true;
            ///lboxSorted.Items.AddRange(numbers);
        }

        private void vypis()
        {
            if (cbQuickBox.Checked)
            {
                for (int i = 0; i < pozice; i++)
                    lboxSorted.Items.Add(sorted[i] + ";");
            }
            else
            {
                string omq = "";
                for (int i = 0; i < pozice; i++)
                    omq += sorted[i].ToString() + " ; ";
                rtbSorted.BeginInvoke((MethodInvoker)delegate ()
                {
                    rtbSorted.Text = omq;
                });
            }
        }

        // Vstup do pole:
        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string[] splitnum = tbVstup.Text.Split(';', ',');
                int test = 0;
                int pocet_trim = 1;
                Regex regex = new Regex(@"^\d+$");
                for (int i = 0; i < tbVstup.Text.Length; i++)  // nalezení středníků a čísel
                {
                    if (tbVstup.Text.Substring(i, 1) == ";" || tbVstup.Text.Substring(i, 1) == ",")
                    { pocet_trim++; }
                }
                for (int i = 0; i < pocet_trim; i++)  // výpis čísel
                {
                    string bezmezery = Regex.Replace(splitnum[i].Trim(), " ", "");
                    if (regex.IsMatch(bezmezery))
                    {
                        int cislo = Convert.ToInt32(bezmezery);
                        pole[pozice] = cislo;
                        vypispole.Text += cislo + "; ";
                        rtbPole.Text += cislo + " ; ";
                        lboxPole.Items.Add(cislo + ";");
                        pozice++;
                    }
                }
                tbVstup.Clear();
                //numbers[pozice] = new oop_sort { number = cislo };
                //numbers = new oop_sort[] { new oop_sort() { number = cislo } };
                //MessageBox.Show(numbers[0].number + "");
            }
            catch
            { MessageBox.Show("V poli můžou být pouze čísla!"); }
        }


        //random pole:
        private void btRandPole_Click(object sender, EventArgs e)
        {
            Reset();
            if (cbQuick)
                rndpoleText("a");
            else
            {
                string omq = "";
                Thread th = new Thread(() => rndpoleText(omq)); //parametrized thread
                th.Start();
            }

            if (firstRand)
            {
                //controls pro set random:
                lbSetRandom.Visible = true;
                btnSetRandom.Visible = true;
                btnSetRandom.Click += new EventHandler(btn_setRandom);
                tbrandMax.Visible = true;
                tbrandMin.Visible = true;
                tbrandNum.Visible = true;
                tbrandMax.Text = randMax.ToString();
                tbrandMin.Text = randMin.ToString();
                tbrandNum.Text = randNum.ToString();
                tbrandMax.GotFocus += new EventHandler(tbRandMax_GotFocus);
                tbrandMax.LostFocus += new EventHandler(tbRandMax_LostFocus);
                tbrandMin.GotFocus += new EventHandler(tbRandMin_GotFocus);
                tbrandMin.LostFocus += new EventHandler(tbRandMin_LostFocus);
                tbrandNum.GotFocus += new EventHandler(tbRandNum_GotFocus);
                tbrandNum.LostFocus += new EventHandler(tbRandNum_LostFocus);
                firstRand = false;
            }
        }

        int randNum = 45000;
        int randMin = 0;
        int randMax = 999999;
        private void rndpoleText(string xd)
        {
            Random random = new Random();
            int cislo;
            if (xd != "a")  //není quick(list)box active
            {
                for (int i = 0; i < randNum; i++)
                {
                    cislo = random.Next(randMin, randMax);
                    pole[i] = cislo;
                    xd += pole[i] + " ; ";
                    pozice++;
                    //numbers[i] = new oop_sort { number = cislo };
                }
                rtbPole.BeginInvoke((MethodInvoker)delegate ()
                { rtbPole.Text = xd; vypispole.Text = ""; });
            }
            else  //takto zdlouhavější kód, pro teoreticky vyšší rychlost počítání bez ifů
            {
                for (int i = 0; i < randNum; i++)
                {
                    cislo = random.Next(randMin, randMax);
                    pole[i] = cislo;
                    pozice++;
                    lboxPole.Items.Add(cislo + ";");
                    //lboxPole.BeginInvoke((MethodInvoker)delegate ()
                    //{ lboxPole.Items.Add(cislo + ";"); });  //tohle na listboxu pěkně blbne s Thready!
                }
                ///lboxPole.Items.AddRange(pole[]);  //nevím ještě, jak to funguje přesně
            }
        }

        //set random:
        Button btnSetRandom = new Button();
        TextBox tbrandNum = new TextBox();
        TextBox tbrandMin = new TextBox();
        TextBox tbrandMax = new TextBox();
        Label lbSetRandom = new Label();
        bool firstRand = true;
        void btn_setRandom(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\d+$");
            if (regex.IsMatch(tbrandNum.Text))
            {
                randNum = Convert.ToInt32(tbrandNum.Text);
            }
            if (regex.IsMatch(tbrandMin.Text))
            {
                randMin = Convert.ToInt32(tbrandMin.Text);
            }
            if (regex.IsMatch(tbrandMax.Text))
            {
                randMax = Convert.ToInt32(tbrandMax.Text) + 1;
            }
            if (randMax <= randMin)
            { randMax = randMin + 1; }
            MessageBox.Show("Počet náhodných čísel: " + randNum + "\r\n" + "Minimální hodnota náhodného čísla: " + randMin + "\r\n" + "Maximální hodnota náhodného čísla: " + (randMax - 1));
        }

        //placeholder, když není součástí kódu:
        private void tbRandMax_GotFocus(object sender, EventArgs e)
        { if (tbrandMax.Text == " maximum") tbrandMax.Text = ""; }
        private void tbRandMax_LostFocus(object sender, EventArgs e)
        { if (tbrandMax.Text == "") tbrandMax.Text = " maximum"; }

        private void tbRandMin_GotFocus(object sender, EventArgs e)
        { if (tbrandMin.Text == " minimum") tbrandMin.Text = ""; }
        private void tbRandMin_LostFocus(object sender, EventArgs e)
        { if (tbrandMin.Text == "") tbrandMin.Text = " minimum"; }

        private void tbRandNum_GotFocus(object sender, EventArgs e)
        { if (tbrandNum.Text == " počet čísel") tbrandNum.Text = ""; }
        private void tbRandNum_LostFocus(object sender, EventArgs e)
        { if (tbrandNum.Text == "") tbrandNum.Text = " počet čísel"; }


        //Reset:
        private void btReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            //for (int x = 0; x < pole.Length; x++)
            for (int x = 0; x <= pozice; x++) pole[x] = 0;
            pozice = 0;
            rtbPole.Clear();
            lboxPole.Items.Clear();
            vypispole.Text = "";
        }


        //Quick(List)Box:
        string poletext = "";
        private void cbQuickBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cbQuickBox.Checked)
            {
                rtbPole.Visible = false;
                rtbSorted.Visible = false;
                lboxPole.Visible = true;
                lboxSorted.Visible = true;
                cbQuick = true;
                btnUkazPole.Hide();
                lboxPole.Items.Clear();
                //foreach (int x in pole)
                for (int x = 0; x < pozice; x++)
                {
                    lboxPole.Items.Add(pole[x] + ";");
                }
            }
            else
            {
                rtbPole.Visible = true;
                rtbSorted.Visible = true;
                lboxPole.Visible = false;
                lboxSorted.Visible = false;
                cbQuick = false;
                btnUkazPole.Show();
            }
        }

        Button btnUkazPole = new Button();
        void ukazPole(object sender, EventArgs e)
        {
            poletext = "";
            Thread thd = new Thread(rtbPoleText);
            thd.Start();
        }

        private void rtbPoleText()
        {
            for (int i = 0; i < pozice; i++)
            { poletext += pole[i] + " ; "; }
            rtbPole.BeginInvoke((MethodInvoker)delegate ()
            { rtbPole.Text = poletext; });
        }
    }
}
