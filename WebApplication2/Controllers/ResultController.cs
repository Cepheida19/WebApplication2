using Microsoft.AspNetCore.Mvc;
using WebApplication2.ServicesLayer;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResultController : ControllerBase
    {
        private readonly ILogicCompareService _logicCompareService;

        public ResultController(ILogicCompareService logicCompareService)
        {
            _logicCompareService = logicCompareService;
        }

        [HttpGet("GetResult")]
        public int Get()
        {
            // return int in %;
        }
    }
}