namespace EmlakOtomasyon
{
    partial class EkleGuncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.odaSayisiTextbox = new System.Windows.Forms.TextBox();
            this.salonSayisiTextbox = new System.Windows.Forms.TextBox();
            this.evTipiCombobox = new System.Windows.Forms.ComboBox();
            this.roomLabel = new System.Windows.Forms.Label();
            this.loungeLabel = new System.Windows.Forms.Label();
            this.heatingLabel = new System.Windows.Forms.Label();
            this.homeTypeLabel = new System.Windows.Forms.Label();
            this.homeStatusLabel = new System.Windows.Forms.Label();
            this.fiyatTextbox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.evDurumuCombobox = new System.Windows.Forms.ComboBox();
            this.isitmaTuruCombobox = new System.Windows.Forms.ComboBox();
            this.optionOneLabel = new System.Windows.Forms.Label();
            this.optionTwoLabel = new System.Windows.Forms.Label();
            this.havuzCheck = new System.Windows.Forms.CheckBox();
            this.tab = new System.Windows.Forms.TabControl();
            this.summeryTab = new System.Windows.Forms.TabPage();
            this.manzaraCombobox = new System.Windows.Forms.ComboBox();
            this.privateTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.bahceCheck = new System.Windows.Forms.CheckBox();
            this.garajCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apartmentTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.balkonCheck = new System.Windows.Forms.CheckBox();
            this.katTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tab.SuspendLayout();
            this.summeryTab.SuspendLayout();
            this.privateTab.SuspendLayout();
            this.apartmentTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // odaSayisiTextbox
            // 
            this.odaSayisiTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.odaSayisiTextbox.Location = new System.Drawing.Point(231, 155);
            this.odaSayisiTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.odaSayisiTextbox.MaxLength = 2;
            this.odaSayisiTextbox.Multiline = true;
            this.odaSayisiTextbox.Name = "odaSayisiTextbox";
            this.odaSayisiTextbox.Size = new System.Drawing.Size(168, 27);
            this.odaSayisiTextbox.TabIndex = 4;
            this.odaSayisiTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntKeyPress);
            // 
            // salonSayisiTextbox
            // 
            this.salonSayisiTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salonSayisiTextbox.Location = new System.Drawing.Point(231, 194);
            this.salonSayisiTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.salonSayisiTextbox.MaxLength = 2;
            this.salonSayisiTextbox.Multiline = true;
            this.salonSayisiTextbox.Name = "salonSayisiTextbox";
            this.salonSayisiTextbox.Size = new System.Drawing.Size(168, 27);
            this.salonSayisiTextbox.TabIndex = 5;
            this.salonSayisiTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntKeyPress);
            // 
            // evTipiCombobox
            // 
            this.evTipiCombobox.FormattingEnabled = true;
            this.evTipiCombobox.Items.AddRange(new object[] {
            "Yazlik",
            "Apartman",
            "Mustakil"});
            this.evTipiCombobox.Location = new System.Drawing.Point(231, 80);
            this.evTipiCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.evTipiCombobox.Name = "evTipiCombobox";
            this.evTipiCombobox.Size = new System.Drawing.Size(168, 23);
            this.evTipiCombobox.TabIndex = 2;
            this.evTipiCombobox.SelectedIndexChanged += new System.EventHandler(this.evTipiCombobox_SelectedIndexChanged);
            // 
            // roomLabel
            // 
            this.roomLabel.BackColor = System.Drawing.Color.MintCream;
            this.roomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomLabel.Location = new System.Drawing.Point(131, 154);
            this.roomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(96, 28);
            this.roomLabel.TabIndex = 3;
            this.roomLabel.Text = "Oda Sayısı";
            this.roomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loungeLabel
            // 
            this.loungeLabel.BackColor = System.Drawing.Color.MintCream;
            this.loungeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loungeLabel.Location = new System.Drawing.Point(131, 193);
            this.loungeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loungeLabel.Name = "loungeLabel";
            this.loungeLabel.Size = new System.Drawing.Size(96, 28);
            this.loungeLabel.TabIndex = 3;
            this.loungeLabel.Text = "Salon Sayısı";
            this.loungeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heatingLabel
            // 
            this.heatingLabel.BackColor = System.Drawing.Color.MintCream;
            this.heatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heatingLabel.Location = new System.Drawing.Point(131, 114);
            this.heatingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heatingLabel.Name = "heatingLabel";
            this.heatingLabel.Size = new System.Drawing.Size(96, 28);
            this.heatingLabel.TabIndex = 3;
            this.heatingLabel.Text = "Isıtma Türü";
            this.heatingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeTypeLabel
            // 
            this.homeTypeLabel.BackColor = System.Drawing.Color.MintCream;
            this.homeTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeTypeLabel.Location = new System.Drawing.Point(131, 76);
            this.homeTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.homeTypeLabel.Name = "homeTypeLabel";
            this.homeTypeLabel.Size = new System.Drawing.Size(96, 28);
            this.homeTypeLabel.TabIndex = 3;
            this.homeTypeLabel.Text = "Ev Tipi";
            this.homeTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeStatusLabel
            // 
            this.homeStatusLabel.BackColor = System.Drawing.Color.MintCream;
            this.homeStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeStatusLabel.Location = new System.Drawing.Point(131, 36);
            this.homeStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.homeStatusLabel.Name = "homeStatusLabel";
            this.homeStatusLabel.Size = new System.Drawing.Size(96, 28);
            this.homeStatusLabel.TabIndex = 3;
            this.homeStatusLabel.Text = "Ev Durumu";
            this.homeStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fiyatTextbox
            // 
            this.fiyatTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fiyatTextbox.Location = new System.Drawing.Point(231, 236);
            this.fiyatTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.fiyatTextbox.MaxLength = 15;
            this.fiyatTextbox.Multiline = true;
            this.fiyatTextbox.Name = "fiyatTextbox";
            this.fiyatTextbox.Size = new System.Drawing.Size(168, 27);
            this.fiyatTextbox.TabIndex = 6;
            this.fiyatTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntKeyPress);
            // 
            // priceLabel
            // 
            this.priceLabel.BackColor = System.Drawing.Color.MintCream;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(131, 236);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(96, 28);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Fiyat";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.IndianRed;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.Azure;
            this.addButton.Location = new System.Drawing.Point(231, 281);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(111, 42);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Ekle";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // evDurumuCombobox
            // 
            this.evDurumuCombobox.FormattingEnabled = true;
            this.evDurumuCombobox.Items.AddRange(new object[] {
            "Yazlik",
            "Apartman",
            "Mustakil"});
            this.evDurumuCombobox.Location = new System.Drawing.Point(231, 40);
            this.evDurumuCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.evDurumuCombobox.Name = "evDurumuCombobox";
            this.evDurumuCombobox.Size = new System.Drawing.Size(168, 23);
            this.evDurumuCombobox.TabIndex = 1;
            // 
            // isitmaTuruCombobox
            // 
            this.isitmaTuruCombobox.FormattingEnabled = true;
            this.isitmaTuruCombobox.Items.AddRange(new object[] {
            "Kombi",
            "Soba",
            "Klima"});
            this.isitmaTuruCombobox.Location = new System.Drawing.Point(231, 118);
            this.isitmaTuruCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.isitmaTuruCombobox.Name = "isitmaTuruCombobox";
            this.isitmaTuruCombobox.Size = new System.Drawing.Size(168, 23);
            this.isitmaTuruCombobox.TabIndex = 3;
            // 
            // optionOneLabel
            // 
            this.optionOneLabel.BackColor = System.Drawing.Color.Bisque;
            this.optionOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.optionOneLabel.Location = new System.Drawing.Point(20, 50);
            this.optionOneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.optionOneLabel.Name = "optionOneLabel";
            this.optionOneLabel.Size = new System.Drawing.Size(96, 28);
            this.optionOneLabel.TabIndex = 3;
            this.optionOneLabel.Text = "Havuz";
            this.optionOneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optionTwoLabel
            // 
            this.optionTwoLabel.BackColor = System.Drawing.Color.Bisque;
            this.optionTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.optionTwoLabel.Location = new System.Drawing.Point(20, 91);
            this.optionTwoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.optionTwoLabel.Name = "optionTwoLabel";
            this.optionTwoLabel.Size = new System.Drawing.Size(96, 28);
            this.optionTwoLabel.TabIndex = 3;
            this.optionTwoLabel.Text = "Manzara";
            this.optionTwoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // havuzCheck
            // 
            this.havuzCheck.AutoSize = true;
            this.havuzCheck.Location = new System.Drawing.Point(131, 56);
            this.havuzCheck.Margin = new System.Windows.Forms.Padding(2);
            this.havuzCheck.Name = "havuzCheck";
            this.havuzCheck.Size = new System.Drawing.Size(42, 19);
            this.havuzCheck.TabIndex = 12;
            this.havuzCheck.Text = "Var";
            this.havuzCheck.UseVisualStyleBackColor = true;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.summeryTab);
            this.tab.Controls.Add(this.privateTab);
            this.tab.Controls.Add(this.apartmentTab);
            this.tab.Location = new System.Drawing.Point(418, 37);
            this.tab.Margin = new System.Windows.Forms.Padding(2);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(261, 203);
            this.tab.TabIndex = 13;
            // 
            // summeryTab
            // 
            this.summeryTab.Controls.Add(this.optionOneLabel);
            this.summeryTab.Controls.Add(this.havuzCheck);
            this.summeryTab.Controls.Add(this.optionTwoLabel);
            this.summeryTab.Controls.Add(this.manzaraCombobox);
            this.summeryTab.Location = new System.Drawing.Point(4, 24);
            this.summeryTab.Margin = new System.Windows.Forms.Padding(2);
            this.summeryTab.Name = "summeryTab";
            this.summeryTab.Padding = new System.Windows.Forms.Padding(2);
            this.summeryTab.Size = new System.Drawing.Size(253, 175);
            this.summeryTab.TabIndex = 0;
            this.summeryTab.Text = "Yazlık";
            this.summeryTab.UseVisualStyleBackColor = true;
            // 
            // manzaraCombobox
            // 
            this.manzaraCombobox.FormattingEnabled = true;
            this.manzaraCombobox.Items.AddRange(new object[] {
            "Yazlik",
            "Apartman",
            "Mustakil"});
            this.manzaraCombobox.Location = new System.Drawing.Point(131, 95);
            this.manzaraCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.manzaraCombobox.Name = "manzaraCombobox";
            this.manzaraCombobox.Size = new System.Drawing.Size(107, 23);
            this.manzaraCombobox.TabIndex = 5;
            // 
            // privateTab
            // 
            this.privateTab.Controls.Add(this.label2);
            this.privateTab.Controls.Add(this.bahceCheck);
            this.privateTab.Controls.Add(this.garajCheck);
            this.privateTab.Controls.Add(this.label3);
            this.privateTab.Location = new System.Drawing.Point(4, 24);
            this.privateTab.Margin = new System.Windows.Forms.Padding(2);
            this.privateTab.Name = "privateTab";
            this.privateTab.Padding = new System.Windows.Forms.Padding(2);
            this.privateTab.Size = new System.Drawing.Size(253, 175);
            this.privateTab.TabIndex = 1;
            this.privateTab.Text = "Müstakil";
            this.privateTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Bisque;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Garaj ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bahceCheck
            // 
            this.bahceCheck.AutoSize = true;
            this.bahceCheck.Location = new System.Drawing.Point(131, 97);
            this.bahceCheck.Margin = new System.Windows.Forms.Padding(2);
            this.bahceCheck.Name = "bahceCheck";
            this.bahceCheck.Size = new System.Drawing.Size(42, 19);
            this.bahceCheck.TabIndex = 16;
            this.bahceCheck.Text = "Var";
            this.bahceCheck.UseVisualStyleBackColor = true;
            // 
            // garajCheck
            // 
            this.garajCheck.AutoSize = true;
            this.garajCheck.Location = new System.Drawing.Point(131, 56);
            this.garajCheck.Margin = new System.Windows.Forms.Padding(2);
            this.garajCheck.Name = "garajCheck";
            this.garajCheck.Size = new System.Drawing.Size(42, 19);
            this.garajCheck.TabIndex = 16;
            this.garajCheck.Text = "Var";
            this.garajCheck.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Bisque;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "Bahçe";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // apartmentTab
            // 
            this.apartmentTab.Controls.Add(this.label4);
            this.apartmentTab.Controls.Add(this.balkonCheck);
            this.apartmentTab.Controls.Add(this.katTextbox);
            this.apartmentTab.Controls.Add(this.label5);
            this.apartmentTab.Location = new System.Drawing.Point(4, 24);
            this.apartmentTab.Margin = new System.Windows.Forms.Padding(2);
            this.apartmentTab.Name = "apartmentTab";
            this.apartmentTab.Padding = new System.Windows.Forms.Padding(2);
            this.apartmentTab.Size = new System.Drawing.Size(253, 175);
            this.apartmentTab.TabIndex = 2;
            this.apartmentTab.Text = "Apartman";
            this.apartmentTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Bisque;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Balkon";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // balkonCheck
            // 
            this.balkonCheck.AutoSize = true;
            this.balkonCheck.Location = new System.Drawing.Point(131, 56);
            this.balkonCheck.Margin = new System.Windows.Forms.Padding(2);
            this.balkonCheck.Name = "balkonCheck";
            this.balkonCheck.Size = new System.Drawing.Size(42, 19);
            this.balkonCheck.TabIndex = 20;
            this.balkonCheck.Text = "Var";
            this.balkonCheck.UseVisualStyleBackColor = true;
            // 
            // katTextbox
            // 
            this.katTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.katTextbox.Location = new System.Drawing.Point(131, 95);
            this.katTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.katTextbox.MaxLength = 2;
            this.katTextbox.Multiline = true;
            this.katTextbox.Name = "katTextbox";
            this.katTextbox.PlaceholderText = "Kat Sayısı";
            this.katTextbox.Size = new System.Drawing.Size(68, 27);
            this.katTextbox.TabIndex = 17;
            this.katTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntKeyPress);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Bisque;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "Kat";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EkleGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(758, 378);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.homeStatusLabel);
            this.Controls.Add(this.homeTypeLabel);
            this.Controls.Add(this.heatingLabel);
            this.Controls.Add(this.loungeLabel);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.isitmaTuruCombobox);
            this.Controls.Add(this.evDurumuCombobox);
            this.Controls.Add(this.evTipiCombobox);
            this.Controls.Add(this.fiyatTextbox);
            this.Controls.Add(this.salonSayisiTextbox);
            this.Controls.Add(this.odaSayisiTextbox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EkleGuncelle";
            this.Text = "Emlak Otomasyonu";
            this.Load += new System.EventHandler(this.EkleGuncelle_Load);
            this.tab.ResumeLayout(false);
            this.summeryTab.ResumeLayout(false);
            this.summeryTab.PerformLayout();
            this.privateTab.ResumeLayout(false);
            this.privateTab.PerformLayout();
            this.apartmentTab.ResumeLayout(false);
            this.apartmentTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox odaSayisiTextbox;
        private System.Windows.Forms.TextBox salonSayisiTextbox;
        private System.Windows.Forms.ComboBox evTipiCombobox;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label loungeLabel;
        private System.Windows.Forms.Label heatingLabel;
        private System.Windows.Forms.Label homeTypeLabel;
        private System.Windows.Forms.Label homeStatusLabel;
        private System.Windows.Forms.TextBox fiyatTextbox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox evDurumuCombobox;
        private System.Windows.Forms.ComboBox isitmaTuruCombobox;
        private System.Windows.Forms.Label optionOneLabel;
        private System.Windows.Forms.Label optionTwoLabel;
        private System.Windows.Forms.CheckBox havuzCheck;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage summeryTab;
        private System.Windows.Forms.TabPage privateTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox garajCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage apartmentTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox balkonCheck;
        private System.Windows.Forms.TextBox katTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox bahceCheck;
        private System.Windows.Forms.ComboBox manzaraCombobox;
    }
}

