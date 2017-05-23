using System.Threading.Tasks;
using Abp.Application.Services;
using Lyx.Admin.Roles.Dto;

namespace Lyx.Admin.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
