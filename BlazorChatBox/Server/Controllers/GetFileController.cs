using Microsoft.AspNetCore.Mvc;

namespace BlazorChatBox.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetFileController : Controller
    {
        private readonly IGetFile _fileService;

        public GetFileController(IGetFile fileService)
        {
            _fileService = fileService;
        }

        [HttpGet("getFile/{fileName}")]
        public IActionResult GetImg(string fileName)
        {
            Stream bytes = _fileService.GetFile(fileName);
            return new FileStreamResult(bytes, "image/png");
        }

    }

}
