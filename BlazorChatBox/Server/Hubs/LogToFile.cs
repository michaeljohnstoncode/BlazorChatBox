namespace BlazorChatBox.Client
{
    public class LogToFile
    {
        static FileInfo _pathToRead = new FileInfo(@"F:\chatlog test\ChatLogs.txt");

        public static IEnumerable<string> DisplayLogs()
        {
            var tempSRList = new List<string>();
            var intIncrease = -1;


            using (StreamReader sr = new StreamReader(_pathToRead.FullName))
            {
                while (sr.Peek() >= 0)
                {
                    intIncrease++;
                    tempSRList.Add(sr.ReadLine());
                    yield return tempSRList[intIncrease];
                }
            }
        }
    }
}
