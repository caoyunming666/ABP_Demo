using System.Threading.Tasks;
using Abp.Application.Services;
using ABPDemo.Configuration.Dto;

namespace ABPDemo.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}