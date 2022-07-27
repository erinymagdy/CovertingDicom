using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(convertDicomToJpg.Startup))]
namespace convertDicomToJpg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
