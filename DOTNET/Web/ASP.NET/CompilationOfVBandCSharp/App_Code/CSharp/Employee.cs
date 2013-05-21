using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Employee
/// </summary>
public class Employee
{
    string employeeName;

    public string EmployeeName
    {
        get { return employeeName; }
        set { employeeName = value; }
    }
    int empID;

    public int EmpID
    {
        get { return empID; }
        set { empID = value; }
    }
	public Employee(string empname, int empid)
	{
        employeeName = empname;
        EmpID = empid;
	}
    
}
