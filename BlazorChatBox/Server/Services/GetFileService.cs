using BlazorChatBox.Server.Services;

namespace BlazorChatBox;

public class GetFileService : IGetFile
{
    public Stream GetFile(string fileName)
    {
       
        ReadFileToByte readFileToByte = new();
        Console.WriteLine($"the fileName from controller to SERVICE: {fileName}");
        var imgByte = readFileToByte.GetFile(fileName);
        return imgByte;
    }
}
