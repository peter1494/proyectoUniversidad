using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(proyectoUniversidad.Startup))]
namespace proyectoUniversidad
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
