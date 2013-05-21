using System;
using System.Text;
//using System.Diagnostics;
class myclass
{
	public static void Main()
	{
	System.Diagnostics.Process p = new System.Diagnostics.Process();
	string myMail = String.Format("mailto:{0}?subject={1}&body={2}","a nyone@email.com", "Subject Goes Here", "This is the body of the email");
p.StartInfo.FileName = myMail;
p.Start();
	
	}
}