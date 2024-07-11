using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yetenekler;

namespace Oyuncular
{
    internal class OnLibero : Oyuncu
    {
        //## OLUŞTURUCULAR  ----------  ----------  ----------  ----------
        protected OnLibero(string isim, int guc, int hiz, int topKontrol) : base(isim, guc, hiz, topKontrol)
        {
            Isim = isim;
            Guc = guc;
            Hiz = hiz;
            TopKontrol = topKontrol;
            Pozisyon = Pozisyon.onLibero;
            YetenekListesi = new IYetenek[]
            {
                Pas.Yarat(this),
                TopKap.Yarat(this)
            };
        }



        //## METODLAR  ----------  ----------  ----------  ----------

        public static OnLibero Yarat(string isim, int guc, int hiz, int topKontrol) => new OnLibero(isim, guc, hiz, topKontrol);


    }  //  OnLibero sınıfı
}  //  Oyuncular isim alanı
