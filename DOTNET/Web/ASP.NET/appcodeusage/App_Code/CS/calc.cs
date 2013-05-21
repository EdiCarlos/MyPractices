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
/// Summary description for calc
/// </summary>
public class calc
{
    
	public calc()
	{
	}

    public double Addition(int num1, int num2)
    {
        return (num1 + num2);
    }

    public double Subtraction(int num1, int num2)
    {
        return (num1 - num2);
   
    }

    public double Multiplication(int num1, int num2)
    {
        return (num1 * num2);
   
    }

    public double Division(int num1, int num2)
    {
        return (num1 / num2);
   
    }

}
