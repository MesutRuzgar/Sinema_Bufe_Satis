using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bufe_Satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasaTutari = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay,toplam;
            misir = Convert.ToInt32(TxtMisir.Text);
            bilet = Convert.ToInt32(TxtBilet.Text);
            su = Convert.ToInt32(TxtSu.Text);
            cay = Convert.ToInt32(TxtSu.Text);
            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;
            lblToplam.Text = toplam.ToString("N")+ " TL";

            kasaTutari = kasaTutari + toplam;
            lblKasa.Text = kasaTutari.ToString("N3")+ " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtMisir.Text = "";
            TxtSu.Text = "";
            TxtCay.Text = "";
            TxtBilet.Text = "";
            TxtMisir.Focus();
            
        }
    }
}
