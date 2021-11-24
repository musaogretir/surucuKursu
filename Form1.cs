namespace Surucu_Kursu_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void öðrenciKayýtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            ogrKayit ogrKayit =null;

            foreach (Form f in Application.OpenForms)//Formun sadece bir kopyasýna izin veriyoruz.
            {
                if (f.Name == "ogrKayit") { 
                    isOpen = true; 
                    ogrKayit = (ogrKayit)f;
                }
            }
            

            if (isOpen)
            {
                ogrKayit.MdiParent = this;
                ogrKayit.Show();
            }
            else
            {
                ogrKayit = new ogrKayit();
                ogrKayit.MdiParent = this;
                ogrKayit.Show();
            }



        }

        private void öðrenciBÝlgiGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            ogrBilgiGuncelle ogrBilgiGuncelle = null;

            foreach (Form f in Application.OpenForms)//Formun sadece bir kopyasýna izin veriyoruz.
            {
                if (f.Name == "ogrBilgiGuncelle")
                {
                    isOpen = true;
                    ogrBilgiGuncelle = (ogrBilgiGuncelle)f;
                }
            }


            if (isOpen)
            {
                ogrBilgiGuncelle.MdiParent = this;
                ogrBilgiGuncelle.Show();
            }
            else
            {
                ogrBilgiGuncelle = new ogrBilgiGuncelle();
                ogrBilgiGuncelle.MdiParent = this;
                ogrBilgiGuncelle.Show();
            }
        }

        private void öðrenciSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            ogrSil ogrSil = null;

            foreach (Form f in Application.OpenForms)//Formun sadece bir kopyasýna izin veriyoruz.
            {
                if (f.Name == "ogrSil")
                {
                    isOpen = true;
                    ogrSil = (ogrSil)f;
                }
            }


            if (isOpen)
            {
                ogrSil.MdiParent = this;
                ogrSil.Show();
            }
            else
            {
                ogrSil = new ogrSil();
                ogrSil.MdiParent = this;
                ogrSil.Show();
            }
        }

        private void yeniKursOluþturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            yeniKurs yeniKurs = null;

            foreach (Form f in Application.OpenForms)//Formun sadece bir kopyasýna izin veriyoruz.
            {
                if (f.Name == "yeniKurs")
                {
                    isOpen = true;
                    yeniKurs = (yeniKurs)f;
                }
            }


            if (isOpen)
            {
                yeniKurs.MdiParent = this;
                yeniKurs.Show();
            }
            else
            {
                yeniKurs = new yeniKurs();
                yeniKurs.MdiParent = this;
                yeniKurs.Show();
            }
        }

        private void kursGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            kursGuncelle kursGuncelle = null;

            foreach (Form f in Application.OpenForms)//Formun sadece bir kopyasýna izin veriyoruz.
            {
                if (f.Name == "kursGuncelle")
                {
                    isOpen = true;
                    kursGuncelle = (kursGuncelle)f;
                }
            }


            if (isOpen)
            {
                kursGuncelle.MdiParent = this;
                kursGuncelle.Show();
            }
            else
            {
                kursGuncelle = new kursGuncelle();
                kursGuncelle.MdiParent = this;
                kursGuncelle.Show();
            }
        }

       
        private void kursSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            kursSil kursSil = null;

            foreach (Form f in Application.OpenForms)//Formun sadece bir kopyasýna izin veriyoruz.
            {
                if (f.Name == "kursSil")
                {
                    isOpen = true;
                    kursSil = (kursSil)f;
                }
            }


            if (isOpen)
            {
                kursSil.MdiParent = this;
                kursSil.Show();
            }
            else
            {
                kursSil = new kursSil();
                kursSil.MdiParent = this;
                kursSil.Show();
            }
        }

        private void SurucuKursuBilgileriToolStripMenuItem(object sender, EventArgs e)
        {
            bool isOpen = false;

            surucuKursuBilgileri surucuKursuBilgileri = null;

            foreach (Form f in Application.OpenForms)//Formun sadece bir kopyasýna izin veriyoruz.
            {
                if (f.Name == "surucuKursuBilgileri")
                {
                    isOpen = true;
                    surucuKursuBilgileri = (surucuKursuBilgileri)f;
                }
            }


            if (isOpen)
            {
                surucuKursuBilgileri.MdiParent = this;
                surucuKursuBilgileri.Show();
            }
            else
            {
                surucuKursuBilgileri = new surucuKursuBilgileri();
                surucuKursuBilgileri.MdiParent = this;
                surucuKursuBilgileri.Show();
            }
        }

        private void sistemeKullanýcýEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            kullaniciEkle kullaniciEkle = null;

            foreach (Form f in Application.OpenForms)//Formun sadece bir kopyasýna izin veriyoruz.
            {
                if (f.Name == "kullaniciEkle")
                {
                    isOpen = true;
                    kullaniciEkle = (kullaniciEkle)f;
                }
            }


            if (isOpen)
            {
                kullaniciEkle.MdiParent = this;
                kullaniciEkle.Show();
            }
            else
            {
                kullaniciEkle = new kullaniciEkle();
                kullaniciEkle.MdiParent = this;
                kullaniciEkle.Show();
            }
        }

        private void kullanýcýBÝlgisiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            kullaniciGuncelle kullaniciGuncelle = null;

            foreach (Form f in Application.OpenForms)//Formun sadece bir kopyasýna izin veriyoruz.
            {
                if (f.Name == "kullaniciGuncelle")
                {
                    isOpen = true;
                    kullaniciGuncelle = (kullaniciGuncelle)f;
                }
            }


            if (isOpen)
            {
                kullaniciGuncelle.MdiParent = this;
                kullaniciGuncelle.Show();
            }
            else
            {
                kullaniciGuncelle = new kullaniciGuncelle();
                kullaniciGuncelle.MdiParent = this;
                kullaniciGuncelle.Show();
            }
        }

        private void sýnavBilgisiGirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            sinavBilgisiGir sinavBilgisiGir = null;

            foreach (Form f in Application.OpenForms)//Formun sadece bir kopyasýna izin veriyoruz.
            {
                if (f.Name == "sinavBilgisiGir")
                {
                    isOpen = true;
                    sinavBilgisiGir = (sinavBilgisiGir)f;
                }
            }


            if (isOpen)
            {
                sinavBilgisiGir.MdiParent = this;
                sinavBilgisiGir.Show();
            }
            else
            {
                sinavBilgisiGir = new sinavBilgisiGir();
                sinavBilgisiGir.MdiParent = this;
                sinavBilgisiGir.Show();
            }
        }
    }
}