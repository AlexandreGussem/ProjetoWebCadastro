using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoWebCadastro.Startup))]
namespace ProjetoWebCadastro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
