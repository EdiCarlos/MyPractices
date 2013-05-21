using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using och = SendRequestConsole.EAIOrchestration;

namespace SendRequestConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            och.Request request = new och.Request();
            request.Header = new och.RequestHeader() { 
            RequestID = "1001",
            OrderDate = DateTime.Now,
            GrandTotal = 1000
            };
            List<och.RequestItem> list = new List<och.RequestItem>();
            list.Add(new och.RequestItem() { 
            Description = "Computer",
            Quantity = 1,
            UnitPrice = 1000
            });
            request.Items = list.ToArray(); 
            och.EAIOrchestration_EAIProcess_ReceivePortClient client = new och.EAIOrchestration_EAIProcess_ReceivePortClient();
            client.Operation_1(request);

        }
    }
}
