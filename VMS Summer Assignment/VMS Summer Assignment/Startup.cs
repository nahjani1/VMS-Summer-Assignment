using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VMS_Summer_Assignment.Startup))]
namespace VMS_Summer_Assignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
