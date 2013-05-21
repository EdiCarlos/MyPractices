using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using net.webservicex.www;

public partial class RandomNumber : System.Web.UI.Page, System.Web.UI.ICallbackEventHandler
{
    private string _callbackresult = null;

    protected void Page_Load(object sender, EventArgs e)
    {
        string cbReference = Page.ClientScript.GetCallbackEventReference(this, "arg", "ConvertArea", "context");
        string cbScript = @"function UseCallback(arg, context){" + cbReference + ";}";
        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "UseCallback", cbScript, true);
    }
    //public void RaiseCallbackEvent(string eventArgs)
    //{
    //    Random rand = new Random();
    //    _callbackresult = rand.Next().ToString();
    //}

    //#region ICallbackEventHandler Members

    //public string GetCallbackResult()
    //{
    //    return _callbackresult;
    //}

    //#endregion

    #region ICallbackEventHandler Members

    public string GetCallbackResult()
    {
        return _callbackresult;
    }

    public void RaiseCallbackEvent(string eventArgument)
    {
        //Random rand = new Random();
        //_callbackresult = rand.Next().ToString();
        net.webservicex.www.AreaUnit area = new AreaUnit();
        _callbackresult = area.ChangeAreaUnit(double.Parse(eventArgument), Areas.square, Areas.acre).ToString();   
    }

    #endregion
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("UseOfData.aspx?AddressId=2");
    }
}
