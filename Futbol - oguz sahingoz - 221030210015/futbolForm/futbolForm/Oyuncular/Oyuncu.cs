using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yetenekler;

namespace Oyuncular
{
    enum Pozisyon { kaleci, stoper, bek, onLibero, ortaSaha, forvet }
    internal abstract class Oyuncu
    {
        //##  ALANLAR  ----------  ----------  ----------  ----------
        protected IYetenek[] YetenekListesi;

        //##  NİTELİKLER  ----------  ----------  ----------  ----------
        public string Isim {  get; protected set; }
        public Pozisyon Pozisyon {  get; protected set; }

        public int Guc {  get; protected set; }
        public int Hiz { get; protected set; }
        public int TopKontrol { get; protected set; }

        //##  OLUŞTURUCULAR  ----------  ----------  ----------  ----------

        protected Oyuncu (string isim, int guc, int hiz, int topKontrol )
        {
            Isim = isim;
            Guc = guc;
            Hiz = hiz;
            TopKontrol = topKontrol;
        }

        //##  NİTELİKLER  ----------  ----------  ----------  ----------

        #region FONKSİYON Oyna()
        public string Oyna(string secim)
        {
            yetenek secim_y = Donustur(secim);
            foreach (IYetenek secilenYetenek in YetenekListesi)
            {
                if (secilenYetenek.YetenekAdi == secim_y)
                    return secilenYetenek.Uygula();
                
                    
            }
            throw new Exception("yetenek seçim sorunu");
            return "";
        }  //  yapılan yetenek seçimini uygular

        public string Oyna(yetenek secim)
        {
            
            foreach (IYetenek secilenYetenek in YetenekListesi)
            {
                if (secilenYetenek.YetenekAdi == secim)
                    return secilenYetenek.Uygula();
                
            }
                throw new Exception("yetenek seçim sorunu");
            return "";
        }  //  yapılan yetenek seçimini uygular
        #endregion

        public yetenek Donustur(string strVersiyon) => (yetenek)Enum.Parse(typeof(yetenek), strVersiyon);

        public List<string> YetenekListele()
        {
            List<string> temp = new List<string>();
            foreach (IYetenek y in YetenekListesi)
            {
                temp.Add(y.YetenekAdi.ToString());
            }
            return temp;
        }

    }



}  //  Oyuncular sınıf alanları



//## ALANLAR  ----------  ----------  ----------  ----------
//## NİTELİKLER  ----------  ----------  ----------  ----------
//## OLUŞTURUCULAR  ----------  ----------  ----------  ----------
//## İNDEXLER  ----------  ----------  ----------  ----------
//## METODLAR  ----------  ----------  ----------  ----------