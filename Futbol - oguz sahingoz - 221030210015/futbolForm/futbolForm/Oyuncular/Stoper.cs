using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yetenekler;

namespace Oyuncular
{
    internal class Stoper : Oyuncu
    {

        //## OLUŞTURUCULAR  ----------  ----------  ----------  ----------
        protected Stoper(string isim, int guc, int hiz, int topKontrol) : base(isim, guc, hiz, topKontrol)
        {
            Isim = isim;
            Guc = guc;
            Hiz = hiz;
            TopKontrol = topKontrol;
            Pozisyon = Pozisyon.stoper;
            YetenekListesi = new IYetenek[]
            {
                Pas.Yarat(this),
                TopKap.Yarat(this)
            };
        }



        //## METODLAR  ----------  ----------  ----------  ----------

        public static Stoper Yarat(string isim, int guc, int hiz, int topKontrol) => new Stoper(isim, guc, hiz, topKontrol);

    }  // stoper sınıfı
}  //  Oyuncular isim alanı
