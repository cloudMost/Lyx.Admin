using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lyx.Admin.Spider
{
    /// <summary>
    /// 小说爬虫实体类
    /// </summary>
    [Table("Spider_Novel")]
    public class NovelSpider: CreationAuditedEntity<int>
    {
        /// <summary>
        /// 小说名最大长度
        /// </summary>
        public const int MaxNovelNameLength = 16;

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
        /// 文章
        /// </summary>
        public virtual ICollection<ArticleSpider> Articles { get; set; }

    }
}
