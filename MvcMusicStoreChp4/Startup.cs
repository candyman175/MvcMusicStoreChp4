using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcMusicStoreChp4.Startup))]
namespace MvcMusicStoreChp4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
