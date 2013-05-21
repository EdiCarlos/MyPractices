using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GetLoginFromRegistryLib;

namespace useofComObj
{
    class Program
    {
        static void Main(string[] args)
        {
            GetLogin login = new GetLogin();
            object obj1 = @"<Query><PortalDBConns><Conn Name='PortalfmReportConnection'/><Conn Name='Transportation'/><Conn Name='ProfileReadOnly'/><Conn Name='PowerTrack'/><Conn Name='PortalPTREPORTINGDB'/>
			<Conn Name='PortalPTReportDX'/>
			<Conn Name='PortalPTControl'/>
			<Conn Name='ProductPayTransaction'/>
			<Conn Name='SDE'/>
			<Conn Name='Settlement'/>
			<Conn Name='PortalPTWebsite'/>
			<Conn Name='PortalPTWebsiteAuthoring'/>
			<Conn Name='PerformanceMonitoring'/>
			<Conn Name='PortalAnalytical'/>
			<Conn Name='R2-BI-PTTranProfile-'/>
			</PortalDBConns></Query>";
            object obj2 = null;
            login.GetLoginsByName(ref obj1, out obj2);

        }
    }
}
