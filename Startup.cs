using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP220214V4.Startup))]
namespace ASP220214V4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
