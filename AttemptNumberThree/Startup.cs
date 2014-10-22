using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AttemptNumberThree.Startup))]
namespace AttemptNumberThree
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
