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
    public partial class ogrSil : Form
    {
        public ogrSil()
        {
            InitializeComponent();
        }

        private void ogrSil_Load(object sender, EventArgs e)
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
                btnSil.Enabled = true;
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
                btnSil.Enabled = false;
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Kayıt silinecek.\nOnaylıyor musunuz?","Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            
            if (d == DialogResult.Yes)
            {
                int secim = comboBox3.SelectedIndex;

                Form1.tumKayitlar.RemoveAt(secim);

                JSON j = new JSON();

                j.JSONkaydet("veriler.JSON", Form1.tumKayitlar);

                ogrSil_Load(this,null);

                MessageBox.Show("Kayıt silindi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
