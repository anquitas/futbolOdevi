using Oyuncular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Yetenekler
{
    internal class Pas : IYetenek
    {

        //## NİTELİKLER  ----------  ----------  ----------  ----------
        public yetenek YetenekAdi { get; private set; }
        public double[] statAgirlik { get; private set; }
        public Oyuncu BagliOyuncu { get; private set; }


        //## OLUŞTURUCULAR  ----------  ----------  ----------  ----------
        private Pas(Oyuncu O)
        {
            YetenekAdi = yetenek.Pas;
            statAgirlik = new double[] { 0.3, 0.3, 0.4 };
            BagliOyuncu = O;
        }

        //## METODLAR  ----------  ----------  ----------  ----------

        public string Uygula() => Hesapla(BagliOyuncu) > 5 ? $"{BagliOyuncu.Isim} başarılı bir pas verdi" : $"{BagliOyuncu.Isim} rakibe pas verdi";

        public int Hesapla(Oyuncu O) => Convert.ToInt32(statAgirlik[0] * O.Guc + statAgirlik[1] * O.Hiz + statAgirlik[2] * O.TopKontrol);
        public static Pas Yarat(Oyuncu O) => new Pas(O);
    }  //  Pas sınıfı
}  //  Yetenekler isim alanı
