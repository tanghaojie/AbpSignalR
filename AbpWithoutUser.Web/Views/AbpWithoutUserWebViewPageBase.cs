using Abp.Web.Mvc.Views;

namespace AbpWithoutUser.Web.Views
{
    public abstract class AbpWithoutUserWebViewPageBase : AbpWithoutUserWebViewPageBase<dynamic>
    {

    }

    public abstract class AbpWithoutUserWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AbpWithoutUserWebViewPageBase()
        {
            LocalizationSourceName = AbpWithoutUserConsts.LocalizationSourceName;
        }
    }
}