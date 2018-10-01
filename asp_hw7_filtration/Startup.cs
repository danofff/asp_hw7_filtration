using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asp_hw7_filtration.Startup))]
namespace asp_hw7_filtration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
