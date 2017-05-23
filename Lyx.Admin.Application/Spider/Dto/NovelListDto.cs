using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace Lyx.Admin.Spider.Dto
{
    /// <summary>
    /// 小说列表输出
    /// </summary>
    [AutoMapFrom(typeof(NovelSpider))]
    public class NovelListDto: EntityDto<int>
    {
        /// <summary>
        /// 小说名
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// 小说作者
        /// </summary>
        public virtual string Author { get; set; }
        /// <summary>
        /// 小说分类
        /// </summary>
        public virtual string Category { get; set; }
        /// <summary>
        /// 是否完结
        /// </summary>
        public virtual bool IsOver { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }
    }
}
