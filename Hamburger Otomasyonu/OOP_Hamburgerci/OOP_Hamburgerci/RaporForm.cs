using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci
{
    public partial class RaporForm : Form
    {
        public RaporForm()
        {
            InitializeComponent();
        }

        private void RaporForm_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal ekstraMalzemeGeliri = 0;
            int satisAdet = 0;
            foreach (Siparis siparis in MainMenu.siparisListesi)
            {
                if (siparis.Adet > 1)
                {
                    foreach (Ekstra ekstra in siparis.EkstraMalzemesi)
                    {
                        ekstraMalzemeGeliri += ekstra.Fiyat*siparis.Adet;
                    }
                }
                else
                {
                    foreach (Ekstra ekstra in siparis.EkstraMalzemesi)
                    {
                        ekstraMalzemeGeliri += ekstra.Fiyat;
                    }
                }
                ciro += siparis.ToplamTutar;
                
                satisAdet += siparis.Adet;
                listBox1.Items.Add(siparis);
            }

            lblCiro.Text = ciro.ToString("C2");
            lblEkstraGelir.Text = ekstraMalzemeGeliri.ToString("C2");
            lblMenuAdet.Text = satisAdet.ToString();
            lblSiparisSayisi.Text = listBox1.Items.Count.ToString();
        }
    }
}
