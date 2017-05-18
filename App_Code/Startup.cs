using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Đồ_án_website_Bóng_đá.Startup))]
namespace Đồ_án_website_Bóng_đá
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
