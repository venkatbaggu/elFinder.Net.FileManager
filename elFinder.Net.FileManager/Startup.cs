using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(elFinder.Net.FileManager.Startup))]
namespace elFinder.Net.FileManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
