using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using insurtech.Roles.Dto;
using insurtech.Users.Dto;

namespace insurtech.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task DeActivate(EntityDto<long> user);
        Task Activate(EntityDto<long> user);
        Task<ListResultDto<RoleDto>> GetRoles();
        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);

        [RemoteService(false)]
        Task VerifyEmail(long userId, string code);

    }
}
