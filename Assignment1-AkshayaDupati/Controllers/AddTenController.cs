using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_AkshayaDupati.Controllers
{
    public class AddTenController : ApiController
    {

        // GET - api/AddTen/10
        /// <summary>
        /// The below function is used to add 10 to the given parameter in the request
        /// </summary>
        /// <param name="id">Eg.21</param>
        /// <returns>31</returns>
        public int Get(int id)
        {

            var addedValue = id + 10;
            return addedValue;
        }
    }
}
