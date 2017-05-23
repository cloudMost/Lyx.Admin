using Abp.Application.Services.Dto;

namespace Lyx.Admin.Dto
{
    /// <summary>
    /// 分页dto 带整理
    /// </summary>
    public class PagedAndSortedInputDto : PagedInputDto, ISortedResultRequest
    {
        public string Sorting { get; set; }

        public PagedAndSortedInputDto()
        {
            MaxResultCount = AppConsts.DefaultPageSize;
        }
    }
}