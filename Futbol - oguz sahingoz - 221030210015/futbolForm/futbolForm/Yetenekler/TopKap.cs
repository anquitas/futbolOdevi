using Oyuncular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yetenekler
{
    internal class TopKap : IYetenek
    {
        //## NİTELİKLER  ----------  ----------  ----------  ----------
        public yetenek YetenekAdi { get; private set; }
        public double[] statAgirlik { get; private set; }
        public Oyuncu BagliOyuncu { get; private set; }


        //## OLUŞTURUCULAR  ----------  ----------  ----------  ----------
        private TopKap (Oyuncu O)
        {
            YetenekAdi = yetenek.TopKap;
            statAgirlik = new double[] { 0.4, 0.5, 0.1 };
            BagliOyuncu = O;
        }

        //## METODLAR  ----------  ----------  ----------  ----------

        public string Uygula() => Hesapla(BagliOyuncu) > 5 ? $"{BagliOyuncu.Isim} topu kaptı" : $"{BagliOyuncu.Isim} geçit verdi";

        public int Hesapla(Oyuncu O) => Convert.ToInt32(statAgirlik[0] * O.Guc + statAgirlik[1] * O.Hiz + statAgirlik[2] * O.TopKontrol);

        public static TopKap Yarat(Oyuncu O) => new TopKap (O);
    }  //  TopKap sınıfı
}  //  Yetenekler isim alanı
