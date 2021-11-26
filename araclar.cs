using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surucu_Kursu_Otomasyonu
{
    internal class araclar
    {
        public static void resetForm(Panel p)//Formdaki bilgi giriş alanlarını temizliyoruz.
        {
            foreach (Control control in p.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is MaskedTextBox)
                {
                    MaskedTextBox maskedtextBox = (MaskedTextBox)control;
                    maskedtextBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                } 
                
            }
        }
    }
}
