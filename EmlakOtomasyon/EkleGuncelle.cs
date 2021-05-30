using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using static EmlakOtomasyon.Enums;
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

            homeTypeCombobox.Items.Clear();
            foreach (string name in Enum.GetNames(typeof(HomeTypeEnum)))
            {
                homeTypeCombobox.Items.Add(name);
            }

            homeStatusCombobox.Items.Clear();
            foreach (string name in Enum.GetNames(typeof(HomeStatus)))
            {
                homeStatusCombobox.Items.Add(name);
            }

            viewCombobox.Items.Clear();
            foreach (string name in Enum.GetNames(typeof(HouseView)))
            {
                viewCombobox.Items.Add(name);
            }

            heatingCombobox.Items.Clear();
            foreach (string name in Enum.GetNames(typeof(TypeOfHeating)))
            {
                heatingCombobox.Items.Add(name);
            }
        }

        private void IntKeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void homeTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (homeTypeCombobox.Text == "Yazlık")
            {
                tab.TabPages.Clear();
                tab.TabPages.Insert(0, summeryTab);
                summeryTab.Focus();
            }
            else if (homeTypeCombobox.Text == "Müstakil")
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

            if (roomTextbox.Text == "" || loungeTextbox.Text == "" || heatingCombobox.Text == "" || homeStatusCombobox.Text == "" || homeTypeCombobox.Text == "" || priceTextbox.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
                return;
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
