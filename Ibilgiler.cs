using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surucu_Kursu_Otomasyonu
{
    internal interface Ibilgiler
    {
        void JSONkaydet(string dosya, List<kisi> liste);
        List<kisi> JSONgetir(string dosya, List<kisi> liste);
        void JSONguncelle();
        void JSONsil();

    }
}
