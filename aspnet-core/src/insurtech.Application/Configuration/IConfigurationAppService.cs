using System.Threading.Tasks;
using insurtech.Configuration.Dto;

namespace insurtech.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
