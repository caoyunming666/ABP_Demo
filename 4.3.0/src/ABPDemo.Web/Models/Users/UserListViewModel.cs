using System.Collections.Generic;
using ABPDemo.Roles.Dto;
using ABPDemo.Users.Dto;

namespace ABPDemo.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}