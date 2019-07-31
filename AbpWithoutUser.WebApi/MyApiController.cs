using Abp.Dependency;
using Abp.Runtime.Session;
using Abp.WebApi.Controllers;
using Castle.Core.Logging;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace AbpWithoutUser {
    public class MsgHubApi : Hub, ITransientDependency {
        public IAbpSession AbpSession { get; set; }

        public ILogger Logger { get; set; }

        public MsgHubApi()
        {
            AbpSession = NullAbpSession.Instance;
            Logger = NullLogger.Instance;
        }
    }
    public class MyApiController : AbpApiController {
        [HttpGet]
        public void SignalR()
        {
            var msgHubApi = GlobalHost.ConnectionManager.GetHubContext<MsgHubApi>();
            msgHubApi.Clients.All.msg("server message from webapi layer");
        }
    }
}
