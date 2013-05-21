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
using MoviePlexDAL;
using System.Data;
using System.Data.Entity;


namespace MoviePlexSampleProj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
           MoviePlexEntities mEntities = new MoviePlexEntities();
            InitializeComponent();
            //((CollectionViewSource)this.Resources["MP_TheaterBrand"]).Source = (from mp in mEntities.MP_TheatersBrand select mp).ToList();
            CollectionViewSource colViewSource = (CollectionViewSource)this.Resources["MPTheaterBrand"];
            colViewSource.Source =  mEntities.MP_TheatersBrand.Select(e => e).ToList();
        }
    }
    //public class SingleTonMoviePlexAdal
    //{
    //    private static MoviePlexEntities entities = new MoviePlexEntities();
    //    public static MoviePlexEntities GetInstance
    //    {
    //        get { return entities; }
    //    }
    //}
}
