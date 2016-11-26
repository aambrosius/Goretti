using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GorrettiBoutique.Startup))]
namespace GorrettiBoutique
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
