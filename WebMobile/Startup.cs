using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMobile.Startup))]
namespace WebMobile
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
