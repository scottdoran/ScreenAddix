using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScreenAddix.Startup))]
namespace ScreenAddix
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
