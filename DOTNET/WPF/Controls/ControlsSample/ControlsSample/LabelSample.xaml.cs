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
using System.Windows.Shapes;

namespace ControlsSample
{
    /// <summary>
    /// Interaction logic for LabelSample.xaml
    /// </summary>
    public partial class LabelSample : Window
    {
        public LabelSample()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Login Button Clicked");
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cancel Button Clicked");
            this.Close();
        }
    }
}
