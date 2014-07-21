using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamCityDemo.Startup))]
namespace TeamCityDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
