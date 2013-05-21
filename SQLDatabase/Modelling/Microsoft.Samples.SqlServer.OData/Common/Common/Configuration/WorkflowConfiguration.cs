// Copyright Microsoft

using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Configuration;

namespace Microsoft.Samples.SqlServer.Common
{
  public class WorkflowConfiguration
  {
    private string _workflowPath = string.Empty;

    [Category("Workflow XAML Path"),Editor(typeof(System.Windows.Forms.Design.FolderNameEditor), typeof(UITypeEditor))]
    public string WorkflowPath
    {
      get
      {
          return this.GetAppSetting("WorkflowPath");
      }
      set
      {
          this.CreateAppSetting("WorkflowPath", value);
          _workflowPath = this.GetAppSetting("WorkflowPath"); ;
      }
    }
    
    public string GetAppSetting(string name)
    {
      string value = null;
      try
      {
        // Get the AppSettings section.
        value = ConfigurationManager.AppSettings[name];
      }
      catch (ConfigurationErrorsException ex)
      {
        //Handle in a production application
      }

      return value;
    }

    public void CreateAppSetting(string name, string value)
    {
      // Get the application configuration file.
      System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

      //Do not append setting values
      config.AppSettings.Settings.Remove(name);
      config.AppSettings.Settings.Add(name, value);

      // Save the configuration file.
      config.Save(ConfigurationSaveMode.Modified);

      ConfigurationManager.RefreshSection("appSettings");
    }
  }
}
