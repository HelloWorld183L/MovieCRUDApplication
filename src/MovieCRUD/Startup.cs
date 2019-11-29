using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieCRUD.Web.Startup))]
namespace MovieCRUD.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}