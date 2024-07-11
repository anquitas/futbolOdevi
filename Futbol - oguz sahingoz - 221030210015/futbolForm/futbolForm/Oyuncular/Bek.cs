using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yetenekler;

namespace Oyuncular
{
    internal class Bek : Oyuncu
    {
        //## OLUŞTURUCULAR  ----------  ----------  ----------  ----------
        protected Bek(string isim, int guc, int hiz, int topKontrol) : base (isim, guc, hiz, topKontrol)
        {
            Isim = isim;
            Guc = guc;
            Hiz = hiz;
            TopKontrol = topKontrol;
            Pozisyon = Pozisyon.bek;
            YetenekListesi = new IYetenek[]
            {
                Pas.Yarat(this),
                TopKap.Yarat(this), 
                OrtaAt.Yarat(this),
            };
        }



        //## METODLAR  ----------  ----------  ----------  ----------

        public static Bek Yarat(string isim, int guc, int hiz, int topKontrol) => new Bek(isim, guc, hiz, topKontrol);


    }  //  Bek sınıfı
}  //  Oyuncular isim alanı
