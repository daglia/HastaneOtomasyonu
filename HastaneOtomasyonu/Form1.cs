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

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.SelectedIndex = 0;
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
            dosyaAc.Title = "Bir XML dosyası seçiniz";
            dosyaAc.Filter = "(XML Dosyası) | *.xml;";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.FileName = "Kisiler.xml";

            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Kisi>));
                XmlReader reader = new XmlTextReader(dosyaAc.FileName);
                if (xmlSerializer.CanDeserialize(reader))
                {
                    kisiler = xmlSerializer.Deserialize(reader) as List<Kisi>;
                    MessageBox.Show($"{kisiler.Count} kişi sisteme başarıyla eklendi.");
                    lstKisiler.Items.Clear();
                    lstKisiler.Items.AddRange(kisiler.ToArray());
                }
                else
                {
                    MessageBox.Show("Lütfen bir XML dosyası seçin.");
                }
            }
        }

        private void jSONOlarakAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir JSON dosyası seçiniz";
            dosyaAc.Filter = "(JSON Dosyası) | *.json;";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.FileName = "Kisiler.json";

            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream dosya = File.OpenRead(dosyaAc.FileName);
                    StreamReader reader = new StreamReader(dosya);
                    string dosyaIcerigi = reader.ReadToEnd();
                    reader.Close();
                    dosya.Close();
                    kisiler = JsonConvert.DeserializeObject<List<Kisi>>(dosyaIcerigi);

                    MessageBox.Show($"{kisiler.Count} kişi sisteme başarıyla eklendi.");
                    lstKisiler.Items.Clear();
                    lstKisiler.Items.AddRange(kisiler.ToArray());
                }
                catch (Exception)
                {
                    MessageBox.Show("Bir hata oluştu.");
                }
            }
        }

        private void xMLOlarakAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dosyaKaydet.Title = "Bir XML dosyası seçiniz";
            dosyaKaydet.Filter = "(XML Dosyası) | *.xml;";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaKaydet.FileName = "Kisiler.xml";

            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Kisi>));
                TextWriter textWriter = new StreamWriter(dosyaKaydet.FileName);
                serializer.Serialize(textWriter, kisiler); //Kisi class'ı public olmalı
                textWriter.Close();
                textWriter.Dispose();
                MessageBox.Show($"XML başarıyla dışa aktarıldı: {dosyaKaydet.FileName}");
            }
        }

        private void jSONOlarakAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dosyaKaydet.Title = "Bir JSON dosyası seçiniz";
            dosyaKaydet.Filter = "(JSON Dosyası) | *.json;";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaKaydet.FileName = "Kisiler.json";

            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                FileStream file = File.Open(dosyaKaydet.FileName, FileMode.Open);
                StreamWriter writer = new StreamWriter(file);
                writer.Write(JsonConvert.SerializeObject(kisiler));
                writer.Close();
                writer.Dispose();
                MessageBox.Show($"JSON başarıyla dışa aktarıldı: {dosyaKaydet.FileName}");
            }
        }

        Kisi yeniKisi;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            if(toolStripComboBox1.SelectedIndex == 0) //Hasta
            {
                yeniKisi = new Hasta(txtAd.Text, txtSoyad.Text);
            }
            else if(toolStripComboBox1.SelectedIndex == 1) //Calışan
            {
                if(cbGorev.SelectedIndex == 0) //Doktor
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

                kisiler.Add(yeniKisi);
                //MessageBox.Show($"Hosgeldin {yeniKisi.Ad} {yeniKisi.Soyad}");
                FormuTemizle();
                lstKisiler.Items.AddRange(kisiler.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
