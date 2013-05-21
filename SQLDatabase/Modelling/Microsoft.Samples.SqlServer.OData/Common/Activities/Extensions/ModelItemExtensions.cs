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

namespace Microsoft.Samples.SqlServer.ExtensionMethods
{
  public static class ModelItemExtensions
  {
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
    public static ModelItem GetParent(this ModelItem mi, string name)
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

    /// <summary>
    /// Remove quotes if expression value has quotes
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string RemoveQuotes(this string value)
    {
        return value.Replace("\"", string.Empty);
    }
  }
}
