using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Web.SignalR;
using Abp.WebApi;

namespace AbpWithoutUser
{
    [DependsOn(typeof(AbpWebApiModule), typeof(AbpWithoutUserApplicationModule),
        typeof(AbpWebSignalRModule))]
    public class AbpWithoutUserWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(AbpWithoutUserApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
