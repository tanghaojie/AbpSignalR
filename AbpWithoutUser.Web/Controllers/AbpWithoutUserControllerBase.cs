using Abp.Web.Mvc.Controllers;

namespace AbpWithoutUser.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class AbpWithoutUserControllerBase : AbpController
    {
        protected AbpWithoutUserControllerBase()
        {
            LocalizationSourceName = AbpWithoutUserConsts.LocalizationSourceName;
        }
    }
}