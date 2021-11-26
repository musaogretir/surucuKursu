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
            JSON j = new JSON();
            List<kisi> liste = new List<kisi>();
            liste = j.JSONgetir("veriler.JSON",liste);

            for (int i = 0; i < liste.Count; i++)
            {
                comboBox3.Items.Add(liste[i]._ad + " " + liste[i]._soyad);
            }
            

        }
    }
}
