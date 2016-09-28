using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppYeti.Startup))]
namespace AppYeti
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
