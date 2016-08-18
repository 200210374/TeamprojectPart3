using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamprojectPart3.Startup))]
namespace TeamprojectPart3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
