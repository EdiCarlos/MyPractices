using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;

namespace ActiveDirectorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (DirectoryEntry entry = new DirectoryEntry())
            //{
            //    entry.Username = "axkhan2";
            //    entry.Password = "andheri8";

            //    try
            //    {
            //        DirectorySearcher searcher = new DirectorySearcher(entry);
            //        searcher.FindOne();
            //        Console.WriteLine("username and password exists in directory");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //    //PrincipalContext context = new PrincipalContext(ContextType.Domain, "US");
            //    //Console.WriteLine(context.ValidateCredentials("us/axkhan2", "andheri2"));
            //}

            //Console.WriteLine("LDAP://RootDSE/"+defaultNameContext());
            //SearchResult sr = FindCurrentUser(new string[] { "allowedAttributesEffective" });
            Console.WriteLine(defaultNameContext());
        }

        private static SearchResult FindCurrentUser(string[] attribsToLoad)
        {
            //parse the current user's logon name as search key
            string sFilter = String.Format("(&(objectClass=user)(objectCategory=person)(sAMAccountName={0}))", Environment.UserName);

            DirectoryEntry searchRoot = new DirectoryEntry(GetLDAPPath, null, null, AuthenticationTypes.Secure);//sets search root to adsPath

            using (searchRoot)//this just pulls the infomation for the current user
            {
                string user = Environment.UserName;
                DirectorySearcher ds = new DirectorySearcher(searchRoot, sFilter, attribsToLoad, SearchScope.Subtree);
                ds.SizeLimit = 1;
                return ds.FindOne();
            }
        }
        public static string defaultNameContext()
        {
            string defaultNamingContext;
            using (DirectoryEntry rootDSE = new DirectoryEntry("LDAP://RootDSE"))
            {
                defaultNamingContext = rootDSE.Properties["defaultNamingContext"].Value.ToString();
                Console.WriteLine("Server Name: {0}", rootDSE.Properties["serverName"].Value.ToString());
                Console.WriteLine("Domain Name: {0}", rootDSE.Properties["rootDomainNamingContext"].Value.ToString());
            }
            Console.WriteLine("Accessing domain: {0}", defaultNamingContext);
            return defaultNamingContext;
           
        }
        public static String GetLDAPPath
        {
            get
            {
                using (DirectoryEntry entry = new DirectoryEntry("LDAP://RootDSE"))
                {
                    string domain = entry.Properties["defaultNamingContext"][0].ToString();
                    return "LDAP://" + domain;
                }
            }
        }
    }
}
