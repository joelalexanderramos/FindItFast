using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FindItFast.Backend.Startup))]
namespace FindItFast.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
