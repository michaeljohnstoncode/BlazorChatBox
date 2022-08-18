using BlazorChatBox.Client.Hubs;

namespace BlazorChatBox.Server.Services
{
    public class SaveFileService
    {
        public Task SendFile(SendFileViewModel fileInfo)
        {
            var fileData = fileInfo.FileData;
            string fileName = fileInfo.FileName;
            Console.WriteLine($"this is the attempted file name for uploading: {fileName}");
            string filePath = $"F:\\chatlog test\\{fileName}";
            using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                Console.WriteLine($"FileStream uploading file success...: {fileName}");
                fs.Write(fileData, 0, fileData.Length);
            }

            return Task.CompletedTask;
        }
    }
}
