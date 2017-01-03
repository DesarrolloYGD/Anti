using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AntiAging.Startup))]
namespace AntiAging
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
