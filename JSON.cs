using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Surucu_Kursu_Otomasyonu
{
    internal class JSON : Ibilgiler
    {
        public List<kisi> JSONgetir(string dosya, List<kisi> liste)
        {
            if (File.Exists(dosya))
            {
                string JSONdata = File.ReadAllText(dosya);
                liste = JsonConvert.DeserializeObject<List<kisi>>(JSONdata);
            }
            return liste;
        }


        public void JSONguncelle()
        {
            throw new NotImplementedException();
        }

        public void JSONkaydet(string dosya, List<kisi> liste)
        {
            string JSONdata = JsonConvert.SerializeObject(liste);
            if (File.Exists(dosya))
            {
                File.Delete(dosya);
                using (var dy = new StreamWriter(dosya, true))
                {
                    dy.WriteLine(JSONdata);
                    dy.Close();
                }
            }
            else
            {
                using (var dy = new StreamWriter(dosya, true))
                {
                    dy.WriteLine(JSONdata);
                    dy.Close();
                }
            }
        }

        public void JSONsil()
        {
            throw new NotImplementedException();
        }
    }
}
