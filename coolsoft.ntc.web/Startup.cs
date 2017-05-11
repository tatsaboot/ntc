using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(coolsoft.ntc.web.Startup))]
namespace coolsoft.ntc.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
