using LightInject;
using System.Reflection;
using System.Web.Http;

namespace WebDeveloper.API
{
    public partial class Startup
    {
        public void ConfigInjector()
        {
            var container = new ServiceContainer();
            container.RegisterAssembly(Assembly.GetExecutingAssembly());
            container.RegisterAssembly("WebDeveloper.DataAccess*.dll");
            container.RegisterAssembly("WebDeveloper.Model*.dll");
            container.RegisterApiControllers();
            container.EnableWebApi(GlobalConfiguration.Configuration);
        }
    }
}