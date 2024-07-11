﻿using Oyuncular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Yetenekler
{
    internal class TopYakala : IYetenek
    {
        //## NİTELİKLER  ----------  ----------  ----------  ----------
        public yetenek YetenekAdi { get; private set; }
        public double[] statAgirlik { get; private set; }
        public Oyuncu BagliOyuncu { get; private set; }


        //## OLUŞTURUCULAR  ----------  ----------  ----------  ----------
        private TopYakala (Oyuncu O)
        {
            YetenekAdi = yetenek.TopYakala;
            statAgirlik = new double[] { 0.3, 0.4, 0.3 };
            BagliOyuncu = O;
        }

        //## METODLAR  ----------  ----------  ----------  ----------

        public string Uygula() => Hesapla(BagliOyuncu) > 5 ? $"{BagliOyuncu.Isim} topu yakaladı" : $"{BagliOyuncu.Isim} gol yedi";

        public int Hesapla(Oyuncu O) => Convert.ToInt32(statAgirlik[0] * O.Guc + statAgirlik[1] * O.Hiz + statAgirlik[2] * O.TopKontrol);
        
        public static TopYakala Yarat(Oyuncu O) => new TopYakala(O);
    }
}