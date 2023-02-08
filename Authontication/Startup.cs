using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Authontication.Startup))]
namespace Authontication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
