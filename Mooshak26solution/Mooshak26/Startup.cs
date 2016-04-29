using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mooshak26.Startup))]
namespace Mooshak26
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
