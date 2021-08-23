using System.Threading.Tasks;
using Bite_IT.Domain;
using Bite_IT.Hubs.Clients;
using Microsoft.AspNetCore.SignalR;

namespace Bite_IT.Hubs
{
    public class MenuHub : Hub<IDbClient>
    {
        public async Task SendMenuDb(Menu menu)
        {
            await Clients.All.ReceiveMenuData(menu);
        }
    }
}