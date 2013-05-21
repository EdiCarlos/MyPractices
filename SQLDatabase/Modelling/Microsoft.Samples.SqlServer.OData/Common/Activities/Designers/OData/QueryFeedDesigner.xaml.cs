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
using System.Activities.Statements;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.Samples.SqlServer.Activities;
using Microsoft.Samples.SqlServer.ExtensionMethods;
using Microsoft.Samples.SqlServer.Activities.Designers.OData;
using System.Windows.Media.Imaging;
using System.Windows.Controls.Primitives;

namespace Microsoft.Samples.SqlServer.Activities.Designers
{
    public class OrderByItem
    {
        public string Content {get; set;}
        public string Direction {get; set;}
        public bool IsChecked { get; set; }
    }

    public class SelectItem
    {
        public string Content {get; set;}
        public string Type {get; set;}
        public bool IsChecked { get; set; }
        public bool IsPreview { get; set; }
    }

    // Interaction logic for QueryFeedDesigner.xaml

    //NEXT: Refactor this class using MVVM to better support WPF Data Binding
    public partial class QueryFeedDesigner
    {
        private IEnumerable<EntitySet> entitySet = null;
        private IEnumerable<EntityPropertySchema> filterSchema = null;
        private IEnumerable<EntityPropertySchema> selectSchema = null;

        private string resource = string.Empty;
        private string uri = string.Empty;
        private ModelItem selectedModelItem = null;

        private Dictionary<string, SelectItem> selectItems = null;
        private Dictionary<string, OrderByItem> orderByItems = null;

        ODataQuery odataQuery = null;

        public QueryFeedDesigner()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Refresh designer items when ActivityDesigner is loaded.
        /// NOTE: This sample sets a default service Uri
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActivityDesigner_Loaded(object sender, RoutedEventArgs e)
        {
            selectedModelItem = (sender as QueryFeedDesigner).ModelItem;           
            selectItems = new Dictionary<string, SelectItem>();
            orderByItems = new Dictionary<string, OrderByItem>();

            if (selectedModelItem.Properties["Uri"].Value == null)
            {
                //NOTE: This sample uses a default ServiceUrl
                selectedModelItem.Properties["Uri"].SetValue(Properties.Settings.Default.ServiceUrl);
            }
            {
                uri = selectedModelItem.Properties["Uri"].Value.ToString();
                odataQuery = new ODataQuery(uri);
            }

            this.RefreshItems();
        }

        /// <summary>
        /// Refresh expression builder items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActivityDesigner_GotFocus(object sender, RoutedEventArgs e)
        {
            selectedModelItem = (sender as QueryFeedDesigner).ModelItem;
            this.RefreshEntitySets();
        }

        /// <summary>
        /// Refresh EntitySets
        /// </summary>
        private void RefreshEntitySets()
        {
            ODataQuery q = null;

            //NOTE: The sample assumes a EntityProperties activity variable as IEnumerable<IEnumerable<EntityProperty>>
            ModelItem sequence = selectedModelItem.GetParent(typeof(Sequence));

            Collection<System.Activities.Variable> variables = sequence.Properties["Variables"].ComputedValue as Collection<System.Activities.Variable>;
            var variable = (from v in variables where v.Name == "EntityProperties" select v).First();

            selectedModelItem.Properties["EntityProperties"].SetValue(new OutArgument<IEnumerable<IEnumerable<EntityProperty>>>(variable));

            //Get entity sets
            if (selectedModelItem.Properties["Uri"].Value != null)
            {
                uri = selectedModelItem.Properties["Uri"].Value.ToString();
                q = new ODataQuery(uri);
                entitySet = q.EntitySets;
            }
        }

        /// <summary>
        /// Refresh Select and OrderBy Items
        /// </summary>
        private void RefreshItems()
        {
            if (selectedModelItem.Properties["Resource"].Value != null)
            {
                resource = selectedModelItem.Properties["Resource"].Value.ToString();
                filterSchema = odataQuery.FilterSchema(resource);
                selectSchema = odataQuery.SelectSchema(resource);

                //Fill Select
                if (selectSchema != null)
                {
                    List<string> namedResources = new List<string>();
                    List<string> selectList = selectedModelItem.Properties["SelectProperties"].Value.GetCurrentValue() as List<string>;
                    bool isSelectChecked;

                    foreach (EntityPropertySchema entity in selectSchema)
                    {
                        isSelectChecked = false;

                        //Select Items
                        if (selectList.Contains(entity.Name))
                            isSelectChecked = true;

                        //Update or Add
                        if (selectItems.Keys.Contains(entity.Name))
                        {
                            selectItems[entity.Name].IsChecked = isSelectChecked;
                        }
                        else
                        {
                            selectItems.Add(entity.Name, new SelectItem { Content = entity.Name, IsChecked = isSelectChecked, Type = entity.Type });
                        }
                        if (selectItems[entity.Name].IsChecked && selectItems[entity.Name].Type == "Edm.Stream")
                            namedResources.Add(selectItems[entity.Name].Content);

                        selectedModelItem.Properties["NamedResources"].SetValue(namedResources);
                    }
                }
                
                //Fill OrderBy
                if (filterSchema != null)
                {
                    List<string> orderbyList = selectedModelItem.Properties["OrderBy"].Value.GetCurrentValue() as List<string>;
                    bool isOrderByChecked;
                    string direction;

                    foreach (EntityPropertySchema entity in filterSchema)
                    {
                        //OrderBy Items
                        isOrderByChecked = false;
                        direction = "asc";

                        var orderbyDirection = from n in orderbyList
                                               where n.Split(new char[] { ' ' })[0] == entity.Name
                                               select n.Split(new char[] { ' ' })[1];

                        if (orderbyDirection.Count() > 0)
                        {
                            isOrderByChecked = true;
                            direction = orderbyDirection.First<string>();

                        }

                        if (orderByItems.Keys.Contains(entity.Name))
                        {
                            orderByItems[entity.Name].IsChecked = isOrderByChecked;
                            orderByItems[entity.Name].Direction = direction;
                        }
                        else
                        {
                            orderByItems.Add(entity.Name, new OrderByItem { Content = entity.Name, Direction = direction, IsChecked = isOrderByChecked });
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Reset the schema when a new resource is selected
        /// </summary>
        private void ResetSchema()
        {
            if (selectedModelItem.Properties["Uri"].Value != null)
            {
                uri = selectedModelItem.Properties["Uri"].Value.ToString();
            }

            if (selectedModelItem.Properties["Resource"].Value != null)
            {
                resource = selectedModelItem.Properties["Resource"].Value.ToString();
                filterSchema = odataQuery.FilterSchema(resource);
                selectSchema = odataQuery.SelectSchema(resource);
            }

            //Clear old schema items
            selectItems.Clear();
            //Resets when resource changed
            selectedModelItem.Properties["SelectProperties"].SetValue(new List<string>());

            orderByItems.Clear();
            //Resets when resrouce changed
            selectedModelItem.Properties["OrderBy"].SetValue(new List<string>());

            //Reset Select
            if (selectSchema != null)
            {
                foreach (EntityPropertySchema entity in selectSchema)
                {
                    selectItems.Add(entity.Name, new SelectItem { Content = entity.Name, IsChecked = false, Type = entity.Type });
                }
            }

            //Reset Filter Items
            if (filterSchema != null)
            {
                foreach (EntityPropertySchema entity in filterSchema)
                {
                    orderByItems.Add(entity.Name, new OrderByItem { Content = entity.Name, Direction = "asc", IsChecked = false });
                }
            }
        }
       
        /// <summary>
        /// Fill resource names
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resourceComboBox_DropDownOpened(object sender, EventArgs e)
        {
            ComboBox resourceCombobox = (sender as ComboBox);
            //Set focus so that the ActivityDesigner_GotFocus event is raised to get the selected model item
            resourceCombobox.Focus();

            resourceCombobox.ItemsSource = entitySet;
        }

        /// <summary>
        /// Change entity schema ComboBox items when resource drop down closes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resourceComboBox_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox resourceComboBox = (sender as ComboBox);
            if (resourceComboBox.Text != resource)
                this.ResetSchema();
        }

        //NEXT: Use ComboBox.ItemTemplate
        /// <summary>
        /// Fill select items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectCombobox_DropDownOpened(object sender, EventArgs e)
        {
            ComboBox selectCombobox = (sender as ComboBox);
            selectCombobox.Focus();

            selectCombobox.Items.Clear();


            int i = -1;
            foreach (string key in selectItems.Keys)
            {
                i++;
                Grid comboBoxGrid = new Grid();

                // Define the Columns
                ColumnDefinition colDef1 = new ColumnDefinition();
                ColumnDefinition colDef2 = new ColumnDefinition();

                comboBoxGrid.ColumnDefinitions.Add(colDef1);
                comboBoxGrid.ColumnDefinitions.Add(colDef2);

                // Define the Rows
                RowDefinition rowDef1 = new RowDefinition();

                comboBoxGrid.RowDefinitions.Add(rowDef1);

                Image selectImage = new Image();

                if (selectItems[key].Type == "Edm.Stream")
                {
                    selectImage.Tag = "Edm.Stream";
                    selectImage.Source = new BitmapImage(new Uri
                        (String.Format(@"{0}Edm.Stream.png", Properties.Settings.Default.SelectIcons)));
                }
                else
                    selectImage.Source = new BitmapImage(new Uri
                        (String.Format(@"{0}Edm.Default.png", Properties.Settings.Default.SelectIcons)));

                Grid.SetRow(selectImage, 0);
                Grid.SetColumn(selectImage, 0);

                CheckBox selectCheckbox = new CheckBox
                {
                    Tag = "selectCheckbox",
                    IsChecked = selectItems[key].IsChecked,
                    Content = key,
                    VerticalAlignment = System.Windows.VerticalAlignment.Center,
                    VerticalContentAlignment = System.Windows.VerticalAlignment.Center,
                    Margin = new Thickness(3, 0, 0, 0)
                };

                Grid.SetRow(selectCheckbox, 0);
                Grid.SetColumn(selectCheckbox, 1);

                comboBoxGrid.Children.Add(selectImage);
                comboBoxGrid.Children.Add(selectCheckbox);

                selectCombobox.Items.Add(comboBoxGrid);
            }
        }

        /// <summary>
        /// Assign Select items to SelectProperties ModelItem property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectCombobox_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox selectComboBox = (sender as ComboBox);
            List<string> selectItems = new List<string>();

            foreach (Grid item in selectComboBox.Items)
            {
                CheckBox selectCheckBox = GetSelectCheckbox(item);

                if ((bool)selectCheckBox.IsChecked)
                {
                    selectItems.Add(selectCheckBox.Content.ToString());
                }
            }

            selectedModelItem.Properties["SelectProperties"].SetValue(selectItems);

            this.RefreshItems();
        }

        private CheckBox GetSelectCheckbox(Grid item)
        {
            CheckBox selectCheckbox = null;

            foreach(FrameworkElement element in item.Children)
            {
                if (element.Tag == "selectCheckbox")
                    selectCheckbox = element as CheckBox;
            }

            return selectCheckbox;
        }

        //NEXT: Use ComboBox.ItemTemplate
        /// <summary>
        /// Orderby ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderbyListBox_DropDownOpened(object sender, EventArgs e)
        {
            ComboBox orderbyComboBox = (sender as ComboBox);
            orderbyComboBox.Focus();

            orderbyComboBox.Items.Clear();

            foreach (string key in orderByItems.Keys)
            {
                Grid comboBoxGrid = new Grid();

                // Define the Columns
                ColumnDefinition colDef1 = new ColumnDefinition();
                ColumnDefinition colDef2 = new ColumnDefinition();
                comboBoxGrid.ColumnDefinitions.Add(colDef1);
                comboBoxGrid.ColumnDefinitions.Add(colDef2);

                // Define the Rows
                RowDefinition rowDef1 = new RowDefinition();
                comboBoxGrid.RowDefinitions.Add(rowDef1);

                // Add the second text cell to the Grid
                Button orderByButton = new Button();
                orderByButton.Click += orderByButton_Click;
                orderByButton.Content = orderByItems[key].Direction;
                orderByButton.Width = 30;
                Grid.SetRow(orderByButton, 0);
                Grid.SetColumn(orderByButton, 0);

                CheckBox orderByCheckbox = new CheckBox();
                orderByCheckbox.IsChecked = orderByItems[key].IsChecked;
                orderByCheckbox.Content = key;
                orderByCheckbox.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                orderByCheckbox.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
                orderByCheckbox.Margin = new Thickness(3,0,0,0);
                Grid.SetRow(orderByCheckbox, 0);
                Grid.SetColumn(orderByCheckbox, 1);

                comboBoxGrid.Children.Add(orderByButton);
                comboBoxGrid.Children.Add(orderByCheckbox);

                orderbyComboBox.Items.Add(comboBoxGrid);
            }
        }


        //NEXT: Use a Command
        /// <summary>
        /// OrderBy Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void orderByButton_Click(object sender, RoutedEventArgs e)
        {
            Button orderbyButton = (sender as Button);
            orderbyButton.Content = orderbyButton.Content.ToString() == "asc" ? "desc" : "asc";
        }

        /// <summary>
        /// Assign OrderBy items to OrderBy ModelItem property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderbyListBox_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox orderbyComboBox = (sender as ComboBox);
            List<string> orderbyItems = new List<string>();
            foreach (Grid item in orderbyComboBox.Items)
            {
                Button orderbyButton = item.Children[0] as Button;
                CheckBox orderbyCheckBox = item.Children[1] as CheckBox;

                if ((bool)orderbyCheckBox.IsChecked)
                {
                    orderbyItems.Add
                        (String.Format("{0} {1}",orderbyCheckBox.Content.ToString(),orderbyButton.Content.ToString()));
                }

            }
            selectedModelItem.Properties["OrderBy"].SetValue(orderbyItems);

            this.RefreshItems();
        }
    }
}

