using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Receives an input number of days and calcualtes the total cost of hosting according to fortnights.
        /// </summary>
        /// <param name="id">Represents number of days</param> 
        /// <returns>Returns a string with fortnights cost, HST and total cost of hosting</returns>
        /// <example>
        ///   GET /api/HostingCost/0  => "1 fortnights at $5.50/FN = $5.50 CAD", "HST 13% = $0.72 CAD", "Total = $6.22 CAD"
        ///   GET /api/HostingCost/14 => "2 fortnights at $5.50/FN = $11.00 CAD", "HST 13% = $1.43 CAD", "Total = $12.43 CAD"
        ///   GET /api/HostingCost/15 => "2 fortnights at $5.50/FN = $11.00 CAD", "HST 13% = $1.43 CAD", "Total = $12.43 CAD"
        ///   GET /api/HostingCost/21 => "2 fortnights at $5.50/FN = $11.00 CAD", "HST 13% = $1.43 CAD", "Total = $12.43 CAD"
        ///   GET /api/HostingCost/28 => "3 fortnights at $5.50/FN = $16.50 CAD", "HST 13% = $2.15 CAD", "Total = $18.65 CAD"
        /// </example>
        public IEnumerable<string> GET(int id)
        {
            int fortnights = (id / 14) + 1; // As day 1 counts as fortnight 1 and day 14 starts fortnight 2 and so on..
            double costPerFortnight = 5.50; 
            double hostingCostWithoutTax = costPerFortnight * fortnights;
            double HST = 0.13 * hostingCostWithoutTax;
            double totalHostingCost = HST + hostingCostWithoutTax;

            return new string[]
            {
                $"{fortnights} fortnights at $5.50/FN = ${hostingCostWithoutTax.ToString("0.00")} CAD", // converted to string to fix 2 decimal places with the 0 at the end. EG: $5.50 .
                $"HST 13% = ${HST.ToString("0.00")} CAD",
                $"Total = ${totalHostingCost.ToString("0.00")} CAD"
            };

        }
    }
}
