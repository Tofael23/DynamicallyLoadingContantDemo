using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DynamicallyLoadingContant.Startup))]
namespace DynamicallyLoadingContant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
