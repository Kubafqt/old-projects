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
    public partial class Form2 : Form
    {

        public Form2()
        { InitializeComponent(); }

        Form1 f1 = new Form1();
       
        private void btnngYes_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Show();
            f1.NG();

            //f1.abc();
            //Form1.ActiveForm.Disposed += new EventHandler(closeForm2);
        }

        private void btnngYesSave_Click(object sender, EventArgs e)
        {
            f1.ab();
            this.Close();
            f1.Show();
            f1.NG();
            f1.btnSave.PerformClick();
            //f1.abc();
        }

        private void btnngNo_Click(object sender, EventArgs e)
        { this.Close(); }
    }
}

