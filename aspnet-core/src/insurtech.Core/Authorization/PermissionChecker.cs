using Abp.Authorization;
using insurtech.Authorization.Roles;
using insurtech.Authorization.Users;

namespace insurtech.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
