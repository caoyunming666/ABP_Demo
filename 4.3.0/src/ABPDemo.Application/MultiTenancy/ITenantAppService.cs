using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABPDemo.MultiTenancy.Dto;

namespace ABPDemo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
