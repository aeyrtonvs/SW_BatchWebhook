using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SW_APIS.Models;
using SW_APIS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SW_APIS.Controllers
{
    [Route("/batch/")]
    public class BatchController : Controller
    {
        [Route("webhook")]
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Webhook([FromBody]BatchModel batchRequest)
        {
            var validateRequest = BatchService.ValidateRequest(batchRequest);
            if (validateRequest.status != "success")
            {
                return BadRequest(validateRequest);
            }
            return Ok(validateRequest);
        }
    }
}
