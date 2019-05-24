using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRDemo
{
    public class SignalRHub : Hub
    {
        public async Task Join(string whateverId)
        {
            await this.Groups.AddToGroupAsync(this.Context.ConnectionId, whateverId);

            await SendMessage(whateverId);
        }

        public async Task SendMessage(string whateverId)
        {
            // Wait a second
            await Task.Delay(1000);

            await this.Clients.Group(whateverId).SendAsync("ConfirmConnection", arg1: whateverId);
        }
    }
}
