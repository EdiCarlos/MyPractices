// Copyright Microsoft

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities.Presentation.Model;
using System.Activities;
using Microsoft.VisualBasic.Activities;
using System.Activities.Statements;
using System.Collections.ObjectModel;


//ADD
//if (base.OwnerActivity != null)
//        {
//          ModelItem mi = base.OwnerActivity.SequenceActivity("SqlConnectionBuilder");
//          if (mi.ItemType == typeof(Sequence))
//          {
//            Collection<Activity> computedValues = mi.Properties["Activities"].ComputedValue as Collection<Activity>;

          //baseActivity = base.OwnerActivity.BaseActivity("SqlServerBaseActivity");

          //ModelItem mi = baseActivity.SequenceActivity("SqlConnectionBuilder");
          //if (mi.ItemType == typeof(Sequence))
          //{
          //  Collection<Activity> computedValues = mi.Activities();

//List<string> variableNames = (from m in base.MetaData
//                                      where m.Name == "VariableNames"
//                                      select m.Value).First() as List<string>;


//public class SharePointExpressionTypeConverter : IExpressionTypeConverter
//{
//    public object CommitedText(List<ListItem> nameValues)
//    {
//        string value = new DictionaryTypeConverter().CommitedText(nameValues).ToString();

//        return "New System.Collections.Generic.Dictionary(Of String, Object) From{" + value + "}";
//    }
//}

//public sealed class ListTypeConverter : IExpressionTypeConverter
//{
//    public object CommitedText(List<ListItem> nameValues)
//    {
//        string name = string.Empty;
//        string value = string.Empty;
//        string convertedValue = string.Empty;

//        if (nameValues.Count > 0)
//        {
//            foreach (ListItem item in nameValues)
//            {
//                name = item.Name;
//                value = item.Value == null ? string.Empty : item.Value.ToString();
//                convertedValue += "{" + name.QuotedValue() + "},";
//            }
//        }

//        //Remove ending comma
//        if (convertedValue.Length > 0)
//            convertedValue = convertedValue.Substring(0, convertedValue.Length - 1);

//        return "New System.Collections.Generic.List(Of String) From{" + convertedValue + "}";
//    }
//}


//public sealed class DictionaryTypeConverter : IExpressionTypeConverter
//{
//    public object CommitedText(List<ListItem> nameValues)
//    {
//        string name = string.Empty;
//        string value = string.Empty;
//        string convertedValue = string.Empty;

//        if (nameValues.Count > 0)
//        {
//            foreach (ListItem item in nameValues)
//            {
//                name = item.Name;
//                value = item.Value == null ? string.Empty : item.Value.ToString();
//                convertedValue += "{" + name.QuotedValue() + ", " + value + "},";
//            }
//        }

//        //Remove ending comma
//        if (convertedValue.Length > 0)
//            convertedValue = convertedValue.Substring(0, convertedValue.Length - 1);

//        return convertedValue;
//    }
//}

//public sealed class QuotedValueExpressionTypeConverter : IExpressionTypeConverter
//{
//    public object CommitedText(List<ListItem> nameValues)
//    {
//        object value = nameValues.Count > 0 ? nameValues[0].Value : string.Empty;
//        value = value != null ? value : string.Empty;
//        return "\"" + value + "\"";
//    }
//}

//public sealed class StringExpressionTypeConverter : IExpressionTypeConverter
//{
//    public object CommitedText(List<ListItem> nameValues)
//    {
//        object value = nameValues.Count > 0 ? nameValues[0].Value : string.Empty;
//        return value.ToString();
//    }
//} 



namespace Microsoft.Samples.SqlServer.ExtensionMethods
{
  public static class ModelItemExtensions
  {
    public static Collection<Activity> Activities(this ModelItem modelItem)
    {
      return modelItem.Properties["Activities"].ComputedValue as Collection<Activity>;
    }

    /// <summary>
    /// Get target model item expression depending on the VisualBasicValue type
    /// </summary>
    /// <param name="expression"></param>
    /// <param name="path"></param>
    /// <returns></returns>
    public static object TargetExpression(this ModelItem expression, string path)
    {
      object expressionText = null;

      if (expression != null)
      {
        if (expression.Source.ComputedValue.GetType() == typeof(VisualBasicValue<Object>))
        {
          expressionText = (expression.Source.ComputedValue as VisualBasicValue<Object>).ExpressionText.NonQuotedValue();
        }
        else if (expression.Source.ComputedValue.GetType() == typeof(VisualBasicValue<Dictionary<String, Object>>))
        {
          expressionText = (expression.Source.ComputedValue as VisualBasicValue<Dictionary<String, Object>>).ExpressionText;
        }
        else
        {
          expressionText  = expression.Source.ComputedValue.ToString();
        }
      }
      return expressionText;
    }

    /// <summary>
    /// Get the path computed value
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="modelItem"></param>
    /// <param name="path"></param>
    /// <returns></returns>
    public static object Expression<T>(this ModelItem modelItem, string path)
    {
      InArgument<T> computedValue = null;
      computedValue = modelItem.Properties[path].ComputedValue as InArgument<T>;

      return computedValue.Expression;
    }


    //NEXT: Fix: Should not be .Parent.Parent, Should be typeof(Sequence)
    /// <summary>
    /// Get the model item sequence
    /// </summary>
    /// <param name="modelItem"></param>
    /// <param name="path"></param>
    /// <returns></returns>
    public static ModelItem SequenceActivity(this ModelItem modelItem, string path)
    {
      ModelItem mi = null;
      if (modelItem.Parent.Parent != null)
      {
        mi = modelItem.Parent.Parent;        
      }
      return mi;
    }
   
    /// <summary>
    /// Get the model item's base activity from the type name
    /// </summary>
    /// <param name="activity"></param>
    /// <param name="baseTypeName"></param>
    /// <returns></returns>
    public static ModelItem BaseActivity(this ModelItem activity, string baseTypeName)
    {
      ModelItem mi = null;

      //Recursive loop .Parent until parentPath
      if (activity != null)
        mi = GetParent(activity, baseTypeName);
      return mi;
    }

    /// <summary>
    /// Get the model item's parent by name
    /// </summary>
    /// <param name="mi"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    private static ModelItem GetParent(ModelItem mi, string name)
    {      
      while (mi != null)
      {
        if (mi.ItemType.BaseType.Name == name)
          break;
        mi = GetParent(mi.Parent, name);
      }

      return mi;
    }

    /// <summary>
    /// Get the model item's parent by type
    /// </summary>
    /// <param name="mi"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static ModelItem GetParent(this ModelItem mi, Type type)
    {      
      while (mi != null)
      {
        if (mi.ItemType.Name == type.Name)
          break;
        mi = GetParent(mi.Parent, type);
      }

      return mi;
    }
  }
}
