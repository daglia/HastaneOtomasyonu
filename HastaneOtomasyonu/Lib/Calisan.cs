using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Lib
{
    public abstract class Calisan : Kisi, IMaasAlabilir
    {
        public decimal SaatlikUcret { set => throw new NotImplementedException(); }

        public decimal Tutar => throw new NotImplementedException();
    }
}
