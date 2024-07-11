using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oyuncular;

namespace Yetenekler
{
    public enum yetenek { Atak, Pas, Çalım, TopKap, TopYakala, KaleyeSut, OrtaAt }
    internal interface IYetenek
    {
        //## NİTELİKLER  ----------  ----------  ----------  ----------
        Oyuncu BagliOyuncu { get; }  // implemente eden nesnenin Bağlı olduğu oyuncu
        yetenek YetenekAdi {  get; }  // implemente eden sınıfın hangi yetenek tipinde olduğu
        double[] statAgirlik {  get; }  //  implemente eden sınıfın stat ağırlıkları



        //## METODLAR  ----------  ----------  ----------  ----------
        string Uygula();  //  yeteneğin uygulanmasını sağlayan fonksiyon
    }  //  IYetenek interface'i
}  //  Yetenekler isim alanı
