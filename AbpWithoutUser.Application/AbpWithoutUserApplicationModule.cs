using System.Reflection;
using Abp.Modules;

namespace AbpWithoutUser
{
    [DependsOn(typeof(AbpWithoutUserCoreModule))]
    public class AbpWithoutUserApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
