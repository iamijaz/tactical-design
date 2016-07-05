using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControllerFactoryDemo.Startup))]
namespace ControllerFactoryDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
