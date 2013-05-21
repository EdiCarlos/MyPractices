//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class patch_convert_comments : System.Web.UI.Page
{
    dbDataContext db = new dbDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        bool done = bool.Parse(Setup.Patch.Get("comments"));
        btnUpdate.Enabled = !done;
        lblFinished.Visible = done;
        lnkNext.Visible = done;
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        StreamWriter sw = new StreamWriter(Server.MapPath("~/patch/patch_Data/") + "comment_conversion_log.txt", false);
        sw.WriteLine("Slick-Ticket Comment/Ticket Conversion Log - " + DateTime.Now.ToString());
        sw.WriteLine("");
        sw.WriteLine("ID                      Error");
        sw.WriteLine("--------------------------------------------------------------------------------");
        string[] split;
        string[] delimiters = new string[] { ": </span>", " - ", "</span><span style='float:right'><span class='bold'>Status: </span>", " <span class='bold'>", "</span><span  class='clear'></span></div><div>", "</div><div>", "</div>" };
        try
        {
            sw.WriteLine(" > Comments");
            foreach (comment c in db.comments)
            {
                try
                {
                    split = c.comment1.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    //for (int i = 0; i < split.Length; i++)
                    //    sw.WriteLine(i.ToString() + " " + split[i]);

                    try { c.assigned_to = GetSubUnit(split[2]); }
                    catch
                    {
                        sw.WriteLine(c.id + " - Sub-Group not found: " + split[2] + ", assigned to " + c.ticket.sub_unit.sub_unit_name);
                        c.assigned_to = c.ticket.assigned_to_group;
                    }

                    try { c.status_id = GetStatus(split[3]); }
                    catch { sw.WriteLine(c.id + " - Status not found: " + split[3] + ", set to default"); }

                    try { c.priority_id = GetPriority(split[5]); }
                    catch { sw.WriteLine(c.id + " - Priority not found: " + split[5] + ", set to default"); }

                    c.comment1 = split[6];
                }
                catch (Exception ex)
                {
                    sw.WriteLine("ERR: " + ex.Message);
                }
            }
            sw.WriteLine("");
            sw.WriteLine(" > Tickets");
            foreach (ticket t in db.tickets)
            {
                try
                {
                    split = t.details.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    //for (int i = 0; i < split.Length; i++)
                    //    sw.WriteLine(i.ToString() + " " + split[i]);

                    t.details = split[4];
                }
                catch (Exception ex)
                {
                    sw.WriteLine("ERR: " + ex.Message);
                }
            }
            db.SubmitChanges();
            Setup.Patch.Update("comments", "True");
            lblOutput.Text += "Comments updated successfully";
            lblOutput.CssClass = "success";
            lblFinished.Visible = true;
            btnUpdate.Enabled = false;
            lnkNext.Visible = true;
        }
        catch (Exception ex)
        {
            lblOutput.Text = "An error occured: " + ex.ToString();
            lblOutput.CssClass = "error";
        }
        finally 
        { 
            sw.Close(); sw.Dispose(); 
        }
    }

    protected int GetSubUnit(string str)
    {
        return db.sub_units.Single(x => x.sub_unit_name.Equals(str)).id;
    }
    protected int GetPriority(string str)
    {
        return db.priorities.Single(x => x.priority_name.Equals(str)).id;
    }
    protected int GetStatus(string str)
    {
        return db.statuses.Single(x => x.status_name.Equals(str)).id;
    }
}
