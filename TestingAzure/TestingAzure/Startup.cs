using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingAzure.Startup))]
namespace TestingAzure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
