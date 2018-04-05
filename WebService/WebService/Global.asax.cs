using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using System.Web;
using System.Web.Http;
using WebService.Config;
using WebService.Repository;

namespace WebService
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            var builder = new ContainerBuilder();

            // WebApiConfig
            GlobalConfiguration.Configure(WebApiConfig.Register);

            // HttpConfiguration
            var config = GlobalConfiguration.Configuration;

            // Rejestrowanie Web Api Controllers
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // Rejestracja repozytoriów
            builder.RegisterInstance<IStudentsRepository>(new StudentsRepository());

            // Inicjalizacja AutoMappera
            AutoMapperConfig.RegisterMapping();

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
