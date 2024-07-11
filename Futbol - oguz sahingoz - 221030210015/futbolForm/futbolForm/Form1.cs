using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oyuncular;
using Yetenekler;

namespace futbolForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //## OYUNCU TANIMLARI  ----------  ----------  ----------  ----------
        Button secili; 
        Oyuncu oyuncu;
        Kaleci K = Kaleci.Yarat("daniel",5,6,8);
        Bek bek0 = Bek.Yarat("obito",4,3,7);
        Bek bek1 = Bek.Yarat("naruto", 4, 3, 7);
        Stoper stp0 = Stoper.Yarat("oğuz", 8, 8, 8);
        Stoper stp1 = Stoper.Yarat("luffy",6,7,3);
        OnLibero OL = OnLibero.Yarat("Zoro",9,6,8);
        OrtaSaha OS0 = OrtaSaha.Yarat("mikasa",8,9,7);
        OrtaSaha OS1 = OrtaSaha.Yarat("armin", 2, 3, 8);
        Forvet F0 = Forvet.Yarat("madara", 7,7,7);
        Forvet F1 = Forvet.Yarat("samantha", 4, 6, 8);
        Forvet F2 = Forvet.Yarat("randy",5,4,6);


        //## BUTON KONTOL  ----------  ----------  ----------  ----------
        #region oyuncu butonları
        private void KB0_Click(object sender, EventArgs e)
        {
            oyuncuSec(K);
            btnRenk(KB0);
        }

        private void StpB0_Click(object sender, EventArgs e)
        {
            oyuncuSec(stp0);
            btnRenk(StpB0);
        }

        private void StpB1_Click(object sender, EventArgs e)
        {
            oyuncuSec(stp1);
            btnRenk(StpB1);
        }

        private void BekB0_Click(object sender, EventArgs e)
        {
            oyuncuSec(bek0);
            btnRenk(BekB0);

        }

        private void BekB1_Click(object sender, EventArgs e)
        {
            oyuncuSec(bek1);
            btnRenk(BekB1);
        }

        private void OLB0_Click(object sender, EventArgs e)
        {
            oyuncuSec(OL);
            btnRenk(OLB0);
        }

        private void OSB0_Click(object sender, EventArgs e)
        {
            oyuncuSec(OS0);
            btnRenk(OSB0);
        }

        private void OSB1_Click(object sender, EventArgs e)
        {
            oyuncuSec(OS1);
            btnRenk(OSB1);
        }

        private void FB0_Click(object sender, EventArgs e)
        {
            oyuncuSec(F0);
            btnRenk(FB0);
        }

        private void FB1_Click(object sender, EventArgs e)
        {
            oyuncuSec(F1);
            btnRenk(FB1);
        }

        private void FB2_Click(object sender, EventArgs e)
        {
            oyuncuSec(F2);
            btnRenk(FB2);
        }
        #endregion

        private void SecimButonu_Click(object sender, EventArgs e)
        {
            string selected = SecimListesi.SelectedItem.ToString();
            MessageBox.Show(oyuncu.Oyna(selected));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            secili = KB0;
        }

        private void oyuncuSec (Oyuncu O )
        {
            oyuncu = O;
            SecimListesi.DataSource = oyuncu.YetenekListele();
        }

        private void btnRenk (Button btn)
        {
            secili.BackColor = Color.SteelBlue;
            secili = btn;
            secili.BackColor = Color.Yellow;

        }

    }  // form1 sınıfı
}  //  futbolForm isim alanı 
