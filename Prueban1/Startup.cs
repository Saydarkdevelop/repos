using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prueban1.Startup))]
namespace Prueban1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
