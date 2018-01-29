using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ISAM5635_MIT.Startup))]
namespace ISAM5635_MIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
