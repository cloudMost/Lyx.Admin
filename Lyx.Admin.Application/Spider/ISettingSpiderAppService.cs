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
    public interface ISettingSpiderAppService : IApplicationService
    {
     
        /// <summary>
        /// 创建或更新
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdateSetting(CreateOrUpdateSettingInput input);

    }
}
