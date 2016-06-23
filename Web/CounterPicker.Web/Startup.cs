using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CounterPicker.Web.Startup))]
namespace CounterPicker.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
