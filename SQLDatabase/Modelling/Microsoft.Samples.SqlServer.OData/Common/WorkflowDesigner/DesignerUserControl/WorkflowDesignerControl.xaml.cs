// Copyright Microsoft

using System;
using System.Activities.Core.Presentation;
using System.Activities.Presentation;
using System.Activities.Presentation.Model;
using System.Activities.Presentation.Toolbox;
using System.Activities.Presentation.Validation;
using System.Activities.Presentation.View;
using System.Activities.Statements;
using System.Collections.Generic;
using System.IO;
using System.Windows.Controls;
using Microsoft.Samples.SqlServer.Activities;
using Microsoft.Samples.SqlServer.ExtensionMethods;
using System.Collections.ObjectModel;
using Microsoft.Samples.SqlServer.Activities.ActivityPublishers;
using Microsoft.Samples.SqlServer.Activities.Designers.ActivityPublishers;
using System.Activities.Presentation.Services;
using System.Activities;
using Microsoft.VisualBasic.Activities;
using System.Linq;
using Microsoft.Samples.SqlServer.Activities.Designers.OData;

namespace Microsoft.Samples.SqlServer.Workflow.Designer
{
  public partial class WorkflowDesignerControl : UserControl
  {
    public string ClientName = string.Empty;

    #region Private Variables
    private WorkflowDesigner workflowDesigner;
    private ModelService modelService;
    private ValidationErrorService errorService;        
    private string currentWorkflowPath = string.Empty;
    private DesignerView designerView;       
    #endregion

    public WorkflowDesignerControl()
    {     
        InitializeComponent();
    }

    public string WorkflowPath
    {
        get
        {
            return currentWorkflowPath;
        }
    }
    private void InitializeDesigner()
    {
        //Create a designer
        workflowDesigner = new WorkflowDesigner();
        workflowDesigner.ModelChanged += new EventHandler(workflowDesigner_ModelChanged);

        designerArea.Child = workflowDesigner.View;

        //Error service
        workflowDesigner.Context.Services.Publish<IValidationErrorService>(errorService);
    }

    #region Workflow Designer

    private void Init()
    {
        //Register designers for the standard activities
        DesignerMetadata metaData = new DesignerMetadata();
        metaData.Register();

        errorService = new ValidationErrorService(this.messageListBox);

        this.InitializeDesigner();
    }

    private void AssignDelegates()
    {
        designerView = workflowDesigner.Context.Services.GetService<DesignerView>();
        modelService = workflowDesigner.Context.Services.GetService<ModelService>();

        //Handle Flow Diagram
        designerView.PreviewMouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(designerView_PreviewMouseDoubleClick);
    }

    /// <summary>
    /// New workflow
    /// </summary>
    /// <returns></returns>
    public WorkflowDesigner New()
    {
        this.Init();

        Variable<IEnumerable<IEnumerable<EntityProperty>>> entityProperty = 
            new Variable<IEnumerable<IEnumerable<EntityProperty>>>();
        entityProperty.Name = "EntityProperties";
        Sequence newSequence = new Sequence();
        newSequence.Variables.Add(entityProperty);

        try
        {
            workflowDesigner.Load(newSequence);

            string fullPath = System.Reflection.Assembly.GetAssembly(typeof(Microsoft.Samples.SqlServer.Workflow.Designer.WorkflowDesignerControl)).Location;
            currentWorkflowPath = String.Format(@"{0}\new activity.xaml", Path.GetDirectoryName(fullPath));
            
            this.AssignDelegates();
            this.SetStyleNames();
        }
        catch
        {
            //Handle exception in a production application
        }

        return workflowDesigner;
    }


    /// <summary>
    /// Load a workflow.
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public WorkflowDesigner Load(string path)
    {
        currentWorkflowPath = path;

        this.Init();

        try
        {
            workflowDesigner.Load(currentWorkflowPath);
            this.AssignDelegates();
            this.SetStyleNames();   
        }
        catch
        {
            //Handle exception in a production application
        }

        return workflowDesigner;
    }

    /// <summary>
    /// Sample set style names from client. This is hard-coded for the sample.
    /// A production application would factor this code much differently
    /// </summary>
    private void SetStyleNames()
    {
        TablePartPublisherDesigner activityPublisher = null;
        IEnumerable<ModelItem> activityCollection = modelService.Find(modelService.Root, typeof(Activity));

        IEnumerable<ModelItem> tablePartPublishers = from mi in activityCollection
                                          where mi.ItemType == typeof(Microsoft.Samples.SqlServer.Activities.ActivityPublishers.TablePartPublisher)
                                          select mi;

        foreach (ModelItem mi in tablePartPublishers)
        {
            activityPublisher = workflowDesigner.Context.Services.GetService<ViewService>().GetView(mi) as TablePartPublisherDesigner;
            activityPublisher.StyleNames.Clear();

            switch (this.ClientName)
            {
                case "Word":
                    {
                        activityPublisher.StyleNames.Add("Light Shading - Accent 5");
                        activityPublisher.StyleNames.Add("Light Shading - Accent 2");
                        activityPublisher.StyleNames.Add("Medium List 2 - Accent 5");
                        activityPublisher.StyleNames.Add("Medium Grid 1 - Accent 4");
                        activityPublisher.StyleNames.Add("Colorful List");
                        break;
                    }
                default:
                    {
                        activityPublisher.StyleNames.Add("TableStyleMedium9");
                        activityPublisher.StyleNames.Add("TableStyleMedium10");
                        activityPublisher.StyleNames.Add("TableStyleMedium20");
                        activityPublisher.StyleNames.Add("TableStyleMedium24");
                        activityPublisher.StyleNames.Add("TableStyleMedium28");
                        break;
                    }
            }
    }
    }

    /// <summary>
    /// Auto save the workflow
    /// </summary>
    /// <param name="path"></param>
    /// <param name="markup"></param>
    public void SaveXamlFile(String path, String markup)
    {
      try
      {
        using (FileStream stream = new FileStream(path, FileMode.Create))
        {
          using (StreamWriter writer = new StreamWriter(stream))
          {
            writer.Write(markup);
          }
        }
      }
      catch (Exception ex)
      {
        //Production application would handle catch
      }
    }
    #endregion

    #region Event Delegates

    /// <summary>
    /// FlowDiagram Activity
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    void designerView_PreviewMouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        if ((sender as DesignerView).FocusedViewElement != null)
        {
          ModelItem mi = (sender as DesignerView).FocusedViewElement.ModelItem;
          if (mi.ItemType == typeof(FlowDecision))
          {       
            ConditionForm conditionForm = new ConditionForm();

            // Assume Flowchart is in Sequence    
            ModelItem sequence = mi.GetParent(typeof(Sequence));
            if (sequence != null)
            {
              conditionForm.Variables = sequence.Properties["Variables"].ComputedValue as Collection<System.Activities.Variable>;
            }

            //Set the condition forms ModelItem
            conditionForm.ConditionModelItem = mi;
            conditionForm.ShowDialog();
          }
      }
    }

    /// <summary>
    /// Update when model changes
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    void workflowDesigner_ModelChanged(object sender, EventArgs e)
    {
        //Set StyleNames
        this.SetStyleNames();

        workflowDesigner.Flush();
        this.SaveXamlFile(currentWorkflowPath, workflowDesigner.Text);

        designerView.UpdateLayout();
    }
    
    #endregion
  }

}
