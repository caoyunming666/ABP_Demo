using System.Threading.Tasks;
using Abp.Application.Services;
using ABPDemo.Sessions.Dto;

namespace ABPDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
