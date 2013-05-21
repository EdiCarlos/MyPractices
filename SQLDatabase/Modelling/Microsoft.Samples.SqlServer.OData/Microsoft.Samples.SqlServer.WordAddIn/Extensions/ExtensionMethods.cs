// Copyright Microsoft

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;
using System.Activities;
using System.Activities.XamlIntegration;
using Microsoft.Samples.SqlServer.Activities.Designers.OData;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Xml.Linq;
using DocumentFormat.OpenXml;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Samples.SqlServer.WordAddIn;
using System.Windows.Media.Imaging;

namespace Microsoft.Samples.SqlServer.WordAddin.ExtensionMethods
{
    public static class WordExtensions
    {
        public static void InsertBitmapImage(this word.Selection selection, string serviceQuery)
        {
            // Create source.
            BitmapImage bi = new BitmapImage();

            // BitmapImage.UriSource must be in a BeginInit/EndInit block.
            bi.BeginInit();
            bi.DownloadCompleted += new EventHandler(bi_DownloadCompleted);
            bi.UriSource = new Uri(serviceQuery, UriKind.RelativeOrAbsolute);
            bi.EndInit();
        }

        static void bi_DownloadCompleted(object sender, EventArgs e)
        {
            string fullPath = System.Reflection.Assembly.GetAssembly(typeof(Microsoft.Samples.SqlServer.WordAddIn.WorkflowRibbon)).Location;
            string gifPath = String.Format(@"{0}$word.odata.gif", Path.GetDirectoryName(fullPath));
            using (FileStream stream = new FileStream(gifPath, FileMode.Create))
            {
                var encoder = new GifBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create((BitmapImage)sender));
                encoder.Save(stream);
            }

            Globals.ThisAddIn.Application.Selection.InlineShapes.AddPicture(gifPath, false);
        }

        //NEXT: Implement namedResource to insert image
        public static void InsertEntityTableXml(this word.Range range, IEnumerable<IEnumerable<EntityProperty>> entityProperties, 
            string styleName, string namedResource)
        {
            SdtCell contentControl = null;
            TableRow row = null;
            int incrementor = 1;

            Stream packageStream = range.GetPackageStreamFromRange();

            List<string> propertyNames =
            (from item in entityProperties select item).First<IEnumerable<EntityProperty>>()
                .Where(n => n.Type != "Edm.Stream" && n.Name != "id").Select(n => n.Name).ToList<string>();

            int columnCount = propertyNames.Count();
            int rowCount = entityProperties.Count();

            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(packageStream, true))  
            {
                //Remove all children 
                wordDoc.MainDocumentPart.Document.Body.RemoveAllChildren();
                //Generate table markup. 
                Table table = new Table();
                
                //Data Columns
                row = new TableRow();                    
                foreach (string name in propertyNames)
                {
                    incrementor++;
                    contentControl = GenerateSdtCell(name, name, name, incrementor);

                    row.AppendChild<SdtCell>(contentControl);
                        
                }
                table.AppendChild<TableRow>(row);
                
                //Data Values
                //Reset incrementor
                incrementor = 1;

                foreach (IEnumerable<EntityProperty> items in entityProperties)
                {
                    //For this sample, add namedResource to ContentControl tag
                    string tag = string.Format("{0}/#{1}",
                        (from p in items where p.Name == "id" select p.Value).First().ToString(), namedResource);

                    row = new TableRow();

                    foreach (EntityProperty item in items)
                    {
                        //For this sample, ignore link.image/gif and id
                        //See the Ribbon sample for how to used named resources
                        if (item.Type != "Edm.Stream" && item.Name != "id")
                        {
                            incrementor++;
                            contentControl = GenerateSdtCell(item.Name, item.Value.ToString(), tag, incrementor);

                            row.AppendChild<SdtCell>(contentControl);
                        }
                    }
                    table.AppendChild<TableRow>(row);
                }

                wordDoc.MainDocumentPart.Document
                    .Body
                    .AppendChild<Table>(table);

                wordDoc.MainDocumentPart.Document.Save();
                //Flush the contents of the package 
                wordDoc.Package.Flush();
                //Convert back to flat opc using this in-memory package 
                XDocument xDoc = OpcHelper.OpcToFlatOpc(wordDoc.Package);

                range.Application.ScreenUpdating = false;
                //Insert this flat opc Xml 
                range.InsertXML(xDoc.ToString());

                try
                {
                    range.Tables[1].set_Style(styleName);
                }
                catch
                { 
                    //Catch a specific exception in a production application
                }
                range.Application.ScreenUpdating = true;
            } 
        }

        public static SdtCell GenerateSdtCell(string name, string text, string tag, int contentcontrolId)
        {
            SdtCell element =
            new SdtCell(
            new SdtProperties(
                new Tag {Val = tag},
                new SdtAlias() {Val = name},
                new SdtId() { Val = contentcontrolId },
                new SdtPlaceholder( new DocPartReference())),
            new SdtContentCell(
                new TableCell(

                    new DocumentFormat.OpenXml.Wordprocessing.Paragraph(
                        new ProofError() { Type = ProofingErrorValues.SpellStart },
                        new Run(
                            new Text(text)),
                        new ProofError() { Type = ProofingErrorValues.SpellEnd }
                    ))));
            return element;
        }
    }
}
