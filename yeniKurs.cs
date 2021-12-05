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
    public partial class yeniKurs : Form
    {
        public yeniKurs()
        {
            InitializeComponent();
        }

        private void yeniKurs_Load(object sender, EventArgs e)
        {
            for (int i = 2021; i <= 2050; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }

            foreach (kisi k in Form1.tumKayitlar)
            {
                if (k._kursBilgileri._kursAd == null)
                {
                    listBox1.Items.Add(k._tckimlik.ToString() + "-" + k._ad + " " + k._soyad);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                listBox2.Items.Add(listBox1.Items[listBox1.SelectedIndex]);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
            {
                listBox1.Items.Add(listBox2.Items[listBox2.SelectedIndex]);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1 && comboBox2.SelectedIndex>-1)
            {
                textBox1.Text = comboBox1.Text+"_"+comboBox2.Text+"_DÖNEMİ_KURSU";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kursDonem = "", kursAd="", mesaj = "";
            
            string[] temp;

            string[] ogretmenler = new string[3];

            List<string> liste = new List<string>();

            if (comboBox1.SelectedIndex > -1 && comboBox2.SelectedIndex > -1)
            {
                kursDonem = comboBox1.Text + "_" + comboBox2.Text;
            }
            else
            {
                mesaj = "Kurs dönemi seçiniz.\n";
            }

            if (textBox1.Text.Trim() != "")
            {
                kursAd = textBox1.Text;
            }
            else
            {
                mesaj += "Kurs adı giriniz.\n";
            }


            ogretmenler[0] = comboBox3.SelectedIndex.ToString();
            ogretmenler[1] = comboBox4.SelectedIndex.ToString();
            ogretmenler[2] = comboBox5.SelectedIndex.ToString();

            foreach (string ogr in listBox2.Items)
            {
                temp = ogr.Split('-');
                liste.Add(temp[0]);
            }

            if (mesaj == "")
            {
                foreach (string tc in liste)
                {
                    foreach (kisi ogr in Form1.tumKayitlar)
                    {
                        if (ogr._tckimlik == tc)
                        {
                            Form1.tumKayitlar[Form1.tumKayitlar.IndexOf(ogr)]._kursBilgileri._kursDonem = kursDonem;
                            Form1.tumKayitlar[Form1.tumKayitlar.IndexOf(ogr)]._kursBilgileri._kursAd = kursAd;
                            Form1.tumKayitlar[Form1.tumKayitlar.IndexOf(ogr)]._kursBilgileri._kursOgretmenleri = ogretmenler;
                        }
                    }
                }

                MessageBox.Show("Kurs oluşturuldu","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mesaj,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }
    }
}
