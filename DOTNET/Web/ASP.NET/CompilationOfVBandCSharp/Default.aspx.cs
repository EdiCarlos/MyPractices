using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Employee emp = new Employee("arifKhan", 1200);
        Label lbl = new Label();
        lbl.Text = "CSharp Employee Name = " + emp.EmployeeName + " EmployeeID = " + emp.EmpID.ToString();
        this.Controls.Add(lbl);
        Literal lit = new Literal();
        lit.Text = @"<br \>";
        this.Controls.Add(lit);
        Person person = new Person("Arif", "Khan");
        Label lbl1 = new Label();
        lbl1.Text = "VB Person FirstName = " + person.FirstNameP + " Last Name = " + person.LastNameP;
        this.Controls.Add(lbl1);
    }
}
