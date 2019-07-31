using Abp.Dependency;
using Abp.Runtime.Session;
using Castle.Core.Logging;
using Microsoft.AspNet.SignalR;
using System.Web.Mvc;

namespace AbpWithoutUser.Web.Controllers {
    public class MsgHub : Hub, ITransientDependency {
        public IAbpSession AbpSession { get; set; }

        public ILogger Logger { get; set; }

        public MsgHub()
        {
            AbpSession = NullAbpSession.Instance;
            Logger = NullLogger.Instance;
        }
    }
    public class HomeController : AbpWithoutUserControllerBase {
        public void SignalR()
        {
            var msgHub = GlobalHost.ConnectionManager.GetHubContext<MsgHub>();
            msgHub.Clients.All.msg("server message from web layer");
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}