using BlazorChatBox.Client;
using BlazorChatBox.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorChatBox.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetLogController : ControllerBase
    {

      //private readonly ILogger<LogsController> _logger;
        private readonly IGetLogChat _chatService;


      public GetLogController(/*ILogger<LogsController> logger,*/ IGetLogChat chatService)
        {
            //_logger = logger;
            _chatService = chatService;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _chatService.GetLogs();
        }

    }
}
