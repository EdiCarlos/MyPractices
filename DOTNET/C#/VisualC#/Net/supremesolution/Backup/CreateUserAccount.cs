using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SupremeTransport
{
    public partial class CreateUserAccount : Form
    {
        Main main;
        public CreateUserAccount()
        {
            InitializeComponent();
        }
        public CreateUserAccount(Main main)
        {
            this.main = main;
        }
        private void Supremetab_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex.Equals(0))
            {
                this.AcceptButton = btnSCreateAccount;
                this.CancelButton = btnScancel;
            }
            else
            {
                this.AcceptButton = btnZCreateAccount;
                this.CancelButton = btnZcancel;
            }
        }
    }
}