using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test26.Startup))]
namespace test26
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
