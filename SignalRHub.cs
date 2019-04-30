using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRDemo
{
    public class SignalRHub : Hub
    {
        public async Task JoinAsync(string aliasId)
        {
            await this.Groups.AddToGroupAsync(this.Context.ConnectionId, aliasId);
        }
    }
}
