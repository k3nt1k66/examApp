using System.Threading.Tasks;
using WebApplication2.Dtos;

namespace WebApplication2.SyncDataServices.Http
{
    public interface ICommandDataClient
    {
        Task SendAppToCommand(PlatformReadDto plat);
    }
}