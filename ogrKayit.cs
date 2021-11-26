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
            long tc = Convert.ToInt64(maskedTextBox1.Text);
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

            int i = 0;
            foreach (Control c in panel4.Controls)//İşaretli Checkbox'ları buluyoruz.
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked) { evraklar[i] = 1; i++; } else { evraklar[i] = 0; i++; }
                }
            }


            kisi k = new kisi(tc, ad, soyad, dt, dy, cs, adres, tel, eposta, ehliyetTur, evraklar);

            List<kisi> liste = new List<kisi>();

            liste.Add(k);

            JSON j = new JSON();

            j.JSONkaydet("veriler.JSON",liste);
        }
    }
}
