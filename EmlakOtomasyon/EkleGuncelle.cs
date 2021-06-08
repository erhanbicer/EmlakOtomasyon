using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using static EmlakOtomasyon.Enums;
using EmlakOtomasyon.helper;
using System.Windows.Forms;

namespace EmlakOtomasyon
{
    public partial class EkleGuncelle : Form
    {
        public EkleGuncelle()
        {
            InitializeComponent();
            init();
        }


        private void init()
        {
            tab.TabPages.Remove(summeryTab);
            tab.TabPages.Remove(apartmentTab);
            tab.TabPages.Remove(privateTab);

            evTipiCombobox.Items.Clear();
            foreach (string name in Enum.GetNames(typeof(HomeTypeEnum)))
            {
                evTipiCombobox.Items.Add(name);
            }

            evDurumuCombobox.Items.Clear();
            foreach (string name in Enum.GetNames(typeof(HomeStatus)))
            {
                evDurumuCombobox.Items.Add(name);
            }

            manzaraCombobox.Items.Clear();
            foreach (string name in Enum.GetNames(typeof(HouseView)))
            {
                manzaraCombobox.Items.Add(name);
            }

            isitmaTuruCombobox.Items.Clear();
            foreach (string name in Enum.GetNames(typeof(TypeOfHeating)))
            {
                isitmaTuruCombobox.Items.Add(name);
            }
        }

        private void IntKeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void homeTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (evTipiCombobox.Text == "Yazlık")
            {
                tab.TabPages.Clear();
                tab.TabPages.Insert(0, summeryTab);
                summeryTab.Focus();
            }
            else if (evTipiCombobox.Text == "Müstakil")
            {
                tab.TabPages.Clear();
                tab.TabPages.Insert(0, privateTab);
                privateTab.Focus();
            }
            else
            {
                tab.TabPages.Clear();
                tab.TabPages.Insert(0, apartmentTab);
                apartmentTab.Focus();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (odaSayisiTextbox.Text == "" || salonSayisiTextbox.Text == "" || isitmaTuruCombobox.Text == "" || evDurumuCombobox.Text == "" || evTipiCombobox.Text == "" || fiyatTextbox.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
                return;
            }

            try
            {
                switch (evTipiCombobox.Text)
                {
                    case "Yazlık":
                        DBHelper.getInstance().executeNonQuery(string.Format(
                        "INSERT INTO gayrimenkuller(" +
                        "durumu, tipi, isitma_turu, oda_sayisi, salon_sayisi, fiyat, is_havuz, manzara" +
                        ") values " +
                        "('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                        evDurumuCombobox.Text,
                        evTipiCombobox.Text,
                        isitmaTuruCombobox.Text,
                        Convert.ToInt32(odaSayisiTextbox.Text),
                        Convert.ToInt32(salonSayisiTextbox.Text),
                        fiyatTextbox.Text,
                        Convert.ToInt32(havuzCheck.Checked),
                        manzaraCombobox.Text
                        ));
                        break;
                    case "Müstakil":
                        DBHelper.getInstance().executeNonQuery(string.Format(
                        "insert into gayrimenkuller(" +
                        "durumu, tipi, isitma_turu, oda_sayisi, salon_sayisi, fiyat, is_garaj, is_bahce" +
                        ") values " +
                        "('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                        evDurumuCombobox.Text,
                        evTipiCombobox.Text,
                        isitmaTuruCombobox.Text,
                        Convert.ToInt32(odaSayisiTextbox.Text),
                        Convert.ToInt32(salonSayisiTextbox.Text),
                        fiyatTextbox.Text,
                        Convert.ToInt32(garajCheck.Checked),
                        Convert.ToInt32(bahceCheck.Checked)
                        ));
                        break;
                    case "Apartman":
                        DBHelper.getInstance().executeNonQuery(string.Format(
                        "insert into gayrimenkuller(" +
                        "durumu, tipi, isitma_turu, oda_sayisi, salon_sayisi, fiyat, is_balkon, kat" +
                        ") values " +
                        "('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                        evDurumuCombobox.Text,
                        evTipiCombobox.Text,
                        isitmaTuruCombobox.Text,
                        Convert.ToInt32(odaSayisiTextbox.Text),
                        Convert.ToInt32(salonSayisiTextbox.Text),
                        fiyatTextbox.Text,
                        Convert.ToInt32(balkonCheck.Checked),
                        katTextbox.Text
                        ));
                        break;
                    default:
                        break;
                }

                MessageBox.Show("Başarılı");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir sorun oluştu", "Opps!");
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
