using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for ShoppingCart
/// </summary>
[Serializable]
public class ShoppingCart
{
    public ShoppingCart()
    {

    }
    string PID, CompanyProductName;
    int Number;
    decimal Price;
    DateTime DateAdded;

    public DateTime DateItemAdded
    {
        get { return DateAdded; }
        set { DateAdded = value; }
    }

    public decimal PriceAdded
    {
        get { return Price; }
        set { Price = value; }
    }

    public int NumberSelected
    {
        get { return Number; }
        set { Number = value; }
    }



    public string ProductName
    {
        get { return CompanyProductName; }
        set { CompanyProductName = value; }
    }
    public string ProductID
    {
        get { return PID; }
        set { PID = value; }
    }


}
