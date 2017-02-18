using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProfitTracker.Startup))]
namespace ProfitTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
