using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRDemo
{
    public class SignalRHub : Hub
    {
        public async Task JoinAsync(string aliasId)
        {
            await this.Groups.AddToGroupAsync(this.Context.ConnectionId, aliasId);

            await SendMessage(aliasId);
        }


        public async Task SendMessage(string aliasId)
        {
            // Wait a second
            await Task.Delay(1000);

            await this.Clients.Group(aliasId).SendAsync("ConfirmConnection", arg1: aliasId);
        }
    }
}
