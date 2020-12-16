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
    public partial class EkstraForm : Form
    {
        public EkstraForm()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MainMenu.ekstraListesi.Add(new Ekstra { EkstraAdi = txtAd.Text, Fiyat = nudFiyat.Value });
            this.Hide();
            MainMenu main = new MainMenu();
            main.Show();
        }
    }
}
