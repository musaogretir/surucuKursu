using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surucu_Kursu_Otomasyonu
{
    internal class formKontrol
    {
        private Form F { get; set; }    

        private string Fad { get; set; }  

        public Form acikmi(string fad)
        {
            bool isOpen = false; F = null;

            foreach (Form frm in Application.OpenForms)//Formun sadece bir kopyasına izin veriyoruz.
            {
                if (frm.Name == fad)
                {
                    isOpen = true;
                    F = frm;
                }
            }

            return F;
        }
    }
}
