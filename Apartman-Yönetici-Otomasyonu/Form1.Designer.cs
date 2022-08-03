namespace Apartman_Yönetici_Otomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.binaadı = new System.Windows.Forms.Label();
            this.dairesayısı = new System.Windows.Forms.Label();
            this.binaadıtxt = new System.Windows.Forms.TextBox();
            this.dairesystxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kytbtn = new System.Windows.Forms.Button();
            this.EvSahibimichkbx = new System.Windows.Forms.CheckBox();
            this.telnotxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hngdairetxt = new System.Windows.Forms.TextBox();
            this.hngdairelbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.odendibtn = new System.Windows.Forms.Button();
            this.evnotxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yılcmbox = new System.Windows.Forms.ComboBox();
            this.aycmbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aidatucrtlbl = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gdrucrettxtbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gdrndntxtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // binaadı
            // 
            this.binaadı.AutoSize = true;
            this.binaadı.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.binaadı.Location = new System.Drawing.Point(9, 41);
            this.binaadı.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.binaadı.Name = "binaadı";
            this.binaadı.Size = new System.Drawing.Size(94, 24);
            this.binaadı.TabIndex = 0;
            this.binaadı.Text = "Bina Adı:";
            // 
            // dairesayısı
            // 
            this.dairesayısı.AutoSize = true;
            this.dairesayısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dairesayısı.Location = new System.Drawing.Point(9, 87);
            this.dairesayısı.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dairesayısı.Name = "dairesayısı";
            this.dairesayısı.Size = new System.Drawing.Size(125, 24);
            this.dairesayısı.TabIndex = 0;
            this.dairesayısı.Text = "Daire Sayısı:";
            // 
            // binaadıtxt
            // 
            this.binaadıtxt.Location = new System.Drawing.Point(218, 41);
            this.binaadıtxt.Margin = new System.Windows.Forms.Padding(4);
            this.binaadıtxt.Name = "binaadıtxt";
            this.binaadıtxt.Size = new System.Drawing.Size(165, 28);
            this.binaadıtxt.TabIndex = 1;
            // 
            // dairesystxt
            // 
            this.dairesystxt.Location = new System.Drawing.Point(218, 87);
            this.dairesystxt.Margin = new System.Windows.Forms.Padding(4);
            this.dairesystxt.Name = "dairesystxt";
            this.dairesystxt.Size = new System.Drawing.Size(165, 28);
            this.dairesystxt.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dairesayısı);
            this.groupBox1.Controls.Add(this.binaadıtxt);
            this.groupBox1.Controls.Add(this.dairesystxt);
            this.groupBox1.Controls.Add(this.binaadı);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(737, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bina oluşturma sekmesi";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(453, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 76);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bina Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.kytbtn);
            this.groupBox2.Controls.Add(this.EvSahibimichkbx);
            this.groupBox2.Controls.Add(this.telnotxt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.hngdairetxt);
            this.groupBox2.Controls.Add(this.hngdairelbl);
            this.groupBox2.Location = new System.Drawing.Point(17, 180);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(622, 182);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Daire Bilgileri";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 28);
            this.textBox1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "İsim Soyisim:";
            // 
            // kytbtn
            // 
            this.kytbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kytbtn.Location = new System.Drawing.Point(406, 62);
            this.kytbtn.Margin = new System.Windows.Forms.Padding(4);
            this.kytbtn.Name = "kytbtn";
            this.kytbtn.Size = new System.Drawing.Size(198, 58);
            this.kytbtn.TabIndex = 5;
            this.kytbtn.Text = "Kayıt Oluştur";
            this.kytbtn.UseVisualStyleBackColor = true;
            this.kytbtn.Click += new System.EventHandler(this.kytbtn_Click);
            // 
            // EvSahibimichkbx
            // 
            this.EvSahibimichkbx.AutoSize = true;
            this.EvSahibimichkbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EvSahibimichkbx.Location = new System.Drawing.Point(397, 145);
            this.EvSahibimichkbx.Margin = new System.Windows.Forms.Padding(4);
            this.EvSahibimichkbx.Name = "EvSahibimichkbx";
            this.EvSahibimichkbx.Size = new System.Drawing.Size(153, 28);
            this.EvSahibimichkbx.TabIndex = 4;
            this.EvSahibimichkbx.Text = "Ev Sahibimi?";
            this.EvSahibimichkbx.UseVisualStyleBackColor = true;
            // 
            // telnotxt
            // 
            this.telnotxt.Location = new System.Drawing.Point(191, 121);
            this.telnotxt.Margin = new System.Windows.Forms.Padding(4);
            this.telnotxt.Name = "telnotxt";
            this.telnotxt.Size = new System.Drawing.Size(168, 28);
            this.telnotxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Telefon No:";
            // 
            // hngdairetxt
            // 
            this.hngdairetxt.Location = new System.Drawing.Point(191, 43);
            this.hngdairetxt.Margin = new System.Windows.Forms.Padding(4);
            this.hngdairetxt.Name = "hngdairetxt";
            this.hngdairetxt.Size = new System.Drawing.Size(168, 28);
            this.hngdairetxt.TabIndex = 1;
            // 
            // hngdairelbl
            // 
            this.hngdairelbl.AutoSize = true;
            this.hngdairelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hngdairelbl.Location = new System.Drawing.Point(10, 41);
            this.hngdairelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hngdairelbl.Name = "hngdairelbl";
            this.hngdairelbl.Size = new System.Drawing.Size(126, 24);
            this.hngdairelbl.TabIndex = 0;
            this.hngdairelbl.Text = "Hangi Daire:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.odendibtn);
            this.groupBox3.Controls.Add(this.evnotxtbox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.yılcmbox);
            this.groupBox3.Controls.Add(this.aycmbox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(647, 180);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(450, 182);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aidat Takip ";
            // 
            // odendibtn
            // 
            this.odendibtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odendibtn.Location = new System.Drawing.Point(253, 92);
            this.odendibtn.Margin = new System.Windows.Forms.Padding(4);
            this.odendibtn.Name = "odendibtn";
            this.odendibtn.Size = new System.Drawing.Size(185, 57);
            this.odendibtn.TabIndex = 6;
            this.odendibtn.Text = "ÖDE";
            this.odendibtn.UseVisualStyleBackColor = true;
            this.odendibtn.Click += new System.EventHandler(this.odendibtn_Click);
            // 
            // evnotxtbox
            // 
            this.evnotxtbox.Location = new System.Drawing.Point(376, 44);
            this.evnotxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.evnotxtbox.Name = "evnotxtbox";
            this.evnotxtbox.Size = new System.Drawing.Size(59, 28);
            this.evnotxtbox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(248, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Daire No:";
            // 
            // yılcmbox
            // 
            this.yılcmbox.FormattingEnabled = true;
            this.yılcmbox.Items.AddRange(new object[] {
            "2025",
            "2024",
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010"});
            this.yılcmbox.Location = new System.Drawing.Point(73, 89);
            this.yılcmbox.Margin = new System.Windows.Forms.Padding(4);
            this.yılcmbox.Name = "yılcmbox";
            this.yılcmbox.Size = new System.Drawing.Size(165, 30);
            this.yılcmbox.TabIndex = 3;
            // 
            // aycmbox
            // 
            this.aycmbox.BackColor = System.Drawing.SystemColors.Window;
            this.aycmbox.FormattingEnabled = true;
            this.aycmbox.Items.AddRange(new object[] {
            "OCAK",
            "ŞUBAT",
            "MART",
            "NİSAN",
            "MAYIS",
            "HAZİRAN",
            "TEMMUZ",
            "AĞUSTOS",
            "EYLÜL",
            "EKİM",
            "KASIM",
            "ARALIK"});
            this.aycmbox.Location = new System.Drawing.Point(73, 41);
            this.aycmbox.Margin = new System.Windows.Forms.Padding(4);
            this.aycmbox.Name = "aycmbox";
            this.aycmbox.Size = new System.Drawing.Size(165, 30);
            this.aycmbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yıl:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ay:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(813, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Aidat Ücreti:";
            // 
            // aidatucrtlbl
            // 
            this.aidatucrtlbl.AutoSize = true;
            this.aidatucrtlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aidatucrtlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.aidatucrtlbl.Location = new System.Drawing.Point(944, 102);
            this.aidatucrtlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aidatucrtlbl.Name = "aidatucrtlbl";
            this.aidatucrtlbl.Size = new System.Drawing.Size(68, 25);
            this.aidatucrtlbl.TabIndex = 6;
            this.aidatucrtlbl.Text = "40 TL";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gdrucrettxtbx);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.gdrndntxtbox);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(17, 385);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(586, 168);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gider Rapor";
            // 
            // gdrucrettxtbx
            // 
            this.gdrucrettxtbx.Location = new System.Drawing.Point(177, 96);
            this.gdrucrettxtbx.Name = "gdrucrettxtbx";
            this.gdrucrettxtbx.Size = new System.Drawing.Size(143, 28);
            this.gdrucrettxtbx.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Gider Ücreti:";
            // 
            // gdrndntxtbox
            // 
            this.gdrndntxtbox.Location = new System.Drawing.Point(177, 44);
            this.gdrndntxtbox.Name = "gdrndntxtbox";
            this.gdrndntxtbox.Size = new System.Drawing.Size(143, 28);
            this.gdrndntxtbox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Gider Nedeni?";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 64);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 60);
            this.button2.TabIndex = 0;
            this.button2.Text = "Kayıt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Location = new System.Drawing.Point(629, 385);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(453, 168);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kasa Rapor";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(140, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 87);
            this.button3.TabIndex = 0;
            this.button3.Text = "KASA SORGULA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(827, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "2021-2022 yılı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.aidatucrtlbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Bina-Yönetici Otomasyonu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label binaadı;
        private System.Windows.Forms.Label dairesayısı;
        private System.Windows.Forms.TextBox binaadıtxt;
        private System.Windows.Forms.TextBox dairesystxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button kytbtn;
        private System.Windows.Forms.CheckBox EvSahibimichkbx;
        private System.Windows.Forms.TextBox telnotxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hngdairetxt;
        private System.Windows.Forms.Label hngdairelbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox yılcmbox;
        private System.Windows.Forms.ComboBox aycmbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button odendibtn;
        private System.Windows.Forms.TextBox evnotxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label aidatucrtlbl;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox gdrucrettxtbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox gdrndntxtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
    }
}

