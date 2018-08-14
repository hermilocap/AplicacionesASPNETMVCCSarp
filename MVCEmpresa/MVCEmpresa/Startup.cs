using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCEmpresa.Startup))]
namespace MVCEmpresa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
