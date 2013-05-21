//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net

using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

public partial class patch_update_database : System.Web.UI.Page
{
    string fileUrl;
    protected void Page_Load(object sender, EventArgs e)
    {
        fileUrl = Server.MapPath(".") + "\\patch_Data\\update.sql";
        bool done = bool.Parse(Setup.Patch.Get("db_updated"));
        btnRunSQL.Enabled = !done;
        lblDBCreation.Visible = done;
        lnkNext.Visible = done;
        if (!done)
        {
            string templateUrl = Server.MapPath(".") + "\\patch_Data\\update_template.sql";
            StreamReader sr = new StreamReader(templateUrl);
            StreamWriter sw = new StreamWriter(fileUrl, false);
            try
            {
                dbDataContext db = new dbDataContext();
                int first_group = db.sub_units.First().id;
                while (!sr.EndOfStream)
                    sw.WriteLine(sr.ReadLine().Replace("_REPLACE_", first_group.ToString()));
            }
            catch (Exception ex)
            {
                lblOutput.Text = "An error occured: " + ex.ToString();
                lblOutput.CssClass = "error";
            }
            finally
            {
                sr.Close(); sr.Dispose();
                sw.Close(); sw.Dispose();
            }
        }
    }

    protected void btnRunSQL_Click(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SlickTicket"].ConnectionString;
        int timeout = 600;
        SqlConnection conn = null;

        try
        {
            // read file
            WebRequest request = WebRequest.Create(fileUrl);
            using (StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream()))
            {
                lblOutput.Text = "Connecting to SQL Server database...<br />";

                // Create new connection to database
                conn = new SqlConnection(connectionString);

                conn.Open();

                while (!sr.EndOfStream)
                {
                    StringBuilder sb = new StringBuilder();
                    SqlCommand cmd = conn.CreateCommand();

                    while (!sr.EndOfStream)
                    {
                        string s = sr.ReadLine();
                        if (s != null && s.ToUpper().Trim().Equals("GO"))
                        {
                            break;
                        }

                        sb.AppendLine(s);
                    }

                    // Execute T-SQL against the target database
                    cmd.CommandText = sb.ToString();
                    cmd.CommandTimeout = timeout;

                    cmd.ExecuteNonQuery();
                }

            }

            Setup.Patch.Update("db_updated", "True");
            lblOutput.Text += "Tables updated successfully";
            lblOutput.CssClass = "success";
            lblDBCreation.Visible = true;
            btnRunSQL.Enabled = false;
            lnkNext.Visible = true;
        }
        catch (Exception ex)
        {
            lblOutput.Text = "An error occured: " + ex.ToString();
            lblOutput.CssClass = "error";
        }
        finally
        {
            // Close out the connection
            if (conn != null)
            {
                try
                {
                    conn.Close();
                    conn.Dispose();
                }
                catch (Exception ex)
                {
                    lblOutput.Text = "Could not close the connection.  Error was " + ex.ToString();
                    lblOutput.CssClass = "error";
                }
            }
            pnlOutput.CssClass = "border";
        }
    }
}
