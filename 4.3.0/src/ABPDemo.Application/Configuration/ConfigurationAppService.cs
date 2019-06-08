using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABPDemo.Configuration.Dto;

namespace ABPDemo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPDemoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
