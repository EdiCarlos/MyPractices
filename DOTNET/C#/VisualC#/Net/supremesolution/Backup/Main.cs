using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SupremeTransport
{

    public partial class Main : Form
    {

        Login frm;
        LogOutFrm logOutfrm;
        Supreme_Bill supremeBill;

        zahid_mainBill zahid_mbill;
        Dispatch_report dispatch;
        Supreme_local supremeLocal;
        DdBackup dbbackup;
        Supreme_Pend supremePending;
        Zahid_Pending zahidPending;
        Supreme_local_pending supreme_local_pend;
        SupBillReceived supbillrcvd;
        ZahBillRecieved zahbillrcvd;
        SupLocalBillRecieved lclBillRecieved;
        ZahPaymentReceived zahidPaymentRcv;
        private int childFormNumber = 0;

        public Main()
        {
            InitializeComponent();
            frm = new Login(this);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            EnableAllToolStrip();
            //supremeBill = new Supreme_Bill();
            //supremeBill.MdiParent = this;
            //supremeBill.WindowState = FormWindowState.Maximized;
            //supremeBill.Show();

        }

        public void EnableAllToolStrip()
        {
            if (UserLogin.Authenticated)
            {
                toolStripBillRecieved.Enabled = true;
                toolStripBillsPending.Enabled = true;
                toolStripBills.Enabled = true;
                LoginToolStripMenuItem.Enabled = false;
                LogOutToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                this.Text += "Logged in as " + UserLogin.UserName;
                if (UserLogin.Usergroup == userGroup.Supreme)
                {
                    zahidMainBillToolStripMenuItem.Enabled = false;
                    zahidPendingBillsToolStripMenuItem.Enabled = false;
                    zahidBillsToolStripMenuItem1.Enabled = false;
                }
                else
                {
                    zahidMainBillToolStripMenuItem.Enabled = true;
                    zahidPendingBillsToolStripMenuItem.Enabled = true;
                    zahidBillsToolStripMenuItem1.Enabled = true;

                }

                if (UserLogin.Usergroup == userGroup.Zahid)
                {
                    supremePendingBillsToolStripMenuItem.Enabled = false;
                    supremeLocalBillsToolStripMenuItem.Enabled = false;
                    supremeBillsToolStripMenuItem.Enabled = false;
                    supremeBillsRecievedToolStripMenuItem.Enabled = false;
                    supremeLocalBillsRecievedToolStripMenuItem.Enabled = false;
                }
                else
                {
                    supremePendingBillsToolStripMenuItem.Enabled = true;
                    supremeLocalBillsToolStripMenuItem.Enabled = true;
                    supremeBillsToolStripMenuItem.Enabled = true;
                    supremeBillsRecievedToolStripMenuItem.Enabled = true;
                    supremeLocalBillsRecievedToolStripMenuItem.Enabled = true;
                }
            }
            else
            {
                toolStripBillRecieved.Enabled = false;
                toolStripBillsPending.Enabled = false;
                toolStripBills.Enabled = false;
                LoginToolStripMenuItem.Enabled = true;
                LogOutToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
            }
        }

        #region File strip events
        private void ShowNewForm(object sender, EventArgs e)
        {
            // Create a new instance of the child form.
            Form childForm = new Form();
            // Make it a child of this MDI form before showing it.
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                // TODO: Add code here to open the file.
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
                // TODO: Add code here to save the current contents of the form to a file.
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard.GetText() or System.Windows.Forms.GetData to retrieve information from the clipboard.
        }
        #endregion

        #region Windows Tool Strip events
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void TileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        #endregion

        #region Status Bar Events

        private void statusStrip_SizeChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Width = " + this.Size.Width + " Height = " + this.Size.Height;
        }
        #endregion

        #region control tool strip events
        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormStatus.IsActive(this, frm))
            {
                frm = new Login(this);
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Login form is Already Opened \n please close the form first");
            }
        }
        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["LogOutFrm"];
            if (frm == null)
            {
                logOutfrm = new LogOutFrm(this);
                logOutfrm.Show();
            }
            else
            {
                MessageBox.Show("Logout form is already opened");
            }
        }

        #endregion
        #region Mdi Container Events

        private void Main_MdiChildActivate(object sender, EventArgs e)
        {
            //foreach (Form frm in this.MdiChildren)
            //{
            //    MessageBox.Show(frm.Name);
            //}
        }
        #endregion
        /* this event opens logout pop box*/
        #region View Strip events
        private void toolbarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolbarsToolStripMenuItem.Checked;
        }

        private void statusBarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem1.Checked;
        }
        #endregion
        #region bills strip events
        private void supremeBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supremeBill = new Supreme_Bill();
            supremeBill.MdiParent = this;
            supremeBill.WindowState = FormWindowState.Maximized;
            supremeBill.Show();
        }
        private void zahidBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zahid_mbill = new zahid_mainBill();
            zahid_mbill.MdiParent = this;
            zahid_mbill.WindowState = FormWindowState.Maximized;
            zahid_mbill.Show();
        }

        #endregion

        private void dispatchReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dispatch = new Dispatch_report();
            dispatch.MdiParent = this;
            dispatch.WindowState = FormWindowState.Maximized;
            dispatch.Show();
        }

        private void supremeLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supremeLocal = new Supreme_local();
            supremeLocal.MdiParent = this;
            supremeLocal.WindowState = FormWindowState.Maximized;
            supremeLocal.Show();
        }

        private void backupDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbbackup = new DdBackup();
            dbbackup.MdiParent = this;
            dbbackup.WindowState = FormWindowState.Maximized;
            dbbackup.Show();
        }

        private void supremePendingBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supremePending = new Supreme_Pend();
            supremePending.MdiParent = this;
            supremePending.WindowState = FormWindowState.Maximized;
            supremePending.Show();
            supremePending.DefaultStyle();
        }

        public void SupremePendingBills()
        {
            supremePending = new Supreme_Pend();
            supremePending.MdiParent = this;
            supremePending.WindowState = FormWindowState.Maximized;
            supremePending.Show();
            supremePending.DefaultStyle();

        }
        private void zahidPendingBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zahidPending = new Zahid_Pending();
            zahidPending.MdiParent = this;
            zahidPending.WindowState = FormWindowState.Maximized;
            zahidPending.Show();
            zahidPending.DefaultStyle();
        }
        public void ZahidPendingBills()
        {
            zahidPending = new Zahid_Pending();
            zahidPending.MdiParent = this;
            zahidPending.WindowState = FormWindowState.Maximized;
            zahidPending.Show();
            zahidPending.DefaultStyle();

        }
        private void supremeLocalBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supreme_local_pend = new Supreme_local_pending();
            supreme_local_pend.MdiParent = this;
            supreme_local_pend.WindowState = FormWindowState.Maximized;
            supreme_local_pend.Show();
            supreme_local_pend.DefaultStyle();

        }

        private void supremeBillsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            supbillrcvd = new SupBillReceived();
            supbillrcvd.MdiParent = this;
            supbillrcvd.WindowState = FormWindowState.Maximized;
            supbillrcvd.Show();
        }

        private void zahidBillsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //zahbillrcvd = new ZahBillRecieved();
            //zahbillrcvd.MdiParent = this;
            //zahbillrcvd.WindowState = FormWindowState.Maximized;
            //zahbillrcvd.Show();
            zahidPaymentRcv = new ZahPaymentReceived();
            zahidPaymentRcv.MdiParent = this;
            zahidPaymentRcv.WindowState = FormWindowState.Maximized;
            zahidPaymentRcv.Show();
        }

        private void supremeLocalBillsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lclBillRecieved = new SupLocalBillRecieved();
            lclBillRecieved.MdiParent = this;
            lclBillRecieved.WindowState = FormWindowState.Maximized;
            lclBillRecieved.Show();
        }
    }
}
