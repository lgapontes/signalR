using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNet.SignalR.Messaging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Xml.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;

namespace WebApplication
{
    public class MensagensDiferentesEXEs
    {

        public static async Task<string> EnviarMensagensPeloWindowsForm()
        {
            Debug.WriteLine(">> Simulando MSG Windows Forms");

            try
            {
                HubConnection hubConnection = new HubConnection("https://localhost:44350/");
                IHubProxy chat = hubConnection.CreateHubProxy("ChatHub");
                await hubConnection.Start();
                await chat.Invoke<string, string>("Send", null, "SERVIDOR Windows Forms", "Simulando teste de outro EXE");
                hubConnection.Dispose();
            }
            catch
            {
                /*
                 * Segundo a documentação, o Dispose feito pelo client (neste caso simulando uma Windows Forms)
                 * sempre dispara uma Exception (controlada), para informar que não foi o servidor que encerrou.                 
                 * 
                 * https://stackoverflow.com/questions/52962752/how-to-correctly-dispose-a-client-stream-if-the-connection-has-disconnected
                 */
                Debug.WriteLine(">> Conexao finalizada");
            }
            
            return "ok";
        }        
    }
}