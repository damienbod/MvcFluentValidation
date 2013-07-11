using System.Web.Mvc;
using MvcFluentValidation.Models;

namespace MvcFluentValidation.Controllers
{
    public class FluentController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(FluentDataModel model)
        {
            if (ModelState.IsValid)
            {

                return this.RedirectToAction("Index");
            }

            return View("Index", model);
        }

    }
}
