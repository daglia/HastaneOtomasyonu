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
        public List<Hasta> Hastalar { get; set; } = new List<Hasta>();
        public List<DateTime> MudahaleSaati { get; set; } = new List<DateTime>();

        public Doktor() { }

        public void MudahaleEt(Hasta hasta, DateTime mudahaleSaati)
        {
            Doktor doktor = new Doktor();
            Hemsire hemsire = new Hemsire();
            hemsire.HBrans = doktor.DBrans;
            Hemsireler.Add(hemsire);
            hasta._mudahaleSaati = mudahaleSaati;
            Hastalar.Add(hasta);
            MudahaleSaati.Add(mudahaleSaati);
        }

        public override string ToString()
        {
            return $"{DBrans} - Dr. {Ad} {Soyad}";
        }
    }
}
