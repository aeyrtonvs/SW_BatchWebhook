using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SW_APIS.Models;
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
        [Authorize]
        public async Task Webhook([FromBody]BatchModel batchRequest)
        {

        }
    }
}
