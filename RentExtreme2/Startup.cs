using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentExtreme2.Startup))]
namespace RentExtreme2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
