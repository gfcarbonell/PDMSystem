using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AGAServerBackend.Startup))]
namespace AGAServerBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
