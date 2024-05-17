using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using insurtech.Configuration.Dto;

namespace insurtech.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : insurtechAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
