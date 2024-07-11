using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yetenekler;

namespace Oyuncular
{
    internal class Kaleci : Oyuncu
    {
        //## OLUŞTURUCULAR  ----------  ----------  ----------  ----------
        protected Kaleci(string isim, int guc, int hiz, int topKontrol) : base(isim, guc, hiz, topKontrol)
        {
            Isim = isim;
            Guc = guc;
            Hiz = hiz;
            TopKontrol = topKontrol;
            Pozisyon = Pozisyon.kaleci;
            YetenekListesi = new IYetenek[]
            {
                TopYakala.Yarat(this),
                Pas.Yarat(this)
            };
        }



        //## METODLAR  ----------  ----------  ----------  ----------

        public static Kaleci Yarat(string isim, int guc, int hiz, int topKontrol) => new Kaleci (isim, guc, hiz, topKontrol);

    }
}
