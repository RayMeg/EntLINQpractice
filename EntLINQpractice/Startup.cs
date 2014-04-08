using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntLINQpractice.Startup))]
namespace EntLINQpractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
