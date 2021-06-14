using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static EmlakOtomasyon.Enums;
using EmlakOtomasyon.helper;

namespace EmlakOtomasyon
{
    public partial class Listele : Form
    {
        string SHORT_GAYRIMENKUL = "Id as 'Ilan No', durumu as 'Ev Durumu', tipi as 'Evin Tipi', isitma_turu as 'Isıtma Türü', oda_sayisi as 'Oda Sayısı', salon_sayisi as 'Salon Sayısı', fiyat as Fiyat, is_havuz as 'Havuzlu', manzara as Manzara, is_garaj as 'Garaj', is_bahce as 'Bahçe', is_balkon as Balkonlu, kat as Kat";
        public Listele()
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
            foreach (string name in Enum.GetNames(typeof(Manzara)))
            {
                manzaraCombobox.Items.Add(name);
            }

            isitmaTuruCombobox.Items.Clear();
            foreach (string name in Enum.GetNames(typeof(TypeOfHeating)))
            {
                isitmaTuruCombobox.Items.Add(name);
            }
            listele();
        }

        public void listele()
        {
            dataGridView1.DataSource = DBHelper.getInstance().executeDataTable("select " + SHORT_GAYRIMENKUL + " from gayrimenkuller");
        }

        private void filtreleButton_Click(object sender, EventArgs e)
        {
            var queryBuilder = "";
            if(evDurumuCombobox.SelectedIndex >= 0)
            {
                queryBuilder += string.Format(" AND durumu = '{0}'", evDurumuCombobox.SelectedItem.ToString());
            }

            if (evTipiCombobox.SelectedIndex >= 0)
            {
                switch (evTipiCombobox.SelectedItem.ToString())
                {
                    case "Apartman":
                            if(katTextbox.Text.ToString() != "")
                            {
                                queryBuilder += string.Format(" AND kat = {0}", Convert.ToInt32(katTextbox.Text.ToString()));
                            }

                            if (balkonCheck.Checked)
                            {
                                queryBuilder += string.Format(" AND is_balkon = {0}", Convert.ToByte(balkonCheck.Checked));
                            }
                        break;
                    case "Müstakil":
                            if (garajCheck.Checked)
                            {
                                queryBuilder += string.Format(" AND is_garaj = {0}", Convert.ToByte(garajCheck.Checked));
                            }

                            if (bahceCheck.Checked)
                            {
                                queryBuilder += string.Format(" AND is_bahce = {0}", Convert.ToByte(bahceCheck.Checked));
                            }
                        break;
                    case "Yazlık":
                        if (manzaraCombobox.SelectedIndex >= 0)
                        {
                            queryBuilder += string.Format(" AND manzara = '{0}'", manzaraCombobox.SelectedItem.ToString());
                        }

                        if (havuzCheck.Checked)
                        {
                            queryBuilder += string.Format(" AND is_havuz = {0}", Convert.ToByte(havuzCheck.Checked));
                        }
                        break;
                }
                queryBuilder += string.Format(" AND tipi = '{0}'", evTipiCombobox.SelectedItem.ToString());
            }

            if (isitmaTuruCombobox.SelectedIndex >= 0)
            {
                queryBuilder += string.Format(" AND isitma_turu = '{0}'", isitmaTuruCombobox.SelectedItem.ToString());
            }

            if (odaSayisiTextbox.Text.ToString() != "")
            {
                queryBuilder += string.Format(" AND oda_sayisi = {0}", Convert.ToInt32(odaSayisiTextbox.Text.ToString()));
            }

            if (salonSayisiTextbox.Text.ToString() != "")
            {
                queryBuilder += string.Format(" AND salon_sayisi = {0}", Convert.ToInt32(salonSayisiTextbox.Text.ToString()));
            }

            if (fiyatTextbox.Text.ToString() != "")
            {
                queryBuilder += string.Format(" AND fiyat = '{0}'", fiyatTextbox.Text.ToString());
            }

            dataGridView1.DataSource = DBHelper.getInstance().executeDataTable(string.Format("select "+ SHORT_GAYRIMENKUL +" from gayrimenkuller where 1=1 {0}", queryBuilder));
        }

        private void hepsiniListeleButton_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            evDurumuCombobox.ResetText();
            evTipiCombobox.ResetText();
            isitmaTuruCombobox.ResetText();
            odaSayisiTextbox.ResetText();
            salonSayisiTextbox.ResetText();
            fiyatTextbox.ResetText();
            havuzCheck.ResetText();
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            int id;

            Int32.TryParse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), out id);

            if (id > 0)
            { 
                try
                {
                    DBHelper.getInstance().executeNonQuery("DELETE FROM gayrimenkuller WHERE Id = " + id);
                    listele();
                    MessageBox.Show("Başarılı");
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata oluştu...");
                }
            } else {
                MessageBox.Show("Lütfen gayrimenkul seçiniz...");
            }
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = (int) dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            EkleGuncelle frm = new EkleGuncelle(id, this);
            frm.ShowDialog();
        }
    }
}
