using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Doña_Juanita1.Startup))]
namespace Doña_Juanita1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
