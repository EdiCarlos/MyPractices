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

namespace LayoutSample
{
    /// <summary>
    /// Interaction logic for VSStyleForm.xaml
    /// </summary>
    public partial class VSStyleForm : Window
    {
        ColumnDefinition column1CloneForLayer0;
        ColumnDefinition column2CloneForLayer0;
        ColumnDefinition column2CloneForLayer1;

        public VSStyleForm()
        {
            InitializeComponent();
            column1CloneForLayer0 = new ColumnDefinition();
            column1CloneForLayer0.SharedSizeGroup = "column1";
            column2CloneForLayer0 = new ColumnDefinition();
            column2CloneForLayer0.SharedSizeGroup = "column2";
            column2CloneForLayer1 = new ColumnDefinition();
            column2CloneForLayer1.SharedSizeGroup = "column2";
        }
        private void pane1Pin_Click(object sender, RoutedEventArgs e)
        {
            if (pane1Button.Visibility == System.Windows.Visibility.Collapsed)
            {
                UnDockPane(1);
            }
            else
            {
                DockPane(1);
            }
        }

        private void DockPane(int paneNumber)
        {
            if (paneNumber == 1)
            {
                pane1Button.Visibility = System.Windows.Visibility.Collapsed;
                pane1Image.Source = new BitmapImage(new Uri("http://icons.iconarchive.com/icons/aha-soft/blue/16/pin-icon.png"));
                Layer0.ColumnDefinitions.Add(column1CloneForLayer0);
                if (pane2Button.Visibility == System.Windows.Visibility.Collapsed)
                {
                    Layer1.ColumnDefinitions.Add(column2CloneForLayer1);
                }
            }
            else if (paneNumber == 2)
            {
                pane2Button.Visibility = System.Windows.Visibility.Collapsed;
                pane2PinImage.Source = new BitmapImage(new Uri("http://icons.iconarchive.com/icons/aha-soft/blue/16/pin-icon.png"));

                Layer0.ColumnDefinitions.Add(column2CloneForLayer0);

                if (pane1Button.Visibility == System.Windows.Visibility.Collapsed)
                {
                    Layer1.ColumnDefinitions.Add(column2CloneForLayer1);
                }
            }
        }

        private void UnDockPane(int paneNumber)
        {
            if (paneNumber == 1)
            {
                Layer1.Visibility = Visibility.Visible;
                pane1Button.Visibility = Visibility.Visible;
                pane1Image.Source = new BitmapImage(new Uri("http://icons.iconarchive.com/icons/icons-land/vista-map-markers/16/Map-Marker-Push-Pin-1-Chartreuse-icon.png"));
                // Remove the cloned columns from layers 0 and 1:
                Layer0.ColumnDefinitions.Remove(column1CloneForLayer0);
                // This won’t always be present, but Remove silently ignores bad columns:
                Layer1.ColumnDefinitions.Remove(column2CloneForLayer1);
            }
            else if (paneNumber == 2)
            {
                Layer2.Visibility = Visibility.Visible;
pane2Button.Visibility = Visibility.Visible;
pane2PinImage.Source = new BitmapImage(new Uri("http://icons.iconarchive.com/icons/icons-land/vista-map-markers/16/Map-Marker-Push-Pin-1-Chartreuse-icon.png"));
// Remove the cloned columns from layers 0 and 1:
Layer0.ColumnDefinitions.Remove(column2CloneForLayer0);
// This won’t always be present, but Remove silently ignores bad columns:
Layer1.ColumnDefinitions.Remove(column2CloneForLayer1);
            }
        }
        private void pane1Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Layer1.Visibility = Visibility.Visible;
            // Adjust Z order to ensure the pane is on top:
            Grid.SetZIndex(Layer1, 1);
            Grid.SetZIndex(Layer2, 0);
            // Ensure the other pane is hidden if it is undocked
            if (pane2Button.Visibility == Visibility.Visible)
                Layer2.Visibility = Visibility.Collapsed;

        }

        private void pane2Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Layer2.Visibility = Visibility.Visible;
            // Adjust Z order to ensure the pane is on top:
            Grid.SetZIndex(Layer2, 1);
            Grid.SetZIndex(Layer1, 0);
            // Ensure the other pane is hidden if it is undocked
            if (pane1Button.Visibility == Visibility.Visible)
                Layer1.Visibility = Visibility.Collapsed;
        }

        private void Layer0_MouseEnter(object sender, MouseEventArgs e)
        {
            if (pane1Button.Visibility == Visibility.Visible)
                Layer1.Visibility = Visibility.Collapsed;
            if (pane2Button.Visibility == Visibility.Visible)
                Layer2.Visibility = Visibility.Collapsed;
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            if (pane2Button.Visibility == Visibility.Visible)
                Layer2.Visibility = Visibility.Collapsed;
        }

        private void pane2Pin_Click(object sender, RoutedEventArgs e)
        {
            if (pane1Button.Visibility == System.Windows.Visibility.Collapsed)
            {
                UnDockPane(2);
            }
            else
            {
                DockPane(2);
            }
        }

        private void Grid_MouseEnter_1(object sender, MouseEventArgs e)
        {
            if (pane1Button.Visibility == Visibility.Visible)
                Layer1.Visibility = Visibility.Collapsed;
        }
    }
}
