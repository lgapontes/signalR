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
    public class EnviarMensagens
    {

        public static void EnviarMensagemPeloDotNetCore(string mensagem)
        {
            Debug.WriteLine(">> Simulando MSG pelo mesmo servidor SignalR");
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();
            context.Clients.All.addNewMessageToPage("Servidor", mensagem);
        }

        public static async void EscutarMensagensPeloWindowsForm()
        {
            await Task.Delay(5000);
            Debug.WriteLine(">> Simulando MSG Windows Forms");
            using (var hubConnection = new HubConnection("https://localhost:44350/"))
            {
                IHubProxy chat = hubConnection.CreateHubProxy("ChatHub");
                //chat.On<string,string>("Send", (name, message) => Debug.WriteLine(">> {0}: {1}", name, message));
                await hubConnection.Start();
                await Task.Delay(5000);
            }

            //HubConnection conn = new HubConnectionBuilder()
            //    .WithUrl("https://localhost:44350/signalr").Build();

            //conn.StartAsync().ContinueWith(t => {
            //    if (t.IsFaulted)
            //        Debug.WriteLine(t.Exception.GetBaseException());
            //    else
            //        Debug.WriteLine(">> Conectado ao HUB");

            //    //conn.On<string, string>("Send", (name, message) => Debug.WriteLine(">> {0}: {1}", name, message));
            //}).Wait();


            //conn.On<string, string>("Send", (name, message) => Debug.WriteLine(">> {0}: {1}", name, message));
        }

        /*
        private IHubContext _context;

        private EnviarMensagens()
        {
            _context = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();
        }

        // This method is invoked by a Timer object.
        private void Enviar(string mensagem)
        {
            _context.Clients.All.Send("Servidor", mensagem);
        }

        public static void Send(string mensagem)
        {
            EnviarMensagens em = new EnviarMensagens();
            em.Enviar(mensagem);
        }
        */
    }
}