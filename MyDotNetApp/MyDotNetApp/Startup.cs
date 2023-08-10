using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyDotNetApp.Startup))]
namespace MyDotNetApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
