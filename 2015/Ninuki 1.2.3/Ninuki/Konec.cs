using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ninuki
{
    public partial class Konec : Form
    {
        public Konec()
        { InitializeComponent(); }

        Form1 frm = new Form1();

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.Close();
            frm.Show();
            frm.NG();
        }

        private void btnPokracovat_Click(object sender, EventArgs e)
        { this.Close(); }

        private void btnSaveGame_Click(object sender, EventArgs e)
        { /*frm.btnSave.PerformClick();*/ frm.ab(); }

        private void btnKonec_Click(object sender, EventArgs e)
        {
            this.Close();
            frm.abc();
        }
    }
}
