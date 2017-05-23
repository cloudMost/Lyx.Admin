using System.Linq;
using System.Linq.Dynamic;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.Entity;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;

using Lyx.Admin.Spider.Dto;
using Abp.AutoMapper;

namespace Lyx.Admin.Spider
{
    /// <summary>
    /// 爬虫服务
    /// </summary>
    public class SpiderAppService : AdminAppServiceBase, ISpiderAppService
    {
        private readonly IRepository<NovelSpider> _novelRepository;
        
        private readonly SpiderManager _spiderManager;

        /// <summary>
        /// 构造
        /// </summary>
        public SpiderAppService(IRepository<NovelSpider> novelRepository,SpiderManager spiderManager)
        {
            _novelRepository = novelRepository;
            _spiderManager = spiderManager;
            
        }
        /// <summary>
        /// 获取小说列表数据
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<PagedResultDto<NovelListDto>> GetNovels(GetNovelInput input)
        {
            var query=_novelRepository.GetAll();
            
            //增加查询条件
            //query=query.WhereIf(!input.);

            var resultCount = await query.CountAsync();
            var results = await query
                .AsNoTracking()
                .OrderBy(input.Sorting)
                .PageBy(input)
                .ToListAsync();

            var list= new PagedResultDto<NovelListDto>(resultCount, results.MapTo<List<NovelListDto>>());

            return list;
        }

        public async Task CreateOrUpdateNovelSpider(CreateOrUpdateInput input)
        {
            if (input.NovelSpider.Id.HasValue)
            {
                //await UpdateNovelSpiderAsync(input);
            }
            else
            {
                await CreateNovelSpiderAsync(input);
            }
        }

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        protected virtual async Task CreateNovelSpiderAsync(CreateOrUpdateInput input)
        {
            try
            {
                var novel = input.NovelSpider.MapTo<NovelSpider>();
                await _spiderManager.CreateNovelSpider(novel);
            }
            catch (System.Exception ex)
            {

                throw;
            }

        }

    }
}
