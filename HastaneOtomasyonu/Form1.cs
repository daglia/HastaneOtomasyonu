using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if(toolStripComboBox1.SelectedIndex == 0)
            {
                //Visible işlemleri

                gbMuayene.Visible = true;
                gbMuayeneBilgileri.Visible = true;
                gbEkBilgiler.Visible = false;

                //Label işlemleri

                lblKayitli.Text = "Kayıtlı Hastalar";
                gbKisiBilgileri.Text = "Hasta Bilgileri";
                
            }
            else if(toolStripComboBox1.SelectedIndex == 1)
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
    }
}
