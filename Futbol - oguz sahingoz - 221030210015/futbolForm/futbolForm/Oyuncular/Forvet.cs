using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yetenekler;

namespace Oyuncular
{
    internal class Forvet : Oyuncu
    {
        //## OLUŞTURUCULAR  ----------  ----------  ----------  ----------
        protected Forvet(string isim, int guc, int hiz, int topKontrol) : base(isim, guc, hiz, topKontrol)
        {
            Isim = isim;
            Guc = guc;
            Hiz = hiz;
            TopKontrol = topKontrol;
            Pozisyon = Pozisyon.forvet;
            YetenekListesi = new IYetenek[]
            {
                Pas.Yarat(this),
                Calım.Yarat(this),
                KaleyeSut.Yarat(this),
                Atak.Yarat(this)
            };
        }



        //## METODLAR  ----------  ----------  ----------  ----------

        public static Forvet Yarat(string isim, int guc, int hiz, int topKontrol) => new Forvet(isim, guc, hiz, topKontrol);

    }  //  Forvet sınıfı
}  //  Oyuncular isim alanı
