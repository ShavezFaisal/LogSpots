using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LogSpots.Startup))]
namespace LogSpots
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
