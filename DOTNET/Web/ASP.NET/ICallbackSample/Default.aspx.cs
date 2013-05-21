using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page, ICallbackEventHandler
{
    string firstName = string.Empty, lastName = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        string callBackScript = Page.ClientScript.GetCallbackEventReference(this, "arg1", "GetAsyncFullName", "context");
        string cScript = "function UseCallback(arg1, context){"+callBackScript+";}";
        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "UseCallback", cScript, true);
    }
    
    public string GetCallbackResult()
    {
        return firstName + " " + lastName;
    }

    public void RaiseCallbackEvent(string eventArgument)
    {
        string[] result = eventArgument.Split('|');
        firstName = result[0];
        lastName = result[1];
    }
}