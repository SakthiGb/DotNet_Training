using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Emplyee.Startup))]
namespace Emplyee
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
