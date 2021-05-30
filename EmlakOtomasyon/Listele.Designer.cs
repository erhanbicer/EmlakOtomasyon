
namespace EmlakOtomasyon
{
    partial class Listele
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
            this.tab = new System.Windows.Forms.TabControl();
            this.summeryTab = new System.Windows.Forms.TabPage();
            this.optionOneLabel = new System.Windows.Forms.Label();
            this.poolCheck = new System.Windows.Forms.CheckBox();
            this.optionTwoLabel = new System.Windows.Forms.Label();
            this.viewCombobox = new System.Windows.Forms.ComboBox();
            this.privateTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.gardenCheck = new System.Windows.Forms.CheckBox();
            this.garageCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apartmentTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.balconyCheck = new System.Windows.Forms.CheckBox();
            this.floorTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.homeStatusLabel = new System.Windows.Forms.Label();
            this.homeTypeLabel = new System.Windows.Forms.Label();
            this.heatingLabel = new System.Windows.Forms.Label();
            this.loungeLabel = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.heatingCombobox = new System.Windows.Forms.ComboBox();
            this.homeStatusCombobox = new System.Windows.Forms.ComboBox();
            this.homeTypeCombobox = new System.Windows.Forms.ComboBox();
            this.priceTextbox = new System.Windows.Forms.TextBox();
            this.loungeTextbox = new System.Windows.Forms.TextBox();
            this.roomTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.summeryTab.SuspendLayout();
            this.privateTab.SuspendLayout();
            this.apartmentTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.summeryTab);
            this.tab.Controls.Add(this.privateTab);
            this.tab.Controls.Add(this.apartmentTab);
            this.tab.Location = new System.Drawing.Point(401, 47);
            this.tab.Margin = new System.Windows.Forms.Padding(2);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(261, 203);
            this.tab.TabIndex = 27;
            // 
            // summeryTab
            // 
            this.summeryTab.Controls.Add(this.optionOneLabel);
            this.summeryTab.Controls.Add(this.poolCheck);
            this.summeryTab.Controls.Add(this.optionTwoLabel);
            this.summeryTab.Controls.Add(this.viewCombobox);
            this.summeryTab.Location = new System.Drawing.Point(4, 24);
            this.summeryTab.Margin = new System.Windows.Forms.Padding(2);
            this.summeryTab.Name = "summeryTab";
            this.summeryTab.Padding = new System.Windows.Forms.Padding(2);
            this.summeryTab.Size = new System.Drawing.Size(253, 175);
            this.summeryTab.TabIndex = 0;
            this.summeryTab.Text = "Yazlık";
            this.summeryTab.UseVisualStyleBackColor = true;
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
            // poolCheck
            // 
            this.poolCheck.AutoSize = true;
            this.poolCheck.Location = new System.Drawing.Point(133, 58);
            this.poolCheck.Margin = new System.Windows.Forms.Padding(2);
            this.poolCheck.Name = "poolCheck";
            this.poolCheck.Size = new System.Drawing.Size(42, 19);
            this.poolCheck.TabIndex = 12;
            this.poolCheck.Text = "Var";
            this.poolCheck.UseVisualStyleBackColor = true;
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
            // viewCombobox
            // 
            this.viewCombobox.FormattingEnabled = true;
            this.viewCombobox.Items.AddRange(new object[] {
            "Yazlik",
            "Apartman",
            "Mustakil"});
            this.viewCombobox.Location = new System.Drawing.Point(131, 95);
            this.viewCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.viewCombobox.Name = "viewCombobox";
            this.viewCombobox.Size = new System.Drawing.Size(107, 23);
            this.viewCombobox.TabIndex = 5;
            // 
            // privateTab
            // 
            this.privateTab.Controls.Add(this.label2);
            this.privateTab.Controls.Add(this.gardenCheck);
            this.privateTab.Controls.Add(this.garageCheck);
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
            // gardenCheck
            // 
            this.gardenCheck.AutoSize = true;
            this.gardenCheck.Location = new System.Drawing.Point(133, 99);
            this.gardenCheck.Margin = new System.Windows.Forms.Padding(2);
            this.gardenCheck.Name = "gardenCheck";
            this.gardenCheck.Size = new System.Drawing.Size(42, 19);
            this.gardenCheck.TabIndex = 16;
            this.gardenCheck.Text = "Var";
            this.gardenCheck.UseVisualStyleBackColor = true;
            // 
            // garageCheck
            // 
            this.garageCheck.AutoSize = true;
            this.garageCheck.Location = new System.Drawing.Point(133, 58);
            this.garageCheck.Margin = new System.Windows.Forms.Padding(2);
            this.garageCheck.Name = "garageCheck";
            this.garageCheck.Size = new System.Drawing.Size(42, 19);
            this.garageCheck.TabIndex = 16;
            this.garageCheck.Text = "Var";
            this.garageCheck.UseVisualStyleBackColor = true;
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
            this.apartmentTab.Controls.Add(this.balconyCheck);
            this.apartmentTab.Controls.Add(this.floorTextbox);
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
            // balconyCheck
            // 
            this.balconyCheck.AutoSize = true;
            this.balconyCheck.Location = new System.Drawing.Point(133, 58);
            this.balconyCheck.Margin = new System.Windows.Forms.Padding(2);
            this.balconyCheck.Name = "balconyCheck";
            this.balconyCheck.Size = new System.Drawing.Size(42, 19);
            this.balconyCheck.TabIndex = 20;
            this.balconyCheck.Text = "Var";
            this.balconyCheck.UseVisualStyleBackColor = true;
            // 
            // floorTextbox
            // 
            this.floorTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.floorTextbox.Location = new System.Drawing.Point(131, 95);
            this.floorTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.floorTextbox.MaxLength = 2;
            this.floorTextbox.Multiline = true;
            this.floorTextbox.Name = "floorTextbox";
            this.floorTextbox.Size = new System.Drawing.Size(42, 27);
            this.floorTextbox.TabIndex = 17;
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
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.IndianRed;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.Azure;
            this.addButton.Location = new System.Drawing.Point(200, 287);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(111, 42);
            this.addButton.TabIndex = 26;
            this.addButton.Text = "Filtrele";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // priceLabel
            // 
            this.priceLabel.BackColor = System.Drawing.Color.MintCream;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(114, 246);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(96, 28);
            this.priceLabel.TabIndex = 16;
            this.priceLabel.Text = "Fiyat";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeStatusLabel
            // 
            this.homeStatusLabel.BackColor = System.Drawing.Color.MintCream;
            this.homeStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeStatusLabel.Location = new System.Drawing.Point(114, 46);
            this.homeStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.homeStatusLabel.Name = "homeStatusLabel";
            this.homeStatusLabel.Size = new System.Drawing.Size(96, 28);
            this.homeStatusLabel.TabIndex = 17;
            this.homeStatusLabel.Text = "Ev Durumu";
            this.homeStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeTypeLabel
            // 
            this.homeTypeLabel.BackColor = System.Drawing.Color.MintCream;
            this.homeTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeTypeLabel.Location = new System.Drawing.Point(114, 86);
            this.homeTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.homeTypeLabel.Name = "homeTypeLabel";
            this.homeTypeLabel.Size = new System.Drawing.Size(96, 28);
            this.homeTypeLabel.TabIndex = 18;
            this.homeTypeLabel.Text = "Ev Tipi";
            this.homeTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heatingLabel
            // 
            this.heatingLabel.BackColor = System.Drawing.Color.MintCream;
            this.heatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heatingLabel.Location = new System.Drawing.Point(114, 124);
            this.heatingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heatingLabel.Name = "heatingLabel";
            this.heatingLabel.Size = new System.Drawing.Size(96, 28);
            this.heatingLabel.TabIndex = 19;
            this.heatingLabel.Text = "Isıtma Türü";
            this.heatingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loungeLabel
            // 
            this.loungeLabel.BackColor = System.Drawing.Color.MintCream;
            this.loungeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loungeLabel.Location = new System.Drawing.Point(114, 203);
            this.loungeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loungeLabel.Name = "loungeLabel";
            this.loungeLabel.Size = new System.Drawing.Size(96, 28);
            this.loungeLabel.TabIndex = 20;
            this.loungeLabel.Text = "Salon Sayısı";
            this.loungeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomLabel
            // 
            this.roomLabel.BackColor = System.Drawing.Color.MintCream;
            this.roomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomLabel.Location = new System.Drawing.Point(114, 164);
            this.roomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(96, 28);
            this.roomLabel.TabIndex = 21;
            this.roomLabel.Text = "Oda Sayısı";
            this.roomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heatingCombobox
            // 
            this.heatingCombobox.FormattingEnabled = true;
            this.heatingCombobox.Items.AddRange(new object[] {
            "Yazlik",
            "Apartman",
            "Mustakil"});
            this.heatingCombobox.Location = new System.Drawing.Point(214, 128);
            this.heatingCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.heatingCombobox.Name = "heatingCombobox";
            this.heatingCombobox.Size = new System.Drawing.Size(168, 23);
            this.heatingCombobox.TabIndex = 22;
            // 
            // homeStatusCombobox
            // 
            this.homeStatusCombobox.FormattingEnabled = true;
            this.homeStatusCombobox.Items.AddRange(new object[] {
            "Yazlik",
            "Apartman",
            "Mustakil"});
            this.homeStatusCombobox.Location = new System.Drawing.Point(214, 50);
            this.homeStatusCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.homeStatusCombobox.Name = "homeStatusCombobox";
            this.homeStatusCombobox.Size = new System.Drawing.Size(168, 23);
            this.homeStatusCombobox.TabIndex = 14;
            // 
            // homeTypeCombobox
            // 
            this.homeTypeCombobox.FormattingEnabled = true;
            this.homeTypeCombobox.Items.AddRange(new object[] {
            "Yazlik",
            "Apartman",
            "Mustakil"});
            this.homeTypeCombobox.Location = new System.Drawing.Point(214, 90);
            this.homeTypeCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.homeTypeCombobox.Name = "homeTypeCombobox";
            this.homeTypeCombobox.Size = new System.Drawing.Size(168, 23);
            this.homeTypeCombobox.TabIndex = 15;
            // 
            // priceTextbox
            // 
            this.priceTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceTextbox.Location = new System.Drawing.Point(214, 246);
            this.priceTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.priceTextbox.MaxLength = 15;
            this.priceTextbox.Multiline = true;
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Size = new System.Drawing.Size(168, 27);
            this.priceTextbox.TabIndex = 25;
            // 
            // loungeTextbox
            // 
            this.loungeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loungeTextbox.Location = new System.Drawing.Point(214, 204);
            this.loungeTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.loungeTextbox.MaxLength = 2;
            this.loungeTextbox.Multiline = true;
            this.loungeTextbox.Name = "loungeTextbox";
            this.loungeTextbox.Size = new System.Drawing.Size(168, 27);
            this.loungeTextbox.TabIndex = 24;
            // 
            // roomTextbox
            // 
            this.roomTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomTextbox.Location = new System.Drawing.Point(214, 165);
            this.roomTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.roomTextbox.MaxLength = 2;
            this.roomTextbox.Multiline = true;
            this.roomTextbox.Name = "roomTextbox";
            this.roomTextbox.Size = new System.Drawing.Size(168, 27);
            this.roomTextbox.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Azure;
            this.button1.Location = new System.Drawing.Point(349, 287);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 42);
            this.button1.TabIndex = 26;
            this.button1.Text = "Hepsini Listele";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Azure;
            this.button2.Location = new System.Drawing.Point(496, 287);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 42);
            this.button2.TabIndex = 26;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(118, 348);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(544, 236);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Azure;
            this.button3.Location = new System.Drawing.Point(551, 608);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 42);
            this.button3.TabIndex = 26;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.IndianRed;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Azure;
            this.button4.Location = new System.Drawing.Point(410, 608);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 42);
            this.button4.TabIndex = 26;
            this.button4.Text = "Sil";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.homeStatusLabel);
            this.Controls.Add(this.homeTypeLabel);
            this.Controls.Add(this.heatingLabel);
            this.Controls.Add(this.loungeLabel);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.heatingCombobox);
            this.Controls.Add(this.homeStatusCombobox);
            this.Controls.Add(this.homeTypeCombobox);
            this.Controls.Add(this.priceTextbox);
            this.Controls.Add(this.loungeTextbox);
            this.Controls.Add(this.roomTextbox);
            this.Name = "Listele";
            this.Text = "Listele";
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

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage summeryTab;
        private System.Windows.Forms.Label optionOneLabel;
        private System.Windows.Forms.CheckBox poolCheck;
        private System.Windows.Forms.Label optionTwoLabel;
        private System.Windows.Forms.ComboBox viewCombobox;
        private System.Windows.Forms.TabPage privateTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox gardenCheck;
        private System.Windows.Forms.CheckBox garageCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage apartmentTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox balconyCheck;
        private System.Windows.Forms.TextBox floorTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label homeStatusLabel;
        private System.Windows.Forms.Label homeTypeLabel;
        private System.Windows.Forms.Label heatingLabel;
        private System.Windows.Forms.Label loungeLabel;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.ComboBox heatingCombobox;
        private System.Windows.Forms.ComboBox homeStatusCombobox;
        private System.Windows.Forms.ComboBox homeTypeCombobox;
        private System.Windows.Forms.TextBox priceTextbox;
        private System.Windows.Forms.TextBox loungeTextbox;
        private System.Windows.Forms.TextBox roomTextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}