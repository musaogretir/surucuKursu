using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surucu_Kursu_Otomasyonu
{
    public class kurs
    {
        public struct surucuKursuBilgileri {
            public string? skAd;
            public string? skAdres;
            public string? skTel;
            public string? skFaks;
            public string? skEposta;
        }

        public surucuKursuBilgileri? _skb { get; set; }
        public string? _kursDonem { get; set; }
        public string? _kursAd { get; set; }
        public string[]? _kursOgretmenleri { get; set; }

        public kurs(surucuKursuBilgileri? skb, string? kursDonem, string? kursAd, string[]? kursOgretmenleri)
        {
            this._skb = skb;
            this._kursDonem = kursDonem;
            this._kursAd = kursAd;
            this._kursOgretmenleri = kursOgretmenleri;
        }
    }
}
