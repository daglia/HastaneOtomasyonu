using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Lib
{
    public class Personel : Calisan
    {
        public Gorevler CGorev { get; set; }
        public Personel() { }
        public Personel(string ad, string soyad, Gorevler cGorev) : base(ad, soyad)
        {
            this.CGorev = cGorev;
        }
    }
}
