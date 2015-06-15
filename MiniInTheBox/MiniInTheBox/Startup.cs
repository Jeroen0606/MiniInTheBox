using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiniInTheBox.Startup))]
namespace MiniInTheBox
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
