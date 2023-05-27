using Owin;
using Microsoft.Owin;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System;

[assembly: OwinStartup(typeof(WebApplication.Startup))]
namespace WebApplication
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}