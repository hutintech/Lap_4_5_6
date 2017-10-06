using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lap_4_5_6.Startup))]
namespace Lap_4_5_6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
