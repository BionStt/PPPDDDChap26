using System.Web;
using System.Web.Mvc;

namespace PPPDDD.Chap20.Concurrency.Presentation
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}