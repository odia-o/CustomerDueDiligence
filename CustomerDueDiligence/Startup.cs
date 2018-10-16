using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerDueDiligence.Startup))]
namespace CustomerDueDiligence
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
