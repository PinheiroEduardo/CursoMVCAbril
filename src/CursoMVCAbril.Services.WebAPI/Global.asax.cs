using System.Web;
using System.Web.Http;
using CursoMVCAbril.Application.AutoMapper;

namespace CursoMVCAbril.Services.WebAPI
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoMapperConfig.RegisterMappings();
        }
    }
}