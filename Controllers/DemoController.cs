using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using nagp_deployment_demo;

namespace Web_Application.Controllers
{
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly ILogger<DemoController> _logger;
        private readonly DemoDbContext _demoDbContext;
        public DemoController(ILogger<DemoController> logger, DemoDbContext demoDbContext)
        {
            _logger = logger;
            _demoDbContext = demoDbContext;
        }

        [HttpGet("")]
        public Demo Get()
        {
            try{
    	    Demo demo = _demoDbContext.Demo.Find(1);
            return demo;
            }
            catch{
                return new Demo(){
                    Data = "Unable to fetch data from db"
                };
            }
        }

    }
}
