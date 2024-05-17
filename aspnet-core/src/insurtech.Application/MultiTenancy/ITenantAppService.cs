using Abp.Application.Services;
using insurtech.MultiTenancy.Dto;

namespace insurtech.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

