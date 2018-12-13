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

        public Doktor() { }
        public Doktor(string ad, string soyad, Branslar dBrans) : base(ad, soyad)
        {
            this.DBrans = dBrans;
        }

        public void MudahaleEt(Hasta hasta, DateTime mudahaleSaati)
        {
            Doktor doktor = new Doktor();
            Hemsire hemsire = new Hemsire();
            hemsire.hBrans = doktor.DBrans.ToString();
            Hemsireler.Add(hemsire);
        }

        public override string ToString()
        {
            return $"{DBrans} - Dr. {Ad} {Soyad}";
        }
    }
}
