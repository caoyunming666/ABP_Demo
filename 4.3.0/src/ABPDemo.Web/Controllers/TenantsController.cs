using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Application.Services.Dto;
using Abp.Web.Mvc.Authorization;
using ABPDemo.Authorization;
using ABPDemo.MultiTenancy;

namespace ABPDemo.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : ABPDemoControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _tenantAppService.GetAll(new PagedResultRequestDto { MaxResultCount = int.MaxValue }); //Paging not implemented yet
            return View(output);
        }

        public async Task<ActionResult> EditTenantModal(int tenantId)
        {
            var tenantDto = await _tenantAppService.Get(new EntityDto(tenantId));
            return View("_EditTenantModal", tenantDto);
        }
    }
}