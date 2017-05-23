using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;

using Lyx.Admin.Spider.Dto;
using Abp.Application.Services.Dto;

namespace Lyx.Admin.Spider
{
    public interface ISpiderAppService: IApplicationService
    {
        /// <summary>
        /// 获取小说集合
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<NovelListDto>> GetNovels(GetNovelInput input);

        /// <summary>
        /// 创建或更新
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdateNovelSpider(CreateOrUpdateInput input);

    }
}
