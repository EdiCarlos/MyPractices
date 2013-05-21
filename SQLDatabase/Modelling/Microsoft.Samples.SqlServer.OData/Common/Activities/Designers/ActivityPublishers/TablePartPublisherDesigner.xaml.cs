// Copyright Microsoft

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
using System.Activities.Presentation.Model;
using Microsoft.Samples.SqlServer.ExtensionMethods;
using System.Activities.Statements;
using System.Collections.ObjectModel;
using System.Workflow.ComponentModel;

namespace Microsoft.Samples.SqlServer.Activities.Designers.ActivityPublishers
{
    // Interaction logic for TablePartPublisherDesigner.xaml
    public partial class TablePartPublisherDesigner
    {
        private ModelItem selectedModelItem = null;

        //Set StyleNames from client context
        private List<String> m_styleNames = null;

        public TablePartPublisherDesigner()
        {
            InitializeComponent();
        }

        public List<String> StyleNames
        {
            get
            {
                if (m_styleNames == null)
                    m_styleNames = new List<string>();
                return m_styleNames;
            }
        }

        private void ActivityDesigner_Loaded(object sender, RoutedEventArgs e)
        {
            selectedModelItem = (sender as TablePartPublisherDesigner).ModelItem;
        }

        private void nameCombobox_DropDownOpened(object sender, EventArgs e)
        {
            ComboBox nameCombobox = (sender as ComboBox);
            nameCombobox.ItemsSource = m_styleNames;
        }

        private void resourceCombobox_DropDownOpened(object sender, EventArgs e)
        {
            ComboBox resourceCombobox = (sender as ComboBox);
            QueryFeed queryFeed = null;

            resourceCombobox.Items.Clear();

            //Get Sequence parent
            ModelItem sequence = selectedModelItem.GetParent(typeof(Sequence));

            //Get QueryFeed Activities
            var queryFeedActivities =
                from a in sequence.Properties["Activities"].ComputedValue as Collection<System.Activities.Activity>
                 where a.DisplayName == "QueryFeed"
                 select a;
            
            if (queryFeedActivities.Count() > 0)
                queryFeed = queryFeedActivities.First() as QueryFeed;

                if (queryFeed != null)
            {
                if (queryFeed.NamedResources != null)
                {
                    resourceCombobox.Items.Add(string.Empty);
                    foreach (string item in queryFeed.NamedResources)
                    {
                        resourceCombobox.Items.Add(item);
                    }
                }
            }
        }
    }
}

