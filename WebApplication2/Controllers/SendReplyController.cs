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
        public string Post(int number, string reply)
        {
            _logicService.ProcessData(number, reply);
            return "Ok";
        }
    }
}
