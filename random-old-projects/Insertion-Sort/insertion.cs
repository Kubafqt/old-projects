using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Insertion_Sort
{
    class insertion 
    {
        static int rekurze = 0;
        public static int maximum;
        public static void sort(int pos)
        {
            int x = 1;
            int number = Form1.sorted[pos];
            bool hledani = true;
            int pozX;
            while (hledani)
            {
                if (number <= Form1.sorted[pos - x]) //seřazované číslo je menší/rovná se než číslo na aktuální pozici
                {
                   if (pos - x != 0) x++; //porovnání s dalším číslem v pořadí
                   else   //číslo došlo na začátek řady (nejmenší z předchozích)
                    {
                        hledani = false;
                        pozX = 0;
                        prepsani(pos, pozX, number);
                    }
                }
                else  //číslo je nyní větší než číslo na aktuální pozici
                {
                    hledani = false;
                    if (x != 1)  //seřazení, pokud není na svém místě;
                    {
                        pozX = pos - x + 1;
                        prepsani(pos, pozX, number);
                    }
                    else if (pos < maximum - 1) //(Form1.sorted[pos + 1] != null) - zeptat se jestli není null
                    {
                        pos++;
                        rekurze++;
                        if (rekurze <= 4000)
                        { sort(pos); }
                        else recursReset(pos);
                    }
                    else vypis(Form1.cbQuick);  // poslední číslo v poli a neřadí se -> výpis
                }
            }
        }

        private static void prepsani(int pos, int pozX, int number)
        {
            if (pos < maximum) //(Form1.sorted[pos + 1] != null)
            {
                for (int i = pos - 1; i >= pozX; i--)
                Form1.sorted[i + 1] = Form1.sorted[i];
                Form1.sorted[pozX] = number;
                pos++;
                rekurze++;
                if (rekurze <= 4000)
                { sort(pos); }
                else recursReset(pos);
            }
            else vypis(Form1.cbQuick);  // souřadnice už přišla na poslední číslo v poli -> výpis
        }

        private static void vypis(bool cbQuick)  //parametr této funkce není nutný, ale je záživný
        {
            switch (cbQuick)
            {
                case true: //listbox ošetření
                    {
                        for (int i = 0; i < maximum; i++)
                        Form1.lboxSorted.Items.Add(Form1.sorted[i] + ";");
                        break;
                    }
                case false: //richbox
                    {
                        Thread thd = new Thread(threadvypis);
                        thd.Start();
                        break;
                    }
            }
        }

        private static void threadvypis()
        {
            string omq = "";
            for (int x = 0; x < maximum; x++) omq += Form1.sorted[x].ToString() + " ; ";
            Form1.rtbSorted.BeginInvoke((MethodInvoker)delegate () { Form1.rtbSorted.Text = omq; });
        }

        private static void recursReset(int pos)
        {
            rekurze = 0;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer(); //dlouhý, kvůli tomu using system.Threading! -> jeden thread, ktery může být i ve Form1.cs\\
            timer.Interval = 1;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();  
            void timer_Tick(object sender, EventArgs e)
            {
                timer.Enabled = false;
                sort(pos);
            }
        }

        #region testovací účely
        public static void a(int rr)
        {
            rr++;
            if (rr <= 5000)
                b(rr);
            else
            {
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 100; //specify interval time as you want
                timer.Tick += new EventHandler(timer_Tick);
                timer.Start();
                void timer_Tick(object sender, EventArgs e)
                {
                    timer.Enabled = false;
                    MessageBox.Show("Hello - a");
                    b(rr);
                }
            }
        }
        
        private static void b(int rr)
        {
            rr++;
            if (rr <= 5000)
                a(rr);
            else
            {
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 100; //specify interval time as you want
                timer.Tick += new EventHandler(timer_Tick);
                timer.Start();
                void timer_Tick(object sender, EventArgs e)
                {
                    timer.Enabled = false;
                    MessageBox.Show("Hello - b");
                    a(rr);
                }
            }
        }
        #endregion

    }
}
