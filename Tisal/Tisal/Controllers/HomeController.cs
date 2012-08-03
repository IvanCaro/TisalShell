using System.Web.Mvc;

namespace Tisal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Tisal 22222";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
