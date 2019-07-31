using AbpWithoutUser.Web.App_Start;
using Microsoft.Owin;
using Owin;
using Abp.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
[assembly: OwinStartup(typeof(Startup))]
namespace AbpWithoutUser.Web.App_Start {
    public class Startup {
        public void Configuration(IAppBuilder app)
        {
            app.UseAbp();
            app.MapSignalR();
        }
    }
}