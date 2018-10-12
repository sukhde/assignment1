using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(assign1.Startup))]
namespace assign1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
