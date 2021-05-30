using System;
using System.Windows.Forms;
using EmlakOtomasyon.helper;
using EmlakOtomasyon.validation;

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

            if (Validation.kullaniciAdi(kullaniciAdi))
            {
                return;
            }
            else if (Validation.sifre(sifre))
            {
                return;
            }

            try
            {
                string command = "select * from kullanicilar where kullanici_adi='" + kullaniciAdi + "' and sifre='" + sifre + "'";
                DBHelper db = DBHelper.getInstance();

                bool isLogin = db.isLogin(command);

                if (isLogin)
                {
                    MessageBox.Show("Giriş başarılı", "Giriş Başarılı");
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre", "Giriş Başarısız");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Bağlantı problemi oluştu \n" + exp.Message);
            }




            //AnaMenu anaMenu = new AnaMenu();
            //anaMenu.ShowDialog();
        }
    }
}
