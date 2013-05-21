using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Crom.Controls.Docking;

namespace MyForm
{
    public partial class MainForm : Form
    {
        Crom.Controls.Docking.DockContainer _docker = null;
        public MainForm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            loginForm.TopLevel = false;
            DetailsForm detForm = new DetailsForm();
            detForm.TopLevel = false;
            detForm.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            _docker.PreviewRenderer = new PreviewRenderer();

            //DockableFormInfo loginInfo =  _docker.Add(loginForm, Crom.Controls.Docking.zAllowedDock.Horizontally, Guid.NewGuid());
            //DockableFormInfo detInfo = _docker.Add(detForm, Crom.Controls.Docking.zAllowedDock.Horizontally, Guid.NewGuid());
            _docker.DockForm(_docker.Add(loginForm, Crom.Controls.Docking.zAllowedDock.Unknown, Guid.NewGuid()), DockStyle.Bottom, zDockMode.Inner);
            
           // _docker.Add(detForm, Crom.Controls.Docking.zAllowedDock.All, Guid.NewGuid());
            //_docker.DockForm(loginInfo, DockStyle.Top, zDockMode.Outer);
            _docker.DockForm(_docker.Add(detForm, Crom.Controls.Docking.zAllowedDock.All, Guid.NewGuid()), DockStyle.Fill, zDockMode.None);

        }

        private void _docker_FormClosed(object sender, Crom.Controls.Docking.FormEventArgs e)
        {
            e.Form.Close();
        }

        private void _docker_FormClosing(object sender, DockableFormClosingEventArgs e)
        {
        }
    }
}
