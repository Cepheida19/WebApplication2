using Microsoft.AspNetCore.Mvc;
using WebApplication2.ServicesLayer;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SendReplyController : ControllerBase
    {
        private readonly ILogicService _logicService;

        public SendReplyController(ILogicService logicService)
        {
            _logicService = logicService;
        }

        [HttpPost("PostSendReply")]
        public async Task<string> Post(int number, string reply)
        {
            await _logicService.ProcessData(number, reply);
            return "Ok";
        }

        [HttpGet("GetDatabaseResult")]
        public async Task<int> GetDatabaseResult()
        {
            return await _logicService.CompareDatabaseAnswers();
        }
    }
}
