using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReadXMLResponse
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputXml = @"<Response Value=""0"" IsComplete=""Y"" ErrorCode=""0"" CriticalLevel="""" ErrorMessage=""""><Data><Invoice DRN=""2002292951"" AnchorID=""""><Statuses Financial=""SU"" Fulfillment=""NR"" Documentation=""NR"" Price=""NR"" /><SystemInfo AllowedActions="""" EditableCode="""" TimeStamp="""" /><PerformanceTest TestID="""" NextAvaSeq="""" Type="""" /></Invoice></Data></Response>";
            XElement doc = XElement.Parse(inputXml, LoadOptions.None);
            
        }
    }
}
