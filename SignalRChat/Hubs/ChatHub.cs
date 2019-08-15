using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }


        public async Task BrodCast()
        {
            await Clients.All.SendAsync("LogMessage");
        }

        public async Task UpdatePlayingVideo( string URL , string TITLE)
        {
            await Clients.All.SendAsync("Update" , URL , TITLE);
        }


    }
}