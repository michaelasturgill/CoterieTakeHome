using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace CoterieTakeHome.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RateController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetRatePerDescription()
        {
            string inputData = "";
            string ohRate = "1";
            string flRate = "1.2";
            string txRate = ".943";
            string architectFactor = "1";
            string plumberFactor = ".5";
            string programmerFactor = "1.25";

            if (inputData == ohRate && inputData == architectFactor)
            {
                return Ok();
            }
            else if (inputData == ohRate && inputData == plumberFactor)
            {
                return Ok();
            }
            else if (inputData == ohRate && inputData == programmerFactor)
            {
                return Ok();
            }

            else if (inputData == flRate && inputData == architectFactor)
            {
                return Ok();
            }
            else if (inputData == flRate && inputData == plumberFactor)
            {
                return Ok();
            }
            else if (inputData == flRate && inputData == programmerFactor)
            {
                return Ok();
            }

            else if (inputData == txRate && inputData == architectFactor)
            {
                return Ok();
            }
            else if (inputData == txRate && inputData == plumberFactor)
            {
                return Ok();
            }
            else if (inputData == txRate && inputData == programmerFactor)
            {
                return Ok();
            }

            else
            {
                return NotFound();
            }
        }

    }
}
