using Oyuncular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yetenekler
{
    internal class Calım : IYetenek
    {
        //## NİTELİKLER  ----------  ----------  ----------  ----------
        public yetenek YetenekAdi { get; private set; }
        public double[] statAgirlik { get; private set; }
        public Oyuncu BagliOyuncu { get; private set; }


        //## OLUŞTURUCULAR  ----------  ----------  ----------  ----------
        private Calım (Oyuncu O)
        {
            YetenekAdi = yetenek.Çalım;
            statAgirlik = new double[] { 0.1, 0.4, 0.4 };
            BagliOyuncu = O;
        }

        //## METODLAR  ----------  ----------  ----------  ----------

        public string Uygula() => Hesapla(BagliOyuncu) > 5 ? $"{BagliOyuncu.Isim} iyi bir çalım attı" : $"{BagliOyuncu.Isim} kendi ayağına takıldı";

        public int Hesapla(Oyuncu O) => Convert.ToInt32(statAgirlik[0] * O.Guc + statAgirlik[1] * O.Hiz + statAgirlik[2] * O.TopKontrol);
        public static Calım Yarat(Oyuncu O) => new Calım(O);
    }  //  Calım sınıfı
}  //  Yetenekler isim alanı
