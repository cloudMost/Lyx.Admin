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
    public class SettingSpiderManager : DomainService
    {
       
        private readonly IRepository<SettingSpider> _settingSpiderRepository;

        public SettingSpiderManager(IRepository<SettingSpider> settingSpiderRepository
            )
        {
            _settingSpiderRepository = settingSpiderRepository;
           
        }
      

        /// <summary>
        /// 创建
        /// </summary>
        /// <returns></returns>
        public virtual async Task CreateNovelSetting(SettingSpider set)
        {
            await _settingSpiderRepository.InsertAsync(set);
        }

    }
}
