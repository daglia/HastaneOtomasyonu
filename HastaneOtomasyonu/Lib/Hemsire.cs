using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Lib
{
    public class Hemsire : Calisan, IMudahaleEdebilir
    {
        //public Branslar HBrans { get; set; }
        public string hBrans;

        public Hemsire()
        {
        }
        public Hemsire(string ad, string soyad) : base(ad, soyad)
        {
            //Doktor doktor = new Doktor("aaa","aaa",Branslar.GöğüsHastalıkları);
            //this.hBrans = doktor.DBrans.ToString();

        }

        public void MudahaleEt(Doktor doktor, DateTime mudahaleSaati)
        {
            //doktor.MudahaleEt();
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Ad: {Ad}\nSoyad: {Soyad}\nBrans: {hBrans}";
        }
    }
}
