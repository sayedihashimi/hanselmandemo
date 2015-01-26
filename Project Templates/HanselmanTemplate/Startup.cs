using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HanselmanTemplate.Startup))]
namespace HanselmanTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
