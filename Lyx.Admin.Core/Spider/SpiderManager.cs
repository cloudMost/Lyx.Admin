using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Lyx.Admin.Spider
{
    public class SpiderManager:DomainService
    {
        private readonly IRepository<NovelSpider> _novelRepository;
        
        private readonly IRepository<ArticleSpider> _articleRepository;

        private readonly IRepository<InterFruit> _interFruitRepository;

        public SpiderManager(IRepository<NovelSpider> novelRepository,
            IRepository<ArticleSpider> articleRepository,
            IRepository<InterFruit> interFruitRepository
            )
        {
            _novelRepository = novelRepository;
            _articleRepository = articleRepository;
            _interFruitRepository = interFruitRepository;
        }
      

        /// <summary>
        /// 创建小说爬虫
        /// </summary>
        /// <returns></returns>
        public virtual async Task CreateNovelSpider(NovelSpider novel)
        {
            await _novelRepository.InsertAsync(novel);
        }

    }
}
