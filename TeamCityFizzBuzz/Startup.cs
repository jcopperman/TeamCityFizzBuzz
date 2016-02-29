using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamCityFizzBuzz.Startup))]
namespace TeamCityFizzBuzz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
