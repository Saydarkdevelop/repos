using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Doña_Juanita.Startup))]
namespace Doña_Juanita
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
