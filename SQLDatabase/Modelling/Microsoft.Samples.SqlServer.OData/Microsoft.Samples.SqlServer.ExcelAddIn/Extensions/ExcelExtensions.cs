// Copyright Microsoft

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Samples.SqlServer.Activities.Designers.OData;
using Microsoft.Office.Interop.Excel;

namespace Microsoft.Samples.SqlServer.ExcelAddIn.Extensions
{
    public static class ExcelExtensions
    {
        public static void InsertEntityTable(this Range activeCell, IEnumerable<IEnumerable<EntityProperty>> entityProperties, string styleName)
        {
            int currentColumn = 0;
            int currentRow = 1;
            Range range;

            List<string> propertyNames = (from item in entityProperties select item).First<IEnumerable<EntityProperty>>().Select(n => n.Name).ToList<string>();
            int columnCount = propertyNames.Count();
            int rowCount = entityProperties.Count();

            Globals.ThisAddIn.Application.ScreenUpdating = false;

            //Data Columns
            foreach (string name in propertyNames)
            {
                range = activeCell.get_Offset(1, currentColumn);
                range.FormulaR1C1 = name;
                currentColumn++;
            }
            currentColumn = 0;

            //Data Values
            foreach (IEnumerable<EntityProperty> items in entityProperties)
            {
                //row = new TableRow();
                currentRow++;
                foreach (EntityProperty item in items)
                {
                    range = activeCell.get_Offset(currentRow, currentColumn);
                    range.FormulaR1C1 = item.Value;
                    currentColumn++;
                }
                currentColumn = 0;
            }
            
            Worksheet activeSheet = Globals.ThisAddIn.Application.ActiveSheet;
            Range styleRange = activeCell.Range[activeSheet.Cells[2, 1], activeSheet.Cells[rowCount + 2, columnCount]];
            string listObjectName = String.Format("Table{0}", activeSheet.ListObjects.Count);

            try
            {
                activeSheet.ListObjects.AddEx(XlListObjectSourceType.xlSrcRange, styleRange, Type.Missing, XlYesNoGuess.xlYes).Name = listObjectName;
                activeSheet.ListObjects[listObjectName].TableStyle = styleName;
            }
            catch
            {
                //Handle exception in a production application
            }

            styleRange.Columns.AutoFit();

            Globals.ThisAddIn.Application.ScreenUpdating = true;
        }
    }
}
