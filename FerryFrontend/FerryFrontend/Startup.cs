using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FerryFrontend.Startup))]
namespace FerryFrontend
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
