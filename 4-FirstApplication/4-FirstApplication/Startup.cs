using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_4_FirstApplication.Startup))]
namespace _4_FirstApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
