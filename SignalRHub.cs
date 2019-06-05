using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRDemo
{
    public class SignalRHub : Hub
    {
        public async Task Join(string timestamp)
        {
            await this.Groups.AddToGroupAsync(this.Context.ConnectionId, timestamp);

            await SendMessage(this.Context.ConnectionId, timestamp);
        }

        public async Task SendMessage(string connectionId, string timestamp)
        {
            // Wait a second
            //await Task.Delay(1000);

            await this.Clients.Group(timestamp).SendAsync("confirmJoin", arg1: connectionId, arg2: timestamp);
        }
    }
}
