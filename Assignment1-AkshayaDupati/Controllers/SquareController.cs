using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_AkshayaDupati.Controllers
{
    public class SquareController : ApiController
    {

        // GET - api/Square/id
        /// <summary>
        /// This function is used to multiply the number that comes in as the parameter in the request with itself
        /// </summary>
        /// <param name="id">Eg.2</param>
        /// <returns>4</returns>
        public int Get(int id)
        {

            var squaredValue = id * id;
            return squaredValue;
        }
    }
}
