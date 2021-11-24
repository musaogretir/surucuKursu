using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surucu_Kursu_Otomasyonu
{
    internal interface Ibilgiler
    {
        void JSONkaydet(string dosya, kisi kisi);
        void JSONgetir();
        void JSONguncelle();
        void JSONsil();

    }
}
