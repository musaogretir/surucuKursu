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

            kisi k = new kisi(tc, ad, soyad, dt, dy, cs);
            k.JSONkaydet("veriler.JSON",k);
        }
    }
}
