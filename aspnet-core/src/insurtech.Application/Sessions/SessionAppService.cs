using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Auditing;
using insurtech.Sessions.Dto;

namespace insurtech.Sessions
{
    public class SessionAppService : insurtechAppServiceBase, ISessionAppService
    {
        [DisableAuditing]
        public async Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations()
        {
            try
            {

                var output = new GetCurrentLoginInformationsOutput
                {
                    Application = new ApplicationInfoDto
                    {
                        Version = AppVersionHelper.Version,
                        ReleaseDate = AppVersionHelper.ReleaseDate,
                        Features = new Dictionary<string, bool>()
                    }
                };

                if (AbpSession.TenantId.HasValue)
                {
                    output.Tenant = ObjectMapper.Map<TenantLoginInfoDto>(await GetCurrentTenantAsync());
                }

                if (AbpSession.UserId.HasValue)
                {
                    output.User = ObjectMapper.Map<UserLoginInfoDto>(await GetCurrentUserAsync());
                }

                return output;
            }catch(Exception e)
            {
                throw new Exception("ex:", e);

            }
        }
    }
}
