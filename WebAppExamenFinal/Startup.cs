using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppExamenFinal.Startup))]
namespace WebAppExamenFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
