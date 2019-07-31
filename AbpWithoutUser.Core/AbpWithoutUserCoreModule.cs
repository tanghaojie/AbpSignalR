using System.Reflection;
using Abp.Modules;

namespace AbpWithoutUser
{
    public class AbpWithoutUserCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
