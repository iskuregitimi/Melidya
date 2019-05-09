using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Melidya.AdminWebUI.Startup))]
namespace Melidya.AdminWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
