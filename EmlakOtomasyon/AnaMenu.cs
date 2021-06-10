using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmlakOtomasyon
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            EkleGuncelle ekle = new EkleGuncelle();
            ekle.Show();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            Listele listele = new Listele();
            listele.Show();
        }

        private void AnaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
