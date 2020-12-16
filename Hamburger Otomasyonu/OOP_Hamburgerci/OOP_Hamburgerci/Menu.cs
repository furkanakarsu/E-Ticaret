using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgerci
{
    public class Menu
    {
        //bir menunun .....'sı olur.
        public string MenuAd { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return MenuAd + " " + Fiyat;
        }


    }
}
