<%@ Application Language="C#" ClassName="GlobalClass" %>
<%@ Import Namespace="System.IO" %>
<%@ Import Namespace="System.Collections.Generic" %>

<script RunAt="server">

    private static string[] filelist;
    private static Dictionary<string, string> metadata = new Dictionary<string, string>();
    public void AddMetaData(string key, string value)
    {
        lock (metadata)
        {
            if (!metadata.ContainsKey(key))
            {
                metadata.Add(key, value);
            }
        }
    }
    public string GetMetaData(string key)
    {
        lock (metadata)
        {
            return metadata[key];
        }
    }
    public static string[] FileList
    {
        get
        {
            if (filelist == null)
            {
                filelist = Directory.GetFiles(HttpContext.Current.Request.PhysicalApplicationPath);
            }
            return filelist;
        }
    }
    void Application_Start(object sender, EventArgs e)
    {
        // Code that runs on application startup
    }

    void Application_End(object sender, EventArgs e)
    {
        //  Code that runs on application shutdown

    }

    void Application_Error(object sender, EventArgs e)
    {
        // Code that runs when an unhandled error occurs

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

