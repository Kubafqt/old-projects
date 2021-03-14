using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Threading;

namespace _Faktorial
{
    class Main
    {
        int x; //číslo ze vstupu
        BigInteger fakt; //na full číslo může být: double, float, long; nejlépe => BigInteger

        bool vypisy = false;
        bool shrt = false;
        int minus;

        DateTime ted = new DateTime();
        double acas = 0;
        double bcas = 0;
        bool startIT = false;


        public void zaklad()
        {
            OPK opk = new OPK(); //definice pro class OPK
            do
            {
                Console.Write("Zadej faktoriál: ");
                string vstup = Console.ReadLine();
                double number;
                string cislo = Regex.Match(vstup, @"\d+").Value; //vybrání čísla ze vstupu

                //PŘÍKAZY//
                //clear:
                if (vstup == "clear" || vstup == "Clear")
                { Console.Clear(); opk.next = "a"; }
                //help:
                else if (vstup == "help" || vstup == "Help")
                {
                    Console.WriteLine("\r\n\r\n");
                    Console.WriteLine("Vítejte v počítadle faktoriálu!");
                    Console.WriteLine("\r\n");
                    Console.WriteLine("Zde jsou vypsané příkazy které můžete zadat:\r\n");
                    Console.WriteLine("'number' => výpočet faktoriálu čísla");
                    Console.WriteLine("for 'number' => výpis faktoriálů od 1 do zadaného čísla");
                    Console.WriteLine("short => zkrácení čísla na 10 míst / druhý zadání = default");
                    Console.WriteLine("help => návod k použití");
                    Console.WriteLine("clear => vymazání console");
                    Console.WriteLine("end nebo exit => ukončení programu \r\n\r\n");
                    Console.WriteLine("2016; Jakub Jankovec \r\n\r\n" + Environment.NewLine);

                    opk.next = "a";
                }
                //exit:
                else if (vstup == "end" || vstup == "End" || vstup == "exit" || vstup == "Exit")
                { Environment.Exit(0); }

                //short:
                else if (vstup == "short")
                {
                    fakt = 1;
                    if (!shrt) shrt = true;
                    else shrt = false;
                    Console.WriteLine("Zkracení čísla = " + shrt + "\r\n\r\n");

                    opk.next = "a";
                }

                //výpis všech faktoriálu do čísla:
                else if (vstup.Length >= 4 && vstup.Substring(0, 4) == "for " && double.TryParse(cislo, out number))
                {
                    vypisy = true;
                    fakt = 1;

                    x = Convert.ToInt32(cislo);
                    prubeh();
                    //Thread TH = new Thread(prubeh);
                    //TH.Start();

                    opk.next = "a";
                }

                //výpis faktoriálu:
                else
                {
                    if (double.TryParse(vstup, out number)) //je to číslo
                    {
                        x = Convert.ToInt32(vstup);

                        if (x <= 0)
                        { Console.WriteLine(); Console.WriteLine("Neplatný vstup!(číslo musí být větší než 0) Pro pomoc zadejte příkaz help. \r\n\r\n"); }
                        else
                        {
                            vypisy = false;
                            fakt = 1;
                            startIT = true;
                            prubeh();
                            //Thread TH = new Thread(prubeh);
                            //TH.Start();
                        }
                    }
                    else //není to číslo
                    { Console.WriteLine(); Console.WriteLine("Neplatný vstup! Pro pomoc zadejte příkaz help. \r\n\r\n"); }
                    //opk.opakovani();
                    opk.next = "a";
                }
                //PŘÍKAZY//
            }
            while (opk.next == "a");
        }

        string faktToString;
        BigInteger bigHELP;
        BigInteger mocnina;
        double thc;
        double zkrFakt;
        int kej = 1;
        private void prubeh()
        {
            ted = DateTime.Now;
            if (startIT)
            {
                acas = ted.Millisecond + ted.Second * 1000 + ted.Minute * 60000 + ted.Hour * 3600000;
                startIT = false;
            }
            kej = 1;
            /*if (Console.KeyAvailable)
            { Console.WriteLine("\r\n"); } => nefunguje*/
            while (kej < x && !Console.KeyAvailable)  // možno výpočet přerušit vstupem z klávesnice
            {
                kej++;
                //výpočet:
                fakt = fakt * kej;
                //výpisy:
                if (vypisy) //&& kej > 50000) //for 'číslo'
                    ShortTest();
                else if (!vypisy && kej == x) //bez foru
                    ShortTest();
            }
        }

        private void ShortTest()
        {
            faktToString = fakt.ToString();
            if (!shrt && !vypisy) //bez shortu
            { Console.WriteLine("Výsledek: " + fakt + "\r\n\r\n"); }
            else if(!shrt && vypisy)
            { Console.WriteLine(kej + "! = " + fakt); if (kej == x) { Console.WriteLine("\r\n\r\n"); } }
            else //short 'číslo'
            {
                if (faktToString.Length > 307) //konec pro double
                {
                    minus = faktToString.Length - 307;
                    mocnina = BigInteger.Pow(10, minus);
                    fakt = fakt / mocnina;
                    thc = (double)fakt / Math.Pow(10, faktToString.Length - 1 - minus);
                }
                else thc = (double)fakt / Math.Pow(10, faktToString.Length - 1);
                zkrFakt = Math.Round(thc, 10);

                if (vypisy)
                {
                    if (faktToString.Length <= 10) Console.WriteLine(kej + "! = " + fakt);
                    else Console.WriteLine(kej + "! = " + zkrFakt + "E+" + (faktToString.Length - 1));
                    if (kej == x) Console.WriteLine("\r\n\r\n");
                }
                else
                {
                    Console.WriteLine("Výsledek: " + zkrFakt + "E+" + (faktToString.Length - 1));
                    ted = DateTime.Now;
                    bcas = (ted.Millisecond + ted.Second * 1000 + ted.Minute * 60000 + ted.Hour * 3600000) - acas;
                    Console.WriteLine("\r\nCelkový čas: " + bcas / 1000 + " sec\r\n\r\n" + Environment.NewLine);
                }
            }
        }
    }
}
