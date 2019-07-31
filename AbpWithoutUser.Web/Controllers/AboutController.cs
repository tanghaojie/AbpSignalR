using System.Web.Mvc;

namespace AbpWithoutUser.Web.Controllers
{
    public class AboutController : AbpWithoutUserControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}