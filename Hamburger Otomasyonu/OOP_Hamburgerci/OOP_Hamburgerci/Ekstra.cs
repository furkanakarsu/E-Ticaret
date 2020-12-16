using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgerci
{
    public class Ekstra
    {
        public string EkstraAdi { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return EkstraAdi;
        }

    }
}
