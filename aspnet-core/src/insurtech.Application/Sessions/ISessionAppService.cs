using System.Threading.Tasks;
using Abp.Application.Services;
using insurtech.Sessions.Dto;

namespace insurtech.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
