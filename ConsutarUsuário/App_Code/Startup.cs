using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConsutarUsuário.Startup))]
namespace ConsutarUsuário
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
