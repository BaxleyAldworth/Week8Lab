using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week8Lab.Reddit.Startup))]
namespace Week8Lab.Reddit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
