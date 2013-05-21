using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyButton
{
    public partial class LoginControl : UserControl
    {
        public event EventHandler BtnHandler;
        public event EventHandler BtnClearHandler;
        public LoginControl()
        {
            InitializeComponent();
            btnLogin.Click += new EventHandler(btnLogin_Click);
            btnClear.Click += new EventHandler(btnClear_Click);
        }

        void btnClear_Click(object sender, EventArgs e)
        {
            RaiseClearButtonClicked(e);
        }
        string username;
        string password;
        [EditorBrowsable(EditorBrowsableState.Always)]
        public string Password
        {
            get { return password; }
            set { password = value;
              }
        }
        [EditorBrowsable(EditorBrowsableState.Always)]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        
        [EditorBrowsable(EditorBrowsableState.Always)]
        public void RaiseLoginButtonClicked(EventArgs e)
        {
            if (BtnHandler != null)
            {
                BtnHandler(this, e);
            }
        }
        [EditorBrowsable(EditorBrowsableState.Always)]
        public void RaiseClearButtonClicked(EventArgs e)
        {
            if (BtnClearHandler != null)
            {
                BtnClearHandler(this, e);
            }
        }
        void btnLogin_Click(object sender, EventArgs e)
        {
            RaiseLoginButtonClicked(e);
        }
    }
}
