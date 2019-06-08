using System.Threading.Tasks;
using Abp.Application.Services;
using ABPDemo.Authorization.Accounts.Dto;

namespace ABPDemo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
