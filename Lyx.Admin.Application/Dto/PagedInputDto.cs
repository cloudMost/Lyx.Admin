using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Lyx.Admin;
using Abp.Linq.Extensions;
namespace Lyx.Admin.Dto
{
    /// <summary>
    /// 分页dto
    /// </summary>
    public class PagedInputDto : IPagedResultRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [Range(1, AppConsts.MaxPageSize)]
        public int MaxResultCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Range(0, int.MaxValue)]
        public int SkipCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public PagedInputDto()
        {
            MaxResultCount = AppConsts.DefaultPageSize;
        }
    }
}