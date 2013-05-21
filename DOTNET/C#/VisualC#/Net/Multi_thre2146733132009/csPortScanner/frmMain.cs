using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace csPortScanner
{
    public partial class frmMain : Form
    {

        int nStartPort = 0;
        int nEndPort = 1000;
        int nCurrPort = 0;
        int nThreadCount = 100;
        int nTimeOut = 150;
        bool bScanning = false;
        string cCurrIP = "127.0.0.1";
        string cEndIP = "127.0.0.1";

        System.Threading.Thread[] ScanThread; // declares thread array

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            
            if (!bScanning) // check to make sure that we are NOT scanning
            {
                bScanning = true;

                this.btnScan.Text = "Stop Scan";

                cCurrIP = this.txtTragetIP.Text;
                cEndIP = this.txtEndIP.Text;

                nStartPort = Convert.ToInt32(txtStartPort.Text);
                nEndPort = Convert.ToInt32(txtEndPort.Text);
                nTimeOut = Convert.ToInt32(txtTimeOut.Text);

                ProgressBar.Minimum = 0;
                ProgressBar.Maximum = ((nEndPort - nStartPort) + 1);
                ProgressBar.Value = 0;
                lblClosedPorts.Text = "0";
                lblOpenPorts.Text = "0";
                lblIPScanned.Text = "0";
                lvwResults.Items.Clear();

                ScanIP(cCurrIP);   // starts scanning

            }
            else
            {
                System.Windows.Forms.DialogResult msgBox;
                int nNumOfThreadsToKill = (ScanThread.Length - 1);

                msgBox = MessageBox.Show("Are you sure you want to abort the scan?", "Abort Scan?", MessageBoxButtons.YesNo,MessageBoxIcon.Information) ;
                if (msgBox == DialogResult.Yes)
                {
                    for (int lPtr = 0; lPtr <= nNumOfThreadsToKill; lPtr++)
                    {
                        if (ScanThread[lPtr].IsAlive) 
                        { 
                            ScanThread[lPtr].Abort(); 
                            this.Text = "Active Threads [" + (nThreadCount - lPtr) + "] - PLEASE WAIT";
                        };
                    }

                    bScanning = false;
                    this.Text = "C# Port Scanner";
                    this.btnScan.Text = "Start Scan";
                    MessageBox.Show("Scan aborted!");
                };// end if

            }; // end if

        }

        private void ScanIP(string tCurrip)
        {
            nCurrPort = nStartPort;
            nThreadCount = Convert.ToInt32(txtThreadCount.Text);
            
            ScanThread = new System.Threading.Thread[nThreadCount]; // sets array size to nThreadCount

            for (int lPtr = 0; lPtr <= (ScanThread.Length - 1); lPtr++)
            {
                ScanThread[ lPtr ] = new System.Threading.Thread(ScanPorts);
                ScanThread[ lPtr ].Name = "Thread " + lPtr;
                ScanThread[ lPtr ].IsBackground = true;
                ScanThread[ lPtr ].Start();
                this.Text = "Active Threads [" + (lPtr + 1) + "] Scanning : " + tCurrip;
            } //end for

            System.Threading.Thread.Sleep(200);

        }

        private void ScanPorts()
        {

            System.Net.Sockets.TcpClient tcpSock; 
            int tPort;

            do // while (currPort < endPort)
            {
                nCurrPort++;    // increment nCurrPort by 1
                tPort = nCurrPort;    // Thread Port : saves ports to probe in the routeins local variable - less chances of two or more threads getting the same port number
                
                try
                {
                    tcpSock = new System.Net.Sockets.TcpClient();
                    tcpSock.Connect(cCurrIP, tPort);                // Attempt to connect to an IP on a Port
                    System.Threading.Thread.Sleep(nTimeOut);
                    if (tcpSock.Connected) 
                    {
                        WriteToList(cCurrIP + ":" + tPort); // add open ip:port to list control
                        WriteToResults("1"); // increase the open port count
                        tcpSock.Close();    //Makes sure the socket is closed
                    }
                    else
                    {
                        WriteToResults("0"); // increase the closed port count
                    }
                }
                catch 
                {
                    WriteToResults("0"); // on error assume that it was a connection error, thus increment port closed count
                }
                finally
                {
                   progressBarInc(""); // increase the value of the progress bar by 1
                }
            } while (nCurrPort < nEndPort);

            nThreadCount--;

            if (nThreadCount == 1){ // check if this is the last thread running
                cCurrIP = GetNextIP(cCurrIP);   // gets next ip to work on
                WriteToResults("2"); // + IP scanned count
                System.Threading.Thread.Sleep(500);
                if (cCurrIP != GetNextIP(cEndIP))
                {   // starts scanning next ip

                    progressBarInc("reset");    // resets the progressbar for the next IP
                    SetTextCallback d = new SetTextCallback(ScanIP);
                    this.Invoke(d, new object[] { cCurrIP });
                }
                else    // otherwise the scan is complete..
                {
                    progressBarInc("");    // & reset btnScan to 'start scan'
                    bScanning = false;
                    MessageBox.Show("Scan Complete!" );
                };
                
            }
        }

        private string GetNextIP(string cCurrentIP)
        {
            string[] cSegment = cCurrentIP.Split('.');
            string cTempNextIP = "";
            int[] nSegment;

            if (cCurrentIP == "255.255.255.255") { return "0.0.0.0"; };

            nSegment = new int[4];

            for (int nSeg = 0; nSeg < nSegment.Length; nSeg++)
            {
                nSegment[nSeg] = Convert.ToInt32(cSegment[nSeg]); // to convert string to int
            }

            if (nSegment[3] >= 255) { nSegment[2]++; cTempNextIP = Convert.ToString(nSegment[0] + "." + nSegment[1] + "." + nSegment[2] + ".1"); }
            else { nSegment[3]++; cTempNextIP = Convert.ToString(nSegment[0] + "." + nSegment[1] + "." + nSegment[2] + "." + nSegment[3]); };
            if (nSegment[2] >= 256) { nSegment[1]++; cTempNextIP = Convert.ToString(nSegment[0] + "." + nSegment[1] + ".0.1"); };
            if (nSegment[1] >= 256) { nSegment[0]++; cTempNextIP = Convert.ToString(nSegment[0] + ".0.0.1"); };

            return cTempNextIP;

        }

        private void txtTragetIP_TextChanged(object sender, EventArgs e)
        {
            this.txtEndIP.Text = this.txtTragetIP.Text;
        }

#region Form : Thread Interaction... Messy code sorry

        delegate void SetTextCallback(string text);

        public void WriteToList(string sText)
        {

            System.Threading.Thread.Sleep(100);

            // Check if this method is running on a different thread
            // than the thread that created the control.
            if (this.lvwResults.InvokeRequired)
            {
                // It's on a different thread, so use Invoke.
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke
                    (d, new object[] { sText });
            }
            else
            {
                // It's on the same thread, no need for Invoke
                SetText(sText);
            }

        }

        private void SetText(string sText)
        {

            string[] sData = sText.Split(':');  // used to seperate IP:PORT in sText
            
            this.lvwResults.BeginUpdate();

            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;

            lvi = new ListViewItem();
            lvi.Text = sData[0] ;

            lvsi = new ListViewItem.ListViewSubItem();
            lvsi.Text = sData[1];
            lvi.SubItems.Add(lvsi);

            lvsi = new ListViewItem.ListViewSubItem();
            lvsi.Text = "Open"; // we are only listing open ports so this may as well be a const :)
            lvi.SubItems.Add(lvsi);

            this.lvwResults.Items.Add(lvi);

            this.lvwResults.EndUpdate();


        }

        private void WriteToResults(string sText)
        {

            System.Threading.Thread.Sleep(100);

            // Check if this method is running on a different thread
            // than the thread that created the control.
            
            
                // It's on a different thread, so use Invoke.
                SetTextCallback d = new SetTextCallback(SetResult);
                this.Invoke
                    (d, new object[] { sText });

        }

        private void SetResult(string sText)
        {
            int nVal = 0;
            switch(Convert.ToInt32(sText))
            {
                case 0:
                    nVal = Convert.ToInt32(this.lblClosedPorts.Text);
                    nVal++;
                    this.lblClosedPorts.Text = Convert.ToString(nVal);
                    break;
                case 1:
                    nVal = Convert.ToInt32(this.lblOpenPorts.Text);
                    nVal++;
                    this.lblOpenPorts.Text = Convert.ToString(nVal);
                    break;
                default:
                    nVal = Convert.ToInt32(this.lblIPScanned.Text);
                    nVal++;
                    this.lblIPScanned.Text = Convert.ToString(nVal);
                    break;
            } // end switch
        }

        public void progressBarInc(string sText)
        {

            System.Threading.Thread.Sleep(100);

            // Check if this method is running on a different thread
            // than the thread that created the control.
            try
            {
                if (this.ProgressBar.InvokeRequired)
                {
                    // It's on a different thread, so use Invoke.
                    SetTextCallback d = new SetTextCallback(SetPB);
                    if (sText != "reset") { this.Invoke(d, new object[] { "invoke" }); }
                    else { this.Invoke(d, new object[] { "reset" }); };
                }
                else
                {
                    // It's on the same thread, no need for Invoke
                    ProgressBar.Value++;
                }
            }
            catch { } // Stops the program from crashing, hehehehe :)

        }

        private void SetPB(string sText)
        {
            
            if (sText == "reset") { ProgressBar.Value = 0; }
            else { ProgressBar.Value++; }; // incremnets progress bar

            if (ProgressBar.Value == ProgressBar.Maximum) { this.btnScan.Text = "Start Scan"; }; // not the best place to put this, but, meh :p
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }




#endregion


    }
}
