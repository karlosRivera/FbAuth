using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FbAuth.Startup))]
namespace FbAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
