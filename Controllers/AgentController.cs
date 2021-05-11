using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;

namespace IdentityWebApiTests.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Policy = "Agent")]
    public class AgentController : ControllerBase
    {
        [HttpGet]
        [Route("[action]")]
        [Authorize(Policy = "ClearanceLevel1")]
        public ActionResult<String> AccessPublicFiles()
        {
            return new OkObjectResult("Public Files Accessed");
        }

        [HttpGet]
        [Route("[action]")]
        [Authorize(Policy = "ClearanceLevel2")]
        public ActionResult<String> AccessClassifiedFiles()
        {
            return new OkObjectResult("Classified Files Accessed");
        }
    }
}