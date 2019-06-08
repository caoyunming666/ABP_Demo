using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABPDemo.Roles.Dto;
using ABPDemo.Users.Dto;

namespace ABPDemo.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}