using System.Web;
using System.Web.Mvc;

namespace phamtungson_2210900122_K22CNT1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
