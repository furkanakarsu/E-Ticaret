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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
       
        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.MenuAd = txtAd.Text;
            menu.Fiyat = nudFiyat.Value;
            MainMenu.menuListesi.Add(menu);
            MainMenu main = new MainMenu();
            this.Hide();
            main.Show();
        }
    }
}
