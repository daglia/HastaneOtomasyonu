using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Lib
{
    public class Doktor : Calisan, IMudahaleEdebilir
    {
        public Branslar DBrans { get; set; }
       // private _brans;

        //public Doktor()
        //{
        //}

        public Doktor(string ad,string soyad,Branslar dBrans) : base(ad,soyad)
        {
            this.DBrans = dBrans;
        }

        public void MudahaleEt(Doktor doktor, DateTime mudahaleSaati)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Ad: {Ad}\nSoyad: {Soyad}\nBrans: {DBrans}";
        }
    }
}
