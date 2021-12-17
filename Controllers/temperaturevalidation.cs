using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tempweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class temperaturevalidation : ControllerBase
    {

        [HttpPost("calculate")]
        public ActionResult temperature(string option, double temp, string scaleinit, string scalefinal)
        {
            if (option.Equals("1"))
            {
                scaleinit = ("c");
                scalefinal = ("f");
                return Ok((temp * 9 / 5) + 32);

            }
            if (option.Equals("2"))
            {
                scaleinit = ("c");
                scalefinal = ("k");
                return Ok(temp + 273.15);

            }

            if (option.Equals("3"))
            {
                scaleinit = ("f");
                scalefinal = ("c");
                return Ok((temp -32) * 5 / 9);

            }

            if (option.Equals("4"))
            {
                scaleinit = ("f");
                scalefinal = ("k");
                return Ok((temp - 32) * 5 / 9 + 273.15);

            }

            if (option.Equals("5"))
            {
                scaleinit = ("k");
                scalefinal = ("c");
                return Ok(temp - 273.15);

            }

            if (option.Equals("6"))
            {
                scaleinit = ("k");
                scalefinal = ("f");
                return Ok((temp -273.15) * 9 / 5 +32);

            }


            else
                return BadRequest("Error Bad Querry");

        }

    }
}



