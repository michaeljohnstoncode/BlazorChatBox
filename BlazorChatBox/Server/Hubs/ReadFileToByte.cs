namespace BlazorChatBox.Server.Services
{
    public class ReadFileToByte
    {
        public Stream GetFile(string fileName)
        {      
            Console.WriteLine($"File name in FileREADER request: {fileName}");
            string filePath = $"F:\\chatlog test\\{fileName}";
            FileInfo fileInfo = new FileInfo(filePath);
            byte[] fileData = new byte[filePath.Length];
            return new FileStream(filePath, FileMode.Open, FileAccess.Read);

        }
    }
}
