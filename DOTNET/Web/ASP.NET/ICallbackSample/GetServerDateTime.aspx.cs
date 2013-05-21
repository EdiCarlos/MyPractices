using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetServerDateTime : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void timeTicker_OnTick(object sender, EventArgs e)
    {
       DateTime dt =  DateTime.Now;
       lblDateTime.Text = dt.Hour.ToString() + ":" + dt.Minute.ToString() + ":" + dt.Second.ToString();
    }
    public void btnStart_OnClick(object sender, EventArgs e)
    {
        Timer1.Tick += new EventHandler<EventArgs>(timeTicker_OnTick);
    }

    
    protected void btnStop_OnClick(object sender, EventArgs e)
    {
        Timer1.Tick -= new EventHandler<EventArgs>(timeTicker_OnTick);
    }
}