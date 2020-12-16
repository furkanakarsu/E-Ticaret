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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public static List<Siparis> siparisListesi = new List<Siparis>();

       public static List<Menu> menuListesi = new List<Menu>()
        {
            new Menu{MenuAd="Whooper",Fiyat=10},
            new Menu{MenuAd="BigMac",Fiyat=15},
            new Menu{MenuAd="Chicken",Fiyat=10}

        };

       public static List<Ekstra> ekstraListesi = new List<Ekstra>()
        {
            new Ekstra{EkstraAdi="Hardal",Fiyat=0.5m},
            new Ekstra{EkstraAdi="Ketçap",Fiyat=0.5m},
            new Ekstra{EkstraAdi="Ranch",Fiyat=1},
            new Ekstra{EkstraAdi="BBQ",Fiyat=1.5m},
            new Ekstra{EkstraAdi="Buffalo",Fiyat=2},
            new Ekstra{EkstraAdi="Mayonez",Fiyat=0.5m}
        };
        private void MainMenu_Load(object sender, EventArgs e)
        {
            foreach (Menu menu in menuListesi)
            {
                cmbMenu.Items.Add(menu);
            }

            foreach (Ekstra ekstra in ekstraListesi)
            {
                CheckBox chk = new CheckBox();
                chk.Text = ekstra.EkstraAdi;
                chk.Tag = ekstra;
                flowLayoutPanel1.Controls.Add(chk);
            }

           
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenu = (Menu)cmbMenu.SelectedItem;
            if (rbKucuk.Checked)
            {
                yeniSiparis.Boyutu = Boyut.Küçük;
            }
            else if (rbOrta.Checked)
            {
                yeniSiparis.Boyutu = Boyut.Orta;
            }
            else
            {
                yeniSiparis.Boyutu = Boyut.Büyük;
            }

            yeniSiparis.EkstraMalzemesi = new List<Ekstra>();
            foreach (CheckBox chk in flowLayoutPanel1.Controls)
            {
                if (chk.Checked)
                {
                    yeniSiparis.EkstraMalzemesi.Add((Ekstra)chk.Tag);
                }
            }

            yeniSiparis.Adet = Convert.ToInt32(nudAdet.Value);
            yeniSiparis.Hesapla();
            listBox1.Items.Add(yeniSiparis);
            TutarHesapla();
            siparisListesi.Add(yeniSiparis);
        }

        public decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                Siparis gelen = (Siparis)listBox1.Items[i];
                toplamTutar += gelen.ToplamTutar;
            }
            lblToplamTutar.Text = toplamTutar.ToString("C2");
            return toplamTutar;
        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Toplam Sipariş Ücret:{TutarHesapla()}\nsiparişi tamamlamak istiyor musunuz?","Sipariş Tamamla",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Sipariş Alındı");
                Temizle();
            }
            else
            {
                MessageBox.Show("İptal Edildi");
            }
        }

        public void Temizle()
        {
            //temizle işlemi yapılacak.
        }

        private void btnMenıOlustur_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();

        }

        private void btnEkstraOlustur_Click(object sender, EventArgs e)
        {
            this.Hide();
            EkstraForm ekstraForm = new EkstraForm();
            ekstraForm.Show();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            RaporForm raporForm = new RaporForm();
            raporForm.Show();
        }
    }
}
