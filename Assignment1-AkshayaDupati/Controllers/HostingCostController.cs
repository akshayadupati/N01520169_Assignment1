using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_AkshayaDupati.Controllers
{
    public class HostingCostController : ApiController
    {
        // GET - api/HostingCost/id
        /// <summary>
        /// This function takes in the number as parameter from the request and calculates the rate based on number of fortnights , tax rates and the total value.
        /// </summary>
        /// <param name="id">0</param>
        /// <returns>“1 fortnights at $5.50/FN = $5.50 CAD”
        ///“HST 13% = $0.72 CAD”
        ///“Total = $6.22 CAD”
        ///</returns>
        public IEnumerable<string> Get(double id)
        {
            double numberOfFortNights = Math.Floor(id / 14) + 1;
            double fortNightRate = Math.Round((numberOfFortNights * 5.50),2);
            string textOne = numberOfFortNights + " fortNights at $5.50/FN = $" + fortNightRate + " CAD";
            double taxRate = Math.Round(((13 * fortNightRate) / 100),2);
            string textTwo = "HST 13% = $" + taxRate + " CAD";
            double total = fortNightRate + taxRate;
            string textThree = "Total = $" + total + " CAD";

            return new string[] { textOne , textTwo , textThree};
        }
    }
}
