using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Lib
{
    public abstract class Calisan : Kisi, IMaasAlabilir
    {
        public decimal _saatlikUcret;
        public Calisan() { }

        public decimal Tutar { get => _saatlikUcret * 8 * 20; }
        public decimal SaatlikUcret
        {
            get
            {
                return _saatlikUcret;
            }
            set
            {
                if (value > 0)
                    _saatlikUcret = value;
                else
                    throw new Exception("Girdiğiniz maaş bilgisi geçersizdir.");
            }
        }
    }
}
