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
    public partial class ogrKayit : Form
    {
        public ogrKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                kisi k = new kisi(tc, ad, soyad, dt, dy, cs, adres, tel, eposta, ehliyetTur, evraklar);

                List<kisi> liste = new List<kisi>();

                liste.Add(k);

                JSON j = new JSON();

                j.JSONkaydet("veriler.JSON",liste);

                araclar.resetForm(panel2);
                araclar.resetForm(panel3);
                araclar.resetForm(panel4);

                MessageBox.Show("Öğrenci kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
