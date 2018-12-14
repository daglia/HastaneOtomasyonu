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

                //Label işlemleri

                lblKayitli.Text = "Kayıtlı Hastalar";
                gbKisiBilgileri.Text = "Hasta Bilgileri";

                cbServisSec.DataSource = Enum.GetValues(typeof(Branslar));

            }
            else if (toolStripComboBox1.SelectedIndex == 1)
            {
                //Visible işlemleri

                gbMuayene.Visible = false;
                gbEkBilgiler.Visible = true;
                gbMuayeneBilgileri.Visible = false;

                //Label işlemleri

                lblKayitli.Text = "Kayıtlı Çalışanlar";
                gbKisiBilgileri.Text = "Çalışan Bilgileri";
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
                if (control is TextBox)
                {
                    if (control.Name == "txtAra")
                        continue;
                    control.Text = string.Empty;
                }
                else if (control is CheckBox)
                    (control as CheckBox).Checked = false;
                else if (control is ListBox lstBox)
                    lstBox.Items.Clear();
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

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (toolStripComboBox1.SelectedIndex == 0) //Hasta
            {
                yeniKisi = new Hasta(txtAd.Text, txtSoyad.Text);
            }
            else if (toolStripComboBox1.SelectedIndex == 1) //Calışan
            {
                if (cbGorev.SelectedIndex == 0) //Doktor
                {
                    yeniKisi = new Doktor(txtAd.Text, txtSoyad.Text, (Branslar)cbBrans.SelectedItem);
                }
                else if (cbGorev.SelectedIndex == 1) //Hemşire
                {
                    yeniKisi = new Hemsire();
                }
                else if (cbGorev.SelectedIndex == 2) //Personel
                {
                    yeniKisi = new Personel(txtAd.Text, txtSoyad.Text, (Gorevler)cbBrans.SelectedItem);
                }
            }

            try
            {
                yeniKisi.Ad = txtAd.Text;
                yeniKisi.Soyad = txtSoyad.Text;
                yeniKisi.email = txtMail.Text;
                yeniKisi.Telefon = txtTelefon.Text;
                yeniKisi.TCKN = txtTCKN.Text;

                foreach(Kisi kisi in kisiler)
                {
                    if (yeniKisi.TCKN == kisi.TCKN)
                        throw new Exception("Aynı kişiyi tekrar giremezsiniz.");
                }

                kisiler.Add(yeniKisi);
                //MessageBox.Show($"Hosgeldin {yeniKisi.Ad} {yeniKisi.Soyad}");
                FormuTemizle();
                lstKisiler.Items.AddRange(kisiler.ToArray());
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
            lstKisiler.Items.AddRange(kisiler.ToArray());
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
            int sayi = rnd.Next(0, 3);

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
            }
            else if (cbGorev.SelectedIndex == 2)
            {
                cbHemsireDoktor.Enabled = false;

                cbBrans.DataSource = Enum.GetValues(typeof(Gorevler));
            }
        }

        private void cbServisSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDoktorSec.Enabled = true;
        }

        private void cbHemsireSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpMuayene.Enabled = true;
        }

        private void cbDoktorSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHemsireSec.Enabled = true;
            Button btn;
            DateTime muayeneSaati = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0);
            int kontrol;

            for (int i = 0; i < 28; i++)
            {
                btn = new Button();
                btn.Size = new Size(flpMuayene.Size.Width / 5, (flpMuayene.Size.Height-10) / 8);
                btn.FlatStyle = FlatStyle.Popup;
                btn.Text = muayeneSaati.ToShortTimeString();

                if (muayeneSaati.ToShortTimeString().ToString()=="11:45") muayeneSaati = muayeneSaati.AddHours(1);

                kontrol=TimeSpan.Compare(muayeneSaati.TimeOfDay, DateTime.Now.TimeOfDay);

                if (kontrol == -1) btn.Enabled = false;

                muayeneSaati = muayeneSaati.AddMinutes(15);

                flpMuayene.Controls.Add(btn);
            }

            //dtpMuayene.MinDate = DateTime.Now;

            //DateTime saat = new DateTime(2018, 11, 26, 9, 0, 0);
            //String muayeneSaati = saat.ToString("HH:mm");

            //while (muayeneSaati != "16:30")
            //{
            //    Console.WriteLine(muayeneSaati);
            //    saat = saat.AddMinutes(15);
            //    muayeneSaati = saat.ToString("HH:mm");
            //    if (muayeneSaati == "11:45")
            //    {
            //        saat = saat.AddMinutes(60);
            //    }

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

            if (seciliKisi is Hasta)
            {

            }
            if (seciliKisi is Doktor)
            {

            }
            if (seciliKisi is Hemsire)
            {

            }
            if (seciliKisi is Personel)
            {

            }
        }
    }
}
