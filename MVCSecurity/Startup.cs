using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCSecurity.Startup))]
namespace MVCSecurity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
