using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bookibrary.Startup))]
namespace Bookibrary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
