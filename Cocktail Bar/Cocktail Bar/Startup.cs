using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cocktail_Bar.Startup))]
namespace Cocktail_Bar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
