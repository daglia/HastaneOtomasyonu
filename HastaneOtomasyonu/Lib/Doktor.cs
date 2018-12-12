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

        public Doktor()
        {
        }

        //public Doktor(string ad):base(ad)
        //{

        //}

        //public decimal SaatlikUcret { set => _saatlikUcret = 25; }


        public void MudahaleEt(Doktor doktor, DateTime mudahaleSaati)
        {
            throw new NotImplementedException();
        }
    }
}
