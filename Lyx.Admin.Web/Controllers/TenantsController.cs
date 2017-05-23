using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Lyx.Admin.Authorization;
using Lyx.Admin.MultiTenancy;

namespace Lyx.Admin.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : AdminControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}