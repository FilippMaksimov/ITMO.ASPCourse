using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITMO.ASPCourse.MVC.Lab08.Startup))]
namespace ITMO.ASPCourse.MVC.Lab08
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
