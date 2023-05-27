using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Messaging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Xml.Linq;
using System.Runtime.Remoting.Messaging;
using Microsoft.AspNet.SignalR.Client;
using System.Threading.Tasks;

namespace WebApplication
{
    public class MensagensMesmoServidor
    {

        public static void EnviarMensagemPeloDotNetCore()
        {
            Debug.WriteLine(">> Simulando MSG pelo mesmo servidor SignalR");
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();
            context.Clients.All.addNewMessageToPage("SERVIDOR .Net Core", "Simulando teste do mesmo EXE");
        }

    }
}