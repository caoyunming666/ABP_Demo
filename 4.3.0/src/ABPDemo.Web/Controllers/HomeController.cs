using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ABPDemo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ABPDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}