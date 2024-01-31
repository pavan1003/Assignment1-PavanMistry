using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Receives an input integer number and returns 10 more than that number.
        /// </summary>
        /// <param name="id">The input integer that gets added by 10.</param>
        /// <returns>The result of adding 10 to the input number.</returns>
        /// <example>
        ///   GET /api/AddTen/21 => 31
        ///   GET /api/AddTen/0 => 10
        ///   GET /api/AddTen/-9 => 1
        /// </example>

        public int Get(int id)
        {
            int IdPlusTen = id + 10;
            return IdPlusTen;
        }
    }
}
