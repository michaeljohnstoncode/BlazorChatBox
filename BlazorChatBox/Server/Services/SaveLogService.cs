namespace BlazorChatBox.Server.Services
{
    public class SaveLogService
    {
        static string _pathToWrite = @"F:\chatlog test\ChatLogs.txt";
        public static void SaveLogsToFile(string chatLogs)
        {
            using (StreamWriter sw = new StreamWriter(_pathToWrite, true))
            {
                sw.WriteLine(chatLogs);
            }
        }
    }
}
