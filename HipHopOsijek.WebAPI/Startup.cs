using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HipHopOsijek.WebAPI.Startup))]
namespace HipHopOsijek.WebAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
