using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaNotas.Startup))]
namespace SistemaNotas
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
