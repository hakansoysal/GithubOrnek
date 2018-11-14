using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GithubOrnek.Startup))]
namespace GithubOrnek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
