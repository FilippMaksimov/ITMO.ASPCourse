using System.Web;
using System.Web.Mvc;

namespace ITMO.ASPCourse.MVC.Lab08
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
