using Microsoft.AspNetCore.SignalR;

namespace BlazorChatBox.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task SendImg(bool didImgSend)
        {
            await Clients.All.SendAsync("ReceiveImg", didImgSend);
        }
    }
}