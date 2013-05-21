//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net


using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Text;

public partial class setup_build_database : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        bool done = bool.Parse(Setup.Settings.Get("db_creation"));
        btnRunSQL.Enabled = !done;
        lblDBCreation.Visible = done;
        lnkNext.Visible = done;
    }

    protected void btnRunSQL_Click(object sender, EventArgs e)
    {
        string fileUrl = Server.MapPath(".") + "\\setup_Data\\setup.sql";
        string connectionString = ConfigurationManager.ConnectionStrings["SlickTicket"].ConnectionString;
        int timeout = 600;
        SqlConnection conn = null;

        Stream stream = new FileStream(Server.MapPath(".") + "\\setup_Data\\styles.xml", FileMode.Open);
        Stream FAQstream = new FileStream(Server.MapPath(".") + "\\setup_Data\\faq.xml", FileMode.Open);

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

            //fills styles
            string nothing = Styles.Import(stream);

            //fills faq
            Faqs.Import(FAQstream);

            Setup.Settings.Update("db_creation", "True");
            lblOutput.Text += "Tables built successfully";
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
            stream.Close();
            FAQstream.Close();

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
