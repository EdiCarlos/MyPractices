using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Collections;

namespace SupremeTransport
{
    public partial class Login : Form
    {
        Main main;
        public Login()
        {
            InitializeComponent();
        }
        public Login(Main main)
        {
            InitializeComponent();
            this.main = main;
        }
        /* this is tab selected index which sets 
         * forms Acceptbutton and Cancel button according to tab
         * buttons by default tabpage1 btnSLogin is accept button 
         * and btnscancel for cancel button
         * */
        private void Supremetab_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex.Equals(0))
            {
                this.AcceptButton = this.btnSLogin;
                this.CancelButton = this.btnScancel;
            }
            else
            {
                this.AcceptButton = this.btnZlogin;
                this.CancelButton = this.btnZcancel;
            }
        }

        private void btnSLogin_Click(object sender, EventArgs e)
        {
            dxErrorProvider1.Clear();

            CheckForError error = new CheckForError(this);
            if (!error.IsValidSupremeLoginForm())
            {
                MessageBox.Show("please errors");

            }
            else
            {
                if (UserLogin.CheckUser(txtSupUserName, txtSupUserPass, ComboSupUserType, sender as Button))
                {
                    MessageBox.Show("Welcome " + UserLogin.UserName);
                    UserLogin.Authenticated = true;
                    
                    main.EnableAllToolStrip();
                    main.SupremePendingBills();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("login failed");
                    UserLogin.Authenticated = false;
                }

            }
        }
      
        private void btnZlogin_Click(object sender, EventArgs e)
        {
            dxErrorProvider1.Clear();
            CheckForError error = new CheckForError(this);
            if (!error.IsValidZahidLoginForm())
            {
                MessageBox.Show("please correct the errors");
            }
            else
            {
                if (UserLogin.CheckUser(txtZahUsername, txtZahUserPass, comboZahUserType, sender as Button))
                {
                    MessageBox.Show("welcome " + UserLogin.UserName);
                    UserLogin.Authenticated = true;
                    main.EnableAllToolStrip();
                    main.ZahidPendingBills();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("login failed");
                    UserLogin.Authenticated = false;
                }
            }
        }
        /*this event closes the login form
         * */
        private void btnZcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //this event closes the login form
        private void btnScancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtZahUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnZClear_Click(object sender, EventArgs e)
        {
            txtZahUsername.Text = String.Empty;
            txtZahUserPass.Text = String.Empty;
            comboZahUserType.SelectedIndex = -1;
        }

        private void btnSClear_Click(object sender, EventArgs e)
        {
            txtSupUserName.Text = String.Empty;
            txtSupUserPass.Text = String.Empty;
            ComboSupUserType.SelectedIndex = -1;
        }

        #region validation class

        public class CheckForError
        {
            ArrayList list = new ArrayList();
            Login lg = new Login();
            public CheckForError(Login lg)
            {
                this.lg = lg;
            }
            public bool IsValidSupremeLoginForm()
            {
                bool retErr = true;
                if (ValidationClass.IsEmpty(lg.txtSupUserName))
                {
                    lg.dxErrorProvider1.SetError(lg.txtSupUserName, "User Name Cannot be Empty");
                    list.Add(false);
                }

                if (ValidationClass.IsEmpty(lg.txtSupUserPass))
                {
                    lg.dxErrorProvider1.SetError(lg.txtSupUserPass, "User Password Cannot be Empty");
                    list.Add(false);
                }

                if (ValidationClass.IsComboBoxEmpty(lg.ComboSupUserType))
                {
                    lg.dxErrorProvider1.SetError(lg.ComboSupUserType, "Select User Type");
                    list.Add(false);
                }

                IEnumerator errorList = list.GetEnumerator();

                while (errorList.MoveNext())
                {
                    if (errorList.Current.Equals(false))
                    {
                        retErr = false;
                        break;
                    }
                }

                return retErr;
            }
            public bool IsValidZahidLoginForm()
            {
                bool retErr = true;
                if (ValidationClass.IsEmpty(lg.txtZahUsername))
                {
                    lg.dxErrorProvider1.SetError(lg.txtZahUsername, "User Name Cannot be Empty");
                    list.Add(false);
                }

                if (ValidationClass.IsEmpty(lg.txtZahUserPass))
                {
                    lg.dxErrorProvider1.SetError(lg.txtZahUserPass, "User Password Cannot be Empty");
                    list.Add(false);
                }

                if (ValidationClass.IsComboBoxEmpty(lg.comboZahUserType))
                {
                    lg.dxErrorProvider1.SetError(lg.comboZahUserType, "Select User Type");
                    list.Add(false);
                }

                IEnumerator errorList = list.GetEnumerator();

                while (errorList.MoveNext())
                {
                    if (errorList.Current.Equals(false))
                    {
                        retErr = false;
                        break;
                    }
                }
                return retErr;
            }
        }
        #endregion

        private void txtSupUserName_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}