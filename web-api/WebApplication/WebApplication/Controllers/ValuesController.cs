using Microsoft.AspNet.SignalR.Messaging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Linq;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    public class ValuesController : ApiController
    {

        [HttpGet]
        [Route("api/msg-mesmo-servidor")]
        public string Get()
        {            
            MensagensMesmoServidor.EnviarMensagemPeloDotNetCore();
            return "ok";
        }

        [HttpGet]
        [Route("api/simular-windows-forms")]
        public async Task<string> GetWindowsForms()
        {
            string retorno = await MensagensDiferentesEXEs.EnviarMensagensPeloWindowsForm();
            return retorno;
        }
    }
}
