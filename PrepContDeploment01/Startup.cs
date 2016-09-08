using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrepContDeploment01.Startup))]
namespace PrepContDeploment01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
