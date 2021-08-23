using System.Threading.Tasks;
using Bite_IT.Domain;

namespace Bite_IT.Hubs.Clients
{
    public interface IDbClient
    {
        Task ReceiveMenuData(Menu menu);
    }
}