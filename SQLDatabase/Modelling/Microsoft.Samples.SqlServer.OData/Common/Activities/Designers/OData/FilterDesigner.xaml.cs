// Copyright Microsoft

using System;
using System.Windows;
using System.Activities.Presentation.View;
using System.Activities.Presentation;
using System.Collections.Generic;
using System.Windows.Data;
using System.Globalization;
using System.Activities.Presentation.Model;
using Microsoft.VisualBasic.Activities;
using System.Activities;
using System.Windows.Controls;

using Microsoft.Samples.SqlServer.Activities;
using Microsoft.Samples.SqlServer.ExtensionMethods;
using Microsoft.Samples.SqlServer.Activities.Designers.OData;

namespace Microsoft.Samples.SqlServer.Activities.Designers
{
  //Used to convert ModelItem.Value to a string for <Binding Path="ModelItem.Value.Expression" Converter="{StaticResource objectConverter}"/>
  [ValueConversion(typeof(object), typeof(String))]
  public class ObjectConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      ModelItem mi = value as ModelItem;
      VisualBasicValue<Object> computedValue = mi.Source.ComputedValue as VisualBasicValue<Object>;
      return computedValue.ExpressionText;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new Exception("The method or operation is not implemented.");
    }
  }

  //Used to convert Enums
  [ValueConversion(typeof(object), typeof(String))]
  public class EnumConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value.ToString() != "End" ? value.ToString().ToLower(): string.Empty;

    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new Exception("The method or operation is not implemented.");
    }
  }

  // Interaction logic for QueryDesigner.xaml
  public partial class FilterDesigner
  {
    private IEnumerable<EntityPropertySchema> filterSchema;

    public FilterDesigner()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Given a Uri and Resource, get the EntityPropertySchema
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ActivityDesigner_GotFocus(object sender, RoutedEventArgs e)
    {
        string uri = string.Empty;
        string resource = string.Empty;
        ODataQuery q = null;

        ModelItem parent = (sender as FilterDesigner).ModelItem.GetParent(typeof(QueryFeed));

        if (parent.Properties["Uri"].Value != null)
            uri = parent.Properties["Uri"].Value.ToString();

        if (parent.Properties["Resource"] != null)
        {
            resource = parent.Properties["Resource"].Value.ToString();

            q = new ODataQuery(uri);
            filterSchema = q.FilterSchema(resource);
        }
    }
    
    /// <summary>
    /// Fill name items from entity schema names
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void nameCombobox_DropDownOpened(object sender, EventArgs e)
    {
        ComboBox nameCombobox = (sender as ComboBox);
        nameCombobox.Focus();
        nameCombobox.ItemsSource = filterSchema;
    }
  }
}
