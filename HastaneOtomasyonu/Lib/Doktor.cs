using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Lib
{
    public class Doktor : Calisan, IMudehaleEdebilir
    {
        public Branslar DBrans { get; set; }

        private decimal _saatlikUcret;

        public decimal Tutar { get => _saatlikUcret * 8 * 20; }

        public Doktor()
        {
        }

        //public Doktor(string ad):base(ad)
        //{

        //}

        public decimal SaatlikUcret { set => _saatlikUcret = 25; }


        public void MudehaleEt()
        {
            throw new NotImplementedException();
        }
    }
}
