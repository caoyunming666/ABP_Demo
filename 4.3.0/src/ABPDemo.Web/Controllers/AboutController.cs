using System.Web.Mvc;

namespace ABPDemo.Web.Controllers
{
    public class AboutController : ABPDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}