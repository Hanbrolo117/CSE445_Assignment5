using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSE445_Assignment5.Startup))]
namespace CSE445_Assignment5
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
