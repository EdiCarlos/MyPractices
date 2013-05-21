using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Activities;
using System.Threading;
using System.ComponentModel;

namespace SimpleExpenseReport
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private int amount = 0;
        AutoResetEvent eve;
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        string result;
        bool isApproveButtonEnabled = false, isRejectButtonEnabled = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OnAborted(WorkflowApplicationAbortedEventArgs args)
        {
            throw new InvalidOperationException("Workflow aborted", args.Reason);
        }
        IApproval approve;
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            eve = new AutoResetEvent(false);
            //MainWindowActivity activity = new MainWindowActivity();
            FlowChartActivityForAmount activity = new FlowChartActivityForAmount();
            WorkflowApplication workFlow = new WorkflowApplication(activity) { Aborted = this.OnAborted };
            approve = new Approval();
            approve.Approve = IsEnable;
            approve.Reject = IsRej;
            approve.TaskCompleted = this.TaskComplete;
            workFlow.Extensions.Add(approve);
            activity.Amount = Convert.ToInt32(textBox1.Text);
            workFlow.Run();
            eve.WaitOne();
            lblApproval.Content = Result;
            btnApproval.IsEnabled = isApproveButtonEnabled;
            btnReject.IsEnabled = isRejectButtonEnabled;
        }
        private void IsRej()
        {
            //MessageBoxResult result =  MessageBox.Show("Rejected");
            Result = "Rejected";
            approve.TaskCompleted();
            isApproveButtonEnabled = false;
            isRejectButtonEnabled = true;
        }

        private void TaskComplete()
        {
            eve.Set();
        }
        private void IsEnable()
        {
            //MessageBox.Show("Approved");
            Result = "Approved";
            approve.TaskCompleted();
            isApproveButtonEnabled = true;
            isRejectButtonEnabled = false;
        }
        public string Result
        {
            get
            {
                return this.result;
            }
            set
            {
                result = value;
                this.RaisePropertyChanged("PropertyChanged");
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string prop)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
        #endregion

        private void btnApproval_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format("{0} has been approved", textBox1.Text));
        }

        private void btnReject_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format("{0} has been rejected",textBox1.Text));
        }
    }
}
