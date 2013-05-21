<%@ Application Language="C#" %>

<script runat="server">

    protected void Application_OnEndRequest(object sender, EventArgs e)
    {
        Response.Write("<hr /> This page was rendered at " + DateTime.Now.ToString());
    }
    protected void Application_Error(object sender, EventArgs e)
    {
        Response.Write("<font face=\"Tahoma\" size=\"2\" color=\"red\">");
        Response.Write("Oops! Looks like an error occurred!!<hr></font>");
        Response.Write("<font face=\"Arial\" size=\"2\">");
        Response.Write(Server.GetLastError().Message.ToString());
        Response.Write("<hr>" + Server.GetLastError().ToString());
        Server.ClearError();
    }
    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup

    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
