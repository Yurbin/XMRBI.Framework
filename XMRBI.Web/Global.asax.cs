using System.Web.Mvc;
using System.Web.Routing;
using XMRBI.Infrastructure;

namespace XMRBI.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ViewEngines.Engines.RemoveAt(0);
            AutoFacConfig.RegisterServices();
            LogHelper.RegisterConfig();
        }
    }
}
