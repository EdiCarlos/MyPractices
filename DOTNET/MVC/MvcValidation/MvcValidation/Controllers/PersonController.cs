using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcValidation.Models;

namespace MvcValidation.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/

        public ActionResult Person()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Person(PersonModel model)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(model.Mobile) && string.IsNullOrEmpty(model.Phone))
                {
                    ModelState.AddModelError("", "There was error");
                }
                else
                {
                    return View(model);
                }
            }
            return View();
        }

        public JsonResult GetName(string name)
        {
            if(!name.Equals("Arif"))
            {
                return Json("Name is not equal to Arif", JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}
