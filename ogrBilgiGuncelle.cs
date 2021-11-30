using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Surucu_Kursu_Otomasyonu
{
    public partial class ogrBilgiGuncelle : Form
    {
        public ogrBilgiGuncelle()
        {
            InitializeComponent();
        }

        private void ogrBilgiGuncelle_Load(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            for (int i = 0; i < Form1.tumKayitlar.Count; i++)
            {
                comboBox3.Items.Add("Tc: " + Form1.tumKayitlar[i]._tckimlik + " -> " + Form1.tumKayitlar[i]._ad + " " + Form1.tumKayitlar[i]._soyad);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secim = comboBox3.SelectedIndex, s = 0;   
            
            if (secim > -1)
            {
                panel2.Enabled = btnGuncelle.Enabled = true;
                maskedTextBox1.Text = Form1.tumKayitlar[secim]._tckimlik;
                textBox1.Text = Form1.tumKayitlar[secim]._ad;
                textBox2.Text = Form1.tumKayitlar[secim]._soyad;
                maskedTextBox2.Text = Form1.tumKayitlar[secim]._dt;
                textBox3.Text = Form1.tumKayitlar[secim]._dy;
                comboBox1.SelectedIndex = Convert.ToInt32(Form1.tumKayitlar[secim]._cs.ToString()) - 1;
                textBox6.Text = Form1.tumKayitlar[secim]._adres;
                maskedTextBox3.Text = Form1.tumKayitlar[secim]._tel;
                textBox4.Text = Form1.tumKayitlar[secim]._eposta;
                comboBox2.SelectedIndex = comboBox2.Items.IndexOf(Form1.tumKayitlar[secim]._ehliyetTuru);

                foreach (Control c in panel4.Controls)
                {
                    if (c is CheckBox)
                    {
                        ((CheckBox)c).Checked = Convert.ToBoolean(Form1.tumKayitlar[secim]._evraklar[s]);
                        s++;
                    }
                }

            }
            else
            {
                panel2.Enabled= btnGuncelle.Enabled = false; 
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string tc = maskedTextBox1.Text;
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string dt = maskedTextBox2.Text;
            string dy = textBox3.Text;
            int cs = comboBox1.SelectedIndex + 1;
            string adres = textBox6.Text;
            string tel = maskedTextBox3.Text;
            string eposta = textBox4.Text;
            string ehliyetTur = comboBox2.Text;
            int[] evraklar = new int[6];
            string mesaj = "";

            int i = 0;
            foreach (Control c in panel4.Controls)//İşaretli Checkbox'ları buluyoruz.
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked) { evraklar[i] = 1; i++; } else { evraklar[i] = 0; i++; }
                }
            }


            if (maskedTextBox1.Text.Length < 11) mesaj = "Geçersiz T.C. Kimlik No.";
            if (textBox1.Text.Trim() == "") mesaj += "\nAd alanı boş olamaz.";
            if (textBox2.Text.Trim() == "") mesaj += "\nSoyad alanı boş olamaz.";
            if (maskedTextBox2.Text.Length < 8) mesaj += "\nGeçersiz Doğum Tarihi.";
            if (textBox3.Text.Trim() == "") mesaj += "\nDoğum yeri alanı boş olamaz.";
            if (comboBox1.SelectedIndex == -1) mesaj += "\nCinsiyet seçiniz.";


            if (mesaj == "")
            {
                kurs kursBilgileri = new();
                kisi k = new kisi(tc, ad, soyad, dt, dy, cs, adres, tel, eposta, ehliyetTur, evraklar, kursBilgileri);

                Form1.tumKayitlar[comboBox3.SelectedIndex] = k;

                JSON j = new JSON();

                j.JSONkaydet("veriler.JSON", Form1.tumKayitlar);

                araclar.resetForm(panel6);//Form alanlarını temizliyoruz.
                araclar.resetForm(panel3);
                araclar.resetForm(panel4);
                comboBox3.SelectedIndex = -1;

                MessageBox.Show("Öğrenci bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
