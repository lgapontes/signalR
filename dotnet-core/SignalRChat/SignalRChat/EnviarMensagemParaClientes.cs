using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace SignalRChat
{
    public class EnviarMensagemParaClientes
    {
        private readonly IHubContext<ChatHub> _hubContext;

        public EnviarMensagemParaClientes(IHubContext<ChatHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task Enviar(string name, string message)
        {
            _hubContext.Clients.All.Send(name, message);
        }
    }
}