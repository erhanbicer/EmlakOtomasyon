using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmlakOtomasyon
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            var kullaniciAdi = tb_kullanciAdi.Text;
            var sifre = tb_sifre.Text;

            
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.ShowDialog();
        }
    }
}
