using System;
using System.Windows.Forms;

namespace EmlakOtomasyon.validation
{
    class Validation
    {
        public static bool kullaniciAdi(string kullaniciAdi)
        {
            bool isValid = kullaniciAdi.Length < 3;
            if (isValid)
            {
                MessageBox.Show("Kullanici adi 3 karakterden küçük olamaz", "Kullanici Adi");
            }

            return isValid;
        }

        public static bool sifre(string sifre)
        {
            bool isValid = sifre.Length < 3;
            if (isValid)
            {
                MessageBox.Show("Şifre 6 karakterden küçük olamaz", "Şifre");
            }

            return isValid;
        }
    }
}
