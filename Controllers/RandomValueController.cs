using Microsoft.AspNetCore.Mvc;
using System;

namespace RandomValueAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomValueController : ControllerBase
    {
        private static readonly Random random = new Random();

        [HttpGet]
        public ActionResult<int> Get()
        {
            int randomValue = random.Next(1, 100);
            return Ok(randomValue);
        }
    }
}
