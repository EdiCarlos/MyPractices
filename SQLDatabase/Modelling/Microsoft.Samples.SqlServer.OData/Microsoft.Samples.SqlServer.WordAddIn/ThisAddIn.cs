// Copyright Microsoft

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;
using System.Windows.Media.Imaging;
using System.IO;
using Microsoft.Samples.SqlServer.WordAddin.ExtensionMethods;
using Microsoft.Office.Core;
using Microsoft.Samples.SqlServer.Activities.Designers.OData;

namespace Microsoft.Samples.SqlServer.WordAddIn
{
    public partial class ThisAddIn
    {
        //NOTE: This sample only works with ProductID
        string key = "ProductID";
        private Word.Application app;

        private void ThisAddIn_Startup(object sender, System.EventArgs e) 
        {
            app = this.Application;
            app.WindowBeforeDoubleClick += new word.ApplicationEvents4_WindowBeforeDoubleClickEventHandler(app_WindowBeforeDoubleClick);
            app.WindowBeforeRightClick += new word.ApplicationEvents4_WindowBeforeRightClickEventHandler(app_WindowBeforeRightClick);
        }

        
        void app_WindowBeforeDoubleClick(word.Selection Sel, ref bool Cancel)
        {
            if (Sel.Range.ParentContentControl != null)
            {
                if (Sel.Range.ParentContentControl.Title == key)
                {
                    Sel.Range.ParentContentControl.Range.Select();

                    app.Selection.InsertBitmapImage(Sel.Range.ParentContentControl.Tag.Replace("#", string.Empty));
                }
            }
        }

        //NOTE: This sample only works with ProductID
        void app_WindowBeforeRightClick(word.Selection Sel, ref bool Cancel)
        {
            RemoveExistingMenuItem();
            if (Sel.Range.ParentContentControl != null)
            {
                if (Sel.Range.ParentContentControl.Title == key)
                {
                    Sel.Range.ParentContentControl.Range.Select();
                    
                    AddMenuItem();
                }
            }
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e) {}


        public void RemoveExistingMenuItem()
        {
            CommandBar contextMenu = app.CommandBars["Table Text"];
            app.CustomizationContext = app.ActiveDocument;
            int count = contextMenu.Controls.Count;
            for (int i = count; i > 0; i--)
            {              
                if (contextMenu.Controls[i].Tag == "#oDataResource")
                {
                    contextMenu.Controls[i].Delete();
                }
            }          
        }

        //NOTE: This sample only works with ProductID
        public void AddMenuItem()
        {
            app.CustomizationContext = app.ActiveDocument;
            MsoControlType menuItem = MsoControlType.msoControlButton;

            if (Globals.Ribbons.WorkflowRibbon.Activity != null)
            {
                IEnumerable<IEnumerable<EntityProperty>> entityProperties = Globals.Ribbons.WorkflowRibbon.Activity.EntityProperties;
                if (entityProperties.Count() > 0)
                {
                    List<string> namedResources =
                        (from item in entityProperties select item).First<IEnumerable<EntityProperty>>()
                        .Where(n => n.Type == "Edm.Stream").Select(n => n.Name).ToList<string>();

  
                    foreach (var resource in namedResources)
                    {
                        CommandBarButton oDataResource =
                            (CommandBarButton)app.CommandBars["Table Text"].Controls.Add
                            (menuItem, missing, missing, 1, true);
                                           
                        oDataResource.Style = MsoButtonStyle.msoButtonCaption;
                        oDataResource.Caption = resource;
                        oDataResource.Tag = "#oDataResource";

                        oDataResource.Click += new Microsoft.Office.Core._CommandBarButtonEvents_ClickEventHandler(oDataResource_Click);
                    }
                }
            } 

            GC.Collect();

        }

        //NOTE: This sample only works with ProductID
        void oDataResource_Click(Microsoft.Office.Core.CommandBarButton Ctrl,
            ref bool CancelDefault)
        {
            if (app.Selection.Range.ParentContentControl != null)
            {
                if (app.Selection.Range.ParentContentControl.Title == key)
                {
                    //Replace /# with Ctrl.Caption
                    string tag = app.Selection.Range.ParentContentControl.Tag;                    
                    tag = tag.Remove(tag.IndexOf("#"), tag.Length - tag.IndexOf("#"));
                    string serviceQuery = string.Format("{0}{1}", tag, Ctrl.Caption);
                    // Create the image element.
                    app.Selection.InsertBitmapImage(serviceQuery);
                }
            }
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }

    //Show form with Word as parent
    public class MyWin32Window : IWin32Window
    {
        private IntPtr _hwnd;

        public MyWin32Window(IntPtr handle)
        {
            _hwnd = handle;
        }

        public IntPtr Handle
        {
            get
            {
                return _hwnd;
            }
        }
    }
}
