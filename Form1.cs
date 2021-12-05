namespace Surucu_Kursu_Otomasyonu
{
    public partial class Form1 : Form
    {
        formKontrol fk = new formKontrol();

        public static List<kisi> tumKayitlar = new List<kisi>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Daha önceden dosyaya eklenmiþ kayýtlarý listeye alýyoruz.
            JSON j = new JSON();
           tumKayitlar = j.JSONgetir("veriler.JSON", tumKayitlar);

            //tumKayitlar.Add(new kisi("55555555555", "musa", "öðretir", "kay", "01/01/1980", 1, "y", "55", "aa","b", new int[] { 0, 0, 0, 0, 0, 0 }));
        }

        private void öðrenciKayýtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrKayit frm = (ogrKayit)fk.acikmi("ogrKayit", new ogrKayit());
            frm.MdiParent = this;
            frm.Show();
        }

        private void öðrenciBÝlgiGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrBilgiGuncelle frm = (ogrBilgiGuncelle)fk.acikmi("ogrBilgiGuncelle", new ogrBilgiGuncelle());
            frm.MdiParent = this;
            frm.Show();
        }

        private void öðrenciSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrSil frm = (ogrSil)fk.acikmi("ogrSil", new ogrSil());
            frm.MdiParent = this;
            frm.Show();
        }

        private void yeniKursOluþturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yeniKurs frm = (yeniKurs)fk.acikmi("yeniKurs", new yeniKurs());
            frm.MdiParent = this;
            frm.Show();
        }

        private void kursGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kursGuncelle frm = (kursGuncelle)fk.acikmi("kursGuncelle", new kursGuncelle());
            frm.MdiParent = this;
            frm.Show();
        }

       
        private void kursSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kursSil frm = (kursSil)fk.acikmi("kursSil", new kursSil());
            frm.MdiParent = this;
            frm.Show();
        }        
        private void SurucuKursuBilgileriToolStripMenuItem(object sender, EventArgs e)
        {
            surucuKursuBilgileri frm = (surucuKursuBilgileri)fk.acikmi("surucuKursuBilgileri", new surucuKursuBilgileri());
            frm.MdiParent = this;
            frm.Show();
        }

        private void sistemeKullanýcýEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullaniciEkle frm = (kullaniciEkle)fk.acikmi("kullaniciEkle", new kullaniciEkle());
            frm.MdiParent = this;
            frm.Show();
        }

        private void kullanýcýBÝlgisiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullaniciGuncelle frm = (kullaniciGuncelle)fk.acikmi("kullaniciGuncelle", new kullaniciGuncelle());
            frm.MdiParent = this;
            frm.Show();
        }

        private void kullanýcýSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullaniciSil frm = (kullaniciSil)fk.acikmi("kullaniciSil", new kullaniciSil());
            frm.MdiParent = this;
            frm.Show();
        }

        private void sýnavBilgisiGirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sinavBilgisiGir frm = (sinavBilgisiGir)fk.acikmi("sinavBilgisiGir", new sinavBilgisiGir());
            frm.MdiParent = this;
            frm.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            JSON j = new JSON();
            j.JSONkaydet("veriler.JSON", Form1.tumKayitlar);
        }
    }
}