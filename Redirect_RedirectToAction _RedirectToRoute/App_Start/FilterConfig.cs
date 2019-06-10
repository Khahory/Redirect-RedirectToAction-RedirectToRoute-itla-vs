using System.Web;
using System.Web.Mvc;

namespace Redirect_RedirectToAction__RedirectToRoute
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
