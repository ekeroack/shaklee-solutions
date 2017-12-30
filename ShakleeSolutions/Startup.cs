using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShakleeSolutions.Startup))]
namespace ShakleeSolutions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
