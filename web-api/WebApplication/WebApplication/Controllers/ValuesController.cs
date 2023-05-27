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

namespace WebApplication.Controllers
{
    public class ValuesController : ApiController
    {

        // GET api/values
        public IEnumerable<string> Get()
        {            
            EnviarMensagens.EnviarMensagemPeloDotNetCore("teste mensagem");
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
