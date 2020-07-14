using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web_Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : ControllerBase
    {
        private readonly ILogger<DemoController> _logger;

        public DemoController(ILogger<DemoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Demo Get()
        {
            return new Demo(){
                Data = "Made by Suyash Khanna"
            };
        }
    }
}
