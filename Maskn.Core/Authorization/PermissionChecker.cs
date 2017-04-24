using Abp.Authorization;
using Maskn.Authorization.Roles;
using Maskn.MultiTenancy;
using Maskn.Users;

namespace Maskn.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
