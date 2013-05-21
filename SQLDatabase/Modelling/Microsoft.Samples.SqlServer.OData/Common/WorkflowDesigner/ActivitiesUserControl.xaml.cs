// Copyright Microsoft

using System;
using System.Activities.Presentation.Toolbox;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Microsoft.Samples.SqlServer.Workflow.Designer
{
    /// <summary>
    /// Interaction logic for ActivitiesUserControl.xaml
    /// </summary>
    public partial class ActivitiesUserControl : UserControl
    {
        private ToolboxControl toolboxControl;
        private HashSet<Type> loadedToolboxActivities = new HashSet<Type>();
        private Dictionary<String, ToolboxCategory> referencedCategories = new Dictionary<string, ToolboxCategory>();
        private ToolboxCategory flowchartCategory;
        private List<ToolboxItemWrapper> flowchartActivities = new List<ToolboxItemWrapper>();

        public ActivitiesUserControl()
        {
            InitializeComponent();

            toolboxControl = CreateToolbox();
            toolboxArea.Child = toolboxControl;
        }

        #region Toolbox methods

        private ToolboxControl CreateToolbox()
        {
            ToolboxControl toolBox = new ToolboxControl();
            Dictionary<String, List<Type>> activitiesToInclude = new Dictionary<String, List<Type>>();

            activitiesToInclude.Add("Essential", new List<Type>
                {
                    typeof(Sequence),
                    typeof(If),
                    typeof(Assign),
                    typeof(While),
                    typeof(DoWhile)
               
                });

            activitiesToInclude.Add("OData Feed", new List<Type>
                {
                    typeof(Microsoft.Samples.SqlServer.Activities.QueryFeed),
                    typeof(Microsoft.Samples.SqlServer.Activities.EntityProperties),
                    typeof(Microsoft.Samples.SqlServer.Activities.Filter),
                    typeof(WriteLine)
                });

            activitiesToInclude.Add("Publishers", new List<Type>
                {   
                    typeof(Microsoft.Samples.SqlServer.Activities.ActivityPublishers.TablePartPublisher)
                });

            activitiesToInclude.Add("Flowchart", new List<Type>
                {
                    typeof(Flowchart),
                    typeof(FlowDecision),
                    typeof(FlowSwitch<>)
                });

            foreach (var category in activitiesToInclude)
            {
                ToolboxCategory toolboxCategory = CreateToolboxCategory(
                    category.Key, category.Value, true);
                toolBox.Categories.Add(toolboxCategory);

                if (toolboxCategory.CategoryName == "Flowchart")
                {
                    flowchartCategory = toolboxCategory;
                    foreach (var tool in toolboxCategory.Tools)
                    {

                        if (tool.Type == typeof(FlowDecision) ||
                            tool.Type == typeof(FlowSwitch<>))
                        {
                            flowchartActivities.Add(tool);
                        }
                    }
                }
            }

            return toolBox;
        }

        private ToolboxCategory CreateToolboxCategory(String categoryName, List<Type> activities, Boolean isStandard)
        {
            ToolboxCategory toolboxCategory = new ToolboxCategory(categoryName);

            foreach (Type activity in activities)
            {
                if (!loadedToolboxActivities.Contains(activity))
                {
                    //Cleanup the name of generic activities
                    String name;
                    String[] nameChunks = activity.Name.Split('`');
                    if (nameChunks.Length == 1)
                    {
                        name = activity.Name;
                    }
                    else
                    {
                        name = String.Format("{0}<>", nameChunks[0]);
                    }

                    //ToolboxImagesPath
                    string iconName = Properties.Settings.Default.ToolboxImagesPath + name + ".png"; ;
                    ToolboxItemWrapper tiw =
                      new ToolboxItemWrapper(activity.FullName, activity.Assembly.FullName, iconName, name);

                    toolboxCategory.Add(tiw);

                    if (isStandard)
                    {
                        loadedToolboxActivities.Add(activity);
                    }
                }
            }

            return toolboxCategory;
        }

        #endregion

    }
}
