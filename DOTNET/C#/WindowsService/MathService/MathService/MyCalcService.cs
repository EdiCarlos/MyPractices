using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace MathService
{
    partial class MyCalcService : ServiceBase
    {
        public MyCalcService()
        {
            InitializeComponent();
            this.ServiceName = "MyCalcService";
            this.CanStop = true;
            this.CanPauseAndContinue = true;
            this.AutoLog = true;
            if (!System.Diagnostics.EventLog.SourceExists("MyCalcSource"))
            {
                System.Diagnostics.EventLog.CreateEventSource("MyCalcSource", "MyLogSource");
                eventLog1.Source = "MyCalcSource";
                eventLog1.Source = "MyLogSource";
            }
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Starting MyCalcService.....");
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("MyCalcService Stopped...");
            // TODO: Add code here to perform any tear-down necessary to stop your service.
        }
    }
}
