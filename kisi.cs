using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Surucu_Kursu_Otomasyonu
{
    internal class kisi : Ibilgiler
    {
        public long _tckimlik { get; set; }
        public string _ad { get; set; }
        public string _soyad { get; set; }
        public string _dt { get; set; }
        public string _dy { get; set; }
        public int _cs { get; set; }

        public kisi(long tckimlik, string ad, string soyad, string dt, string dy, int cs)
        {
            this._tckimlik = tckimlik;
            this._ad = ad;
            this._soyad = soyad;
            this._dt = dt;
            this._dy = dy;
            this._cs = cs;
        }

        public kisi()
        {
        }

        public void JSONgetir()
        {
            throw new NotImplementedException();
        }

        public void JSONguncelle()
        {
            throw new NotImplementedException();
        }

        public void JSONkaydet(string dosya, kisi kisi)
        {
            List<kisi> liste = new List<kisi>();
            liste.Add(kisi);
            string json = JsonSerializer.Serialize(liste);
            MessageBox.Show(json);
            File.AppendAllText(@dosya, json);
        }

        public void JSONsil()
        {
            throw new NotImplementedException();
        }
    }
}
