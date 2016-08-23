using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ImageShare.Web.Startup))]
namespace ImageShare.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
