using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Lib
{
    public interface IMaasAlabilir
    {
        decimal SaatlikUcret { set; }
        decimal Tutar { get; }
    }
}
