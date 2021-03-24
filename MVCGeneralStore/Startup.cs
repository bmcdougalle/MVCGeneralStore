using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCGeneralStore.Startup))]
namespace MVCGeneralStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
