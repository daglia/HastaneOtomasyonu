using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Lib
{
    public class Hemsire : Calisan, IMudahaleEdebilir
    {
        public string hBrans;

        public Hemsire() { }
        public Hemsire(string ad, string soyad) : base(ad, soyad)
        {
        }

        public void MudahaleEt(Hasta hasta, DateTime mudahaleSaati)
        {
            //doktor.MudahaleEt();
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{hBrans} {Ad} {Soyad}";
        }
    }
}
