using System.Web.Http;
using System.Web.Http.Cors;

namespace WebService.Config
{
    public static class CorsConfig
    {
        public static void ConfigureCors(HttpConfiguration configuration)
        {
            string corsWildcard = "*";
            var cors = new EnableCorsAttribute(corsWildcard, corsWildcard, corsWildcard);
            configuration.EnableCors(cors);
        }
    }
}