using BlazorChatBox.Client.Hubs;
using BlazorChatBox.Server.Services;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;


namespace BlazorChatBox.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaveController : ControllerBase
    {
        // post log
        [HttpPost]
        public void PostLog([FromBody] string log)
        {
           Console.WriteLine($"Chat Log received in controller: {log}");
           SaveLogService.SaveLogsToFile(log);
        }

        // post file
        [HttpPost("file")]
        public void PostFile([FromBody] SendFileViewModel fileInfo)
        {
            Console.WriteLine($"fileInfo for uploading file received in controller");
            var SaveFileServices = new SaveFileService();
            SaveFileServices.SendFile(fileInfo);
        }

    }
}
 