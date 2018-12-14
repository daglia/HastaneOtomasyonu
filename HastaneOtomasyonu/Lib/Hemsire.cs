using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Lib
{
    public class Hemsire : Calisan, IMudahaleEdebilir
    {
        public Branslar HBrans { get; set; }

        public Hemsire() { }

        public void MudahaleEt(Hasta hasta, DateTime mudahaleSaati)
        {
            //doktor.MudahaleEt();
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Hem. {Ad} {Soyad}";
        }
    }
}
