using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_AkshayaDupati.Controllers
{
    public class GreetingController : ApiController
    {

        // POST - api/greeting
        /// <summary>
        /// This function is used to post the hello world string when it sends the request
        /// </summary>
        /// <returns>Hello World</returns>
        public string Post()
        {
            return "Hello World!";
        }

        // GET - api/greeting/id
        /// <summary>
        /// This function is used to append the parameter with the greetings text
        /// </summary>
        /// <param name="id">Eg.3</param>
        /// <returns>Greetings to 3 people!</returns>

        public string Get(int id)
        {

            var _greetingsText = "Greetings to " + id + " people!";
            return _greetingsText;
        }
    }
}
