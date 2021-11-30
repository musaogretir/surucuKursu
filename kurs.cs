using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surucu_Kursu_Otomasyonu
{
    public class kurs
    {
        public string _kursDonem { get; set; }
        public string _kursAd { get; set; }
        public string[] _kursOgretmenleri { get; set; }

        public kurs(string kursDonem = null, string kursAd = null, string[] kursOgretmenleri = null)
        {
            this._kursDonem = kursDonem;
            this._kursAd = kursAd;
            this._kursOgretmenleri = kursOgretmenleri;
        }
    }
}
