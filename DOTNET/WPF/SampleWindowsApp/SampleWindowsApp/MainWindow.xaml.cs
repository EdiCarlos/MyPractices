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

namespace SampleWindowsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.AddHandler(Window.MouseRightButtonDownEvent, new MouseButtonEventHandler(Window_MouseRightButtonDown), true);
            //this.AddHandler(Button.ClickEvent, new RoutedEventHandler(Generic_Handler));
            this.AddHandler(ListBox.SelectionChangedEvent, new SelectionChangedEventHandler(Generic_Handler));
            //helpButton.Command = ApplicationCommands.Help;
            //this.CommandBindings.Add(new CommandBinding(ApplicationCommands.Help, HelpExecuted, HelpCanExecute));
            //this.CommandBindings.Add(new CommandBinding(ApplicationCommands.Close, applicationClosed, applicationCanClose));
            this.InputBindings.Add(new InputBinding(ApplicationCommands.Help, new KeyGesture(Key.F2)));
            this.InputBindings.Add(new InputBinding(ApplicationCommands.NotACommand, new KeyGesture(Key.F1)));
            //this.InputBindings.Add(new InputBinding(ApplicationCommands.Close, new KeyGesture(Key.Escape)));
        }
        void applicationCanClose(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        void applicationClosed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
        void HelpCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        void HelpExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com/search?q=About Dialog Box");
        }
        void Mouse_Enter(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
                b.Foreground = Brushes.Blue;
        }
        void Mouse_Leave(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
                b.Foreground = Brushes.Black;
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Title = "Source = " + e.Source.GetType().Name + ", OriginalSource = " + e.OriginalSource.GetType().Name + " @ " + e.Timestamp;
            Control c = e.Source as Control;
            if (c.BorderThickness != new Thickness(5))
            {
                c.BorderThickness = new Thickness(5);
                c.BorderBrush = Brushes.Black;
            }
            else
            {
                c.BorderThickness = new Thickness(0);
            }

        }

        private void Window_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Source = "+ e.Source.GetType().Name + ", OrignalSource = " + e.OriginalSource.GetType().Name );
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                MessageBox.Show("You Just selected " + e.AddedItems[0]);
            }
        }
        void Generic_Handler(object sender, RoutedEventArgs e)
        {
            if (e.RoutedEvent == Button.ClickEvent)
            {
                MessageBox.Show("you just clicked" + e.Source);
            }
            else if (e.RoutedEvent == ListBox.SelectionChangedEvent)
            {
                SelectionChangedEventArgs se = e as SelectionChangedEventArgs;
                if (se.AddedItems.Count > 0)
                {
                    MessageBox.Show("You Just selected " + se.AddedItems[0]);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("OK button click");
        }
    }
}
