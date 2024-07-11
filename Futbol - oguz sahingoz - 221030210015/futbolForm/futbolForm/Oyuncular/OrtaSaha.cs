using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yetenekler;

namespace Oyuncular
{
    internal class OrtaSaha : Oyuncu
    {
        //## OLUŞTURUCULAR  ----------  ----------  ----------  ----------
        protected OrtaSaha (string isim, int guc, int hiz, int topKontrol) : base(isim, guc, hiz, topKontrol)
        {
            Isim = isim;
            Guc = guc;
            Hiz = hiz;
            TopKontrol = topKontrol;
            Pozisyon = Pozisyon.ortaSaha;
            YetenekListesi = new IYetenek[]
            {
                Pas.Yarat(this),
                KaleyeSut.Yarat(this),
                Calım.Yarat(this),
                Atak.Yarat(this),
                OrtaAt.Yarat(this),
            };
        }



        //## METODLAR  ----------  ----------  ----------  ----------

        public static OrtaSaha Yarat(string isim, int guc, int hiz, int topKontrol) => new OrtaSaha (isim, guc, hiz, topKontrol);



    }  //  OrtaSaha sınıfı
}  //  Yetenekler isim alanı
