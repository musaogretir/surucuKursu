using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Surucu_Kursu_Otomasyonu
{
    public class kisi
    {
        public string _tckimlik { get; set; }
        public string _ad { get; set; }
        public string _soyad { get; set; }
        public string _dt { get; set; }
        public string _dy { get; set; }
        public int _cs { get; set; }
        public string _adres { get; set; }
        public string _tel { get; set; }
        public string _eposta { get; set; }
        public string _ehliyetTuru { get; set; }
        public int[] _evraklar { get; set; }
        public kurs? _kursBilgileri { get; set; }


        public kisi(string tckimlik, string ad, string soyad, string dt, string dy, int cs, string adres, string tel, string eposta, string ehliyetTuru, int[] evraklar, kurs? kursBilgileri)
        {
            this._tckimlik = tckimlik;
            this._ad = ad;
            this._soyad = soyad;
            this._dt = dt;
            this._dy = dy;
            this._cs = cs;
            this._adres = adres;
            this._tel = tel;
            this._eposta = eposta;
            this._ehliyetTuru = ehliyetTuru;
            this._evraklar = evraklar;
            this._kursBilgileri = kursBilgileri;
        }
    }
}
