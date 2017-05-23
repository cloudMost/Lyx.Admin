using System.Web.Mvc;

namespace Lyx.Admin.Web.Controllers
{
    public class AboutController : AdminControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}