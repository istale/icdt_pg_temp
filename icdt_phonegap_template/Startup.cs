using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(icdt_phonegap_template.Startup))]
namespace icdt_phonegap_template
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
