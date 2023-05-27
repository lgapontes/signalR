using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Services.Description;

[assembly: OwinStartup(typeof(SignalRChat.Startup))]
namespace SignalRChat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();

            //IHubContext<ChatHub> h = GlobalHost.ConnectionManager.GetHubContext<ChatHub>("ChatHub");
            //EnviarMensagemParaClientes nova = new EnviarMensagemParaClientes(h);
            //nova.Enviar("Servidor", "teste");

        }
    }
}