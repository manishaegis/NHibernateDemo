using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAppLinq.Startup))]
namespace TestAppLinq
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
