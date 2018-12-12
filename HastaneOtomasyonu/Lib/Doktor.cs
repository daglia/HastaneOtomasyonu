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
        public List<Hemsire> Hemsireler { get; set; } = new List<Hemsire>();

        public Doktor(string ad, string soyad, Branslar dBrans) : base(ad, soyad)
        {
            this.DBrans = dBrans;
        }

        public void MudahaleEt(Doktor doktor, DateTime mudahaleSaati)
        {
            Hemsire hemsire = new Hemsire();
            hemsire.hBrans = doktor.DBrans.ToString();
            Hemsireler.Add(hemsire);
        }

        public override string ToString()
        {
            return $"Ad: {Ad}\nSoyad: {Soyad}\nBrans: {DBrans}";
        }
    }
}
