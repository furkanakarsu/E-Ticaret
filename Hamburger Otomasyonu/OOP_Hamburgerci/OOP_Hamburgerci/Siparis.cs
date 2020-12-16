using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgerci
{
    public class Siparis
    {
        public Menu SeciliMenu { get; set; }
        public Boyut Boyutu { get; set; }
        public List<Ekstra> EkstraMalzemesi { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.Fiyat;

            switch (Boyutu)
            {
              
                case Boyut.Orta:
                    ToplamTutar +=  2;
                    break;
                case Boyut.Büyük:
                    ToplamTutar += 5;
                    break;
               
            }

            foreach (Ekstra ekstra in EkstraMalzemesi)
            {
                ToplamTutar += ekstra.Fiyat;
            }
            ToplamTutar = ToplamTutar * Adet;
        }

        public override string ToString()
        {
            if (EkstraMalzemesi.Count > 0)
            {
                string ekstraMalzemeler = "";
                foreach (Ekstra ekstra in EkstraMalzemesi)
                {
                    ekstraMalzemeler += ekstra.EkstraAdi + " ";

                }

                return $"{SeciliMenu.MenuAd} Menu, {Adet} Adet, {Boyutu.ToString()} Boy, ({ekstraMalzemeler}), Toplam tutar= {ToplamTutar.ToString("C2")} ";
            }
            else
            {
                return $"{SeciliMenu.MenuAd} Menu, {Adet} Adet, {Boyutu.ToString()} Boy, Toplam tutar= {ToplamTutar.ToString("C2")} ";
            }
        }

    }
}
