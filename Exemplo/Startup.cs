using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Exemplo.Startup))]
namespace Exemplo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
