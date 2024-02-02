using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Receives an input integer number and applies four mathematical operations on it. Truncates the result to an integer.
        /// </summary>
        /// <param name="id">The input number to perform four mathematical operations on.</param>
        /// <returns>The result of four mathematical operations (addition, subtraction, multiplication, division).</returns>
        /// <example>
        ///   GET /api/NumberMachine/10 => 82
        ///   GET /api/NumberMachine/-5 => 0
        ///   GET /api/NumberMachine/30 => 192
        /// </example>
        public int Get(int id)
        {
            int additon = 65; // used variables for dynamic coding and reusability.
            int substraction = 60;
            int multiplication = 11;
            int division = 2;
            int Result = (((id - substraction) + additon) * multiplication) / division; // Result is truncated to an integer.

            return Result ;
        }
    }
}
