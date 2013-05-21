//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for Tickets
/// </summary>
public static class Tickets
{
    public static IEnumerable<ticket> ICommentedIn(dbDataContext db, int userID)
    {
        return (from c in db.comments where c.active && c.submitter == userID && c.ticket.closed == DateTime.Parse("1/1/2001") select c.ticket).Distinct();
    }

    public static IEnumerable<ticket> MyTickets(dbDataContext db, int userID)
    {
        return (from p in db.tickets where p.submitter == userID && p.closed == DateTime.Parse("1/1/2001") select p).Union(ICommentedIn(db, userID)).OrderByDescending(p => p.priority1.level).OrderBy(p => p.submitted);
    }

    public static IEnumerable<ticket> MyGroupsTickets(dbDataContext db, user usr)
    {
        IEnumerable<ticket> groupTix = from p in db.tickets where p.submitter != usr.id && (p.assigned_to_group == usr.sub_unit || p.originating_group == usr.sub_unit) && p.closed == DateTime.Parse("1/1/2001") select p;
        IEnumerable<ticket> ITix = ICommentedIn(db, usr.id);
        if (groupTix != null && ITix != null)
            return groupTix.Except(ITix).OrderByDescending(p => p.priority1.level).OrderBy(p => p.submitted);
        else
            return groupTix.OrderByDescending(p => p.priority1.level).OrderBy(p => p.submitted);
    }

    public static ticket Add(dbDataContext db, string title, string details, int assign_to_group, int _priority, int submitter, int originating_group)
    {
        ticket newTicket = new ticket();
        newTicket.title = title;
        newTicket.details = details;
        newTicket.closed = DateTime.Parse("1/1/2001");
        newTicket.submitter = submitter;
        newTicket.submitted = DateTime.Now;
        newTicket.last_action = DateTime.Now;
        newTicket.priority = _priority;
        newTicket.assigned_to_group = assign_to_group;
        newTicket.ticket_status = 1; // 1=new
        newTicket.originating_group = originating_group;
        newTicket.active = true;
        db.tickets.InsertOnSubmit(newTicket);
        db.SubmitChanges();

        return newTicket;
    }

    public static ticket Get(dbDataContext db, int ticketID)
    {
        return db.tickets.First(t => t.id == ticketID);
    }

    public static ticket Update(dbDataContext db, int ticketID, int status, int _priority, int assigned_to_group)
    {
        ticket t = Get(db, ticketID);
        t.ticket_status = status;
        t.priority = _priority;
        t.assigned_to_group_last = t.assigned_to_group;
        t.assigned_to_group = assigned_to_group;
        if (status == 5) t.closed = DateTime.Now;
        t.last_action = DateTime.Now;
        db.SubmitChanges();
        return t;
    }

    public static IEnumerable<ticket> ListOpen(dbDataContext db)
    {
        return List(db, true, true);
    }

    public static IEnumerable<ticket> ListClosed(dbDataContext db)
    {
        return List(db, true, false);
    }

    public static IEnumerable<ticket> List(dbDataContext db, bool? active, bool ?open)
    {
        return from p in GetTickets(db, active)
               where 
               (open == null ? true :
                    ((bool)open ? p.closed == DateTime.Parse("1/1/2001") : p.closed != DateTime.Parse("1/1/2001")))
               select p;
    }

    public static IEnumerable<ticket> Search(dbDataContext db, string[] keywords, int usr, DateTime dtFrom, DateTime dtTo, int prty, int stat, bool onlyOpen, int grp, int subgrp)
    {
        return Search(db, keywords, usr, dtFrom, dtTo, prty, stat, onlyOpen, grp, subgrp, true);
    }

    public static IEnumerable<ticket> Search(dbDataContext db, string[] keywords, int usr, DateTime dtFrom, DateTime dtTo, int prty, int stat, bool onlyOpen, int grp, int subgrp, bool? active)
    {
        return from p in GetTickets(db, active)
               where
                   p.title.Contains(keywords[0]) &&
                   p.title.Contains(keywords[1]) &&
                   p.title.Contains(keywords[2]) &&
                   p.title.Contains(keywords[3]) &&
                   p.title.Contains(keywords[4]) &&
                   p.title.Contains(keywords[5]) &&
                   p.title.Contains(keywords[6]) &&
                   p.title.Contains(keywords[7]) &&
                   p.title.Contains(keywords[8]) &&
                   p.title.Contains(keywords[9]) &&

                   p.submitter == (usr < 0 ? p.submitter : usr) &&
                   p.submitted >= dtFrom &&
                   p.submitted <= dtTo &&
                   (prty == 0 ? true : p.priority == prty) &&
                   (stat == 0 ? true : p.ticket_status == stat) &&
                   (!onlyOpen ? true : p.ticket_status != 5) &&
                   (grp == 0 ? true : (
                   (p.sub_unit2.unit_ref == grp) ||
                   (p.sub_unit.unit_ref == grp))) &&
                   (subgrp == 0 ? true : (
                   (p.originating_group == subgrp) ||
                   (p.assigned_to_group == subgrp)))
               select p;
    }

    public static IEnumerable<ticket> GetTickets(dbDataContext db, bool? active)
    {
        return from p in db.tickets
               where
                   (active == null ? true :
                   ((bool)active ? p.active : !p.active))
               select p;
    }

    public class Attachments
    {
        public static void Add(dbDataContext db, string fileName, int ticket_ref, long size, int comment_ref)
        {
            attachment a = new attachment();
            a.attachment_name = fileName;
            a.attachment_size = size.ToString();
            a.submitted = DateTime.Now;
            a.ticket_ref = ticket_ref;
            a.active = true;
            if (comment_ref > 0) a.comment_ref = comment_ref;

            db.attachments.InsertOnSubmit(a);
        }


        public static void SaveMultiple(dbDataContext db, FileUpload[] fuControls, int ticket_ref, int comment_ref)
        {
            bool hasAttachments = false;
            foreach (FileUpload fu in fuControls) if (fu.HasFile) hasAttachments = true;

            if (hasAttachments)
            {
                string dir = HttpContext.Current.Server.MapPath("~") + Utils.Settings.Get("attachments");
                string dirPath = dir + ticket_ref.ToString();
                Directory.CreateDirectory(dirPath);
                dirPath = dirPath + "\\";
                foreach (FileUpload fu in fuControls)
                    if (fu.HasFile) Attachments.Save(db, fu, dirPath, ticket_ref, comment_ref);
            }
            db.SubmitChanges();
        }

        public static void Save(dbDataContext db, FileUpload fu, string dir, int ticket_ref, int comment_ref)
        {
            int count = 1;
            string fileName = fu.FileName;
            string[] fileNameSplit = fileName.Split(new char[] { '.' });
            string ext = "." + fileNameSplit[fileNameSplit.Count() - 1];
            string prefix = fileName.Substring(0, fileName.Length - ext.Length);
            while (File.Exists(dir + fileName))
            {
                fileName = prefix + "[" + count.ToString() + "]" + ext;
                count++;
            }
            fu.SaveAs(dir + fileName);
            FileInfo info = new FileInfo(dir + fileName);

            Add(db, fileName, ticket_ref, info.Length, comment_ref);
        }
    }

    public class Comments
    {
        public static int Add(dbDataContext db, string _comment, int ticket_ref, int userID, int priorityID, int statusID, int sub_unitID)
        {
            comment c = new comment();
            c.submitter = userID;
            c.comment1 = _comment;
            c.submitted = DateTime.Now;
            c.ticket_ref = ticket_ref;
            c.priority_id = priorityID;
            c.status_id = statusID;
            c.assigned_to = sub_unitID;
            c.active = true;
            db.comments.InsertOnSubmit(c);
            db.SubmitChanges();
            return c.id;
        }

        public static IEnumerable<comment> List(dbDataContext db, int ticket_ref)
        {
            return from c in db.comments where c.ticket_ref == ticket_ref && c.active select c;
        }

        public static List<int> CommentingGroups(dbDataContext db, int ticketID)
        {
            return (from c in db.comments where c.ticket_ref == ticketID && c.active select c.user.sub_unit).ToList();
        }
    }
}
