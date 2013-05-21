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

    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        string myScript = @"
function btn_Click(name) {
            txt1.value = name;
        }this.btn_Click("+txtUserName.Text+");";
        //ClientScript.RegisterStartupScript(this.GetType(), "register", myScript, true);
        ClientScript.RegisterClientScriptBlock(this.GetType(), "register", myScript, true);
        this.ModalPopupExtender1.Show();
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        this.ModalPopupExtender1.Hide();
    }
}
