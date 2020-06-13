using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarfazahFashion.Startup))]
namespace MarfazahFashion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
