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

namespace NavigationSamples
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Page2 page2 = new Page2();
            this.NavigationService.Navigate(page2);
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {

            this.NavigationService.Navigate(new Uri("Page3.xaml", UriKind.Relative));
        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Page4.xaml", UriKind.Relative));
        }
        private void buttonFour_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("http://www.google.com"));
        }

    }
}
