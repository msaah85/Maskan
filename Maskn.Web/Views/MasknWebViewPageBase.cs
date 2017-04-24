using Abp.Web.Mvc.Views;

namespace Maskn.Web.Views
{
    public abstract class MasknWebViewPageBase : MasknWebViewPageBase<dynamic>
    {

    }

    public abstract class MasknWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MasknWebViewPageBase()
        {
            LocalizationSourceName = MasknConsts.LocalizationSourceName;
        }
    }
}