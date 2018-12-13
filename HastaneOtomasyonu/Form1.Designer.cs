namespace HastaneOtomasyonu
{
    partial class Form1
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
            this.msIslemler = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içeriAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLOlarakAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONOlarakAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dışarıAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLOlarakAktarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONOlarakAktarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.btnHastaGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.gbMuayene = new System.Windows.Forms.GroupBox();
            this.dtpMuayene = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbHemsireSec = new System.Windows.Forms.ComboBox();
            this.cbDoktorSec = new System.Windows.Forms.ComboBox();
            this.cbServisSec = new System.Windows.Forms.ComboBox();
            this.gbKisiBilgileri = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtTCKN = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblKayitli = new System.Windows.Forms.Label();
            this.lstKisiler = new System.Windows.Forms.ListBox();
            this.gbEkBilgiler = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbGorev = new System.Windows.Forms.ComboBox();
            this.cbHemsireDoktor = new System.Windows.Forms.ComboBox();
            this.cbBrans = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSaatlikUcret = new System.Windows.Forms.TextBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lblAra = new System.Windows.Forms.Label();
            this.gbMuayeneBilgileri = new System.Windows.Forms.GroupBox();
            this.lblMuayeneBilgileri = new System.Windows.Forms.Label();
            this.dosyaKaydet = new System.Windows.Forms.SaveFileDialog();
            this.dosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.msIslemler.SuspendLayout();
            this.gbMuayene.SuspendLayout();
            this.gbKisiBilgileri.SuspendLayout();
            this.gbEkBilgiler.SuspendLayout();
            this.gbMuayeneBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // msIslemler
            // 
            this.msIslemler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.toolStripComboBox1});
            this.msIslemler.Location = new System.Drawing.Point(0, 0);
            this.msIslemler.Name = "msIslemler";
            this.msIslemler.Size = new System.Drawing.Size(784, 27);
            this.msIslemler.TabIndex = 1;
            this.msIslemler.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.içeriAktarToolStripMenuItem,
            this.dışarıAktarToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // içeriAktarToolStripMenuItem
            // 
            this.içeriAktarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLOlarakAktarToolStripMenuItem,
            this.jSONOlarakAktarToolStripMenuItem});
            this.içeriAktarToolStripMenuItem.Name = "içeriAktarToolStripMenuItem";
            this.içeriAktarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.içeriAktarToolStripMenuItem.Text = "İçeri Aktar";
            // 
            // xMLOlarakAktarToolStripMenuItem
            // 
            this.xMLOlarakAktarToolStripMenuItem.Name = "xMLOlarakAktarToolStripMenuItem";
            this.xMLOlarakAktarToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.xMLOlarakAktarToolStripMenuItem.Text = "XML olarak aktar";
            this.xMLOlarakAktarToolStripMenuItem.Click += new System.EventHandler(this.xMLOlarakAktarToolStripMenuItem_Click);
            // 
            // jSONOlarakAktarToolStripMenuItem
            // 
            this.jSONOlarakAktarToolStripMenuItem.Name = "jSONOlarakAktarToolStripMenuItem";
            this.jSONOlarakAktarToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.jSONOlarakAktarToolStripMenuItem.Text = "JSON olarak aktar";
            this.jSONOlarakAktarToolStripMenuItem.Click += new System.EventHandler(this.jSONOlarakAktarToolStripMenuItem_Click);
            // 
            // dışarıAktarToolStripMenuItem
            // 
            this.dışarıAktarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLOlarakAktarToolStripMenuItem1,
            this.jSONOlarakAktarToolStripMenuItem1});
            this.dışarıAktarToolStripMenuItem.Name = "dışarıAktarToolStripMenuItem";
            this.dışarıAktarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.dışarıAktarToolStripMenuItem.Text = "Dışarı Aktar";
            // 
            // xMLOlarakAktarToolStripMenuItem1
            // 
            this.xMLOlarakAktarToolStripMenuItem1.Name = "xMLOlarakAktarToolStripMenuItem1";
            this.xMLOlarakAktarToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.xMLOlarakAktarToolStripMenuItem1.Text = "XML olarak aktar";
            this.xMLOlarakAktarToolStripMenuItem1.Click += new System.EventHandler(this.xMLOlarakAktarToolStripMenuItem1_Click);
            // 
            // jSONOlarakAktarToolStripMenuItem1
            // 
            this.jSONOlarakAktarToolStripMenuItem1.Name = "jSONOlarakAktarToolStripMenuItem1";
            this.jSONOlarakAktarToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.jSONOlarakAktarToolStripMenuItem1.Text = "JSON olarak aktar";
            this.jSONOlarakAktarToolStripMenuItem1.Click += new System.EventHandler(this.jSONOlarakAktarToolStripMenuItem1_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Hasta İşlemleri",
            "Çalışan İşlemleri"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // btnHastaGuncelle
            // 
            this.btnHastaGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHastaGuncelle.Location = new System.Drawing.Point(231, 482);
            this.btnHastaGuncelle.Name = "btnHastaGuncelle";
            this.btnHastaGuncelle.Size = new System.Drawing.Size(79, 34);
            this.btnHastaGuncelle.TabIndex = 13;
            this.btnHastaGuncelle.Text = "Güncelle";
            this.btnHastaGuncelle.UseVisualStyleBackColor = true;
            this.btnHastaGuncelle.Click += new System.EventHandler(this.btnHastaGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Location = new System.Drawing.Point(329, 482);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(79, 34);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Location = new System.Drawing.Point(231, 444);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(177, 32);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // gbMuayene
            // 
            this.gbMuayene.Controls.Add(this.label15);
            this.gbMuayene.Controls.Add(this.label14);
            this.gbMuayene.Controls.Add(this.label13);
            this.gbMuayene.Controls.Add(this.label9);
            this.gbMuayene.Controls.Add(this.dtpMuayene);
            this.gbMuayene.Controls.Add(this.label7);
            this.gbMuayene.Controls.Add(this.cbHemsireSec);
            this.gbMuayene.Controls.Add(this.cbDoktorSec);
            this.gbMuayene.Controls.Add(this.cbServisSec);
            this.gbMuayene.Location = new System.Drawing.Point(415, 59);
            this.gbMuayene.Name = "gbMuayene";
            this.gbMuayene.Size = new System.Drawing.Size(357, 379);
            this.gbMuayene.TabIndex = 10;
            this.gbMuayene.TabStop = false;
            this.gbMuayene.Text = "Muayene İşlemleri";
            // 
            // dtpMuayene
            // 
            this.dtpMuayene.Enabled = false;
            this.dtpMuayene.Location = new System.Drawing.Point(56, 97);
            this.dtpMuayene.MinDate = new System.DateTime(2018, 12, 12, 0, 0, 0, 0);
            this.dtpMuayene.Name = "dtpMuayene";
            this.dtpMuayene.Size = new System.Drawing.Size(295, 20);
            this.dtpMuayene.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(321, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Bütün seçimleri yaptığınızda muayene saatleri aşağıda yer alacaktır.";
            // 
            // cbHemsireSec
            // 
            this.cbHemsireSec.Enabled = false;
            this.cbHemsireSec.FormattingEnabled = true;
            this.cbHemsireSec.Location = new System.Drawing.Point(56, 70);
            this.cbHemsireSec.Name = "cbHemsireSec";
            this.cbHemsireSec.Size = new System.Drawing.Size(295, 21);
            this.cbHemsireSec.TabIndex = 2;
            this.cbHemsireSec.Text = "Hemşire Seçiniz";
            this.cbHemsireSec.SelectedIndexChanged += new System.EventHandler(this.cbHemsireSec_SelectedIndexChanged);
            // 
            // cbDoktorSec
            // 
            this.cbDoktorSec.Enabled = false;
            this.cbDoktorSec.FormattingEnabled = true;
            this.cbDoktorSec.Location = new System.Drawing.Point(56, 44);
            this.cbDoktorSec.Name = "cbDoktorSec";
            this.cbDoktorSec.Size = new System.Drawing.Size(295, 21);
            this.cbDoktorSec.TabIndex = 1;
            this.cbDoktorSec.Text = "Doktor Seçiniz";
            this.cbDoktorSec.SelectedIndexChanged += new System.EventHandler(this.cbDoktorSec_SelectedIndexChanged);
            // 
            // cbServisSec
            // 
            this.cbServisSec.FormattingEnabled = true;
            this.cbServisSec.Location = new System.Drawing.Point(56, 17);
            this.cbServisSec.Name = "cbServisSec";
            this.cbServisSec.Size = new System.Drawing.Size(295, 21);
            this.cbServisSec.TabIndex = 0;
            this.cbServisSec.Text = "Servis Seçiniz";
            this.cbServisSec.SelectedIndexChanged += new System.EventHandler(this.cbServisSec_SelectedIndexChanged);
            // 
            // gbKisiBilgileri
            // 
            this.gbKisiBilgileri.Controls.Add(this.label6);
            this.gbKisiBilgileri.Controls.Add(this.label5);
            this.gbKisiBilgileri.Controls.Add(this.label4);
            this.gbKisiBilgileri.Controls.Add(this.label3);
            this.gbKisiBilgileri.Controls.Add(this.label2);
            this.gbKisiBilgileri.Controls.Add(this.txtMail);
            this.gbKisiBilgileri.Controls.Add(this.txtTelefon);
            this.gbKisiBilgileri.Controls.Add(this.txtTCKN);
            this.gbKisiBilgileri.Controls.Add(this.txtSoyad);
            this.gbKisiBilgileri.Controls.Add(this.txtAd);
            this.gbKisiBilgileri.Location = new System.Drawing.Point(231, 59);
            this.gbKisiBilgileri.Name = "gbKisiBilgileri";
            this.gbKisiBilgileri.Size = new System.Drawing.Size(178, 161);
            this.gbKisiBilgileri.TabIndex = 9;
            this.gbKisiBilgileri.TabStop = false;
            this.gbKisiBilgileri.Text = "Hasta Bilgileri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "E-Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "TCKN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ad";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(58, 123);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(114, 20);
            this.txtMail.TabIndex = 4;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(58, 97);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(114, 20);
            this.txtTelefon.TabIndex = 3;
            // 
            // txtTCKN
            // 
            this.txtTCKN.Location = new System.Drawing.Point(58, 71);
            this.txtTCKN.Name = "txtTCKN";
            this.txtTCKN.Size = new System.Drawing.Size(114, 20);
            this.txtTCKN.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(58, 45);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(114, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(58, 19);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(114, 20);
            this.txtAd.TabIndex = 0;
            // 
            // lblKayitli
            // 
            this.lblKayitli.AutoSize = true;
            this.lblKayitli.Location = new System.Drawing.Point(12, 119);
            this.lblKayitli.Name = "lblKayitli";
            this.lblKayitli.Size = new System.Drawing.Size(76, 13);
            this.lblKayitli.TabIndex = 8;
            this.lblKayitli.Text = "Kayıtlı Hastalar";
            // 
            // lstKisiler
            // 
            this.lstKisiler.FormattingEnabled = true;
            this.lstKisiler.Location = new System.Drawing.Point(12, 135);
            this.lstKisiler.Name = "lstKisiler";
            this.lstKisiler.Size = new System.Drawing.Size(213, 381);
            this.lstKisiler.TabIndex = 7;
            // 
            // gbEkBilgiler
            // 
            this.gbEkBilgiler.Controls.Add(this.label1);
            this.gbEkBilgiler.Controls.Add(this.textBox1);
            this.gbEkBilgiler.Controls.Add(this.label8);
            this.gbEkBilgiler.Controls.Add(this.cbGorev);
            this.gbEkBilgiler.Controls.Add(this.cbHemsireDoktor);
            this.gbEkBilgiler.Controls.Add(this.cbBrans);
            this.gbEkBilgiler.Controls.Add(this.label10);
            this.gbEkBilgiler.Controls.Add(this.label11);
            this.gbEkBilgiler.Controls.Add(this.label12);
            this.gbEkBilgiler.Controls.Add(this.txtSaatlikUcret);
            this.gbEkBilgiler.Location = new System.Drawing.Point(231, 226);
            this.gbEkBilgiler.Name = "gbEkBilgiler";
            this.gbEkBilgiler.Size = new System.Drawing.Size(178, 160);
            this.gbEkBilgiler.TabIndex = 10;
            this.gbEkBilgiler.TabStop = false;
            this.gbEkBilgiler.Text = "Ek Bilgiler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Maaş";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(58, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Görev";
            // 
            // cbGorev
            // 
            this.cbGorev.FormattingEnabled = true;
            this.cbGorev.Items.AddRange(new object[] {
            "Doktor",
            "Hemşire",
            "Personel"});
            this.cbGorev.Location = new System.Drawing.Point(58, 15);
            this.cbGorev.Name = "cbGorev";
            this.cbGorev.Size = new System.Drawing.Size(114, 21);
            this.cbGorev.TabIndex = 10;
            this.cbGorev.SelectedIndexChanged += new System.EventHandler(this.cbGorev_SelectedIndexChanged);
            // 
            // cbHemsireDoktor
            // 
            this.cbHemsireDoktor.FormattingEnabled = true;
            this.cbHemsireDoktor.Location = new System.Drawing.Point(58, 69);
            this.cbHemsireDoktor.Name = "cbHemsireDoktor";
            this.cbHemsireDoktor.Size = new System.Drawing.Size(114, 21);
            this.cbHemsireDoktor.TabIndex = 9;
            // 
            // cbBrans
            // 
            this.cbBrans.FormattingEnabled = true;
            this.cbBrans.Location = new System.Drawing.Point(58, 42);
            this.cbBrans.Name = "cbBrans";
            this.cbBrans.Size = new System.Drawing.Size(114, 21);
            this.cbBrans.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Doktor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "S. Ücret";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Branş";
            // 
            // txtSaatlikUcret
            // 
            this.txtSaatlikUcret.Location = new System.Drawing.Point(58, 96);
            this.txtSaatlikUcret.Name = "txtSaatlikUcret";
            this.txtSaatlikUcret.Size = new System.Drawing.Size(114, 20);
            this.txtSaatlikUcret.TabIndex = 1;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(15, 78);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(210, 20);
            this.txtAra.TabIndex = 10;
            this.txtAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAra_KeyUp);
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Location = new System.Drawing.Point(12, 59);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(37, 13);
            this.lblAra.TabIndex = 14;
            this.lblAra.Text = "Arama";
            // 
            // gbMuayeneBilgileri
            // 
            this.gbMuayeneBilgileri.Controls.Add(this.lblMuayeneBilgileri);
            this.gbMuayeneBilgileri.Location = new System.Drawing.Point(415, 444);
            this.gbMuayeneBilgileri.Name = "gbMuayeneBilgileri";
            this.gbMuayeneBilgileri.Size = new System.Drawing.Size(351, 74);
            this.gbMuayeneBilgileri.TabIndex = 12;
            this.gbMuayeneBilgileri.TabStop = false;
            this.gbMuayeneBilgileri.Text = "Muayene Bilgileri";
            // 
            // lblMuayeneBilgileri
            // 
            this.lblMuayeneBilgileri.AutoSize = true;
            this.lblMuayeneBilgileri.Location = new System.Drawing.Point(11, 20);
            this.lblMuayeneBilgileri.Name = "lblMuayeneBilgileri";
            this.lblMuayeneBilgileri.Size = new System.Drawing.Size(124, 13);
            this.lblMuayeneBilgileri.TabIndex = 0;
            this.lblMuayeneBilgileri.Text = "Henüz randevu alınmadı.";
            // 
            // dosyaAc
            // 
            this.dosyaAc.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(231, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 24);
            this.button1.TabIndex = 15;
            this.button1.Text = "MUHTEŞEM KİŞİ EKLEME";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Servis";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Doktor";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Hemşire";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Tarih";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbMuayeneBilgileri);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.gbEkBilgiler);
            this.Controls.Add(this.btnHastaGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.gbMuayene);
            this.Controls.Add(this.gbKisiBilgileri);
            this.Controls.Add(this.lblKayitli);
            this.Controls.Add(this.lstKisiler);
            this.Controls.Add(this.msIslemler);
            this.MainMenuStrip = this.msIslemler;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.msIslemler.ResumeLayout(false);
            this.msIslemler.PerformLayout();
            this.gbMuayene.ResumeLayout(false);
            this.gbMuayene.PerformLayout();
            this.gbKisiBilgileri.ResumeLayout(false);
            this.gbKisiBilgileri.PerformLayout();
            this.gbEkBilgiler.ResumeLayout(false);
            this.gbEkBilgiler.PerformLayout();
            this.gbMuayeneBilgileri.ResumeLayout(false);
            this.gbMuayeneBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msIslemler;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içeriAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLOlarakAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONOlarakAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dışarıAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLOlarakAktarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jSONOlarakAktarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Button btnHastaGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox gbMuayene;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbHemsireSec;
        private System.Windows.Forms.ComboBox cbDoktorSec;
        private System.Windows.Forms.ComboBox cbServisSec;
        private System.Windows.Forms.GroupBox gbKisiBilgileri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtTCKN;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblKayitli;
        private System.Windows.Forms.ListBox lstKisiler;
        private System.Windows.Forms.DateTimePicker dtpMuayene;
        private System.Windows.Forms.GroupBox gbEkBilgiler;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSaatlikUcret;
        private System.Windows.Forms.ComboBox cbHemsireDoktor;
        private System.Windows.Forms.ComboBox cbBrans;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbGorev;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.GroupBox gbMuayeneBilgileri;
        private System.Windows.Forms.Label lblMuayeneBilgileri;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog dosyaKaydet;
        private System.Windows.Forms.OpenFileDialog dosyaAc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
    }
}

