using System;

class MyEventArgs
{
  string message;
 object sender;
 public MyEventArgs(string mess, object sn)
{
message = mess;
sender = sn;
}
public string Message
{
get { return message;}
set{ message = value;}
}
public object Sender
{
get { return sender;}
set{ sender = value;}
}
}
public delegate void MyHandler(object sender, MyEventArgs e);

class MyButton
{
public event MyHandler ClickEvent;
public void RaiseOnClick()
{
RaiseClick(new MyEventArgs("This is the message from MyButton class", this));
}

public virtual void RaiseClick(MyEventArgs b)
{
if(ClickEvent != null)
{
ClickEvent(this, b);
}
}

}

class exe
{
static void Main()
{
MyButton btn = new MyButton();
btn.ClickEvent += new MyHandler(btnClick);
btn.RaiseOnClick();
}

public static void btnClick(object sender, MyEventArgs e)
{
Console.WriteLine(e.Message);
Console.WriteLine(e.Sender);
}

}