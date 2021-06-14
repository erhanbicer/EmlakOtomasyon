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
using EmlakOtomasyon.model;

namespace EmlakOtomasyon
{
    public partial class EkleGuncelle : Form
    {
        public EkleGuncelle()
        {
            InitializeComponent();
            init();
        }

        int _id;
        Listele listele;
        public EkleGuncelle(int id, Listele listele)
        {
            _id = id;
            this.listele = listele;
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
            foreach (string name in Enum.GetNames(typeof(Manzara)))
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


        private void evTipiCombobox_SelectedIndexChanged(object sender, EventArgs e)
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
                string query = "";
                switch (evTipiCombobox.Text)
                {
                    case "Yazlık":

                        if(manzaraCombobox.Text == "")
                        {
                            MessageBox.Show("Lütfen Manzara alanını boş bırakmayınız.");
                            return;
                        }

                        if (_id > 0)
                        {
                            query = "UPDATE gayrimenkuller SET durumu ='{0}', tipi='{1}', isitma_turu = '{2}', oda_sayisi ='{3}', salon_sayisi='{4}', fiyat = '{5}', is_havuz = '{6}', manzara = '{7}', is_garaj = '{8}', is_bahce = '{9}', is_balkon = '{10}', kat = '{11}' WHERE Id = " + _id;
                        }
                        else
                        {
                            query = "INSERT INTO gayrimenkuller(durumu, tipi, isitma_turu, oda_sayisi, salon_sayisi, fiyat, is_havuz, manzara, is_garaj, is_bahce, is_balkon, kat) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')";
                        }

                        DBHelper.getInstance().executeNonQuery(string.Format(
                                                query,
                                                evDurumuCombobox.Text,
                                                evTipiCombobox.Text,
                                                isitmaTuruCombobox.Text,
                                                Convert.ToInt32(odaSayisiTextbox.Text),
                                                Convert.ToInt32(salonSayisiTextbox.Text),
                                                fiyatTextbox.Text,
                                                Convert.ToInt32(havuzCheck.Checked),
                                                manzaraCombobox.Text,
                                                null, null, null, null
                                                ));
                        break;
                    case "Müstakil":

                        if (_id > 0)
                        {
                            query = "UPDATE gayrimenkuller SET durumu ='{0}', tipi='{1}', isitma_turu = '{2}', oda_sayisi ='{3}', salon_sayisi='{4}', fiyat = '{5}', is_garaj = '{6}', is_bahce = '{7}', is_havuz = '{8}', manzara = '{9}', is_balkon = '{10}', kat = '{11}' WHERE Id = " + _id;
                        }
                        else
                        {
                            query = "insert into gayrimenkuller(durumu, tipi, isitma_turu, oda_sayisi, salon_sayisi, fiyat, is_garaj, is_bahce, is_havuz, manzara, is_balkon, kat) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}','{9}','{10}','{11}')";
                        }
                        DBHelper.getInstance().executeNonQuery(string.Format(
                                                query,
                                                evDurumuCombobox.Text,
                                                evTipiCombobox.Text,
                                                isitmaTuruCombobox.Text,
                                                Convert.ToInt32(odaSayisiTextbox.Text),
                                                Convert.ToInt32(salonSayisiTextbox.Text),
                                                fiyatTextbox.Text,
                                                Convert.ToInt32(garajCheck.Checked),
                                                Convert.ToInt32(bahceCheck.Checked),
                                                null, null, null, null
                                                ));
                        break;
                    case "Apartman":

                        if (_id > 0)
                        {
                            query = "UPDATE gayrimenkuller SET durumu ='{0}', tipi='{1}', isitma_turu = '{2}', oda_sayisi ='{3}', salon_sayisi='{4}', fiyat = '{5}', is_balkon = '{6}', kat = '{7}', is_garaj = '{8}', is_bahce = '{9}', is_havuz = '{10}', manzara = '{11}' WHERE Id = " + _id;
                        }
                        else
                        {
                            query = "insert into gayrimenkuller(durumu, tipi, isitma_turu, oda_sayisi, salon_sayisi, fiyat, is_balkon, kat,is_garaj, is_bahce, is_havuz, manzara) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')";
                        }

                        DBHelper.getInstance().executeNonQuery(string.Format(
                                                query,
                                                evDurumuCombobox.Text,
                                                evTipiCombobox.Text,
                                                isitmaTuruCombobox.Text,
                                                Convert.ToInt32(odaSayisiTextbox.Text),
                                                Convert.ToInt32(salonSayisiTextbox.Text),
                                                fiyatTextbox.Text,
                                                Convert.ToInt32(balkonCheck.Checked),
                                                katTextbox.Text,
                                                null, null, null, null
                                                ));
                        break;
                    default:
                        break;
                }

                if (_id > 0)
                {
                    this.listele.listele();
                }
                MessageBox.Show("Başarılı");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir sorun oluştu", "Opps!");
            }
        }

        private void EkleGuncelle_Load(object sender, EventArgs e)
        {
            if (this._id > 0)
            {
                this.addButton.Text = "Güncelle";
                var a = DBHelper.getInstance().executeSingleGayrimenkulRowReader("SELECT * FROM gayrimenkuller where Id = " + _id);
                evDurumuCombobox.SelectedItem = a.Durumu.ToString();
                evTipiCombobox.SelectedItem = a.Tipi.ToString();
                isitmaTuruCombobox.SelectedItem = a.IsitmaTipi.ToString();
                odaSayisiTextbox.Text = a.Oda.ToString();
                salonSayisiTextbox.Text = a.Salon.ToString();
                fiyatTextbox.Text = a.Fiyat;
                switch (a.Tipi)
                {
                    case HomeTypeEnum.Apartman:
                        katTextbox.Text = (a as ApartmanDairesi).Kat.ToString();
                        balkonCheck.Checked = (a as ApartmanDairesi).Balkon;
                        break;
                    case HomeTypeEnum.Müstakil:
                        garajCheck.Checked = (a as MustakilEv).Garaj;
                        bahceCheck.Checked = (a as MustakilEv).Bahce;
                        break;
                    case HomeTypeEnum.Yazlık:
                        manzaraCombobox.SelectedItem = (a as YazlikEv).Manzara.ToString();
                        havuzCheck.Checked = (a as YazlikEv).Havuz;
                        break;
                }
            }
        }
    }
}
