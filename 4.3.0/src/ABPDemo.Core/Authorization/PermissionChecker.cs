using Abp.Authorization;
using ABPDemo.Authorization.Roles;
using ABPDemo.Authorization.Users;

namespace ABPDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
