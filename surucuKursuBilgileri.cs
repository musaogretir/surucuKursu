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
    public partial class surucuKursuBilgileri : Form
    {
        public surucuKursuBilgileri()
        {
            InitializeComponent();
        }

        private void surucuKursuBilgileri_Load(object sender, EventArgs e)
        {
            kurs.surucuKursuBilgileri x = new kurs.surucuKursuBilgileri();

            foreach (kisi k in Form1.tumKayitlar)
            {
                x = (kurs.surucuKursuBilgileri)k._kursBilgileri._skb;

                if (x.skAd != null) //Daha önce kurs bilgileri girilmiş ise yüklüyoruz.
                {
                    textBox1.Text = x.skAd;
                    textBox2.Text = x.skAdres;
                    maskedTextBox1.Text = x.skTel;
                    maskedTextBox2.Text = x.skFaks;
                    textBox3.Text = x.skEposta;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kurs.surucuKursuBilgileri x = new kurs.surucuKursuBilgileri();

            x.skAd = textBox1.Text;
            x.skAdres = textBox2.Text;
            x.skTel = maskedTextBox1.Text;
            x.skFaks = maskedTextBox2.Text;
            x.skEposta = textBox3.Text;

            foreach (kisi k in Form1.tumKayitlar)
            {
                k._kursBilgileri._skb = x;
            }

            MessageBox.Show("Sürücü kursu bilgileri eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
