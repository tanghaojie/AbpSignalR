using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AbpWithoutUser.Web.Controllers
{
    public class MsgController : Controller
    {
        // GET: Msg
        public ActionResult Index()
        {
            return View();
        }
    }
}