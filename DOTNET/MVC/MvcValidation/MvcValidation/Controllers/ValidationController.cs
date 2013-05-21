using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcValidation.Models;

namespace MvcValidation.Controllers
{
    public class ValidationController : Controller
    {
        //
        // GET: /Validation/


        public ActionResult ValidatePassword()
        {
            //if (ModelState.IsValid)
            //{
            //    if (models.Password.Equals(models.ConfirmPassword))
            //    {
            //        return RedirectToAction("Index", "Home");
            //    }
            //    else
            //    {
            //        ModelState.AddModelError("", "There was error");
            //    }
            //}

            return View();
        }

        [HttpPost]
        public ActionResult ValidatePassword(PasswordModels models)
        {
            if (ModelState.IsValid)
            {
                if (models.Password.Equals(models.ConfirmPassword))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "There was error");
                }
            }

            return View(models);
        }

    }
}
