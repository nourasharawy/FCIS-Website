using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(firstWebProject.Startup))]
namespace firstWebProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
