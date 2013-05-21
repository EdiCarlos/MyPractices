//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net

using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Database Interaction Layer (dbi)
/// </summary>
public class Dbi
{

    public class Statuses
    {
        public static IEnumerable<statuse> List(dbDataContext db)
        {
            return from p in db.statuses orderby p.status_order select p;
        }
    }

    public class Priorities
    {
        public static IEnumerable<priority> List(dbDataContext db, int userAccessLevel)
        {
            return from p in db.priorities where p.level <= userAccessLevel select p;
        }
    }

    public class AccessLevels
    {
        public static IEnumerable<security_level> List(dbDataContext db, int lower_limit)
        {
            return from p in db.security_levels where p.id > lower_limit select p;
        }
    }

    public class Domains
    {
        public static void Add(dbDataContext db, string domain)
        {
            allowed_email_domain aed = new allowed_email_domain();
            aed.domain = domain;
            db.allowed_email_domains.InsertOnSubmit(aed);
            db.SubmitChanges();
        }
    }
}
