using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Utils;
using DevExpress.Data;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace SupremeTransport
{
    class ValidationClass
    {
        public ValidationClass()
        {
        }
       
        public static bool IsEmpty(TextBox txt)
        {
            return txt.Text.Length <= 0 ? true : false;
        }
        public static bool IsMoreThanThirty(TextBox txt)
        {
            return txt.Text.Length > 30 ? true : false;
        }
        public static bool IsComboBoxEmpty(ComboBoxEdit combo)
        {
            return combo.SelectedIndex == -1 ? true : false;
        }

        public static bool IsTextEditEmpty(TextEdit edit)
        {
            return edit.Text == String.Empty ? true : false; 
        }
        public static bool IsTextEditZero(TextEdit edit)
        {
            return edit.Text == "0.00" ? true : false;
        }
        public static bool IsTextEditSingleZero(TextEdit edit)
        {
            return edit.Text == "0" ? true : false;
        }
        public static bool IsTextEditEmptyOrSingleZero(TextEdit edit)
        {
            if (edit.Text.Equals(String.Empty) | edit.Text.Equals("0"))
            {
                return true;
            }
            else
            {
                return false;
            }
            return false;
        }
        public static bool IsCalcEditEmpty(CalcEdit edit)
        {
            return edit.Text == String.Empty ? true : false;
        }

        public static bool IsTextBoxEmpty(TextBox text)
        {
            return text.Text == String.Empty ? true : false;
        }
        public static bool IsTextBoxZero(TextBox edit)
        {
            return edit.Text == "0.00" ? true : false;
        }

        public static bool IsDateEditEmpty(DateEdit edit)
        {
            return edit.Text == String.Empty ? true : false;
        }
        public static bool IsComboEditSelectedIndexZero(ComboBoxEdit combo)
        {
            return combo.SelectedIndex == -1 ? true : false;
        }
        
    }
}
