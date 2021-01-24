using System.Web;
using System.Web.Mvc;

namespace Angular_10__SQl__Asp.net_Framework
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
