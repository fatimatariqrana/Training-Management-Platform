using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PakistanTrainingManagementPlatform.Website.Startup))]
namespace PakistanTrainingManagementPlatform.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
