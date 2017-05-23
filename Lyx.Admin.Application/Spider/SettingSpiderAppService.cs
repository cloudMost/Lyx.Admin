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
    public class SettingSpiderAppService : AdminAppServiceBase, ISettingSpiderAppService
    {
       
        
        private readonly SettingSpiderManager _settingSpiderManager;

        /// <summary>
        /// 构造
        /// </summary>
        public SettingSpiderAppService(SettingSpiderManager settingSpiderManager)
        {

            _settingSpiderManager = settingSpiderManager;
            
        }
     

        public async Task CreateOrUpdateSetting(CreateOrUpdateSettingInput input)
        {
            if (input.Setting.Id.HasValue)
            {
                //await UpdateNovelSpiderAsync(input);
            }
            else
            {
                await CreateNovelSettingAsync(input);
            }
        }

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        protected virtual async Task CreateNovelSettingAsync(CreateOrUpdateSettingInput input)
        {
            try
            {
                var set = input.Setting.MapTo<SettingSpider>();
                await _settingSpiderManager.CreateNovelSetting(set);
            }
            catch (System.Exception ex)
            {

                throw;
            }

        }

    }
}
