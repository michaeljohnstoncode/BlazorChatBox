using BlazorChatBox.Client;

namespace BlazorChatBox;

public class GetLogService : IGetLogChat
{
    public IEnumerable<string> GetLogs()
    {
        var logs = LogToFile.DisplayLogs();
        return logs;
    }
} 