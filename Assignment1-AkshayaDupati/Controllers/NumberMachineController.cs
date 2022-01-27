using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_AkshayaDupati.Controllers
{
    public class NumberMachineController : ApiController
    {

        // GET - api/NumberMachine/id
        /// <summary>
        /// This function takes the number in the request and performs multiplication,division,subtraction and addition using BODMAS rule.
        /// </summary>
        /// <param name="id">Eg.5</param>
        /// <returns>30</returns>
        public int Get(int id)
        {

            int endResult = id * id - id % id + id;
            return endResult;

        }
    }
}
