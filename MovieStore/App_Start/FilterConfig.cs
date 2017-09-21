using System.Web;
using System.Web.Mvc;

namespace MovieStore
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            //在全局添加验证
            //filters.Add(new AuthorizeAttribute());

            //以下强制在https下运行
            //filters.Add(new RequireHttpsAttribute());
        }
    }
}
