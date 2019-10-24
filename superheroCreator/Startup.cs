using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(superheroCreator.Startup))]
namespace superheroCreator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
