using Abp.Web.Mvc.Views;

namespace Lyx.Admin.Web.Views
{
    public abstract class AdminWebViewPageBase : AdminWebViewPageBase<dynamic>
    {

    }

    public abstract class AdminWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AdminWebViewPageBase()
        {
            LocalizationSourceName = AdminConsts.LocalizationSourceName;
        }
    }
}