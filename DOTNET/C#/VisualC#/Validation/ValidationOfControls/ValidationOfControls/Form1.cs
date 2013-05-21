using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ValidationOfControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEmployeename_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmployeename.Text == "")
            {
                errorProvider1.SetError(txtEmployeename, "Employee name Cannot be empty");
                e.Cancel = true;
                return;
            }
            errorProvider1.SetError(txtEmployeename, "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Control control in Controls)
            {
                control.Focus();

                if(!Validate())
                {
                    DialogResult = DialogResult.None;
                    return;
                }
            }
            MessageBox.Show("true");
        }

        private void txtdob_Validating(object sender, CancelEventArgs e)
        {
            DateTime dob;
            if (!DateTime.TryParse(txtdob.Text, out dob))
            {
                errorProvider1.SetError(txtdob, "Must be a date/time value");
                e.Cancel = true;
                return;
            }
            errorProvider1.SetError(txtdob, "");
        }

        private void txtphone_Validating(object sender, CancelEventArgs e)
        {
            //Regex reg = new Regex(@"^\(\d{2}\) \d{4} \d{4}$");
            //if (!reg.IsMatch(txtphone.Text))
            //{
            if (txtphone.Text == String.Empty)
            {
                errorProvider1.SetError(txtphone, "phone number is not valid");
                e.Cancel = true;
                return;
            }//}
            errorProvider1.SetError(txtphone, "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
