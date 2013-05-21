using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetNumber : System.Web.UI.Page, ICallbackEventHandler
{
    string randomNumber = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
       string script =  Page.ClientScript.GetCallbackEventReference(this, "arg", "GetRandomNumber", "context");

       string mainScript = @"function UseCallback(arg, context){" +script+";"+
"}";
      Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "UseCallback", mainScript, true);
    }

    public string GetCallbackResult()
    {
        return randomNumber;
    }

    public void RaiseCallbackEvent(string eventArgument)
    {
       randomNumber =  new Random().Next().ToString();
    }
}