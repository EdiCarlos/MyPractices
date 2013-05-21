<%@ Application Language="C#" %>
<%@ Import Namespace="System.Diagnostics" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Import Namespace="System.Web.Configuration" %>
<%@ Import Namespace="System.Data" %>
<script RunAt="server">

    SqlCommand cmdSelect = null;
    SqlCommand cmdInsert = null;
    SqlConnection con = null;
    
    public override void Init()
    {
        con = new SqlConnection();
        con.ConnectionString = WebConfigurationManager.ConnectionStrings["logCon"].ConnectionString;

        cmdSelect = new SqlCommand("select count(*) from log where filepath = @path", con);
        cmdSelect.Parameters.Add(new SqlParameter("@path", SqlDbType.NVarChar, 500));

        cmdInsert = new SqlCommand("insert into log values(@path)", con);
        cmdInsert.Parameters.Add(new SqlParameter("@path", SqlDbType.NVarChar, 500));
    }
    public int NumberOfRequests
    {
        get
        {
            int result = 0;
            cmdSelect.Parameters["@path"].Value = Request.AppRelativeCurrentExecutionFilePath;
            try
            {
                con.Open();
                result = (int)cmdSelect.ExecuteScalar();
            }
            finally
            {
                con.Close();
            }
            return result;
        }
    }
    void Application_BeginRequest(object sender, EventArgs e)
    {
        cmdInsert.Parameters["@path"].Value = Request.AppRelativeCurrentExecutionFilePath;
        try
        {
            con.Open();
            cmdInsert.ExecuteNonQuery();
        }
        finally
        {
            con.Close();
        }
    }
    void Application_AuthenticateRequest(object sender, EventArgs e)
    {
        Trace.WriteLine("Application AuthenticateRequest called");
        Trace.WriteLine(Request.AppRelativeCurrentExecutionFilePath);
    }
    void Application_Start(object sender, EventArgs e)
    {

    }

    void Application_End(object sender, EventArgs e)
    {
    }

    void Application_Error(object sender, EventArgs e)
    {
    }

    void Session_Start(object sender, EventArgs e)
    {
    }

    void Session_End(object sender, EventArgs e)
    {
    }
       
</script>

