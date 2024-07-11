using Oyuncular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Yetenekler
{
    internal class KaleyeSut : IYetenek
    {
        //## NİTELİKLER  ----------  ----------  ----------  ----------
        public yetenek YetenekAdi { get; private set; }
        public double[] statAgirlik { get; private set; }
        public Oyuncu BagliOyuncu { get; private set; }


        //## OLUŞTURUCULAR  ----------  ----------  ----------  ----------
        private KaleyeSut (Oyuncu O)
        {
            YetenekAdi = yetenek.KaleyeSut;
            statAgirlik = new double[] { 0.3, 0.4, 0.3 };
            BagliOyuncu = O;
        }

        //## METODLAR  ----------  ----------  ----------  ----------

        public string Uygula() => Hesapla(BagliOyuncu) > 5 ? $"{BagliOyuncu.Isim} gol attı" : $"{BagliOyuncu.Isim} auta attı";

        public int Hesapla(Oyuncu O) => Convert.ToInt32(statAgirlik[0] * O.Guc + statAgirlik[1] * O.Hiz + statAgirlik[2] * O.TopKontrol);

        public static KaleyeSut Yarat(Oyuncu O) => new KaleyeSut(O);
    }
}
