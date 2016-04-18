using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Stryker_WasteManagement.Startup))]
namespace Stryker_WasteManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
