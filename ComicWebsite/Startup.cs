using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComicWebsite.Startup))]
namespace ComicWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
