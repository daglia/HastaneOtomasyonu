using HastaneOtomasyonu.Lib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace HastaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Kisi> kisiler = new List<Kisi>();
        List<Kisi> aramalar = new List<Kisi>();

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.SelectedIndex = 0;
            cbGorev.SelectedIndex = 0;
            cbDoktorSec.Enabled = false;
            cbServisSec.Text = "Servis Seçiniz";
            dtpMuayene.MinDate = DateTime.Now;
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedIndex == 0)
            {
                //Visible işlemleri

                gbMuayene.Visible = true;
                gbMuayeneBilgileri.Visible = true;
                gbEkBilgiler.Visible = false;
                if (dtpMuayene.Enabled == true)
                    flpMuayene.Visible = true;

                //Label işlemleri

                lblKayitli.Text = "Kayıtlı Hastalar";
                gbKisiBilgileri.Text = "Hasta Bilgileri";
                flpMuayene.Visible = true;

                cbServisSec.DataSource = Enum.GetValues(typeof(Branslar));
                lstKisiler.Items.Clear();

                foreach (Kisi kisi in kisiler)
                {
                    if (kisi is Hasta)
                        lstKisiler.Items.Add(kisi);
                }


            }
            else if (toolStripComboBox1.SelectedIndex == 1)
            {
                //Visible işlemleri

                gbMuayene.Visible = false;
                gbEkBilgiler.Visible = true;
                flpMuayene.Visible = false;

                //Label işlemleri

                lblKayitli.Text = "Kayıtlı Çalışanlar";
                gbKisiBilgileri.Text = "Çalışan Bilgileri";

                lstKisiler.Items.Clear();

                foreach (Kisi kisi in kisiler)
                {
                    if (kisi is Calisan)
                        lstKisiler.Items.Add(kisi);
                }
            }
        }

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            string ara = txtAra.Text.ToLower();
            aramalar = new List<Kisi>();

            kisiler.Where(kisi => kisi.Ad.ToLower().Contains(ara) || kisi.Soyad.ToLower().Contains(ara) || kisi.TCKN.StartsWith(ara)).ToList().ForEach(kisi => aramalar.Add(kisi));
            lblAra.Text = $"Arama ({aramalar.ToArray().Length} kişi bulundu)";

            FormuTemizle();
            lstKisiler.Items.AddRange(aramalar.ToArray());
            if (txtAra.Text.Equals(string.Empty))
                lblAra.Text = "Arama";
        }

        private void FormuTemizle()
        {

            foreach (Control control in this.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    foreach (Control gbControl in groupBox.Controls)
                    {
                        if (gbControl is TextBox)
                        {
                            gbControl.Text = string.Empty;
                        }
                        else if (gbControl is CheckBox)
                            (gbControl as CheckBox).Checked = false;
                        else if (gbControl is ComboBox)
                        {
                            gbControl.ResetText();
                            if (!(gbControl.Name == "cbDoktorSec" || gbControl.Name == "cbHemsireSec" || gbControl.Name == "cbHemsireDoktor")) continue;
                            gbControl.Enabled = false;
                        }
                        else if (gbControl is DateTimePicker)
                        {
                            gbControl.Enabled = false;
                            gbControl.ResetText();
                        }
                    }
                }
                else if (control is FlowLayoutPanel flowLayoutPanel)
                {
                    foreach (Control flpControl in flowLayoutPanel.Controls)
                    {
                        flpControl.Visible = false;
                    }
                }

                lstKisiler.Items.Clear();
            }
        }

        private void xMLOlarakAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jSONOlarakAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xMLOlarakAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void jSONOlarakAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        Kisi yeniKisi;

        public void ListeGuncelle()
        {
            if (toolStripComboBox1.SelectedIndex == 0)
                foreach (Kisi kisi in kisiler)
                {
                    if (kisi is Hasta)
                        lstKisiler.Items.Add(kisi);
                }
            else if (toolStripComboBox1.SelectedIndex == 1)
                foreach (Kisi kisi in kisiler)
                {
                    if (kisi is Calisan)
                        lstKisiler.Items.Add(kisi);
                }
            lstKisiler.Sorted = true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //boş ctor tanımları yaptık programda hata alırsak tekrar dolu ctor oluştrup burada ona göre instance alınabilir örnek olması açısından bir tanesini burada bırakıyorum 
            if (toolStripComboBox1.SelectedIndex == 0) //Hasta
            {
                //yeniKisi = new Hasta(txtAd.Text, txtSoyad.Text);
                yeniKisi = new Hasta();
            }
            else if (toolStripComboBox1.SelectedIndex == 1) //Calışan
            {
                if (cbGorev.SelectedIndex == 0) //Doktor
                {
                    yeniKisi = new Doktor();

                }
                else if (cbGorev.SelectedIndex == 1) //Hemşire
                {
                    yeniKisi = new Hemsire();
                }
                else if (cbGorev.SelectedIndex == 2) //Personel
                {
                    yeniKisi = new Personel();
                }
            }

            try
            {
                yeniKisi.Ad = txtAd.Text;
                yeniKisi.Soyad = txtSoyad.Text;
                yeniKisi.email = txtMail.Text;
                yeniKisi.Telefon = txtTelefon.Text;
                yeniKisi.TCKN = txtTCKN.Text;

                if (yeniKisi is Doktor doktor)
                    doktor.DBrans = (Branslar)cbBrans.SelectedItem;

                else if (yeniKisi is Hemsire hemsire)
                    hemsire.HBrans = (Branslar)cbBrans.SelectedItem;

                else if (yeniKisi is Personel personel)
                    personel.CGorev = (Gorevler)cbBrans.SelectedItem;

                foreach (Kisi kisi in kisiler)
                {
                    if (yeniKisi.TCKN == kisi.TCKN)
                        throw new Exception("Aynı kişiyi tekrar giremezsiniz.");
                }

                kisiler.Add(yeniKisi);

                FormuTemizle();
                ListeGuncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sorun", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnHastaGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;

            Kisi seciliKisi = (Kisi)lstKisiler.SelectedItem;

            try
            {
                seciliKisi.Ad = txtAd.Text;
                seciliKisi.Soyad = txtSoyad.Text;
                seciliKisi.TCKN = txtTCKN.Text;
                seciliKisi.Telefon = txtTelefon.Text;
                seciliKisi.email = txtMail.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FormuTemizle();
            ListeGuncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;

            Kisi seciliKisi = (Kisi)lstKisiler.SelectedItem;
            kisiler.Remove(seciliKisi);

            FormuTemizle();
            lstKisiler.Items.AddRange(kisiler.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(0, 16);

            switch (sayi)
            {
                case 0:
                    txtAd.Text = "Alpero";
                    txtSoyad.Text = "Maduro";
                    txtMail.Text = "alperomaduro@gmail.com";
                    txtTelefon.Text = "51234567890";
                    txtTCKN.Text = "12345678901";
                    break;
                case 1:
                    txtAd.Text = "Aychenauro";
                    txtSoyad.Text = "Karaillo";
                    txtMail.Text = "aychenaurokaraillo@gmail.com";
                    txtTelefon.Text = "51266267890";
                    txtTCKN.Text = "12345890901";
                    break;
                case 2:
                    txtAd.Text = "Gözdillo";
                    txtSoyad.Text = "Anaguro";
                    txtMail.Text = "gozdilloanaguro@gmail.com";
                    txtTelefon.Text = "51287694590";
                    txtTCKN.Text = "12345679351";
                    break;
                case 3:
                    txtAd.Text = "Mässuht";
                    txtSoyad.Text = "Özjorgen";
                    txtMail.Text = "massuhtozjorgen@gmail.com";
                    txtTelefon.Text = "50907694590";
                    txtTCKN.Text = "12786547351";
                    break;
                case 4:
                    txtAd.Text = "İsmailov";
                    txtSoyad.Text = "Çadırov";
                    txtMail.Text = "ismailovcadirov@gmail.com";
                    txtTelefon.Text = "53597694590";
                    txtTCKN.Text = "12786747651";
                    break;
                case 5:
                    txtAd.Text = "Samuel";
                    txtSoyad.Text = "Allabellabolla";
                    txtMail.Text = "ismailovcadirov@gmail.com";
                    txtTelefon.Text = "53547694490";
                    txtTCKN.Text = "82786547651";
                    break;
                case 6:
                    txtAd.Text = "Federico";
                    txtSoyad.Text = "Hancherro";
                    txtMail.Text = "federicohancherro@gmail.com";
                    txtTelefon.Text = "53587691290";
                    txtTCKN.Text = "32786907651";
                    break;
                case 7:
                    txtAd.Text = "Kubirico";
                    txtSoyad.Text = "Iazzolla";
                    txtMail.Text = "kubirico.iazaolla@gmail.com";
                    txtTelefon.Text = "53587694590";
                    txtTCKN.Text = "12786907659";
                    break;
                case 8:
                    txtAd.Text = "Bourrau";
                    txtSoyad.Text = "Courman";
                    txtMail.Text = "bourraucourman@gmail.com";
                    txtTelefon.Text = "52887694590";
                    txtTCKN.Text = "12703467659";
                    break;
                case 9:
                    txtAd.Text = "Emmanuel";
                    txtSoyad.Text = "Chedouin";
                    txtMail.Text = "emmanuelchedo@gmail.com";
                    txtTelefon.Text = "52887696342";
                    txtTCKN.Text = "12703460687";
                    break;
                case 10:
                    txtAd.Text = "Mu Chan Chit";
                    txtSoyad.Text = "Xe Ba";
                    txtMail.Text = "xeba@gmail.com";
                    txtTelefon.Text = "52887699054";
                    txtTCKN.Text = "12703477787";
                    break;
                case 11:
                    txtAd.Text = "Oswaldo";
                    txtSoyad.Text = "Demrskiy";
                    txtMail.Text = "xeba@gmail.com";
                    txtTelefon.Text = "52887699054";
                    txtTCKN.Text = "12703499087";
                    break;
                case 12:
                    txtAd.Text = "Zhulova";
                    txtSoyad.Text = "Rassov";
                    txtMail.Text = "rassov@gmail.com";
                    txtTelefon.Text = "59007699054";
                    txtTCKN.Text = "12703477787";
                    break;
                case 13:
                    txtAd.Text = "Shuqurro";
                    txtSoyad.Text = "Toulosso";
                    txtMail.Text = "shuq@gmail.com";
                    txtTelefon.Text = "51007699054";
                    txtTCKN.Text = "12111477787";
                    break;
                case 14:
                    txtAd.Text = "Haikutolos";
                    txtSoyad.Text = "Karagozis";
                    txtMail.Text = "haiku@gmail.com";
                    txtTelefon.Text = "55637699054";
                    txtTCKN.Text = "12111778793";
                    break;
                case 15:
                    txtAd.Text = "Fourkhan";
                    txtSoyad.Text = "bin Zülfikar";
                    txtMail.Text = "zulf@gmail.com";
                    txtTelefon.Text = "55676699054";
                    txtTCKN.Text = "12111448793";
                    break;
                default:
                    break;
            }
        }

        private void cbGorev_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGorev.SelectedIndex == 0)
            {
                cbHemsireDoktor.Enabled = false;

                cbBrans.DataSource = Enum.GetValues(typeof(Branslar));
            }
            else if (cbGorev.SelectedIndex == 1)
            {
                cbHemsireDoktor.Enabled = true;

                cbBrans.DataSource = Enum.GetValues(typeof(Branslar));

                foreach (Kisi kisi in kisiler)
                {
                    if (kisi is Doktor doktor)
                        cbHemsireDoktor.Items.Add(doktor);
                }
            }
            else if (cbGorev.SelectedIndex == 2)
            {
                cbHemsireDoktor.Enabled = false;

                cbBrans.DataSource = Enum.GetValues(typeof(Gorevler));
            }
        }

        private void cbServisSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDoktorSec.Text = "Doktor Seçiniz";
            cbHemsireSec.Text = "Hemşire Seçiniz";
            cbDoktorSec.Items.Clear();
            cbDoktorSec.Enabled = true;

            foreach (Kisi kisi in kisiler)
                if (kisi is Doktor doktor && cbServisSec.SelectedIndex == (int)doktor.DBrans)
                    cbDoktorSec.Items.Add(doktor);
        }

        private void cbHemsireSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpMuayene.Enabled = true;
        }

        private void cbDoktorSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpMuayene.Visible = false;
            cbHemsireSec.Enabled = true;

            cbHemsireSec.Items.Clear();
            foreach (Kisi kisi in kisiler)
                if (kisi is Hemsire hemsire && cbServisSec.SelectedIndex == (int)hemsire.HBrans)
                    cbHemsireSec.Items.Add(hemsire);

        }

        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;

            Kisi seciliKisi = (Kisi)lstKisiler.SelectedItem;
            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            txtMail.Text = seciliKisi.email;
            txtTelefon.Text = seciliKisi.Telefon;
            txtTCKN.Text = seciliKisi.TCKN;

            if (seciliKisi is Hasta hasta)
            {
                cbServisSec.Enabled = true;
            }
            else if (seciliKisi is Doktor doktor)
            {
                cbGorev.SelectedIndex = 0;
                cbBrans.SelectedItem = doktor.DBrans;
                //txtSaatlikUcret.Text = doktor.SaatlikUcret.ToString();
            }
            else if (seciliKisi is Hemsire hemsire)
            {
                cbGorev.SelectedIndex = 1;
                cbBrans.SelectedItem = hemsire.HBrans;

            }
            else if (seciliKisi is Personel personel)
            {
                cbGorev.SelectedIndex = 2;
                cbBrans.SelectedItem = personel.CGorev;
            }
        }

        private void dtpMuayene_ValueChanged(object sender, EventArgs e)
        {
            flpMuayene.Visible = true;
        }

        private void dtpMuayene_EnabledChanged(object sender, EventArgs e)
        {
            //seçim işlemleri sırayla gittiğinden doktor seçince değil dtp enable olduğunda button oluşturulmalı
            //valuechanged methodunda yapılmıyor en başta dtp set edildiği için direkt methoda giriyor ayrıca visible işlevlerini bozuyor

            Button btn;
            //DateTime muayeneSaati = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0);
            DateTime muayeneSaati = new DateTime(dtpMuayene.Value.Year, dtpMuayene.Value.Month, dtpMuayene.Value.Day, 9, 0, 0);
            int kontrolSaat;

            for (int i = 0; i < 28; i++)
            {
                btn = new Button();
                btn.Size = new Size(flpMuayene.Size.Width / 5, (flpMuayene.Size.Height - 10) / 8);
                btn.FlatStyle = FlatStyle.Popup;
                btn.Text = muayeneSaati.ToShortTimeString();

                if (muayeneSaati.ToShortTimeString() == "11:45") muayeneSaati = muayeneSaati.AddHours(1);

                if (dtpMuayene.Value.DayOfYear > DateTime.Now.DayOfYear) btn.Enabled = true;
                //if (dtpMuayene.Value.Date.CompareTo(DateTime.Now) > 0) btn.Enabled = true;
                //aynı işlemi yapan başka bir method fikir vermesi için bakılabilir

                else
                {
                    kontrolSaat = TimeSpan.Compare(muayeneSaati.TimeOfDay, DateTime.Now.TimeOfDay);
                    if (kontrolSaat == -1) btn.Enabled = false;
                }

                muayeneSaati = muayeneSaati.AddMinutes(15);

                flpMuayene.Controls.Add(btn);
            }
        }


    }
}
