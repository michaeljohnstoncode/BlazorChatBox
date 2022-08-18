

namespace BlazorChatBox.Client.Hubs
{
    public class SendFileViewModel
    {
        public byte[] FileData { get; set; }
        public string FileName { get; set; } = "default";
  
    }
}
