using Abp.Authorization;
using Lyx.Admin.Authorization.Roles;
using Lyx.Admin.MultiTenancy;
using Lyx.Admin.Users;

namespace Lyx.Admin.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
