using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using AbpWithoutUser.EntityFramework;

namespace AbpWithoutUser
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(AbpWithoutUserCoreModule))]
    public class AbpWithoutUserDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<AbpWithoutUserDbContext>(null);
        }
    }
}
