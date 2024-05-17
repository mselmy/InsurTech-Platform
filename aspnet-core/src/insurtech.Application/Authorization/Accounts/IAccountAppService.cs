using System.Threading.Tasks;
using Abp.Application.Services;
using insurtech.Authorization.Accounts.Dto;

namespace insurtech.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
