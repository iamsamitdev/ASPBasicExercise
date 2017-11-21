using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestWebform.Startup))]
namespace TestWebform
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
