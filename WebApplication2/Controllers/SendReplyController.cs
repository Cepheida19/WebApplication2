using Microsoft.AspNetCore.Mvc;
using WebApplication2.DALLayer;
using WebApplication2.ServicesLayer;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SendReplyController : ControllerBase
    {
        private readonly ILogicService _logicService;
        private readonly IDataService _dataService;

        public SendReplyController(ILogicService logicService, IDataService dataService)
        {
            _logicService = logicService;
            _dataService = dataService;
        }

        [HttpPost("PostSendReply")]
        public string Post(int number, string reply)
        {
            _logicService.ProcessData(number, reply);
            return "Ok";
        }
        [HttpGet("GetResult")]
        public int Get()
        {
            return _logicService.CompareAnswers(_dataService.GetCorrectAnswers(), _dataService.GetReceivedAnswers());
        }
    }
}
