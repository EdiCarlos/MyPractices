using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = DateTime.Now.ToString();
        //Response.Cache.SetCacheability(HttpCacheability.NoCache);
        //Response.Cache.SetNoStore();
        //Response.Cache.SetExpires(DateTime.MinValue);

        Table<tb_tasklist> tb = Cache["tb_tasklist"] as Table<tb_tasklist>;

        if (tb == null)
        {
            mydbContextDataContext mydbContext = new mydbContextDataContext();
            Cache["tb_tasklist"] = mydbContext.tb_tasklists.Select(task => task);
            GridView1.DataSource = mydbContext.tb_tasklists.Select(task => task);
            //Cache.Insert(
            GridView1.DataBind();
            Label1.Text = "This data was reterived from database at " + DateTime.Now.ToString();
        }
        else
        {
            Label1.Text = "this was reterived from cached data" + DateTime.Now.ToString();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetExpires(DateTime.MinValue);
        Response.Cache.SetNoStore();
    }
}
