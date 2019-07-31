using Abp.Application.Services;

namespace AbpWithoutUser
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AbpWithoutUserAppServiceBase : ApplicationService
    {
        protected AbpWithoutUserAppServiceBase()
        {
            LocalizationSourceName = AbpWithoutUserConsts.LocalizationSourceName;
        }
    }
}