using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAjax.Models;

namespace MVCAjax.Controllers
{
    public class NameController : Controller
    {
        //
        // GET: /Name/

        public ActionResult MyName()
        {
            return View();
        }
        public ActionResult FullName()
        {
            return PartialView("_FullName", GetName()); 
        }
        public NameModel GetName()
        {
            return new NameModel()
            {
                FirstName = "Arif",
                LastName = "Khan", 
                MiddleName = "BanneHasan"
            };
        }
    }
}
