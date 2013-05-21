using System.Web.Mvc;
using CustomValidation.MVC.Models;

namespace CustomValidation.MVC.Controllers
{
  public class PartyController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Index(Party party)
    {
      if (ModelState.IsValid)
      {
        // TO DO: Save the party in database.
        return View("Thanks");
      }

      return View();
    }
  }
}
