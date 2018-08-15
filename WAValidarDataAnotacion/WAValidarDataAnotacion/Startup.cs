using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WAValidarDataAnotacion.Startup))]
namespace WAValidarDataAnotacion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
