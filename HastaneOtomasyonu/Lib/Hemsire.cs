using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Lib
{
    public class Hemsire : Calisan, IMudahaleEdebilir
    {
        public Hemsire(string ad, string soyad) : base(ad, soyad)
        {
        }

        public void MudahaleEt(Doktor doktor, DateTime mudahaleSaati)
        {
            throw new NotImplementedException();
        }
    }
}
