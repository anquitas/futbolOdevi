using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oyuncular;

namespace Yetenekler
{
    internal class Atak : IYetenek
    {
       
        //## NİTELİKLER  ----------  ----------  ----------  ----------
        public yetenek YetenekAdi { get; private set; }
        public double[] statAgirlik { get; private set; }
        public Oyuncu BagliOyuncu { get; private set; }


        //## OLUŞTURUCULAR  ----------  ----------  ----------  ----------
        private Atak (Oyuncu O)
        {
            YetenekAdi = yetenek.Atak;
            statAgirlik = new double[] { 0.4, 0.2, 0.3 };
            BagliOyuncu = O;
        }
        
        //## METODLAR  ----------  ----------  ----------  ----------

        public string Uygula() => Hesapla(BagliOyuncu) > 5 ? $"{BagliOyuncu.Isim} başarılı atak yaptı" : $"{BagliOyuncu.Isim} topu kaptırdı"; 
 
        public int Hesapla (Oyuncu O) => Convert.ToInt32(statAgirlik[0]*O.Guc + statAgirlik[1] * O.Hiz + statAgirlik[2] * O.TopKontrol);

        public static Atak Yarat(Oyuncu O) => new Atak(O);

    }  //  Atak sınıfı
}  //  Yetenekler isim alanı


