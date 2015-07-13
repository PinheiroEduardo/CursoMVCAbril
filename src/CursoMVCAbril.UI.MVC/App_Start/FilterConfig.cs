using System.Web;
using System.Web.Mvc;
using CursoMVCAbril.Infra.CrossCutting.MvcFilters;

namespace CursoMVCAbril.UI.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new GlobalErrorHandler());
        }
    }
}
