using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SqlDataSourceSample
{
    public partial class SqlDataControlEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int id = Convert.ToInt32(GridView1.Rows[GridView1.SelectedIndex].Cells[1].Text);
                sqlDDLDataSource.SelectParameters["empID"].DefaultValue = id.ToString();
                FormView1.ChangeMode(FormViewMode.ReadOnly);
            }
        }

        protected void InsertFromForm_Click(object sender, EventArgs e)
        {
            FormView1.ChangeMode(FormViewMode.Insert);
        }

        protected void FormView1_ItemInserting(object sender, FormViewInsertEventArgs e)
        {

        }

        protected void FormView1_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            GridView1.DataBind();
            FormView1.ChangeMode(FormViewMode.ReadOnly);
        }

        protected void FormView1_ItemUpdated(object sender, FormViewUpdatedEventArgs e)
        {
            GridView1.DataBind();
        }

        protected void FormView1_ItemDeleted(object sender, FormViewDeletedEventArgs e)
        {
            GridView1.DataBind();
            FormView1.DataBind();
        }

        protected void FormView1_ItemUpdating(object sender, FormViewUpdateEventArgs e)
        {
            sqlDDLDataSource.UpdateParameters["EmployeeID"].DefaultValue = ((Label)FormView1.FindControl("EmployeeIDLabel1")).Text;
        }
    }
}