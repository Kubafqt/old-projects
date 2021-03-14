using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Security.Cryptography;

namespace Passwords
{
    public partial class Form1 : Form
    {
        public Form1()
        { InitializeComponent(); }

        Random random = new Random();
        string finalString;
        string[] zapis = new string[199999999];
        int pocet = 1;
        int vstup; //počet vygenerovaných čísel
        int take = 0; //kterou řádku přečte

        byte[] hash;
        string hashed;

        int xpocet = 1;
        int davka = 0;
        int limit = 3500; //tohle přenastavit, pokud se hází stackoverflow! (čím vyšší, tím rychlejší generování)
        double percent = 1;

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            xpocet = 1;
            davka++;
            label1.Text = davka * limit + " vygenerovaných hesel.";
            generator();
        }

        //Vygenerování nezahashovaných hesel:
        private void generator()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[9];

            for (int i = 0; i < stringChars.Length; i++)
            { stringChars[i] = chars[random.Next(chars.Length)]; }
            finalString = new String(stringChars);

            if (pocet <= vstup && xpocet < limit)
            {
                
                zapsani();
            }
            else if (xpocet == limit)
            { timer.Enabled = true; }
            else
            {
                /*Thread T1 = new Thread(labeling);
                T1.Start();*/
                Thread T2 = new Thread(hashing);
                T2.Start();
            }
        }

        //Zápis nezahashovaných hesel do pole:
        private void zapsani()
        {
            pocet++;
            xpocet++;
            zapis[pocet] = finalString;

            generator();
        }

        //Hashování a zápis do souboru:
        private void hashing()
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);   //Set save location to My Documents
            int x = 1;
            double lastpercent = 0;
            double pro = 1;
            double pocetD = (double)pocet;
            

            using (StreamWriter sw = new StreamWriter(mydocpath + @"\hesla.txt"))
            {
                //MD5:
                if (rbMD5.Checked == true)
                {
                    using (MD5 crypt = MD5.Create())
                    {
                        while (x < pocet)
                        {
                            StringBuilder sb = new StringBuilder();
                            hash = crypt.ComputeHash(Encoding.UTF8.GetBytes(zapis[x]));
                            for (int i = 0; i < hash.Length; i++)
                            { sb.Append(hash[i].ToString("x2")); }
                            hashed = sb.ToString();

                            pro++;
                            percent = Math.Round((pro / pocet) * 100, 0);
                            if (percent > lastpercent)
                            {
                                lastpercent = percent;
                                labeling(percent);
                            }
                           
                            if (x < pocet - 1) 
                            { sw.Write(zapis[x] + "#" + hashed + "\r\n"); }
                            else
                            { 
                                sw.Write(zapis[x] + "#" + hashed);
                                lbPath.Invoke((MethodInvoker)(() => lbPath.Text = "Cesta k souboru: " + mydocpath + @"\hesla.txt"));
                                label1.Invoke((MethodInvoker)(() => label1.Text = pocet - 1 + " vygenerovaných hesel. => HOTOVO!"));
                            }
                            x++;
                        }         
                    }
                }
                //SHA1:
                else if (rbSHA1.Checked == true) //SHA of FEAR :D
                {
                    using (SHA1 crypt = SHA1.Create())
                    {
                        while (x < pocet)
                        {
                            StringBuilder sb = new StringBuilder();
                            hash = crypt.ComputeHash(Encoding.UTF8.GetBytes(zapis[x]));
                            for (int i = 0; i < hash.Length; i++)
                            { sb.Append(hash[i].ToString("x2")); }
                            hashed = sb.ToString();

                            pro++;
                            percent = Math.Round((pro / pocet) * 100, 0);
                            if (percent > lastpercent)
                            {
                                lastpercent = percent;
                                label1.Invoke((MethodInvoker)(() => label1.Text = pocet - 1 + " vygenerovaných hesel. => HASHING (" + percent + "%)"));
                            }

                            if (x < pocet - 1)
                            { sw.Write(zapis[x] + "#" + hashed + "\r\n"); }
                            else
                            {
                                sw.Write(zapis[x] + "#" + hashed);
                                lbPath.Invoke((MethodInvoker)(() => lbPath.Text = "Cesta k souboru: " + mydocpath + @"\hesla.txt"));
                                percent = Math.Round((pro / pocet) * 100, 0);
                                label1.Invoke((MethodInvoker)(() => label1.Text = pocet - 1 + " vygenerovaných hesel. => HOTOVO! (" + percent + "%)"));
                            }
                            x++;
                        }
                    }
                }
                //SHA256:
                else if (rbSHA256.Checked == true)
                {
                    using (SHA256 crypt = SHA256.Create())
                    {
                        while (x < pocet)
                        {
                            StringBuilder sb = new StringBuilder();
                            hash = crypt.ComputeHash(Encoding.UTF8.GetBytes(zapis[x]));
                            for (int i = 0; i < hash.Length; i++)
                            { sb.Append(hash[i].ToString("x2")); }
                            hashed = sb.ToString();

                            pro++;
                            percent = Math.Round((pro / pocet) * 100, 0);
                            if (percent > lastpercent)
                            {
                                lastpercent = percent;
                                label1.Invoke((MethodInvoker)(() => label1.Text = pocet - 1 + " vygenerovaných hesel. => HASHING (" + percent + "%)"));
                            }

                            if (x < pocet - 1)
                            { sw.Write(zapis[x] + "#" + hashed + "\r\n"); }
                            else
                            {
                                sw.Write(zapis[x] + "#" + hashed);
                                lbPath.Invoke((MethodInvoker)(() => lbPath.Text = "Cesta k souboru: " + mydocpath + @"\hesla.txt"));
                                label1.Invoke((MethodInvoker)(() => label1.Text = pocet - 1 + " vygenerovaných hesel. => HOTOVO!"));
                            }
                            x++;
                        }
                    }
                }
                //SHA512:
                else if (rbSHA512.Checked == true)
                {
                    using (SHA512 crypt = SHA512.Create())
                    {
                        while (x < pocet)
                        {
                            StringBuilder sb = new StringBuilder();
                            hash = crypt.ComputeHash(Encoding.UTF8.GetBytes(zapis[x]));
                            for (int i = 0; i < hash.Length; i++)
                            { sb.Append(hash[i].ToString("x2")); }
                            hashed = sb.ToString();

                            pro++;
                            percent = Math.Round((pro / pocet) * 100, 0);
                            if (percent > lastpercent)
                            {
                                labeling(percent);
                                lastpercent = percent;
                            }

                            if (x < pocet - 1)
                            { sw.Write(zapis[x] + "#" + hashed + "\r\n"); }
                            else
                            {
                                sw.Write(zapis[x] + "#" + hashed);
                                lbPath.Invoke((MethodInvoker)(() => lbPath.Text = "Cesta k souboru: " + mydocpath + @"\hesla.txt"));
                                label1.Invoke((MethodInvoker)(() => label1.Text = pocet - 1 + " vygenerovaných hesel. => HOTOVO!"));
                            }
                            x++;
                        }
                    }
                }
            }
        }

        private void labeling(double procento) //ukázání progressu
        {
            label1.Invoke((MethodInvoker)(() => label1.Text = pocet - 1 + " vygenerovaných hesel. => HASHING (" + percent + "%)"));
        }
    
        //Čtení ze souboru:
        private void cteni()
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamReader sr = new StreamReader(mydocpath + @"\hesla.txt", Encoding.Default))
            {
                MessageBox.Show(take + ".)  " + File.ReadLines(mydocpath + @"\hesla.txt").Skip(take - 1).Take(take).First());
            }
        }

        // Buttony:
        private void btnGen_Click(object sender, EventArgs e)
        {
            if (rbMD5.Checked == true || rbSHA1.Checked == true || rbSHA256.Checked == true || rbSHA512.Checked == true)
            {
                vstup = Convert.ToInt32(tbPocet.Text);
                take = 0;
                pocet = 0;
                xpocet = 0;
                davka = 0;
                generator();
            }
            else
            { MessageBox.Show("Je třeba, aby byla zvolena metoda šifrování hesla!"); }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if (take < vstup) { take++; }
            else { take = 1; }
            cteni();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            try //zatím try/catch -> později nějaký lepší detect.
            { System.Diagnostics.Process.Start("notepad++.exe", mydocpath + @"\hesla.txt"); }
            catch {
                try
                { System.Diagnostics.Process.Start("pspad.exe", mydocpath + @"\hesla.txt"); }
                catch { System.Diagnostics.Process.Start("notepad.exe", mydocpath + @"\hesla.txt"); }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        { this.Close(); }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*Použité odkazy: 1. http://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings-in-c
         *                2. https://msdn.microsoft.com/en-us/library/6ka1wd3w(v=vs.110).aspx
         *                3. https://www.youtube.com/watch?v=S94BQimH6U4
         *                4. http://stackoverflow.com/questions/1262965/how-do-i-read-a-specified-line-in-a-text-file
         *                5. http://stackoverflow.com/questions/4055266/open-a-file-with-notepad-in-c-sharp */
    }
}