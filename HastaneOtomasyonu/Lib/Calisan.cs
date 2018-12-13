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
        public Calisan(string ad, string soyad) : base(ad, soyad)
        {
        }
        public decimal Tutar { get => _saatlikUcret * 8 * 20; }
        public decimal SaatlikUcret { set => _saatlikUcret = value; }
    }
}
